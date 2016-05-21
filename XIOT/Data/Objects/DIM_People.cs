using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace XIOT.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class DIM_People
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _peopleID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _name;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _priority;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _startDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _endDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private double? _uTCOffset;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _observesDST;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _notes;
        
        public DIM_People()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public int? Priority
        {
            get
            {
                return _priority;
            }
            set
            {
                _priority = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? StartDate
        {
            get
            {
                return _startDate;
            }
            set
            {
                _startDate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? EndDate
        {
            get
            {
                return _endDate;
            }
            set
            {
                _endDate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public double? UTCOffset
        {
            get
            {
                return _uTCOffset;
            }
            set
            {
                _uTCOffset = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public bool? ObservesDST
        {
            get
            {
                return _observesDST;
            }
            set
            {
                _observesDST = value;
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
        
        public static List<XIOT.Data.Objects.DIM_People> Select(int? peopleID, string name, int? priority, DateTime? startDate, DateTime? endDate, double? uTCOffset, bool? observesDST, string notes)
        {
            return new DIM_PeopleFactory().Select(peopleID, name, priority, startDate, endDate, uTCOffset, observesDST, notes);
        }
        
        public static List<XIOT.Data.Objects.DIM_People> Select(XIOT.Data.Objects.DIM_People qbe)
        {
            return new DIM_PeopleFactory().Select(qbe);
        }
        
        public static List<XIOT.Data.Objects.DIM_People> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new DIM_PeopleFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<XIOT.Data.Objects.DIM_People> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new DIM_PeopleFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<XIOT.Data.Objects.DIM_People> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new DIM_PeopleFactory().Select(filter, sort, DIM_PeopleFactory.SelectView, parameters);
        }
        
        public static List<XIOT.Data.Objects.DIM_People> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new DIM_PeopleFactory().Select(filter, sort, DIM_PeopleFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<XIOT.Data.Objects.DIM_People> Select(string filter, BusinessObjectParameters parameters)
        {
            return new DIM_PeopleFactory().Select(filter, null, DIM_PeopleFactory.SelectView, parameters);
        }
        
        public static List<XIOT.Data.Objects.DIM_People> Select(string filter, params FieldValue[] parameters)
        {
            return new DIM_PeopleFactory().Select(filter, null, DIM_PeopleFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static XIOT.Data.Objects.DIM_People SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new DIM_PeopleFactory().SelectSingle(filter, parameters);
        }
        
        public static XIOT.Data.Objects.DIM_People SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new DIM_PeopleFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static XIOT.Data.Objects.DIM_People SelectSingle(int? peopleID)
        {
            return new DIM_PeopleFactory().SelectSingle(peopleID);
        }
        
        public int Insert()
        {
            return new DIM_PeopleFactory().Insert(this);
        }
        
        public int Update()
        {
            return new DIM_PeopleFactory().Update(this);
        }
        
        public int Delete()
        {
            return new DIM_PeopleFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("PeopleID: {0}", this.PeopleID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class DIM_PeopleFactory
    {
        
        public DIM_PeopleFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("DIM_People");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("DIM_People");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("DIM_People");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("DIM_People");
            }
        }
        
        public static DIM_PeopleFactory Create()
        {
            return new DIM_PeopleFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? peopleID, string name, int? priority, DateTime? startDate, DateTime? endDate, double? uTCOffset, bool? observesDST, string notes, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (peopleID.HasValue)
            	filter.Add(("PeopleID:=" + peopleID.Value.ToString()));
            if (!(String.IsNullOrEmpty(name)))
            	filter.Add(("Name:*" + name));
            if (priority.HasValue)
            	filter.Add(("Priority:=" + priority.Value.ToString()));
            if (startDate.HasValue)
            	filter.Add(("StartDate:=" + startDate.Value.ToString()));
            if (endDate.HasValue)
            	filter.Add(("EndDate:=" + endDate.Value.ToString()));
            if (uTCOffset.HasValue)
            	filter.Add(("UTCOffset:=" + uTCOffset.Value.ToString()));
            if (observesDST.HasValue)
            	filter.Add(("ObservesDST:=" + observesDST.Value.ToString()));
            if (!(String.IsNullOrEmpty(notes)))
            	filter.Add(("Notes:*" + notes));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<XIOT.Data.Objects.DIM_People> Select(int? peopleID, string name, int? priority, DateTime? startDate, DateTime? endDate, double? uTCOffset, bool? observesDST, string notes, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(peopleID, name, priority, startDate, endDate, uTCOffset, observesDST, notes, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("DIM_People", dataView, request);
            return page.ToList<XIOT.Data.Objects.DIM_People>();
        }
        
        public List<XIOT.Data.Objects.DIM_People> Select(XIOT.Data.Objects.DIM_People qbe)
        {
            return Select(qbe.PeopleID, qbe.Name, qbe.Priority, qbe.StartDate, qbe.EndDate, qbe.UTCOffset, qbe.ObservesDST, qbe.Notes);
        }
        
        public int SelectCount(int? peopleID, string name, int? priority, DateTime? startDate, DateTime? endDate, double? uTCOffset, bool? observesDST, string notes, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(peopleID, name, priority, startDate, endDate, uTCOffset, observesDST, notes, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("DIM_People", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<XIOT.Data.Objects.DIM_People> Select(int? peopleID, string name, int? priority, DateTime? startDate, DateTime? endDate, double? uTCOffset, bool? observesDST, string notes)
        {
            return Select(peopleID, name, priority, startDate, endDate, uTCOffset, observesDST, notes, null, Int32.MaxValue, 0, SelectView);
        }
        
        public XIOT.Data.Objects.DIM_People SelectSingle(int? peopleID)
        {
            List<XIOT.Data.Objects.DIM_People> list = Select(peopleID, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<XIOT.Data.Objects.DIM_People> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("DIM_People", dataView, request);
            return page.ToList<XIOT.Data.Objects.DIM_People>();
        }
        
        public List<XIOT.Data.Objects.DIM_People> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<XIOT.Data.Objects.DIM_People> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public XIOT.Data.Objects.DIM_People SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<XIOT.Data.Objects.DIM_People> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(XIOT.Data.Objects.DIM_People theDIM_People, XIOT.Data.Objects.DIM_People original_DIM_People)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("PeopleID", original_DIM_People.PeopleID, theDIM_People.PeopleID));
            values.Add(new FieldValue("Name", original_DIM_People.Name, theDIM_People.Name));
            values.Add(new FieldValue("Priority", original_DIM_People.Priority, theDIM_People.Priority));
            values.Add(new FieldValue("StartDate", original_DIM_People.StartDate, theDIM_People.StartDate));
            values.Add(new FieldValue("EndDate", original_DIM_People.EndDate, theDIM_People.EndDate));
            values.Add(new FieldValue("UTCOffset", original_DIM_People.UTCOffset, theDIM_People.UTCOffset));
            values.Add(new FieldValue("ObservesDST", original_DIM_People.ObservesDST, theDIM_People.ObservesDST));
            values.Add(new FieldValue("Notes", original_DIM_People.Notes, theDIM_People.Notes));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(XIOT.Data.Objects.DIM_People theDIM_People, XIOT.Data.Objects.DIM_People original_DIM_People, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "DIM_People";
            args.View = dataView;
            args.Values = CreateFieldValues(theDIM_People, original_DIM_People);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("DIM_People", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theDIM_People);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(XIOT.Data.Objects.DIM_People theDIM_People, XIOT.Data.Objects.DIM_People original_DIM_People)
        {
            return ExecuteAction(theDIM_People, original_DIM_People, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(XIOT.Data.Objects.DIM_People theDIM_People)
        {
            return Update(theDIM_People, SelectSingle(theDIM_People.PeopleID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(XIOT.Data.Objects.DIM_People theDIM_People)
        {
            return ExecuteAction(theDIM_People, new DIM_People(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(XIOT.Data.Objects.DIM_People theDIM_People)
        {
            return ExecuteAction(theDIM_People, theDIM_People, "Select", "Delete", DeleteView);
        }
    }
}
