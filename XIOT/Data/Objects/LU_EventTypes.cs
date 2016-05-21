using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace XIOT.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class LU_EventTypes
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _eventTypeID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _eventType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _name;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _dateCreated;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _dateModified;
        
        public LU_EventTypes()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string EventType
        {
            get
            {
                return _eventType;
            }
            set
            {
                _eventType = value;
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
        
        public static List<XIOT.Data.Objects.LU_EventTypes> Select(int? eventTypeID, string eventType, string name, DateTime? dateCreated, DateTime? dateModified)
        {
            return new LU_EventTypesFactory().Select(eventTypeID, eventType, name, dateCreated, dateModified);
        }
        
        public static List<XIOT.Data.Objects.LU_EventTypes> Select(XIOT.Data.Objects.LU_EventTypes qbe)
        {
            return new LU_EventTypesFactory().Select(qbe);
        }
        
        public static List<XIOT.Data.Objects.LU_EventTypes> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new LU_EventTypesFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<XIOT.Data.Objects.LU_EventTypes> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new LU_EventTypesFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<XIOT.Data.Objects.LU_EventTypes> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new LU_EventTypesFactory().Select(filter, sort, LU_EventTypesFactory.SelectView, parameters);
        }
        
        public static List<XIOT.Data.Objects.LU_EventTypes> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new LU_EventTypesFactory().Select(filter, sort, LU_EventTypesFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<XIOT.Data.Objects.LU_EventTypes> Select(string filter, BusinessObjectParameters parameters)
        {
            return new LU_EventTypesFactory().Select(filter, null, LU_EventTypesFactory.SelectView, parameters);
        }
        
        public static List<XIOT.Data.Objects.LU_EventTypes> Select(string filter, params FieldValue[] parameters)
        {
            return new LU_EventTypesFactory().Select(filter, null, LU_EventTypesFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static XIOT.Data.Objects.LU_EventTypes SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new LU_EventTypesFactory().SelectSingle(filter, parameters);
        }
        
        public static XIOT.Data.Objects.LU_EventTypes SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new LU_EventTypesFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static XIOT.Data.Objects.LU_EventTypes SelectSingle(int? eventTypeID)
        {
            return new LU_EventTypesFactory().SelectSingle(eventTypeID);
        }
        
        public int Insert()
        {
            return new LU_EventTypesFactory().Insert(this);
        }
        
        public int Update()
        {
            return new LU_EventTypesFactory().Update(this);
        }
        
        public int Delete()
        {
            return new LU_EventTypesFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("EventTypeID: {0}", this.EventTypeID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class LU_EventTypesFactory
    {
        
        public LU_EventTypesFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("LU_EventTypes");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("LU_EventTypes");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("LU_EventTypes");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("LU_EventTypes");
            }
        }
        
        public static LU_EventTypesFactory Create()
        {
            return new LU_EventTypesFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? eventTypeID, string eventType, string name, DateTime? dateCreated, DateTime? dateModified, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (eventTypeID.HasValue)
            	filter.Add(("EventTypeID:=" + eventTypeID.Value.ToString()));
            if (!(String.IsNullOrEmpty(eventType)))
            	filter.Add(("EventType:*" + eventType));
            if (!(String.IsNullOrEmpty(name)))
            	filter.Add(("Name:*" + name));
            if (dateCreated.HasValue)
            	filter.Add(("DateCreated:=" + dateCreated.Value.ToString()));
            if (dateModified.HasValue)
            	filter.Add(("DateModified:=" + dateModified.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<XIOT.Data.Objects.LU_EventTypes> Select(int? eventTypeID, string eventType, string name, DateTime? dateCreated, DateTime? dateModified, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(eventTypeID, eventType, name, dateCreated, dateModified, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("LU_EventTypes", dataView, request);
            return page.ToList<XIOT.Data.Objects.LU_EventTypes>();
        }
        
        public List<XIOT.Data.Objects.LU_EventTypes> Select(XIOT.Data.Objects.LU_EventTypes qbe)
        {
            return Select(qbe.EventTypeID, qbe.EventType, qbe.Name, qbe.DateCreated, qbe.DateModified);
        }
        
        public int SelectCount(int? eventTypeID, string eventType, string name, DateTime? dateCreated, DateTime? dateModified, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(eventTypeID, eventType, name, dateCreated, dateModified, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("LU_EventTypes", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<XIOT.Data.Objects.LU_EventTypes> Select(int? eventTypeID, string eventType, string name, DateTime? dateCreated, DateTime? dateModified)
        {
            return Select(eventTypeID, eventType, name, dateCreated, dateModified, null, Int32.MaxValue, 0, SelectView);
        }
        
        public XIOT.Data.Objects.LU_EventTypes SelectSingle(int? eventTypeID)
        {
            List<XIOT.Data.Objects.LU_EventTypes> list = Select(eventTypeID, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<XIOT.Data.Objects.LU_EventTypes> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("LU_EventTypes", dataView, request);
            return page.ToList<XIOT.Data.Objects.LU_EventTypes>();
        }
        
        public List<XIOT.Data.Objects.LU_EventTypes> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<XIOT.Data.Objects.LU_EventTypes> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public XIOT.Data.Objects.LU_EventTypes SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<XIOT.Data.Objects.LU_EventTypes> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(XIOT.Data.Objects.LU_EventTypes theLU_EventTypes, XIOT.Data.Objects.LU_EventTypes original_LU_EventTypes)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("EventTypeID", original_LU_EventTypes.EventTypeID, theLU_EventTypes.EventTypeID));
            values.Add(new FieldValue("EventType", original_LU_EventTypes.EventType, theLU_EventTypes.EventType));
            values.Add(new FieldValue("Name", original_LU_EventTypes.Name, theLU_EventTypes.Name));
            values.Add(new FieldValue("DateCreated", original_LU_EventTypes.DateCreated, theLU_EventTypes.DateCreated));
            values.Add(new FieldValue("DateModified", original_LU_EventTypes.DateModified, theLU_EventTypes.DateModified));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(XIOT.Data.Objects.LU_EventTypes theLU_EventTypes, XIOT.Data.Objects.LU_EventTypes original_LU_EventTypes, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "LU_EventTypes";
            args.View = dataView;
            args.Values = CreateFieldValues(theLU_EventTypes, original_LU_EventTypes);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("LU_EventTypes", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theLU_EventTypes);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(XIOT.Data.Objects.LU_EventTypes theLU_EventTypes, XIOT.Data.Objects.LU_EventTypes original_LU_EventTypes)
        {
            return ExecuteAction(theLU_EventTypes, original_LU_EventTypes, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(XIOT.Data.Objects.LU_EventTypes theLU_EventTypes)
        {
            return Update(theLU_EventTypes, SelectSingle(theLU_EventTypes.EventTypeID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(XIOT.Data.Objects.LU_EventTypes theLU_EventTypes)
        {
            return ExecuteAction(theLU_EventTypes, new LU_EventTypes(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(XIOT.Data.Objects.LU_EventTypes theLU_EventTypes)
        {
            return ExecuteAction(theLU_EventTypes, theLU_EventTypes, "Select", "Delete", DeleteView);
        }
    }
}
