using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace XIOT.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class CB_TestPopulation
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _testPopulationID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _testID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _testTestName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _personOrGroup;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _peopleID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _peopleName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _groupID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _groupGroupCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isPass;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _dateCreated;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _dateModified;
        
        public CB_TestPopulation()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? TestPopulationID
        {
            get
            {
                return _testPopulationID;
            }
            set
            {
                _testPopulationID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string TestTestName
        {
            get
            {
                return _testTestName;
            }
            set
            {
                _testTestName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public bool? PersonOrGroup
        {
            get
            {
                return _personOrGroup;
            }
            set
            {
                _personOrGroup = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? PeopleID
        {
            get
            {
                return _peopleID;
            }
            set
            {
                _peopleID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PeopleName
        {
            get
            {
                return _peopleName;
            }
            set
            {
                _peopleName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? GroupID
        {
            get
            {
                return _groupID;
            }
            set
            {
                _groupID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string GroupGroupCode
        {
            get
            {
                return _groupGroupCode;
            }
            set
            {
                _groupGroupCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? IsPass
        {
            get
            {
                return _isPass;
            }
            set
            {
                _isPass = value;
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
        
        public static List<XIOT.Data.Objects.CB_TestPopulation> Select(int? testPopulationID, int? testID, string testTestName, bool? personOrGroup, int? peopleID, string peopleName, int? groupID, string groupGroupCode, bool? isPass, DateTime? dateCreated, DateTime? dateModified)
        {
            return new CB_TestPopulationFactory().Select(testPopulationID, testID, testTestName, personOrGroup, peopleID, peopleName, groupID, groupGroupCode, isPass, dateCreated, dateModified);
        }
        
        public static List<XIOT.Data.Objects.CB_TestPopulation> Select(XIOT.Data.Objects.CB_TestPopulation qbe)
        {
            return new CB_TestPopulationFactory().Select(qbe);
        }
        
        public static List<XIOT.Data.Objects.CB_TestPopulation> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new CB_TestPopulationFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<XIOT.Data.Objects.CB_TestPopulation> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new CB_TestPopulationFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<XIOT.Data.Objects.CB_TestPopulation> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new CB_TestPopulationFactory().Select(filter, sort, CB_TestPopulationFactory.SelectView, parameters);
        }
        
        public static List<XIOT.Data.Objects.CB_TestPopulation> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new CB_TestPopulationFactory().Select(filter, sort, CB_TestPopulationFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<XIOT.Data.Objects.CB_TestPopulation> Select(string filter, BusinessObjectParameters parameters)
        {
            return new CB_TestPopulationFactory().Select(filter, null, CB_TestPopulationFactory.SelectView, parameters);
        }
        
        public static List<XIOT.Data.Objects.CB_TestPopulation> Select(string filter, params FieldValue[] parameters)
        {
            return new CB_TestPopulationFactory().Select(filter, null, CB_TestPopulationFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static XIOT.Data.Objects.CB_TestPopulation SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new CB_TestPopulationFactory().SelectSingle(filter, parameters);
        }
        
        public static XIOT.Data.Objects.CB_TestPopulation SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new CB_TestPopulationFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static XIOT.Data.Objects.CB_TestPopulation SelectSingle(int? testPopulationID)
        {
            return new CB_TestPopulationFactory().SelectSingle(testPopulationID);
        }
        
        public int Insert()
        {
            return new CB_TestPopulationFactory().Insert(this);
        }
        
        public int Update()
        {
            return new CB_TestPopulationFactory().Update(this);
        }
        
        public int Delete()
        {
            return new CB_TestPopulationFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("TestPopulationID: {0}", this.TestPopulationID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class CB_TestPopulationFactory
    {
        
        public CB_TestPopulationFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("CB_TestPopulation");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("CB_TestPopulation");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("CB_TestPopulation");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("CB_TestPopulation");
            }
        }
        
        public static CB_TestPopulationFactory Create()
        {
            return new CB_TestPopulationFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? testPopulationID, int? testID, string testTestName, bool? personOrGroup, int? peopleID, string peopleName, int? groupID, string groupGroupCode, bool? isPass, DateTime? dateCreated, DateTime? dateModified, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (testPopulationID.HasValue)
            	filter.Add(("TestPopulationID:=" + testPopulationID.Value.ToString()));
            if (testID.HasValue)
            	filter.Add(("TestID:=" + testID.Value.ToString()));
            if (!(String.IsNullOrEmpty(testTestName)))
            	filter.Add(("TestTestName:*" + testTestName));
            if (personOrGroup.HasValue)
            	filter.Add(("PersonOrGroup:=" + personOrGroup.Value.ToString()));
            if (peopleID.HasValue)
            	filter.Add(("PeopleID:=" + peopleID.Value.ToString()));
            if (!(String.IsNullOrEmpty(peopleName)))
            	filter.Add(("PeopleName:*" + peopleName));
            if (groupID.HasValue)
            	filter.Add(("GroupID:=" + groupID.Value.ToString()));
            if (!(String.IsNullOrEmpty(groupGroupCode)))
            	filter.Add(("GroupGroupCode:*" + groupGroupCode));
            if (isPass.HasValue)
            	filter.Add(("IsPass:=" + isPass.Value.ToString()));
            if (dateCreated.HasValue)
            	filter.Add(("DateCreated:=" + dateCreated.Value.ToString()));
            if (dateModified.HasValue)
            	filter.Add(("DateModified:=" + dateModified.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<XIOT.Data.Objects.CB_TestPopulation> Select(int? testPopulationID, int? testID, string testTestName, bool? personOrGroup, int? peopleID, string peopleName, int? groupID, string groupGroupCode, bool? isPass, DateTime? dateCreated, DateTime? dateModified, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(testPopulationID, testID, testTestName, personOrGroup, peopleID, peopleName, groupID, groupGroupCode, isPass, dateCreated, dateModified, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("CB_TestPopulation", dataView, request);
            return page.ToList<XIOT.Data.Objects.CB_TestPopulation>();
        }
        
        public List<XIOT.Data.Objects.CB_TestPopulation> Select(XIOT.Data.Objects.CB_TestPopulation qbe)
        {
            return Select(qbe.TestPopulationID, qbe.TestID, qbe.TestTestName, qbe.PersonOrGroup, qbe.PeopleID, qbe.PeopleName, qbe.GroupID, qbe.GroupGroupCode, qbe.IsPass, qbe.DateCreated, qbe.DateModified);
        }
        
        public int SelectCount(int? testPopulationID, int? testID, string testTestName, bool? personOrGroup, int? peopleID, string peopleName, int? groupID, string groupGroupCode, bool? isPass, DateTime? dateCreated, DateTime? dateModified, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(testPopulationID, testID, testTestName, personOrGroup, peopleID, peopleName, groupID, groupGroupCode, isPass, dateCreated, dateModified, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("CB_TestPopulation", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<XIOT.Data.Objects.CB_TestPopulation> Select(int? testPopulationID, int? testID, string testTestName, bool? personOrGroup, int? peopleID, string peopleName, int? groupID, string groupGroupCode, bool? isPass, DateTime? dateCreated, DateTime? dateModified)
        {
            return Select(testPopulationID, testID, testTestName, personOrGroup, peopleID, peopleName, groupID, groupGroupCode, isPass, dateCreated, dateModified, null, Int32.MaxValue, 0, SelectView);
        }
        
        public XIOT.Data.Objects.CB_TestPopulation SelectSingle(int? testPopulationID)
        {
            List<XIOT.Data.Objects.CB_TestPopulation> list = Select(testPopulationID, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<XIOT.Data.Objects.CB_TestPopulation> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("CB_TestPopulation", dataView, request);
            return page.ToList<XIOT.Data.Objects.CB_TestPopulation>();
        }
        
        public List<XIOT.Data.Objects.CB_TestPopulation> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<XIOT.Data.Objects.CB_TestPopulation> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public XIOT.Data.Objects.CB_TestPopulation SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<XIOT.Data.Objects.CB_TestPopulation> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(XIOT.Data.Objects.CB_TestPopulation theCB_TestPopulation, XIOT.Data.Objects.CB_TestPopulation original_CB_TestPopulation)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("TestPopulationID", original_CB_TestPopulation.TestPopulationID, theCB_TestPopulation.TestPopulationID));
            values.Add(new FieldValue("TestID", original_CB_TestPopulation.TestID, theCB_TestPopulation.TestID));
            values.Add(new FieldValue("TestTestName", original_CB_TestPopulation.TestTestName, theCB_TestPopulation.TestTestName));
            values.Add(new FieldValue("PersonOrGroup", original_CB_TestPopulation.PersonOrGroup, theCB_TestPopulation.PersonOrGroup));
            values.Add(new FieldValue("PeopleID", original_CB_TestPopulation.PeopleID, theCB_TestPopulation.PeopleID));
            values.Add(new FieldValue("PeopleName", original_CB_TestPopulation.PeopleName, theCB_TestPopulation.PeopleName));
            values.Add(new FieldValue("GroupID", original_CB_TestPopulation.GroupID, theCB_TestPopulation.GroupID));
            values.Add(new FieldValue("GroupGroupCode", original_CB_TestPopulation.GroupGroupCode, theCB_TestPopulation.GroupGroupCode));
            values.Add(new FieldValue("IsPass", original_CB_TestPopulation.IsPass, theCB_TestPopulation.IsPass));
            values.Add(new FieldValue("DateCreated", original_CB_TestPopulation.DateCreated, theCB_TestPopulation.DateCreated));
            values.Add(new FieldValue("DateModified", original_CB_TestPopulation.DateModified, theCB_TestPopulation.DateModified));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(XIOT.Data.Objects.CB_TestPopulation theCB_TestPopulation, XIOT.Data.Objects.CB_TestPopulation original_CB_TestPopulation, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "CB_TestPopulation";
            args.View = dataView;
            args.Values = CreateFieldValues(theCB_TestPopulation, original_CB_TestPopulation);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("CB_TestPopulation", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theCB_TestPopulation);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(XIOT.Data.Objects.CB_TestPopulation theCB_TestPopulation, XIOT.Data.Objects.CB_TestPopulation original_CB_TestPopulation)
        {
            return ExecuteAction(theCB_TestPopulation, original_CB_TestPopulation, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(XIOT.Data.Objects.CB_TestPopulation theCB_TestPopulation)
        {
            return Update(theCB_TestPopulation, SelectSingle(theCB_TestPopulation.TestPopulationID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(XIOT.Data.Objects.CB_TestPopulation theCB_TestPopulation)
        {
            return ExecuteAction(theCB_TestPopulation, new CB_TestPopulation(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(XIOT.Data.Objects.CB_TestPopulation theCB_TestPopulation)
        {
            return ExecuteAction(theCB_TestPopulation, theCB_TestPopulation, "Select", "Delete", DeleteView);
        }
    }
}
