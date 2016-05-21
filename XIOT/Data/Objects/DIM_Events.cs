using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace XIOT.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class DIM_Events
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _eventID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _name;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _eventTypeID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _eventTypeEventType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isActive;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _logSourceID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _logSourceCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _description;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _granularity;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _timeSourceID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _timeSourceCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private double? _serverUTCOffset;
        
        public DIM_Events()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? EventID
        {
            get
            {
                return _eventID;
            }
            set
            {
                _eventID = value;
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
        public int? EventTypeID
        {
            get
            {
                return _eventTypeID;
            }
            set
            {
                _eventTypeID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string EventTypeEventType
        {
            get
            {
                return _eventTypeEventType;
            }
            set
            {
                _eventTypeEventType = value;
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
        public int? LogSourceID
        {
            get
            {
                return _logSourceID;
            }
            set
            {
                _logSourceID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LogSourceCode
        {
            get
            {
                return _logSourceCode;
            }
            set
            {
                _logSourceCode = value;
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public long? Granularity
        {
            get
            {
                return _granularity;
            }
            set
            {
                _granularity = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? TimeSourceID
        {
            get
            {
                return _timeSourceID;
            }
            set
            {
                _timeSourceID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string TimeSourceCode
        {
            get
            {
                return _timeSourceCode;
            }
            set
            {
                _timeSourceCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public double? ServerUTCOffset
        {
            get
            {
                return _serverUTCOffset;
            }
            set
            {
                _serverUTCOffset = value;
            }
        }
        
        public static List<XIOT.Data.Objects.DIM_Events> Select(int? eventID, string name, int? eventTypeID, string eventTypeEventType, bool? isActive, int? logSourceID, string logSourceCode, string description, long? granularity, int? timeSourceID, string timeSourceCode, double? serverUTCOffset)
        {
            return new DIM_EventsFactory().Select(eventID, name, eventTypeID, eventTypeEventType, isActive, logSourceID, logSourceCode, description, granularity, timeSourceID, timeSourceCode, serverUTCOffset);
        }
        
        public static List<XIOT.Data.Objects.DIM_Events> Select(XIOT.Data.Objects.DIM_Events qbe)
        {
            return new DIM_EventsFactory().Select(qbe);
        }
        
        public static List<XIOT.Data.Objects.DIM_Events> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new DIM_EventsFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<XIOT.Data.Objects.DIM_Events> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new DIM_EventsFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<XIOT.Data.Objects.DIM_Events> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new DIM_EventsFactory().Select(filter, sort, DIM_EventsFactory.SelectView, parameters);
        }
        
        public static List<XIOT.Data.Objects.DIM_Events> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new DIM_EventsFactory().Select(filter, sort, DIM_EventsFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<XIOT.Data.Objects.DIM_Events> Select(string filter, BusinessObjectParameters parameters)
        {
            return new DIM_EventsFactory().Select(filter, null, DIM_EventsFactory.SelectView, parameters);
        }
        
        public static List<XIOT.Data.Objects.DIM_Events> Select(string filter, params FieldValue[] parameters)
        {
            return new DIM_EventsFactory().Select(filter, null, DIM_EventsFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static XIOT.Data.Objects.DIM_Events SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new DIM_EventsFactory().SelectSingle(filter, parameters);
        }
        
        public static XIOT.Data.Objects.DIM_Events SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new DIM_EventsFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static XIOT.Data.Objects.DIM_Events SelectSingle(int? eventID)
        {
            return new DIM_EventsFactory().SelectSingle(eventID);
        }
        
        public int Insert()
        {
            return new DIM_EventsFactory().Insert(this);
        }
        
        public int Update()
        {
            return new DIM_EventsFactory().Update(this);
        }
        
        public int Delete()
        {
            return new DIM_EventsFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("EventID: {0}", this.EventID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class DIM_EventsFactory
    {
        
        public DIM_EventsFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("DIM_Events");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("DIM_Events");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("DIM_Events");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("DIM_Events");
            }
        }
        
        public static DIM_EventsFactory Create()
        {
            return new DIM_EventsFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? eventID, string name, int? eventTypeID, string eventTypeEventType, bool? isActive, int? logSourceID, string logSourceCode, string description, long? granularity, int? timeSourceID, string timeSourceCode, double? serverUTCOffset, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (eventID.HasValue)
            	filter.Add(("EventID:=" + eventID.Value.ToString()));
            if (!(String.IsNullOrEmpty(name)))
            	filter.Add(("Name:*" + name));
            if (eventTypeID.HasValue)
            	filter.Add(("EventTypeID:=" + eventTypeID.Value.ToString()));
            if (!(String.IsNullOrEmpty(eventTypeEventType)))
            	filter.Add(("EventTypeEventType:*" + eventTypeEventType));
            if (isActive.HasValue)
            	filter.Add(("IsActive:=" + isActive.Value.ToString()));
            if (logSourceID.HasValue)
            	filter.Add(("LogSourceID:=" + logSourceID.Value.ToString()));
            if (!(String.IsNullOrEmpty(logSourceCode)))
            	filter.Add(("LogSourceCode:*" + logSourceCode));
            if (!(String.IsNullOrEmpty(description)))
            	filter.Add(("Description:*" + description));
            if (granularity.HasValue)
            	filter.Add(("Granularity:=" + granularity.Value.ToString()));
            if (timeSourceID.HasValue)
            	filter.Add(("TimeSourceID:=" + timeSourceID.Value.ToString()));
            if (!(String.IsNullOrEmpty(timeSourceCode)))
            	filter.Add(("TimeSourceCode:*" + timeSourceCode));
            if (serverUTCOffset.HasValue)
            	filter.Add(("ServerUTCOffset:=" + serverUTCOffset.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<XIOT.Data.Objects.DIM_Events> Select(
                    int? eventID, 
                    string name, 
                    int? eventTypeID, 
                    string eventTypeEventType, 
                    bool? isActive, 
                    int? logSourceID, 
                    string logSourceCode, 
                    string description, 
                    long? granularity, 
                    int? timeSourceID, 
                    string timeSourceCode, 
                    double? serverUTCOffset, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(eventID, name, eventTypeID, eventTypeEventType, isActive, logSourceID, logSourceCode, description, granularity, timeSourceID, timeSourceCode, serverUTCOffset, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("DIM_Events", dataView, request);
            return page.ToList<XIOT.Data.Objects.DIM_Events>();
        }
        
        public List<XIOT.Data.Objects.DIM_Events> Select(XIOT.Data.Objects.DIM_Events qbe)
        {
            return Select(qbe.EventID, qbe.Name, qbe.EventTypeID, qbe.EventTypeEventType, qbe.IsActive, qbe.LogSourceID, qbe.LogSourceCode, qbe.Description, qbe.Granularity, qbe.TimeSourceID, qbe.TimeSourceCode, qbe.ServerUTCOffset);
        }
        
        public int SelectCount(
                    int? eventID, 
                    string name, 
                    int? eventTypeID, 
                    string eventTypeEventType, 
                    bool? isActive, 
                    int? logSourceID, 
                    string logSourceCode, 
                    string description, 
                    long? granularity, 
                    int? timeSourceID, 
                    string timeSourceCode, 
                    double? serverUTCOffset, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(eventID, name, eventTypeID, eventTypeEventType, isActive, logSourceID, logSourceCode, description, granularity, timeSourceID, timeSourceCode, serverUTCOffset, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("DIM_Events", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<XIOT.Data.Objects.DIM_Events> Select(int? eventID, string name, int? eventTypeID, string eventTypeEventType, bool? isActive, int? logSourceID, string logSourceCode, string description, long? granularity, int? timeSourceID, string timeSourceCode, double? serverUTCOffset)
        {
            return Select(eventID, name, eventTypeID, eventTypeEventType, isActive, logSourceID, logSourceCode, description, granularity, timeSourceID, timeSourceCode, serverUTCOffset, null, Int32.MaxValue, 0, SelectView);
        }
        
        public XIOT.Data.Objects.DIM_Events SelectSingle(int? eventID)
        {
            List<XIOT.Data.Objects.DIM_Events> list = Select(eventID, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<XIOT.Data.Objects.DIM_Events> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("DIM_Events", dataView, request);
            return page.ToList<XIOT.Data.Objects.DIM_Events>();
        }
        
        public List<XIOT.Data.Objects.DIM_Events> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<XIOT.Data.Objects.DIM_Events> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public XIOT.Data.Objects.DIM_Events SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<XIOT.Data.Objects.DIM_Events> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(XIOT.Data.Objects.DIM_Events theDIM_Events, XIOT.Data.Objects.DIM_Events original_DIM_Events)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("EventID", original_DIM_Events.EventID, theDIM_Events.EventID));
            values.Add(new FieldValue("Name", original_DIM_Events.Name, theDIM_Events.Name));
            values.Add(new FieldValue("EventTypeID", original_DIM_Events.EventTypeID, theDIM_Events.EventTypeID));
            values.Add(new FieldValue("EventTypeEventType", original_DIM_Events.EventTypeEventType, theDIM_Events.EventTypeEventType));
            values.Add(new FieldValue("IsActive", original_DIM_Events.IsActive, theDIM_Events.IsActive));
            values.Add(new FieldValue("LogSourceID", original_DIM_Events.LogSourceID, theDIM_Events.LogSourceID));
            values.Add(new FieldValue("LogSourceCode", original_DIM_Events.LogSourceCode, theDIM_Events.LogSourceCode));
            values.Add(new FieldValue("Description", original_DIM_Events.Description, theDIM_Events.Description));
            values.Add(new FieldValue("Granularity", original_DIM_Events.Granularity, theDIM_Events.Granularity));
            values.Add(new FieldValue("TimeSourceID", original_DIM_Events.TimeSourceID, theDIM_Events.TimeSourceID));
            values.Add(new FieldValue("TimeSourceCode", original_DIM_Events.TimeSourceCode, theDIM_Events.TimeSourceCode));
            values.Add(new FieldValue("ServerUTCOffset", original_DIM_Events.ServerUTCOffset, theDIM_Events.ServerUTCOffset));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(XIOT.Data.Objects.DIM_Events theDIM_Events, XIOT.Data.Objects.DIM_Events original_DIM_Events, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "DIM_Events";
            args.View = dataView;
            args.Values = CreateFieldValues(theDIM_Events, original_DIM_Events);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("DIM_Events", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theDIM_Events);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(XIOT.Data.Objects.DIM_Events theDIM_Events, XIOT.Data.Objects.DIM_Events original_DIM_Events)
        {
            return ExecuteAction(theDIM_Events, original_DIM_Events, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(XIOT.Data.Objects.DIM_Events theDIM_Events)
        {
            return Update(theDIM_Events, SelectSingle(theDIM_Events.EventID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(XIOT.Data.Objects.DIM_Events theDIM_Events)
        {
            return ExecuteAction(theDIM_Events, new DIM_Events(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(XIOT.Data.Objects.DIM_Events theDIM_Events)
        {
            return ExecuteAction(theDIM_Events, theDIM_Events, "Select", "Delete", DeleteView);
        }
    }
}
