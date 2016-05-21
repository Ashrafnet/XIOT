using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace XIOT.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class CB_ExpressionOperator
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _operatorID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _description;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isActive;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _dateCreated;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _dateModified;
        
        public CB_ExpressionOperator()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? OperatorID
        {
            get
            {
                return _operatorID;
            }
            set
            {
                _operatorID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string Code
        {
            get
            {
                return _code;
            }
            set
            {
                _code = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public bool? IsActive
        {
            get
            {
                return _isActive;
            }
            set
            {
                _isActive = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public DateTime? DateCreated
        {
            get
            {
                return _dateCreated;
            }
            set
            {
                _dateCreated = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public DateTime? DateModified
        {
            get
            {
                return _dateModified;
            }
            set
            {
                _dateModified = value;
            }
        }
        
        public static List<XIOT.Data.Objects.CB_ExpressionOperator> Select(int? operatorID, string code, string description, bool? isActive, DateTime? dateCreated, DateTime? dateModified)
        {
            return new CB_ExpressionOperatorFactory().Select(operatorID, code, description, isActive, dateCreated, dateModified);
        }
        
        public static List<XIOT.Data.Objects.CB_ExpressionOperator> Select(XIOT.Data.Objects.CB_ExpressionOperator qbe)
        {
            return new CB_ExpressionOperatorFactory().Select(qbe);
        }
        
        public static List<XIOT.Data.Objects.CB_ExpressionOperator> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new CB_ExpressionOperatorFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<XIOT.Data.Objects.CB_ExpressionOperator> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new CB_ExpressionOperatorFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<XIOT.Data.Objects.CB_ExpressionOperator> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new CB_ExpressionOperatorFactory().Select(filter, sort, CB_ExpressionOperatorFactory.SelectView, parameters);
        }
        
        public static List<XIOT.Data.Objects.CB_ExpressionOperator> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new CB_ExpressionOperatorFactory().Select(filter, sort, CB_ExpressionOperatorFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<XIOT.Data.Objects.CB_ExpressionOperator> Select(string filter, BusinessObjectParameters parameters)
        {
            return new CB_ExpressionOperatorFactory().Select(filter, null, CB_ExpressionOperatorFactory.SelectView, parameters);
        }
        
        public static List<XIOT.Data.Objects.CB_ExpressionOperator> Select(string filter, params FieldValue[] parameters)
        {
            return new CB_ExpressionOperatorFactory().Select(filter, null, CB_ExpressionOperatorFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static XIOT.Data.Objects.CB_ExpressionOperator SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new CB_ExpressionOperatorFactory().SelectSingle(filter, parameters);
        }
        
        public static XIOT.Data.Objects.CB_ExpressionOperator SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new CB_ExpressionOperatorFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static XIOT.Data.Objects.CB_ExpressionOperator SelectSingle(int? operatorID)
        {
            return new CB_ExpressionOperatorFactory().SelectSingle(operatorID);
        }
        
        public int Insert()
        {
            return new CB_ExpressionOperatorFactory().Insert(this);
        }
        
        public int Update()
        {
            return new CB_ExpressionOperatorFactory().Update(this);
        }
        
        public int Delete()
        {
            return new CB_ExpressionOperatorFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("OperatorID: {0}", this.OperatorID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class CB_ExpressionOperatorFactory
    {
        
        public CB_ExpressionOperatorFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("CB_ExpressionOperator");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("CB_ExpressionOperator");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("CB_ExpressionOperator");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("CB_ExpressionOperator");
            }
        }
        
        public static CB_ExpressionOperatorFactory Create()
        {
            return new CB_ExpressionOperatorFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? operatorID, string code, string description, bool? isActive, DateTime? dateCreated, DateTime? dateModified, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (operatorID.HasValue)
            	filter.Add(("OperatorID:=" + operatorID.Value.ToString()));
            if (!(String.IsNullOrEmpty(code)))
            	filter.Add(("Code:*" + code));
            if (!(String.IsNullOrEmpty(description)))
            	filter.Add(("Description:*" + description));
            if (isActive.HasValue)
            	filter.Add(("IsActive:=" + isActive.Value.ToString()));
            if (dateCreated.HasValue)
            	filter.Add(("DateCreated:=" + dateCreated.Value.ToString()));
            if (dateModified.HasValue)
            	filter.Add(("DateModified:=" + dateModified.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<XIOT.Data.Objects.CB_ExpressionOperator> Select(int? operatorID, string code, string description, bool? isActive, DateTime? dateCreated, DateTime? dateModified, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(operatorID, code, description, isActive, dateCreated, dateModified, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("CB_ExpressionOperator", dataView, request);
            return page.ToList<XIOT.Data.Objects.CB_ExpressionOperator>();
        }
        
        public List<XIOT.Data.Objects.CB_ExpressionOperator> Select(XIOT.Data.Objects.CB_ExpressionOperator qbe)
        {
            return Select(qbe.OperatorID, qbe.Code, qbe.Description, qbe.IsActive, qbe.DateCreated, qbe.DateModified);
        }
        
        public int SelectCount(int? operatorID, string code, string description, bool? isActive, DateTime? dateCreated, DateTime? dateModified, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(operatorID, code, description, isActive, dateCreated, dateModified, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("CB_ExpressionOperator", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<XIOT.Data.Objects.CB_ExpressionOperator> Select(int? operatorID, string code, string description, bool? isActive, DateTime? dateCreated, DateTime? dateModified)
        {
            return Select(operatorID, code, description, isActive, dateCreated, dateModified, null, Int32.MaxValue, 0, SelectView);
        }
        
        public XIOT.Data.Objects.CB_ExpressionOperator SelectSingle(int? operatorID)
        {
            List<XIOT.Data.Objects.CB_ExpressionOperator> list = Select(operatorID, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<XIOT.Data.Objects.CB_ExpressionOperator> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("CB_ExpressionOperator", dataView, request);
            return page.ToList<XIOT.Data.Objects.CB_ExpressionOperator>();
        }
        
        public List<XIOT.Data.Objects.CB_ExpressionOperator> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<XIOT.Data.Objects.CB_ExpressionOperator> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public XIOT.Data.Objects.CB_ExpressionOperator SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<XIOT.Data.Objects.CB_ExpressionOperator> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(XIOT.Data.Objects.CB_ExpressionOperator theCB_ExpressionOperator, XIOT.Data.Objects.CB_ExpressionOperator original_CB_ExpressionOperator)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("OperatorID", original_CB_ExpressionOperator.OperatorID, theCB_ExpressionOperator.OperatorID));
            values.Add(new FieldValue("Code", original_CB_ExpressionOperator.Code, theCB_ExpressionOperator.Code));
            values.Add(new FieldValue("Description", original_CB_ExpressionOperator.Description, theCB_ExpressionOperator.Description));
            values.Add(new FieldValue("IsActive", original_CB_ExpressionOperator.IsActive, theCB_ExpressionOperator.IsActive));
            values.Add(new FieldValue("DateCreated", original_CB_ExpressionOperator.DateCreated, theCB_ExpressionOperator.DateCreated));
            values.Add(new FieldValue("DateModified", original_CB_ExpressionOperator.DateModified, theCB_ExpressionOperator.DateModified));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(XIOT.Data.Objects.CB_ExpressionOperator theCB_ExpressionOperator, XIOT.Data.Objects.CB_ExpressionOperator original_CB_ExpressionOperator, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "CB_ExpressionOperator";
            args.View = dataView;
            args.Values = CreateFieldValues(theCB_ExpressionOperator, original_CB_ExpressionOperator);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("CB_ExpressionOperator", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theCB_ExpressionOperator);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(XIOT.Data.Objects.CB_ExpressionOperator theCB_ExpressionOperator, XIOT.Data.Objects.CB_ExpressionOperator original_CB_ExpressionOperator)
        {
            return ExecuteAction(theCB_ExpressionOperator, original_CB_ExpressionOperator, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(XIOT.Data.Objects.CB_ExpressionOperator theCB_ExpressionOperator)
        {
            return Update(theCB_ExpressionOperator, SelectSingle(theCB_ExpressionOperator.OperatorID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(XIOT.Data.Objects.CB_ExpressionOperator theCB_ExpressionOperator)
        {
            return ExecuteAction(theCB_ExpressionOperator, new CB_ExpressionOperator(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(XIOT.Data.Objects.CB_ExpressionOperator theCB_ExpressionOperator)
        {
            return ExecuteAction(theCB_ExpressionOperator, theCB_ExpressionOperator, "Select", "Delete", DeleteView);
        }
    }
}
