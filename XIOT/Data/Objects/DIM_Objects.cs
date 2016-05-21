using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace XIOT.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class DIM_Objects
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _objectID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _objectName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _objectDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _objectTypeID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _objectTypeCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private double? _uTCOffset;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isActive;
        
        public DIM_Objects()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? ObjectID
        {
            get
            {
                return _objectID;
            }
            set
            {
                _objectID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string ObjectName
        {
            get
            {
                return _objectName;
            }
            set
            {
                _objectName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ObjectDescription
        {
            get
            {
                return _objectDescription;
            }
            set
            {
                _objectDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public int? ObjectTypeID
        {
            get
            {
                return _objectTypeID;
            }
            set
            {
                _objectTypeID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ObjectTypeCode
        {
            get
            {
                return _objectTypeCode;
            }
            set
            {
                _objectTypeCode = value;
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
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
        
        public static List<XIOT.Data.Objects.DIM_Objects> Select(int? objectID, string objectName, string objectDescription, int? objectTypeID, string objectTypeCode, double? uTCOffset, bool? isActive)
        {
            return new DIM_ObjectsFactory().Select(objectID, objectName, objectDescription, objectTypeID, objectTypeCode, uTCOffset, isActive);
        }
        
        public static List<XIOT.Data.Objects.DIM_Objects> Select(XIOT.Data.Objects.DIM_Objects qbe)
        {
            return new DIM_ObjectsFactory().Select(qbe);
        }
        
        public static List<XIOT.Data.Objects.DIM_Objects> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new DIM_ObjectsFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<XIOT.Data.Objects.DIM_Objects> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new DIM_ObjectsFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<XIOT.Data.Objects.DIM_Objects> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new DIM_ObjectsFactory().Select(filter, sort, DIM_ObjectsFactory.SelectView, parameters);
        }
        
        public static List<XIOT.Data.Objects.DIM_Objects> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new DIM_ObjectsFactory().Select(filter, sort, DIM_ObjectsFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<XIOT.Data.Objects.DIM_Objects> Select(string filter, BusinessObjectParameters parameters)
        {
            return new DIM_ObjectsFactory().Select(filter, null, DIM_ObjectsFactory.SelectView, parameters);
        }
        
        public static List<XIOT.Data.Objects.DIM_Objects> Select(string filter, params FieldValue[] parameters)
        {
            return new DIM_ObjectsFactory().Select(filter, null, DIM_ObjectsFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static XIOT.Data.Objects.DIM_Objects SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new DIM_ObjectsFactory().SelectSingle(filter, parameters);
        }
        
        public static XIOT.Data.Objects.DIM_Objects SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new DIM_ObjectsFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static XIOT.Data.Objects.DIM_Objects SelectSingle(int? objectID)
        {
            return new DIM_ObjectsFactory().SelectSingle(objectID);
        }
        
        public int Insert()
        {
            return new DIM_ObjectsFactory().Insert(this);
        }
        
        public int Update()
        {
            return new DIM_ObjectsFactory().Update(this);
        }
        
        public int Delete()
        {
            return new DIM_ObjectsFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("ObjectID: {0}", this.ObjectID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class DIM_ObjectsFactory
    {
        
        public DIM_ObjectsFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("DIM_Objects");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("DIM_Objects");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("DIM_Objects");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("DIM_Objects");
            }
        }
        
        public static DIM_ObjectsFactory Create()
        {
            return new DIM_ObjectsFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? objectID, string objectName, string objectDescription, int? objectTypeID, string objectTypeCode, double? uTCOffset, bool? isActive, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (objectID.HasValue)
            	filter.Add(("ObjectID:=" + objectID.Value.ToString()));
            if (!(String.IsNullOrEmpty(objectName)))
            	filter.Add(("ObjectName:*" + objectName));
            if (!(String.IsNullOrEmpty(objectDescription)))
            	filter.Add(("ObjectDescription:*" + objectDescription));
            if (objectTypeID.HasValue)
            	filter.Add(("ObjectTypeID:=" + objectTypeID.Value.ToString()));
            if (!(String.IsNullOrEmpty(objectTypeCode)))
            	filter.Add(("ObjectTypeCode:*" + objectTypeCode));
            if (uTCOffset.HasValue)
            	filter.Add(("UTCOffset:=" + uTCOffset.Value.ToString()));
            if (isActive.HasValue)
            	filter.Add(("IsActive:=" + isActive.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<XIOT.Data.Objects.DIM_Objects> Select(int? objectID, string objectName, string objectDescription, int? objectTypeID, string objectTypeCode, double? uTCOffset, bool? isActive, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(objectID, objectName, objectDescription, objectTypeID, objectTypeCode, uTCOffset, isActive, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("DIM_Objects", dataView, request);
            return page.ToList<XIOT.Data.Objects.DIM_Objects>();
        }
        
        public List<XIOT.Data.Objects.DIM_Objects> Select(XIOT.Data.Objects.DIM_Objects qbe)
        {
            return Select(qbe.ObjectID, qbe.ObjectName, qbe.ObjectDescription, qbe.ObjectTypeID, qbe.ObjectTypeCode, qbe.UTCOffset, qbe.IsActive);
        }
        
        public int SelectCount(int? objectID, string objectName, string objectDescription, int? objectTypeID, string objectTypeCode, double? uTCOffset, bool? isActive, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(objectID, objectName, objectDescription, objectTypeID, objectTypeCode, uTCOffset, isActive, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("DIM_Objects", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<XIOT.Data.Objects.DIM_Objects> Select(int? objectID, string objectName, string objectDescription, int? objectTypeID, string objectTypeCode, double? uTCOffset, bool? isActive)
        {
            return Select(objectID, objectName, objectDescription, objectTypeID, objectTypeCode, uTCOffset, isActive, null, Int32.MaxValue, 0, SelectView);
        }
        
        public XIOT.Data.Objects.DIM_Objects SelectSingle(int? objectID)
        {
            List<XIOT.Data.Objects.DIM_Objects> list = Select(objectID, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<XIOT.Data.Objects.DIM_Objects> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("DIM_Objects", dataView, request);
            return page.ToList<XIOT.Data.Objects.DIM_Objects>();
        }
        
        public List<XIOT.Data.Objects.DIM_Objects> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<XIOT.Data.Objects.DIM_Objects> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public XIOT.Data.Objects.DIM_Objects SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<XIOT.Data.Objects.DIM_Objects> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(XIOT.Data.Objects.DIM_Objects theDIM_Objects, XIOT.Data.Objects.DIM_Objects original_DIM_Objects)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("ObjectID", original_DIM_Objects.ObjectID, theDIM_Objects.ObjectID));
            values.Add(new FieldValue("ObjectName", original_DIM_Objects.ObjectName, theDIM_Objects.ObjectName));
            values.Add(new FieldValue("ObjectDescription", original_DIM_Objects.ObjectDescription, theDIM_Objects.ObjectDescription));
            values.Add(new FieldValue("ObjectTypeID", original_DIM_Objects.ObjectTypeID, theDIM_Objects.ObjectTypeID));
            values.Add(new FieldValue("ObjectTypeCode", original_DIM_Objects.ObjectTypeCode, theDIM_Objects.ObjectTypeCode));
            values.Add(new FieldValue("UTCOffset", original_DIM_Objects.UTCOffset, theDIM_Objects.UTCOffset));
            values.Add(new FieldValue("IsActive", original_DIM_Objects.IsActive, theDIM_Objects.IsActive));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(XIOT.Data.Objects.DIM_Objects theDIM_Objects, XIOT.Data.Objects.DIM_Objects original_DIM_Objects, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "DIM_Objects";
            args.View = dataView;
            args.Values = CreateFieldValues(theDIM_Objects, original_DIM_Objects);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("DIM_Objects", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theDIM_Objects);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(XIOT.Data.Objects.DIM_Objects theDIM_Objects, XIOT.Data.Objects.DIM_Objects original_DIM_Objects)
        {
            return ExecuteAction(theDIM_Objects, original_DIM_Objects, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(XIOT.Data.Objects.DIM_Objects theDIM_Objects)
        {
            return Update(theDIM_Objects, SelectSingle(theDIM_Objects.ObjectID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(XIOT.Data.Objects.DIM_Objects theDIM_Objects)
        {
            return ExecuteAction(theDIM_Objects, new DIM_Objects(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(XIOT.Data.Objects.DIM_Objects theDIM_Objects)
        {
            return ExecuteAction(theDIM_Objects, theDIM_Objects, "Select", "Delete", DeleteView);
        }
    }
}
