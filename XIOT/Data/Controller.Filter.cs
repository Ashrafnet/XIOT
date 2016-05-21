using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Transactions;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;
using System.Web;
using System.Web.Caching;
using System.Web.Configuration;
using System.Web.Security;

namespace XIOT.Data
{
	public partial class DataControllerBase
    {
        
        private string _viewFilter;
        
        private BusinessObjectParameters _parameters;
        
        private bool _hasWhere;
        
        private DbCommand _currentCommand;
        
        private SelectClauseDictionary _currentExpressions;
        
        public static Regex FilterExpressionRegex = new Regex("(?\'Alias\'\\w+):(?\'Values\'[\\s\\S]*)");
        
        public static Regex FilterValueRegex = new Regex("(?\'Operation\'\\*|\\$\\w+\\$|=|~|<(=|>){0,1}|>={0,1})(?\'Value\'[\\s\\S]*?)(\\0|$)");
        
        private void AppendWhereExpressions(StringBuilder sb, DbCommand command, ViewPage page, SelectClauseDictionary expressions, FieldValue[] values)
        {
            sb.AppendLine();
            sb.Append("where");
            bool firstField = true;
            foreach (FieldValue v in values)
            {
                DataField field = page.FindField(v.Name);
                if ((field != null) && field.IsPrimaryKey)
                {
                    sb.AppendLine();
                    if (firstField)
                    	firstField = false;
                    else
                    	sb.Append("and ");
                    sb.AppendFormat(RemoveTableAliasFromExpression(expressions[v.Name]));
                    sb.AppendFormat("={0}p{1}", _parameterMarker, command.Parameters.Count);
                    DbParameter parameter = command.CreateParameter();
                    parameter.ParameterName = String.Format("{0}p{1}", _parameterMarker, command.Parameters.Count);
                    AssignParameterValue(parameter, field.Type, v.OldValue);
                    command.Parameters.Add(parameter);
                }
            }
            if (_config.ConflictDetectionEnabled)
            	foreach (FieldValue v in values)
                {
                    DataField field = page.FindField(v.Name);
                    if ((field != null) && (!((field.IsPrimaryKey || field.OnDemand)) && !(v.ReadOnly)))
                    {
                        sb.AppendLine();
                        sb.Append("and ");
                        sb.Append(RemoveTableAliasFromExpression(expressions[v.Name]));
                        if (v.OldValue == null)
                        	sb.Append(" is null");
                        else
                        {
                            sb.AppendFormat("={0}p{1}", _parameterMarker, command.Parameters.Count);
                            DbParameter parameter = command.CreateParameter();
                            parameter.ParameterName = String.Format("{0}p{1}", _parameterMarker, command.Parameters.Count);
                            AssignParameterValue(parameter, field.Type, v.OldValue);
                            command.Parameters.Add(parameter);
                        }
                    }
                }
            sb.AppendLine();
        }
        
        private void EnsureWhereKeyword(StringBuilder sb)
        {
            if (!(_hasWhere))
            {
                _hasWhere = true;
                sb.AppendLine("where");
            }
        }
        
        private string ProcessViewFilter(ViewPage page, DbCommand command, SelectClauseDictionary expressions)
        {
            _currentCommand = command;
            _currentExpressions = expressions;
            string filter = Regex.Replace(_viewFilter, "/\\*Sql\\*/(?\'Sql\'[\\s\\S]+)/\\*Sql\\*/|(?\'Parameter\'(@|:)\\w+)|(?\'Other\'(\"|\'|\\[|`)\\s*\\w" +
                    "+)|(?\'Function\'\\$\\w+\\s*\\((?\'Arguments\'[\\S\\s]*?)\\))|(?\'Name\'\\w+)", DoReplaceKnownNames);
            return filter;
        }
        
        private string DoReplaceKnownNames(Match m)
        {
            string sql = m.Groups["Sql"].Value;
            if (!(String.IsNullOrEmpty(sql)))
            	return sql;
            if (!(String.IsNullOrEmpty(m.Groups["Other"].Value)))
            	return m.Value;
            if (!(String.IsNullOrEmpty(m.Groups["Parameter"].Value)))
            	return AssignFilterParameterValue(m.Groups["Parameter"].Value);
            else
            	if (!(String.IsNullOrEmpty(m.Groups["Function"].Value)))
                	return FilterFunctions.Replace(_currentCommand, _currentExpressions, m.Groups["Function"].Value);
                else
                {
                    string s = null;
                    if (_currentExpressions.TryGetValue(m.Groups["Name"].Value, out s))
                    	return s;
                }
            return m.Value;
        }
        
        private string AssignFilterParameterValue(string qualifiedName)
        {
            char prefix = qualifiedName[0];
            string name = qualifiedName.Substring(1);
            if ((prefix.Equals('@') || prefix.Equals(':')) && !(_currentCommand.Parameters.Contains(qualifiedName)))
            {
                object result = null;
                if ((_parameters != null) && _parameters.ContainsKey(qualifiedName))
                	result = _parameters[qualifiedName];
                else
                {
                    IActionHandler handler = _config.CreateActionHandler();
                    if (handler == null)
                    	throw new Exception(String.Format("View \'{0}\' uses a filter with \'{2}\' parameter. Business rules class of the contro" +
                                    "ller must provide a value for this parameter. The filter is defined as {1}.", _viewId, _viewFilter, name));
                    result = handler.GetType().InvokeMember(name, (System.Reflection.BindingFlags.GetProperty | System.Reflection.BindingFlags.GetField), null, handler, new object[0]);
                }
                IEnumerable<object> enumerable = null;
                if (typeof(IEnumerable<object>).IsInstanceOfType(result))
                	enumerable = ((IEnumerable<object>)(result));
                if (enumerable != null)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("(");
                    int parameterIndex = 0;
                    foreach (object o in enumerable)
                    {
                        DbParameter p = _currentCommand.CreateParameter();
                        _currentCommand.Parameters.Add(p);
                        p.ParameterName = (qualifiedName + parameterIndex.ToString());
                        p.Value = o;
                        if (parameterIndex > 0)
                        	sb.Append(",");
                        sb.Append(p.ParameterName);
                        parameterIndex++;
                    }
                    sb.Append(")");
                    return sb.ToString();
                }
                else
                {
                    DbParameter p = _currentCommand.CreateParameter();
                    _currentCommand.Parameters.Add(p);
                    p.ParameterName = qualifiedName;
                    p.Value = result;
                }
            }
            return qualifiedName;
        }
        
        protected virtual void AppendFilterExpressionsToWhere(StringBuilder sb, ViewPage page, DbCommand command, SelectClauseDictionary expressions, string whereClause)
        {
            bool firstCriteria = String.IsNullOrEmpty(_viewFilter);
            if (!(firstCriteria))
            {
                EnsureWhereKeyword(sb);
                sb.AppendLine("(");
                sb.Append(ProcessViewFilter(page, command, expressions));
            }
            if (page.Filter != null)
            	foreach (string filterExpression in page.Filter)
                {
                    Match filterMatch = FilterExpressionRegex.Match(filterExpression);
                    if (filterMatch.Success)
                    {
                        // "ProductName:?g", "CategoryCategoryName:=Condiments\x00=Seafood"
                        bool firstValue = true;
                        string fieldOperator = " or ";
                        if (Regex.IsMatch(filterMatch.Groups["Values"].Value, ">|<"))
                        	fieldOperator = " and ";
                        Match valueMatch = FilterValueRegex.Match(filterMatch.Groups["Values"].Value);
                        while (valueMatch.Success)
                        {
                            string alias = filterMatch.Groups["Alias"].Value;
                            string operation = valueMatch.Groups["Operation"].Value;
                            string paramValue = valueMatch.Groups["Value"].Value;
                            DataField field = page.FindField(alias);
                            if (((field != null) && field.AllowQBE) && (page.DistinctValueFieldName != field.Name || (page.AllowDistinctFieldInFilter || page.CustomFilteredBy(field.Name))))
                            {
                                if (firstValue)
                                {
                                    if (firstCriteria)
                                    {
                                        EnsureWhereKeyword(sb);
                                        sb.AppendLine("(");
                                        firstCriteria = false;
                                    }
                                    else
                                    	sb.Append("and ");
                                    sb.Append("(");
                                    firstValue = false;
                                }
                                else
                                	sb.Append(fieldOperator);
                                if (operation == "~")
                                {
                                    bool firstWord = true;
                                    paramValue = Convert.ToString(StringToValue(paramValue));
                                    foreach (string paramValueWord in paramValue.Split(' '))
                                    {
                                        string pv = paramValueWord.Trim();
                                        DateTime paramValueAsDate;
                                        bool paramValueIsDate = SqlStatement.TryParseDate(command.GetType(), pv, out paramValueAsDate);
                                        bool firstTry = true;
                                        DbParameter parameter = command.CreateParameter();
                                        parameter.ParameterName = String.Format("{0}p{1}", _parameterMarker, command.Parameters.Count);
                                        parameter.DbType = DbType.String;
                                        command.Parameters.Add(parameter);
                                        if (!(paramValueIsDate))
                                        	pv = SqlStatement.EscapePattern(command, pv);
                                        if (!(pv.Contains("%")))
                                        	pv = String.Format("%{0}%", pv);
                                        parameter.Value = pv;
                                        if (firstWord)
                                        	firstWord = false;
                                        else
                                        	sb.Append("and");
                                        sb.Append("(");
                                        foreach (DataField tf in page.Fields)
                                        	if (tf.AllowQBE && (!((tf.IsPrimaryKey && tf.Hidden)) && (!(tf.Type.StartsWith("Date")) || paramValueIsDate)))
                                            {
                                                if (firstTry)
                                                	firstTry = false;
                                                else
                                                	sb.Append(" or ");
                                                if (tf.Type.StartsWith("Date"))
                                                {
                                                    DbParameter dateParameter = command.CreateParameter();
                                                    dateParameter.ParameterName = String.Format("{0}p{1}", _parameterMarker, command.Parameters.Count);
                                                    dateParameter.DbType = DbType.String;
                                                    command.Parameters.Add(dateParameter);
                                                    dateParameter.Value = paramValueAsDate;
                                                    sb.AppendFormat("({0} = {1})", expressions[tf.ExpressionName()], dateParameter.ParameterName);
                                                }
                                                else
                                                	if (command.GetType().Name.Contains("Oracle"))
                                                    {
                                                        sb.AppendFormat("(upper({0}) like {1})", expressions[tf.ExpressionName()], parameter.ParameterName);
                                                        parameter.Value = Convert.ToString(parameter.Value).ToUpper();
                                                    }
                                                    else
                                                    	sb.AppendFormat("({0} like {1})", expressions[tf.ExpressionName()], parameter.ParameterName);
                                            }
                                        sb.Append(")");
                                    }
                                }
                                else
                                	if (operation.StartsWith("$"))
                                    	sb.Append(FilterFunctions.Replace(command, expressions, String.Format("{0}({1}$comma${2})", operation.TrimEnd('$'), alias, Convert.ToBase64String(Encoding.UTF8.GetBytes(paramValue)))));
                                    else
                                    {
                                        DbParameter parameter = command.CreateParameter();
                                        parameter.ParameterName = String.Format("{0}p{1}", _parameterMarker, command.Parameters.Count);
                                        AssignParameterDbType(parameter, field.Type);
                                        sb.Append(expressions[field.ExpressionName()]);
                                        bool requiresRangeAdjustment = ((operation == "=") && (field.Type.StartsWith("DateTime") && !(StringIsNull(paramValue))));
                                        if ((operation == "<>") && StringIsNull(paramValue))
                                        	sb.Append(" is not null ");
                                        else
                                        	if ((operation == "=") && StringIsNull(paramValue))
                                            	sb.Append(" is null ");
                                            else
                                            {
                                                if (operation == "*")
                                                {
                                                    sb.Append(" like ");
                                                    parameter.DbType = DbType.String;
                                                    if (!(paramValue.Contains("%")))
                                                    	paramValue = (SqlStatement.EscapePattern(command, paramValue) + "%");
                                                }
                                                else
                                                	if (requiresRangeAdjustment)
                                                    	sb.Append(">=");
                                                    else
                                                    	sb.Append(operation);
                                                try
                                                {
                                                    parameter.Value = StringToValue(field, paramValue);
                                                }
                                                catch (Exception )
                                                {
                                                    parameter.Value = DBNull.Value;
                                                }
                                                sb.Append(parameter.ParameterName);
                                                command.Parameters.Add(parameter);
                                                if (requiresRangeAdjustment)
                                                {
                                                    DbParameter rangeParameter = command.CreateParameter();
                                                    AssignParameterDbType(rangeParameter, field.Type);
                                                    rangeParameter.ParameterName = String.Format("{0}p{1}", _parameterMarker, command.Parameters.Count);
                                                    sb.Append(String.Format(" and {0} < {1}", expressions[field.ExpressionName()], rangeParameter.ParameterName));
                                                    if (field.Type == "DateTimeOffset")
                                                    {
                                                        DateTime dt = Convert.ToDateTime(parameter.Value);
                                                        parameter.Value = new DateTimeOffset(dt).AddHours(-14);
                                                        rangeParameter.Value = new DateTimeOffset(dt).AddDays(1).AddHours(14);
                                                    }
                                                    else
                                                    	rangeParameter.Value = Convert.ToDateTime(parameter.Value).AddDays(1);
                                                    command.Parameters.Add(rangeParameter);
                                                }
                                            }
                                    }
                            }
                            valueMatch = valueMatch.NextMatch();
                        }
                        if (!(firstValue))
                        	sb.AppendLine(")");
                    }
                }
            if (!(firstCriteria))
            {
                sb.AppendLine(")");
                if (!(String.IsNullOrEmpty(whereClause)))
                	sb.Append("and ");
            }
            if (!(String.IsNullOrEmpty(whereClause)))
            {
                sb.AppendLine("(");
                sb.AppendLine(whereClause);
                sb.AppendLine(")");
            }
        }
        
        protected virtual void AppendRecursiveFilter(ViewPage page)
        {
            if (this._viewType != "Tree")
            	return;
            DataField recursiveField = null;
            if (page.Filter != null)
            	foreach (string filterExpression in page.Filter)
                {
                    Match filterMatch = Regex.Match(filterExpression, "(?\'Alias\'\\w+):");
                    if (filterMatch.Success)
                    {
                        DataField f = page.FindField(filterMatch.Groups["Alias"].Value);
                        if ((f != null) && (f.ItemsDataController == page.Controller))
                        {
                            recursiveField = f;
                            break;
                        }
                    }
                }
                if (recursiveField == null)
                	foreach (DataField f in page.Fields)
                    	if (f.ItemsDataController == page.Controller)
                        {
                            if (!(String.IsNullOrEmpty(_viewFilter)))
                            	_viewFilter = String.Format("({0})and", _viewFilter);
                            _viewFilter = String.Format("{0}({1} is null)", _viewFilter, f.Name);
                            break;
                        }
        }
        
        private void AppendAccessControlRules(DbCommand command, ViewPage page, SelectClauseDictionary expressions)
        {
            object handler = _config.CreateActionHandler();
            if (!((handler is BusinessRules)))
            	return;
            BusinessRules rules = ((BusinessRules)(handler));
            string accessControlFilter = rules.EnumerateAccessControlRules(command, _config.ControllerName, _parameterMarker, page, expressions);
            if (String.IsNullOrEmpty(accessControlFilter))
            	return;
            if (!(String.IsNullOrEmpty(_viewFilter)))
            	_viewFilter = (_viewFilter + " and ");
            _viewFilter = String.Format("{0}/*Sql*/{1}/*Sql*/", _viewFilter, accessControlFilter);
        }
    }
}
