using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace XIOT.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class Dim_EventAttribute
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _eventID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _attributeID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _code;
        
        public Dim_EventAttribute()
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AttributeID
        {
            get
            {
                return _attributeID;
            }
            set
            {
                _attributeID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
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
        
        public static List<XIOT.Data.Objects.Dim_EventAttribute> Select(int? eventID, string attributeID, string code)
        {
            return new Dim_EventAttributeFactory().Select(eventID, attributeID, code);
        }
        
        public static List<XIOT.Data.Objects.Dim_EventAttribute> Select(XIOT.Data.Objects.Dim_EventAttribute qbe)
        {
            return new Dim_EventAttributeFactory().Select(qbe);
        }
        
        public static List<XIOT.Data.Objects.Dim_EventAttribute> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new Dim_EventAttributeFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<XIOT.Data.Objects.Dim_EventAttribute> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new Dim_EventAttributeFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<XIOT.Data.Objects.Dim_EventAttribute> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new Dim_EventAttributeFactory().Select(filter, sort, Dim_EventAttributeFactory.SelectView, parameters);
        }
        
        public static List<XIOT.Data.Objects.Dim_EventAttribute> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new Dim_EventAttributeFactory().Select(filter, sort, Dim_EventAttributeFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<XIOT.Data.Objects.Dim_EventAttribute> Select(string filter, BusinessObjectParameters parameters)
        {
            return new Dim_EventAttributeFactory().Select(filter, null, Dim_EventAttributeFactory.SelectView, parameters);
        }
        
        public static List<XIOT.Data.Objects.Dim_EventAttribute> Select(string filter, params FieldValue[] parameters)
        {
            return new Dim_EventAttributeFactory().Select(filter, null, Dim_EventAttributeFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static XIOT.Data.Objects.Dim_EventAttribute SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new Dim_EventAttributeFactory().SelectSingle(filter, parameters);
        }
        
        public static XIOT.Data.Objects.Dim_EventAttribute SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new Dim_EventAttributeFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static XIOT.Data.Objects.Dim_EventAttribute SelectSingle(int? eventID)
        {
            return new Dim_EventAttributeFactory().SelectSingle(eventID);
        }
        
        public int Insert()
        {
            return new Dim_EventAttributeFactory().Insert(this);
        }
        
        public int Update()
        {
            return new Dim_EventAttributeFactory().Update(this);
        }
        
        public int Delete()
        {
            return new Dim_EventAttributeFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("EventID: {0}", this.EventID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class Dim_EventAttributeFactory
    {
        
        public Dim_EventAttributeFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Dim_EventAttribute");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Dim_EventAttribute");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Dim_EventAttribute");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Dim_EventAttribute");
            }
        }
        
        public static Dim_EventAttributeFactory Create()
        {
            return new Dim_EventAttributeFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? eventID, string attributeID, string code, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (eventID.HasValue)
            	filter.Add(("EventID:=" + eventID.Value.ToString()));
            if (!(String.IsNullOrEmpty(attributeID)))
            	filter.Add(("AttributeID:*" + attributeID));
            if (!(String.IsNullOrEmpty(code)))
            	filter.Add(("Code:*" + code));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<XIOT.Data.Objects.Dim_EventAttribute> Select(int? eventID, string attributeID, string code, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(eventID, attributeID, code, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Dim_EventAttribute", dataView, request);
            return page.ToList<XIOT.Data.Objects.Dim_EventAttribute>();
        }
        
        public List<XIOT.Data.Objects.Dim_EventAttribute> Select(XIOT.Data.Objects.Dim_EventAttribute qbe)
        {
            return Select(qbe.EventID, qbe.AttributeID, qbe.Code);
        }
        
        public int SelectCount(int? eventID, string attributeID, string code, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(eventID, attributeID, code, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Dim_EventAttribute", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<XIOT.Data.Objects.Dim_EventAttribute> Select(int? eventID, string attributeID, string code)
        {
            return Select(eventID, attributeID, code, null, Int32.MaxValue, 0, SelectView);
        }
        
        public XIOT.Data.Objects.Dim_EventAttribute SelectSingle(int? eventID)
        {
            string emptyAttributeID = null;
            string emptyCode = null;
            List<XIOT.Data.Objects.Dim_EventAttribute> list = Select(eventID, emptyAttributeID, emptyCode);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<XIOT.Data.Objects.Dim_EventAttribute> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("Dim_EventAttribute", dataView, request);
            return page.ToList<XIOT.Data.Objects.Dim_EventAttribute>();
        }
        
        public List<XIOT.Data.Objects.Dim_EventAttribute> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<XIOT.Data.Objects.Dim_EventAttribute> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public XIOT.Data.Objects.Dim_EventAttribute SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<XIOT.Data.Objects.Dim_EventAttribute> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(XIOT.Data.Objects.Dim_EventAttribute theDim_EventAttribute, XIOT.Data.Objects.Dim_EventAttribute original_Dim_EventAttribute)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("EventID", original_Dim_EventAttribute.EventID, theDim_EventAttribute.EventID));
            values.Add(new FieldValue("AttributeID", original_Dim_EventAttribute.AttributeID, theDim_EventAttribute.AttributeID));
            values.Add(new FieldValue("Code", original_Dim_EventAttribute.Code, theDim_EventAttribute.Code));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(XIOT.Data.Objects.Dim_EventAttribute theDim_EventAttribute, XIOT.Data.Objects.Dim_EventAttribute original_Dim_EventAttribute, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "Dim_EventAttribute";
            args.View = dataView;
            args.Values = CreateFieldValues(theDim_EventAttribute, original_Dim_EventAttribute);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("Dim_EventAttribute", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theDim_EventAttribute);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(XIOT.Data.Objects.Dim_EventAttribute theDim_EventAttribute, XIOT.Data.Objects.Dim_EventAttribute original_Dim_EventAttribute)
        {
            return ExecuteAction(theDim_EventAttribute, original_Dim_EventAttribute, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(XIOT.Data.Objects.Dim_EventAttribute theDim_EventAttribute)
        {
            return Update(theDim_EventAttribute, SelectSingle(theDim_EventAttribute.EventID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(XIOT.Data.Objects.Dim_EventAttribute theDim_EventAttribute)
        {
            return ExecuteAction(theDim_EventAttribute, new Dim_EventAttribute(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(XIOT.Data.Objects.Dim_EventAttribute theDim_EventAttribute)
        {
            return ExecuteAction(theDim_EventAttribute, theDim_EventAttribute, "Select", "Delete", DeleteView);
        }
    }
}
