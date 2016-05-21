using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace XIOT.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class CB_TestCriteria
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _testCriteriaID;
        
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
        
        public CB_TestCriteria()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? TestCriteriaID
        {
            get
            {
                return _testCriteriaID;
            }
            set
            {
                _testCriteriaID = value;
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
        
        public static List<XIOT.Data.Objects.CB_TestCriteria> Select(int? testCriteriaID, string code, string description, bool? isActive, DateTime? dateCreated, DateTime? dateModified)
        {
            return new CB_TestCriteriaFactory().Select(testCriteriaID, code, description, isActive, dateCreated, dateModified);
        }
        
        public static List<XIOT.Data.Objects.CB_TestCriteria> Select(XIOT.Data.Objects.CB_TestCriteria qbe)
        {
            return new CB_TestCriteriaFactory().Select(qbe);
        }
        
        public static List<XIOT.Data.Objects.CB_TestCriteria> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new CB_TestCriteriaFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<XIOT.Data.Objects.CB_TestCriteria> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new CB_TestCriteriaFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<XIOT.Data.Objects.CB_TestCriteria> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new CB_TestCriteriaFactory().Select(filter, sort, CB_TestCriteriaFactory.SelectView, parameters);
        }
        
        public static List<XIOT.Data.Objects.CB_TestCriteria> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new CB_TestCriteriaFactory().Select(filter, sort, CB_TestCriteriaFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<XIOT.Data.Objects.CB_TestCriteria> Select(string filter, BusinessObjectParameters parameters)
        {
            return new CB_TestCriteriaFactory().Select(filter, null, CB_TestCriteriaFactory.SelectView, parameters);
        }
        
        public static List<XIOT.Data.Objects.CB_TestCriteria> Select(string filter, params FieldValue[] parameters)
        {
            return new CB_TestCriteriaFactory().Select(filter, null, CB_TestCriteriaFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static XIOT.Data.Objects.CB_TestCriteria SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new CB_TestCriteriaFactory().SelectSingle(filter, parameters);
        }
        
        public static XIOT.Data.Objects.CB_TestCriteria SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new CB_TestCriteriaFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static XIOT.Data.Objects.CB_TestCriteria SelectSingle(int? testCriteriaID)
        {
            return new CB_TestCriteriaFactory().SelectSingle(testCriteriaID);
        }
        
        public int Insert()
        {
            return new CB_TestCriteriaFactory().Insert(this);
        }
        
        public int Update()
        {
            return new CB_TestCriteriaFactory().Update(this);
        }
        
        public int Delete()
        {
            return new CB_TestCriteriaFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("TestCriteriaID: {0}", this.TestCriteriaID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class CB_TestCriteriaFactory
    {
        
        public CB_TestCriteriaFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("CB_TestCriteria");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("CB_TestCriteria");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("CB_TestCriteria");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("CB_TestCriteria");
            }
        }
        
        public static CB_TestCriteriaFactory Create()
        {
            return new CB_TestCriteriaFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? testCriteriaID, string code, string description, bool? isActive, DateTime? dateCreated, DateTime? dateModified, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (testCriteriaID.HasValue)
            	filter.Add(("TestCriteriaID:=" + testCriteriaID.Value.ToString()));
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
        public List<XIOT.Data.Objects.CB_TestCriteria> Select(int? testCriteriaID, string code, string description, bool? isActive, DateTime? dateCreated, DateTime? dateModified, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(testCriteriaID, code, description, isActive, dateCreated, dateModified, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("CB_TestCriteria", dataView, request);
            return page.ToList<XIOT.Data.Objects.CB_TestCriteria>();
        }
        
        public List<XIOT.Data.Objects.CB_TestCriteria> Select(XIOT.Data.Objects.CB_TestCriteria qbe)
        {
            return Select(qbe.TestCriteriaID, qbe.Code, qbe.Description, qbe.IsActive, qbe.DateCreated, qbe.DateModified);
        }
        
        public int SelectCount(int? testCriteriaID, string code, string description, bool? isActive, DateTime? dateCreated, DateTime? dateModified, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(testCriteriaID, code, description, isActive, dateCreated, dateModified, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("CB_TestCriteria", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<XIOT.Data.Objects.CB_TestCriteria> Select(int? testCriteriaID, string code, string description, bool? isActive, DateTime? dateCreated, DateTime? dateModified)
        {
            return Select(testCriteriaID, code, description, isActive, dateCreated, dateModified, null, Int32.MaxValue, 0, SelectView);
        }
        
        public XIOT.Data.Objects.CB_TestCriteria SelectSingle(int? testCriteriaID)
        {
            List<XIOT.Data.Objects.CB_TestCriteria> list = Select(testCriteriaID, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<XIOT.Data.Objects.CB_TestCriteria> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("CB_TestCriteria", dataView, request);
            return page.ToList<XIOT.Data.Objects.CB_TestCriteria>();
        }
        
        public List<XIOT.Data.Objects.CB_TestCriteria> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<XIOT.Data.Objects.CB_TestCriteria> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public XIOT.Data.Objects.CB_TestCriteria SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<XIOT.Data.Objects.CB_TestCriteria> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(XIOT.Data.Objects.CB_TestCriteria theCB_TestCriteria, XIOT.Data.Objects.CB_TestCriteria original_CB_TestCriteria)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("TestCriteriaID", original_CB_TestCriteria.TestCriteriaID, theCB_TestCriteria.TestCriteriaID));
            values.Add(new FieldValue("Code", original_CB_TestCriteria.Code, theCB_TestCriteria.Code));
            values.Add(new FieldValue("Description", original_CB_TestCriteria.Description, theCB_TestCriteria.Description));
            values.Add(new FieldValue("IsActive", original_CB_TestCriteria.IsActive, theCB_TestCriteria.IsActive));
            values.Add(new FieldValue("DateCreated", original_CB_TestCriteria.DateCreated, theCB_TestCriteria.DateCreated));
            values.Add(new FieldValue("DateModified", original_CB_TestCriteria.DateModified, theCB_TestCriteria.DateModified));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(XIOT.Data.Objects.CB_TestCriteria theCB_TestCriteria, XIOT.Data.Objects.CB_TestCriteria original_CB_TestCriteria, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "CB_TestCriteria";
            args.View = dataView;
            args.Values = CreateFieldValues(theCB_TestCriteria, original_CB_TestCriteria);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("CB_TestCriteria", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theCB_TestCriteria);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(XIOT.Data.Objects.CB_TestCriteria theCB_TestCriteria, XIOT.Data.Objects.CB_TestCriteria original_CB_TestCriteria)
        {
            return ExecuteAction(theCB_TestCriteria, original_CB_TestCriteria, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(XIOT.Data.Objects.CB_TestCriteria theCB_TestCriteria)
        {
            return Update(theCB_TestCriteria, SelectSingle(theCB_TestCriteria.TestCriteriaID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(XIOT.Data.Objects.CB_TestCriteria theCB_TestCriteria)
        {
            return ExecuteAction(theCB_TestCriteria, new CB_TestCriteria(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(XIOT.Data.Objects.CB_TestCriteria theCB_TestCriteria)
        {
            return ExecuteAction(theCB_TestCriteria, theCB_TestCriteria, "Select", "Delete", DeleteView);
        }
    }
}
