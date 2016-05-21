using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace XIOT.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class CB_DataElement
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _dataElementID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _eventID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _eventName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _eventEventTypeEventType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _eventLogSourceCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _eventTimeSourceCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _dataElementName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _description;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isActive;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _dateCreated;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _dateModified;
        
        public CB_DataElement()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? DataElementID
        {
            get
            {
                return _dataElementID;
            }
            set
            {
                _dataElementID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string EventName
        {
            get
            {
                return _eventName;
            }
            set
            {
                _eventName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string EventEventTypeEventType
        {
            get
            {
                return _eventEventTypeEventType;
            }
            set
            {
                _eventEventTypeEventType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string EventLogSourceCode
        {
            get
            {
                return _eventLogSourceCode;
            }
            set
            {
                _eventLogSourceCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string EventTimeSourceCode
        {
            get
            {
                return _eventTimeSourceCode;
            }
            set
            {
                _eventTimeSourceCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string DataElementName
        {
            get
            {
                return _dataElementName;
            }
            set
            {
                _dataElementName = value;
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
        
        public static List<XIOT.Data.Objects.CB_DataElement> Select(int? dataElementID, int? eventID, string eventName, string eventEventTypeEventType, string eventLogSourceCode, string eventTimeSourceCode, string dataElementName, string description, bool? isActive, DateTime? dateCreated, DateTime? dateModified)
        {
            return new CB_DataElementFactory().Select(dataElementID, eventID, eventName, eventEventTypeEventType, eventLogSourceCode, eventTimeSourceCode, dataElementName, description, isActive, dateCreated, dateModified);
        }
        
        public static List<XIOT.Data.Objects.CB_DataElement> Select(XIOT.Data.Objects.CB_DataElement qbe)
        {
            return new CB_DataElementFactory().Select(qbe);
        }
        
        public static List<XIOT.Data.Objects.CB_DataElement> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new CB_DataElementFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<XIOT.Data.Objects.CB_DataElement> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new CB_DataElementFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<XIOT.Data.Objects.CB_DataElement> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new CB_DataElementFactory().Select(filter, sort, CB_DataElementFactory.SelectView, parameters);
        }
        
        public static List<XIOT.Data.Objects.CB_DataElement> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new CB_DataElementFactory().Select(filter, sort, CB_DataElementFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<XIOT.Data.Objects.CB_DataElement> Select(string filter, BusinessObjectParameters parameters)
        {
            return new CB_DataElementFactory().Select(filter, null, CB_DataElementFactory.SelectView, parameters);
        }
        
        public static List<XIOT.Data.Objects.CB_DataElement> Select(string filter, params FieldValue[] parameters)
        {
            return new CB_DataElementFactory().Select(filter, null, CB_DataElementFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static XIOT.Data.Objects.CB_DataElement SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new CB_DataElementFactory().SelectSingle(filter, parameters);
        }
        
        public static XIOT.Data.Objects.CB_DataElement SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new CB_DataElementFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static XIOT.Data.Objects.CB_DataElement SelectSingle(int? dataElementID)
        {
            return new CB_DataElementFactory().SelectSingle(dataElementID);
        }
        
        public int Insert()
        {
            return new CB_DataElementFactory().Insert(this);
        }
        
        public int Update()
        {
            return new CB_DataElementFactory().Update(this);
        }
        
        public int Delete()
        {
            return new CB_DataElementFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("DataElementID: {0}", this.DataElementID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class CB_DataElementFactory
    {
        
        public CB_DataElementFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("CB_DataElement");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("CB_DataElement");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("CB_DataElement");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("CB_DataElement");
            }
        }
        
        public static CB_DataElementFactory Create()
        {
            return new CB_DataElementFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? dataElementID, int? eventID, string eventName, string eventEventTypeEventType, string eventLogSourceCode, string eventTimeSourceCode, string dataElementName, string description, bool? isActive, DateTime? dateCreated, DateTime? dateModified, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (dataElementID.HasValue)
            	filter.Add(("DataElementID:=" + dataElementID.Value.ToString()));
            if (eventID.HasValue)
            	filter.Add(("EventID:=" + eventID.Value.ToString()));
            if (!(String.IsNullOrEmpty(eventName)))
            	filter.Add(("EventName:*" + eventName));
            if (!(String.IsNullOrEmpty(eventEventTypeEventType)))
            	filter.Add(("EventEventTypeEventType:*" + eventEventTypeEventType));
            if (!(String.IsNullOrEmpty(eventLogSourceCode)))
            	filter.Add(("EventLogSourceCode:*" + eventLogSourceCode));
            if (!(String.IsNullOrEmpty(eventTimeSourceCode)))
            	filter.Add(("EventTimeSourceCode:*" + eventTimeSourceCode));
            if (!(String.IsNullOrEmpty(dataElementName)))
            	filter.Add(("DataElementName:*" + dataElementName));
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
        public List<XIOT.Data.Objects.CB_DataElement> Select(int? dataElementID, int? eventID, string eventName, string eventEventTypeEventType, string eventLogSourceCode, string eventTimeSourceCode, string dataElementName, string description, bool? isActive, DateTime? dateCreated, DateTime? dateModified, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(dataElementID, eventID, eventName, eventEventTypeEventType, eventLogSourceCode, eventTimeSourceCode, dataElementName, description, isActive, dateCreated, dateModified, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("CB_DataElement", dataView, request);
            return page.ToList<XIOT.Data.Objects.CB_DataElement>();
        }
        
        public List<XIOT.Data.Objects.CB_DataElement> Select(XIOT.Data.Objects.CB_DataElement qbe)
        {
            return Select(qbe.DataElementID, qbe.EventID, qbe.EventName, qbe.EventEventTypeEventType, qbe.EventLogSourceCode, qbe.EventTimeSourceCode, qbe.DataElementName, qbe.Description, qbe.IsActive, qbe.DateCreated, qbe.DateModified);
        }
        
        public int SelectCount(int? dataElementID, int? eventID, string eventName, string eventEventTypeEventType, string eventLogSourceCode, string eventTimeSourceCode, string dataElementName, string description, bool? isActive, DateTime? dateCreated, DateTime? dateModified, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(dataElementID, eventID, eventName, eventEventTypeEventType, eventLogSourceCode, eventTimeSourceCode, dataElementName, description, isActive, dateCreated, dateModified, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("CB_DataElement", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<XIOT.Data.Objects.CB_DataElement> Select(int? dataElementID, int? eventID, string eventName, string eventEventTypeEventType, string eventLogSourceCode, string eventTimeSourceCode, string dataElementName, string description, bool? isActive, DateTime? dateCreated, DateTime? dateModified)
        {
            return Select(dataElementID, eventID, eventName, eventEventTypeEventType, eventLogSourceCode, eventTimeSourceCode, dataElementName, description, isActive, dateCreated, dateModified, null, Int32.MaxValue, 0, SelectView);
        }
        
        public XIOT.Data.Objects.CB_DataElement SelectSingle(int? dataElementID)
        {
            List<XIOT.Data.Objects.CB_DataElement> list = Select(dataElementID, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<XIOT.Data.Objects.CB_DataElement> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("CB_DataElement", dataView, request);
            return page.ToList<XIOT.Data.Objects.CB_DataElement>();
        }
        
        public List<XIOT.Data.Objects.CB_DataElement> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<XIOT.Data.Objects.CB_DataElement> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public XIOT.Data.Objects.CB_DataElement SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<XIOT.Data.Objects.CB_DataElement> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(XIOT.Data.Objects.CB_DataElement theCB_DataElement, XIOT.Data.Objects.CB_DataElement original_CB_DataElement)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("DataElementID", original_CB_DataElement.DataElementID, theCB_DataElement.DataElementID));
            values.Add(new FieldValue("EventID", original_CB_DataElement.EventID, theCB_DataElement.EventID));
            values.Add(new FieldValue("EventName", original_CB_DataElement.EventName, theCB_DataElement.EventName));
            values.Add(new FieldValue("EventEventTypeEventType", original_CB_DataElement.EventEventTypeEventType, theCB_DataElement.EventEventTypeEventType));
            values.Add(new FieldValue("EventLogSourceCode", original_CB_DataElement.EventLogSourceCode, theCB_DataElement.EventLogSourceCode));
            values.Add(new FieldValue("EventTimeSourceCode", original_CB_DataElement.EventTimeSourceCode, theCB_DataElement.EventTimeSourceCode));
            values.Add(new FieldValue("DataElementName", original_CB_DataElement.DataElementName, theCB_DataElement.DataElementName));
            values.Add(new FieldValue("Description", original_CB_DataElement.Description, theCB_DataElement.Description));
            values.Add(new FieldValue("IsActive", original_CB_DataElement.IsActive, theCB_DataElement.IsActive));
            values.Add(new FieldValue("DateCreated", original_CB_DataElement.DateCreated, theCB_DataElement.DateCreated));
            values.Add(new FieldValue("DateModified", original_CB_DataElement.DateModified, theCB_DataElement.DateModified));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(XIOT.Data.Objects.CB_DataElement theCB_DataElement, XIOT.Data.Objects.CB_DataElement original_CB_DataElement, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "CB_DataElement";
            args.View = dataView;
            args.Values = CreateFieldValues(theCB_DataElement, original_CB_DataElement);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("CB_DataElement", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theCB_DataElement);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(XIOT.Data.Objects.CB_DataElement theCB_DataElement, XIOT.Data.Objects.CB_DataElement original_CB_DataElement)
        {
            return ExecuteAction(theCB_DataElement, original_CB_DataElement, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(XIOT.Data.Objects.CB_DataElement theCB_DataElement)
        {
            return Update(theCB_DataElement, SelectSingle(theCB_DataElement.DataElementID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(XIOT.Data.Objects.CB_DataElement theCB_DataElement)
        {
            return ExecuteAction(theCB_DataElement, new CB_DataElement(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(XIOT.Data.Objects.CB_DataElement theCB_DataElement)
        {
            return ExecuteAction(theCB_DataElement, theCB_DataElement, "Select", "Delete", DeleteView);
        }
    }
}
