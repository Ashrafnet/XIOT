using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace XIOT.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class LU_ObjectType
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _objectTypeID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _dateCreated;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _dateModified;
        
        public LU_ObjectType()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
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
        
        public static List<XIOT.Data.Objects.LU_ObjectType> Select(int? objectTypeID, string code, DateTime? dateCreated, DateTime? dateModified)
        {
            return new LU_ObjectTypeFactory().Select(objectTypeID, code, dateCreated, dateModified);
        }
        
        public static List<XIOT.Data.Objects.LU_ObjectType> Select(XIOT.Data.Objects.LU_ObjectType qbe)
        {
            return new LU_ObjectTypeFactory().Select(qbe);
        }
        
        public static List<XIOT.Data.Objects.LU_ObjectType> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new LU_ObjectTypeFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<XIOT.Data.Objects.LU_ObjectType> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new LU_ObjectTypeFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<XIOT.Data.Objects.LU_ObjectType> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new LU_ObjectTypeFactory().Select(filter, sort, LU_ObjectTypeFactory.SelectView, parameters);
        }
        
        public static List<XIOT.Data.Objects.LU_ObjectType> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new LU_ObjectTypeFactory().Select(filter, sort, LU_ObjectTypeFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<XIOT.Data.Objects.LU_ObjectType> Select(string filter, BusinessObjectParameters parameters)
        {
            return new LU_ObjectTypeFactory().Select(filter, null, LU_ObjectTypeFactory.SelectView, parameters);
        }
        
        public static List<XIOT.Data.Objects.LU_ObjectType> Select(string filter, params FieldValue[] parameters)
        {
            return new LU_ObjectTypeFactory().Select(filter, null, LU_ObjectTypeFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static XIOT.Data.Objects.LU_ObjectType SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new LU_ObjectTypeFactory().SelectSingle(filter, parameters);
        }
        
        public static XIOT.Data.Objects.LU_ObjectType SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new LU_ObjectTypeFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static XIOT.Data.Objects.LU_ObjectType SelectSingle(int? objectTypeID)
        {
            return new LU_ObjectTypeFactory().SelectSingle(objectTypeID);
        }
        
        public int Insert()
        {
            return new LU_ObjectTypeFactory().Insert(this);
        }
        
        public int Update()
        {
            return new LU_ObjectTypeFactory().Update(this);
        }
        
        public int Delete()
        {
            return new LU_ObjectTypeFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("ObjectTypeID: {0}", this.ObjectTypeID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class LU_ObjectTypeFactory
    {
        
        public LU_ObjectTypeFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("LU_ObjectType");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("LU_ObjectType");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("LU_ObjectType");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("LU_ObjectType");
            }
        }
        
        public static LU_ObjectTypeFactory Create()
        {
            return new LU_ObjectTypeFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? objectTypeID, string code, DateTime? dateCreated, DateTime? dateModified, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (objectTypeID.HasValue)
            	filter.Add(("ObjectTypeID:=" + objectTypeID.Value.ToString()));
            if (!(String.IsNullOrEmpty(code)))
            	filter.Add(("Code:*" + code));
            if (dateCreated.HasValue)
            	filter.Add(("DateCreated:=" + dateCreated.Value.ToString()));
            if (dateModified.HasValue)
            	filter.Add(("DateModified:=" + dateModified.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<XIOT.Data.Objects.LU_ObjectType> Select(int? objectTypeID, string code, DateTime? dateCreated, DateTime? dateModified, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(objectTypeID, code, dateCreated, dateModified, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("LU_ObjectType", dataView, request);
            return page.ToList<XIOT.Data.Objects.LU_ObjectType>();
        }
        
        public List<XIOT.Data.Objects.LU_ObjectType> Select(XIOT.Data.Objects.LU_ObjectType qbe)
        {
            return Select(qbe.ObjectTypeID, qbe.Code, qbe.DateCreated, qbe.DateModified);
        }
        
        public int SelectCount(int? objectTypeID, string code, DateTime? dateCreated, DateTime? dateModified, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(objectTypeID, code, dateCreated, dateModified, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("LU_ObjectType", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<XIOT.Data.Objects.LU_ObjectType> Select(int? objectTypeID, string code, DateTime? dateCreated, DateTime? dateModified)
        {
            return Select(objectTypeID, code, dateCreated, dateModified, null, Int32.MaxValue, 0, SelectView);
        }
        
        public XIOT.Data.Objects.LU_ObjectType SelectSingle(int? objectTypeID)
        {
            string emptyCode = null;
            DateTime? emptyDateCreated = null;
            DateTime? emptyDateModified = null;
            List<XIOT.Data.Objects.LU_ObjectType> list = Select(objectTypeID, emptyCode, emptyDateCreated, emptyDateModified);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<XIOT.Data.Objects.LU_ObjectType> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("LU_ObjectType", dataView, request);
            return page.ToList<XIOT.Data.Objects.LU_ObjectType>();
        }
        
        public List<XIOT.Data.Objects.LU_ObjectType> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<XIOT.Data.Objects.LU_ObjectType> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public XIOT.Data.Objects.LU_ObjectType SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<XIOT.Data.Objects.LU_ObjectType> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(XIOT.Data.Objects.LU_ObjectType theLU_ObjectType, XIOT.Data.Objects.LU_ObjectType original_LU_ObjectType)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("ObjectTypeID", original_LU_ObjectType.ObjectTypeID, theLU_ObjectType.ObjectTypeID));
            values.Add(new FieldValue("Code", original_LU_ObjectType.Code, theLU_ObjectType.Code));
            values.Add(new FieldValue("DateCreated", original_LU_ObjectType.DateCreated, theLU_ObjectType.DateCreated));
            values.Add(new FieldValue("DateModified", original_LU_ObjectType.DateModified, theLU_ObjectType.DateModified));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(XIOT.Data.Objects.LU_ObjectType theLU_ObjectType, XIOT.Data.Objects.LU_ObjectType original_LU_ObjectType, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "LU_ObjectType";
            args.View = dataView;
            args.Values = CreateFieldValues(theLU_ObjectType, original_LU_ObjectType);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("LU_ObjectType", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theLU_ObjectType);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(XIOT.Data.Objects.LU_ObjectType theLU_ObjectType, XIOT.Data.Objects.LU_ObjectType original_LU_ObjectType)
        {
            return ExecuteAction(theLU_ObjectType, original_LU_ObjectType, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(XIOT.Data.Objects.LU_ObjectType theLU_ObjectType)
        {
            return Update(theLU_ObjectType, SelectSingle(theLU_ObjectType.ObjectTypeID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(XIOT.Data.Objects.LU_ObjectType theLU_ObjectType)
        {
            return ExecuteAction(theLU_ObjectType, new LU_ObjectType(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(XIOT.Data.Objects.LU_ObjectType theLU_ObjectType)
        {
            return ExecuteAction(theLU_ObjectType, theLU_ObjectType, "Select", "Delete", DeleteView);
        }
    }
}
