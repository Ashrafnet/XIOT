using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace XIOT.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class CB_Tests
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _testID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _testName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _testDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _appendToLog;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _lastRunDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _lastRunBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _dateCreated;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _dateModified;
        
        public CB_Tests()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? TestID
        {
            get
            {
                return _testID;
            }
            set
            {
                _testID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string TestName
        {
            get
            {
                return _testName;
            }
            set
            {
                _testName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string TestDescription
        {
            get
            {
                return _testDescription;
            }
            set
            {
                _testDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? AppendToLog
        {
            get
            {
                return _appendToLog;
            }
            set
            {
                _appendToLog = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? LastRunDate
        {
            get
            {
                return _lastRunDate;
            }
            set
            {
                _lastRunDate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LastRunBy
        {
            get
            {
                return _lastRunBy;
            }
            set
            {
                _lastRunBy = value;
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
        
        public static List<XIOT.Data.Objects.CB_Tests> Select(int? testID, string testName, string testDescription, bool? appendToLog, DateTime? lastRunDate, string lastRunBy, DateTime? dateCreated, DateTime? dateModified)
        {
            return new CB_TestsFactory().Select(testID, testName, testDescription, appendToLog, lastRunDate, lastRunBy, dateCreated, dateModified);
        }
        
        public static List<XIOT.Data.Objects.CB_Tests> Select(XIOT.Data.Objects.CB_Tests qbe)
        {
            return new CB_TestsFactory().Select(qbe);
        }
        
        public static List<XIOT.Data.Objects.CB_Tests> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new CB_TestsFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<XIOT.Data.Objects.CB_Tests> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new CB_TestsFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<XIOT.Data.Objects.CB_Tests> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new CB_TestsFactory().Select(filter, sort, CB_TestsFactory.SelectView, parameters);
        }
        
        public static List<XIOT.Data.Objects.CB_Tests> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new CB_TestsFactory().Select(filter, sort, CB_TestsFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<XIOT.Data.Objects.CB_Tests> Select(string filter, BusinessObjectParameters parameters)
        {
            return new CB_TestsFactory().Select(filter, null, CB_TestsFactory.SelectView, parameters);
        }
        
        public static List<XIOT.Data.Objects.CB_Tests> Select(string filter, params FieldValue[] parameters)
        {
            return new CB_TestsFactory().Select(filter, null, CB_TestsFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static XIOT.Data.Objects.CB_Tests SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new CB_TestsFactory().SelectSingle(filter, parameters);
        }
        
        public static XIOT.Data.Objects.CB_Tests SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new CB_TestsFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static XIOT.Data.Objects.CB_Tests SelectSingle(int? testID)
        {
            return new CB_TestsFactory().SelectSingle(testID);
        }
        
        public int Insert()
        {
            return new CB_TestsFactory().Insert(this);
        }
        
        public int Update()
        {
            return new CB_TestsFactory().Update(this);
        }
        
        public int Delete()
        {
            return new CB_TestsFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("TestID: {0}", this.TestID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class CB_TestsFactory
    {
        
        public CB_TestsFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("CB_Tests");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("CB_Tests");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("CB_Tests");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("CB_Tests");
            }
        }
        
        public static CB_TestsFactory Create()
        {
            return new CB_TestsFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? testID, string testName, string testDescription, bool? appendToLog, DateTime? lastRunDate, string lastRunBy, DateTime? dateCreated, DateTime? dateModified, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (testID.HasValue)
            	filter.Add(("TestID:=" + testID.Value.ToString()));
            if (!(String.IsNullOrEmpty(testName)))
            	filter.Add(("TestName:*" + testName));
            if (!(String.IsNullOrEmpty(testDescription)))
            	filter.Add(("TestDescription:*" + testDescription));
            if (appendToLog.HasValue)
            	filter.Add(("AppendToLog:=" + appendToLog.Value.ToString()));
            if (lastRunDate.HasValue)
            	filter.Add(("LastRunDate:=" + lastRunDate.Value.ToString()));
            if (!(String.IsNullOrEmpty(lastRunBy)))
            	filter.Add(("LastRunBy:*" + lastRunBy));
            if (dateCreated.HasValue)
            	filter.Add(("DateCreated:=" + dateCreated.Value.ToString()));
            if (dateModified.HasValue)
            	filter.Add(("DateModified:=" + dateModified.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<XIOT.Data.Objects.CB_Tests> Select(int? testID, string testName, string testDescription, bool? appendToLog, DateTime? lastRunDate, string lastRunBy, DateTime? dateCreated, DateTime? dateModified, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(testID, testName, testDescription, appendToLog, lastRunDate, lastRunBy, dateCreated, dateModified, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("CB_Tests", dataView, request);
            return page.ToList<XIOT.Data.Objects.CB_Tests>();
        }
        
        public List<XIOT.Data.Objects.CB_Tests> Select(XIOT.Data.Objects.CB_Tests qbe)
        {
            return Select(qbe.TestID, qbe.TestName, qbe.TestDescription, qbe.AppendToLog, qbe.LastRunDate, qbe.LastRunBy, qbe.DateCreated, qbe.DateModified);
        }
        
        public int SelectCount(int? testID, string testName, string testDescription, bool? appendToLog, DateTime? lastRunDate, string lastRunBy, DateTime? dateCreated, DateTime? dateModified, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(testID, testName, testDescription, appendToLog, lastRunDate, lastRunBy, dateCreated, dateModified, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("CB_Tests", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<XIOT.Data.Objects.CB_Tests> Select(int? testID, string testName, string testDescription, bool? appendToLog, DateTime? lastRunDate, string lastRunBy, DateTime? dateCreated, DateTime? dateModified)
        {
            return Select(testID, testName, testDescription, appendToLog, lastRunDate, lastRunBy, dateCreated, dateModified, null, Int32.MaxValue, 0, SelectView);
        }
        
        public XIOT.Data.Objects.CB_Tests SelectSingle(int? testID)
        {
            List<XIOT.Data.Objects.CB_Tests> list = Select(testID, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<XIOT.Data.Objects.CB_Tests> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("CB_Tests", dataView, request);
            return page.ToList<XIOT.Data.Objects.CB_Tests>();
        }
        
        public List<XIOT.Data.Objects.CB_Tests> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<XIOT.Data.Objects.CB_Tests> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public XIOT.Data.Objects.CB_Tests SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<XIOT.Data.Objects.CB_Tests> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(XIOT.Data.Objects.CB_Tests theCB_Tests, XIOT.Data.Objects.CB_Tests original_CB_Tests)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("TestID", original_CB_Tests.TestID, theCB_Tests.TestID));
            values.Add(new FieldValue("TestName", original_CB_Tests.TestName, theCB_Tests.TestName));
            values.Add(new FieldValue("TestDescription", original_CB_Tests.TestDescription, theCB_Tests.TestDescription));
            values.Add(new FieldValue("AppendToLog", original_CB_Tests.AppendToLog, theCB_Tests.AppendToLog));
            values.Add(new FieldValue("LastRunDate", original_CB_Tests.LastRunDate, theCB_Tests.LastRunDate));
            values.Add(new FieldValue("LastRunBy", original_CB_Tests.LastRunBy, theCB_Tests.LastRunBy));
            values.Add(new FieldValue("DateCreated", original_CB_Tests.DateCreated, theCB_Tests.DateCreated));
            values.Add(new FieldValue("DateModified", original_CB_Tests.DateModified, theCB_Tests.DateModified));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(XIOT.Data.Objects.CB_Tests theCB_Tests, XIOT.Data.Objects.CB_Tests original_CB_Tests, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "CB_Tests";
            args.View = dataView;
            args.Values = CreateFieldValues(theCB_Tests, original_CB_Tests);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("CB_Tests", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theCB_Tests);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(XIOT.Data.Objects.CB_Tests theCB_Tests, XIOT.Data.Objects.CB_Tests original_CB_Tests)
        {
            return ExecuteAction(theCB_Tests, original_CB_Tests, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(XIOT.Data.Objects.CB_Tests theCB_Tests)
        {
            return Update(theCB_Tests, SelectSingle(theCB_Tests.TestID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(XIOT.Data.Objects.CB_Tests theCB_Tests)
        {
            return ExecuteAction(theCB_Tests, new CB_Tests(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(XIOT.Data.Objects.CB_Tests theCB_Tests)
        {
            return ExecuteAction(theCB_Tests, theCB_Tests, "Select", "Delete", DeleteView);
        }
    }
}
