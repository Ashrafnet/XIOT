using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace XIOT.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class Groups_People
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _groupID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _groupGroupCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _peopleID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _peopleName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _dateCreated;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _dateModified;
        
        public Groups_People()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
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
        
        [System.ComponentModel.DataObjectField(true, false, false)]
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
        
        public static List<XIOT.Data.Objects.Groups_People> Select(int? groupID, string groupGroupCode, int? peopleID, string peopleName, DateTime? dateCreated, DateTime? dateModified)
        {
            return new Groups_PeopleFactory().Select(groupID, groupGroupCode, peopleID, peopleName, dateCreated, dateModified);
        }
        
        public static List<XIOT.Data.Objects.Groups_People> Select(XIOT.Data.Objects.Groups_People qbe)
        {
            return new Groups_PeopleFactory().Select(qbe);
        }
        
        public static List<XIOT.Data.Objects.Groups_People> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new Groups_PeopleFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<XIOT.Data.Objects.Groups_People> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new Groups_PeopleFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<XIOT.Data.Objects.Groups_People> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new Groups_PeopleFactory().Select(filter, sort, Groups_PeopleFactory.SelectView, parameters);
        }
        
        public static List<XIOT.Data.Objects.Groups_People> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new Groups_PeopleFactory().Select(filter, sort, Groups_PeopleFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<XIOT.Data.Objects.Groups_People> Select(string filter, BusinessObjectParameters parameters)
        {
            return new Groups_PeopleFactory().Select(filter, null, Groups_PeopleFactory.SelectView, parameters);
        }
        
        public static List<XIOT.Data.Objects.Groups_People> Select(string filter, params FieldValue[] parameters)
        {
            return new Groups_PeopleFactory().Select(filter, null, Groups_PeopleFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static XIOT.Data.Objects.Groups_People SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new Groups_PeopleFactory().SelectSingle(filter, parameters);
        }
        
        public static XIOT.Data.Objects.Groups_People SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new Groups_PeopleFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static XIOT.Data.Objects.Groups_People SelectSingle(int? groupID, int? peopleID)
        {
            return new Groups_PeopleFactory().SelectSingle(groupID, peopleID);
        }
        
        public int Insert()
        {
            return new Groups_PeopleFactory().Insert(this);
        }
        
        public int Update()
        {
            return new Groups_PeopleFactory().Update(this);
        }
        
        public int Delete()
        {
            return new Groups_PeopleFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("GroupID: {0}; PeopleID: {1}", this.GroupID, this.PeopleID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class Groups_PeopleFactory
    {
        
        public Groups_PeopleFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Groups_People");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Groups_People");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Groups_People");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Groups_People");
            }
        }
        
        public static Groups_PeopleFactory Create()
        {
            return new Groups_PeopleFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? groupID, string groupGroupCode, int? peopleID, string peopleName, DateTime? dateCreated, DateTime? dateModified, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (groupID.HasValue)
            	filter.Add(("GroupID:=" + groupID.Value.ToString()));
            if (!(String.IsNullOrEmpty(groupGroupCode)))
            	filter.Add(("GroupGroupCode:*" + groupGroupCode));
            if (peopleID.HasValue)
            	filter.Add(("PeopleID:=" + peopleID.Value.ToString()));
            if (!(String.IsNullOrEmpty(peopleName)))
            	filter.Add(("PeopleName:*" + peopleName));
            if (dateCreated.HasValue)
            	filter.Add(("DateCreated:=" + dateCreated.Value.ToString()));
            if (dateModified.HasValue)
            	filter.Add(("DateModified:=" + dateModified.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<XIOT.Data.Objects.Groups_People> Select(int? groupID, string groupGroupCode, int? peopleID, string peopleName, DateTime? dateCreated, DateTime? dateModified, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(groupID, groupGroupCode, peopleID, peopleName, dateCreated, dateModified, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Groups_People", dataView, request);
            return page.ToList<XIOT.Data.Objects.Groups_People>();
        }
        
        public List<XIOT.Data.Objects.Groups_People> Select(XIOT.Data.Objects.Groups_People qbe)
        {
            return Select(qbe.GroupID, qbe.GroupGroupCode, qbe.PeopleID, qbe.PeopleName, qbe.DateCreated, qbe.DateModified);
        }
        
        public int SelectCount(int? groupID, string groupGroupCode, int? peopleID, string peopleName, DateTime? dateCreated, DateTime? dateModified, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(groupID, groupGroupCode, peopleID, peopleName, dateCreated, dateModified, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Groups_People", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<XIOT.Data.Objects.Groups_People> Select(int? groupID, string groupGroupCode, int? peopleID, string peopleName, DateTime? dateCreated, DateTime? dateModified)
        {
            return Select(groupID, groupGroupCode, peopleID, peopleName, dateCreated, dateModified, null, Int32.MaxValue, 0, SelectView);
        }
        
        public XIOT.Data.Objects.Groups_People SelectSingle(int? groupID, int? peopleID)
        {
            List<XIOT.Data.Objects.Groups_People> list = Select(groupID, null, peopleID, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<XIOT.Data.Objects.Groups_People> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("Groups_People", dataView, request);
            return page.ToList<XIOT.Data.Objects.Groups_People>();
        }
        
        public List<XIOT.Data.Objects.Groups_People> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<XIOT.Data.Objects.Groups_People> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public XIOT.Data.Objects.Groups_People SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<XIOT.Data.Objects.Groups_People> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(XIOT.Data.Objects.Groups_People theGroups_People, XIOT.Data.Objects.Groups_People original_Groups_People)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("GroupID", original_Groups_People.GroupID, theGroups_People.GroupID));
            values.Add(new FieldValue("GroupGroupCode", original_Groups_People.GroupGroupCode, theGroups_People.GroupGroupCode));
            values.Add(new FieldValue("PeopleID", original_Groups_People.PeopleID, theGroups_People.PeopleID));
            values.Add(new FieldValue("PeopleName", original_Groups_People.PeopleName, theGroups_People.PeopleName));
            values.Add(new FieldValue("DateCreated", original_Groups_People.DateCreated, theGroups_People.DateCreated));
            values.Add(new FieldValue("DateModified", original_Groups_People.DateModified, theGroups_People.DateModified));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(XIOT.Data.Objects.Groups_People theGroups_People, XIOT.Data.Objects.Groups_People original_Groups_People, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "Groups_People";
            args.View = dataView;
            args.Values = CreateFieldValues(theGroups_People, original_Groups_People);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("Groups_People", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theGroups_People);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(XIOT.Data.Objects.Groups_People theGroups_People, XIOT.Data.Objects.Groups_People original_Groups_People)
        {
            return ExecuteAction(theGroups_People, original_Groups_People, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(XIOT.Data.Objects.Groups_People theGroups_People)
        {
            return Update(theGroups_People, SelectSingle(theGroups_People.GroupID, theGroups_People.PeopleID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(XIOT.Data.Objects.Groups_People theGroups_People)
        {
            return ExecuteAction(theGroups_People, new Groups_People(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(XIOT.Data.Objects.Groups_People theGroups_People)
        {
            return ExecuteAction(theGroups_People, theGroups_People, "Select", "Delete", DeleteView);
        }
    }
}
