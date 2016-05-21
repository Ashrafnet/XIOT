using System;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace XIOT.Data
{
	public class ActionHandlerBase : XIOT.Data.IActionHandler
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private ActionArgs _arguments;
        
        private ActionResult _result;
        
        public ActionArgs Arguments
        {
            get
            {
                return this._arguments;
            }
            set
            {
                this._arguments = value;
            }
        }
        
        public ActionResult Result
        {
            get
            {
                if (_result == null)
                	_result = new ActionResult();
                return _result;
            }
            set
            {
                _result = value;
            }
        }
        
        public void PreventDefault()
        {
            if (_result != null)
            	_result.Canceled = true;
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        protected virtual void ExecuteMethod(ActionArgs args, ActionResult result, ActionPhase phase)
        {
            bool match = InternalExecuteMethod(args, result, phase, true, true);
            if (!(match))
            	match = InternalExecuteMethod(args, result, phase, true, false);
            if (!(match))
            	match = InternalExecuteMethod(args, result, phase, false, true);
            if (!(match))
            	InternalExecuteMethod(args, result, phase, false, false);
        }
        
        private bool InternalExecuteMethod(ActionArgs args, ActionResult result, ActionPhase phase, bool viewMatch, bool argumentMatch)
        {
            _arguments = args;
            _result = result;
            bool success = false;
            MethodInfo[] methods = GetType().GetMethods((BindingFlags.Public | (BindingFlags.NonPublic | BindingFlags.Instance)));
            foreach (MethodInfo method in methods)
            {
                object[] filters = method.GetCustomAttributes(typeof(ControllerActionAttribute), true);
                foreach (ControllerActionAttribute action in filters)
                	if (((action.Controller == args.Controller) || Regex.IsMatch(args.Controller, action.Controller)) && ((!(viewMatch) && String.IsNullOrEmpty(action.View)) || (action.View == args.View)))
                    {
                        if ((action.CommandName == args.CommandName) && ((!(argumentMatch) && String.IsNullOrEmpty(action.CommandArgument)) || (action.CommandArgument == args.CommandArgument)))
                        {
                            if (action.Phase == phase)
                            {
                                ParameterInfo[] parameters = method.GetParameters();
                                if ((parameters.Length == 2) && ((parameters[0].ParameterType == typeof(ActionArgs)) && (parameters[1].ParameterType == typeof(ActionResult))))
                                	method.Invoke(this, new object[] {
                                                args,
                                                result});
                                else
                                {
                                    object[] arguments = new object[parameters.Length];
                                    for (int i = 0; (i < parameters.Length); i++)
                                    {
                                        ParameterInfo p = parameters[i];
                                        FieldValue v = args[p.Name];
                                        if (v != null)
                                        	if (p.ParameterType.Equals(typeof(FieldValue)))
                                            	arguments[i] = v;
                                            else
                                            	try
                                                {
                                                    arguments[i] = DataControllerBase.ConvertToType(p.ParameterType, v.Value);
                                                }
                                                catch (Exception )
                                                {
                                                }
                                    }
                                    method.Invoke(this, arguments);
                                    success = true;
                                }
                            }
                        }
                    }
            }
            return success;
        }
        
        protected virtual void BeforeSqlAction(ActionArgs args, ActionResult result)
        {
        }
        
        protected virtual void AfterSqlAction(ActionArgs args, ActionResult result)
        {
        }
        
        protected virtual void ExecuteAction(ActionArgs args, ActionResult result)
        {
        }
        
        void IActionHandler.BeforeSqlAction(ActionArgs args, ActionResult result)
        {
            ExecuteMethod(args, result, ActionPhase.Before);
            BeforeSqlAction(args, result);
        }
        
        void IActionHandler.AfterSqlAction(ActionArgs args, ActionResult result)
        {
            ExecuteMethod(args, result, ActionPhase.After);
            AfterSqlAction(args, result);
        }
        
        void IActionHandler.ExecuteAction(ActionArgs args, ActionResult result)
        {
            ExecuteMethod(args, result, ActionPhase.Execute);
            ExecuteAction(args, result);
        }
    }
}
