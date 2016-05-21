using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace XIOT.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class LU_Groups
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _groupID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _groupCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _groupName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _notes;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _dateCreated;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _dateModified;
        
        public LU_Groups()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string GroupCode
        {
            get
            {
                return _groupCode;
            }
            set
            {
                _groupCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string GroupName
        {
            get
            {
                return _groupName;
            }
            set
            {
                _groupName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Notes
        {
            get
            {
                return _notes;
            }
            set
            {
                _notes = value;
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
        
        public static List<XIOT.Data.Objects.LU_Groups> Select(int? groupID, string groupCode, string groupName, string notes, DateTime? dateCreated, DateTime? dateModified)
        {
            return new LU_GroupsFactory().Select(groupID, groupCode, groupName, notes, dateCreated, dateModified);
        }
        
        public static List<XIOT.Data.Objects.LU_Groups> Select(XIOT.Data.Objects.LU_Groups qbe)
        {
            return new LU_GroupsFactory().Select(qbe);
        }
        
        public static List<XIOT.Data.Objects.LU_Groups> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new LU_GroupsFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<XIOT.Data.Objects.LU_Groups> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new LU_GroupsFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<XIOT.Data.Objects.LU_Groups> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new LU_GroupsFactory().Select(filter, sort, LU_GroupsFactory.SelectView, parameters);
        }
        
        public static List<XIOT.Data.Objects.LU_Groups> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new LU_GroupsFactory().Select(filter, sort, LU_GroupsFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<XIOT.Data.Objects.LU_Groups> Select(string filter, BusinessObjectParameters parameters)
        {
            return new LU_GroupsFactory().Select(filter, null, LU_GroupsFactory.SelectView, parameters);
        }
        
        public static List<XIOT.Data.Objects.LU_Groups> Select(string filter, params FieldValue[] parameters)
        {
            return new LU_GroupsFactory().Select(filter, null, LU_GroupsFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static XIOT.Data.Objects.LU_Groups SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new LU_GroupsFactory().SelectSingle(filter, parameters);
        }
        
        public static XIOT.Data.Objects.LU_Groups SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new LU_GroupsFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static XIOT.Data.Objects.LU_Groups SelectSingle(int? groupID)
        {
            return new LU_GroupsFactory().SelectSingle(groupID);
        }
        
        public int Insert()
        {
            return new LU_GroupsFactory().Insert(this);
        }
        
        public int Update()
        {
            return new LU_GroupsFactory().Update(this);
        }
        
        public int Delete()
        {
            return new LU_GroupsFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("GroupID: {0}", this.GroupID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class LU_GroupsFactory
    {
        
        public LU_GroupsFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("LU_Groups");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("LU_Groups");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("LU_Groups");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("LU_Groups");
            }
        }
        
        public static LU_GroupsFactory Create()
        {
            return new LU_GroupsFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? groupID, string groupCode, string groupName, string notes, DateTime? dateCreated, DateTime? dateModified, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (groupID.HasValue)
            	filter.Add(("GroupID:=" + groupID.Value.ToString()));
            if (!(String.IsNullOrEmpty(groupCode)))
            	filter.Add(("GroupCode:*" + groupCode));
            if (!(String.IsNullOrEmpty(groupName)))
            	filter.Add(("GroupName:*" + groupName));
            if (!(String.IsNullOrEmpty(notes)))
            	filter.Add(("Notes:*" + notes));
            if (dateCreated.HasValue)
            	filter.Add(("DateCreated:=" + dateCreated.Value.ToString()));
            if (dateModified.HasValue)
            	filter.Add(("DateModified:=" + dateModified.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<XIOT.Data.Objects.LU_Groups> Select(int? groupID, string groupCode, string groupName, string notes, DateTime? dateCreated, DateTime? dateModified, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(groupID, groupCode, groupName, notes, dateCreated, dateModified, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("LU_Groups", dataView, request);
            return page.ToList<XIOT.Data.Objects.LU_Groups>();
        }
        
        public List<XIOT.Data.Objects.LU_Groups> Select(XIOT.Data.Objects.LU_Groups qbe)
        {
            return Select(qbe.GroupID, qbe.GroupCode, qbe.GroupName, qbe.Notes, qbe.DateCreated, qbe.DateModified);
        }
        
        public int SelectCount(int? groupID, string groupCode, string groupName, string notes, DateTime? dateCreated, DateTime? dateModified, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(groupID, groupCode, groupName, notes, dateCreated, dateModified, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("LU_Groups", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<XIOT.Data.Objects.LU_Groups> Select(int? groupID, string groupCode, string groupName, string notes, DateTime? dateCreated, DateTime? dateModified)
        {
            return Select(groupID, groupCode, groupName, notes, dateCreated, dateModified, null, Int32.MaxValue, 0, SelectView);
        }
        
        public XIOT.Data.Objects.LU_Groups SelectSingle(int? groupID)
        {
            List<XIOT.Data.Objects.LU_Groups> list = Select(groupID, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<XIOT.Data.Objects.LU_Groups> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("LU_Groups", dataView, request);
            return page.ToList<XIOT.Data.Objects.LU_Groups>();
        }
        
        public List<XIOT.Data.Objects.LU_Groups> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<XIOT.Data.Objects.LU_Groups> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public XIOT.Data.Objects.LU_Groups SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<XIOT.Data.Objects.LU_Groups> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(XIOT.Data.Objects.LU_Groups theLU_Groups, XIOT.Data.Objects.LU_Groups original_LU_Groups)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("GroupID", original_LU_Groups.GroupID, theLU_Groups.GroupID));
            values.Add(new FieldValue("GroupCode", original_LU_Groups.GroupCode, theLU_Groups.GroupCode));
            values.Add(new FieldValue("GroupName", original_LU_Groups.GroupName, theLU_Groups.GroupName));
            values.Add(new FieldValue("Notes", original_LU_Groups.Notes, theLU_Groups.Notes));
            values.Add(new FieldValue("DateCreated", original_LU_Groups.DateCreated, theLU_Groups.DateCreated));
            values.Add(new FieldValue("DateModified", original_LU_Groups.DateModified, theLU_Groups.DateModified));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(XIOT.Data.Objects.LU_Groups theLU_Groups, XIOT.Data.Objects.LU_Groups original_LU_Groups, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "LU_Groups";
            args.View = dataView;
            args.Values = CreateFieldValues(theLU_Groups, original_LU_Groups);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("LU_Groups", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theLU_Groups);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(XIOT.Data.Objects.LU_Groups theLU_Groups, XIOT.Data.Objects.LU_Groups original_LU_Groups)
        {
            return ExecuteAction(theLU_Groups, original_LU_Groups, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(XIOT.Data.Objects.LU_Groups theLU_Groups)
        {
            return Update(theLU_Groups, SelectSingle(theLU_Groups.GroupID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(XIOT.Data.Objects.LU_Groups theLU_Groups)
        {
            return ExecuteAction(theLU_Groups, new LU_Groups(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(XIOT.Data.Objects.LU_Groups theLU_Groups)
        {
            return ExecuteAction(theLU_Groups, theLU_Groups, "Select", "Delete", DeleteView);
        }
    }
}
