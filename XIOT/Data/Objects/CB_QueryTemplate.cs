using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace XIOT.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class CB_QueryTemplate
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _templateID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _templateName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _description;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _body;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isActive;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _dateCreated;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _dateModified;
        
        public CB_QueryTemplate()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? TemplateID
        {
            get
            {
                return _templateID;
            }
            set
            {
                _templateID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string TemplateName
        {
            get
            {
                return _templateName;
            }
            set
            {
                _templateName = value;
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
        public string Body
        {
            get
            {
                return _body;
            }
            set
            {
                _body = value;
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
        
        public static List<XIOT.Data.Objects.CB_QueryTemplate> Select(int? templateID, string templateName, string description, bool? isActive, DateTime? dateCreated, DateTime? dateModified)
        {
            return new CB_QueryTemplateFactory().Select(templateID, templateName, description, isActive, dateCreated, dateModified);
        }
        
        public static List<XIOT.Data.Objects.CB_QueryTemplate> Select(XIOT.Data.Objects.CB_QueryTemplate qbe)
        {
            return new CB_QueryTemplateFactory().Select(qbe);
        }
        
        public static List<XIOT.Data.Objects.CB_QueryTemplate> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new CB_QueryTemplateFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<XIOT.Data.Objects.CB_QueryTemplate> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new CB_QueryTemplateFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<XIOT.Data.Objects.CB_QueryTemplate> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new CB_QueryTemplateFactory().Select(filter, sort, CB_QueryTemplateFactory.SelectView, parameters);
        }
        
        public static List<XIOT.Data.Objects.CB_QueryTemplate> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new CB_QueryTemplateFactory().Select(filter, sort, CB_QueryTemplateFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<XIOT.Data.Objects.CB_QueryTemplate> Select(string filter, BusinessObjectParameters parameters)
        {
            return new CB_QueryTemplateFactory().Select(filter, null, CB_QueryTemplateFactory.SelectView, parameters);
        }
        
        public static List<XIOT.Data.Objects.CB_QueryTemplate> Select(string filter, params FieldValue[] parameters)
        {
            return new CB_QueryTemplateFactory().Select(filter, null, CB_QueryTemplateFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static XIOT.Data.Objects.CB_QueryTemplate SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new CB_QueryTemplateFactory().SelectSingle(filter, parameters);
        }
        
        public static XIOT.Data.Objects.CB_QueryTemplate SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new CB_QueryTemplateFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static XIOT.Data.Objects.CB_QueryTemplate SelectSingle(int? templateID)
        {
            return new CB_QueryTemplateFactory().SelectSingle(templateID);
        }
        
        public int Insert()
        {
            return new CB_QueryTemplateFactory().Insert(this);
        }
        
        public int Update()
        {
            return new CB_QueryTemplateFactory().Update(this);
        }
        
        public int Delete()
        {
            return new CB_QueryTemplateFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("TemplateID: {0}", this.TemplateID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class CB_QueryTemplateFactory
    {
        
        public CB_QueryTemplateFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("CB_QueryTemplate");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("CB_QueryTemplate");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("CB_QueryTemplate");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("CB_QueryTemplate");
            }
        }
        
        public static CB_QueryTemplateFactory Create()
        {
            return new CB_QueryTemplateFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? templateID, string templateName, string description, bool? isActive, DateTime? dateCreated, DateTime? dateModified, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (templateID.HasValue)
            	filter.Add(("TemplateID:=" + templateID.Value.ToString()));
            if (!(String.IsNullOrEmpty(templateName)))
            	filter.Add(("TemplateName:*" + templateName));
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
        public List<XIOT.Data.Objects.CB_QueryTemplate> Select(int? templateID, string templateName, string description, bool? isActive, DateTime? dateCreated, DateTime? dateModified, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(templateID, templateName, description, isActive, dateCreated, dateModified, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("CB_QueryTemplate", dataView, request);
            return page.ToList<XIOT.Data.Objects.CB_QueryTemplate>();
        }
        
        public List<XIOT.Data.Objects.CB_QueryTemplate> Select(XIOT.Data.Objects.CB_QueryTemplate qbe)
        {
            return Select(qbe.TemplateID, qbe.TemplateName, qbe.Description, qbe.IsActive, qbe.DateCreated, qbe.DateModified);
        }
        
        public int SelectCount(int? templateID, string templateName, string description, bool? isActive, DateTime? dateCreated, DateTime? dateModified, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(templateID, templateName, description, isActive, dateCreated, dateModified, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("CB_QueryTemplate", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<XIOT.Data.Objects.CB_QueryTemplate> Select(int? templateID, string templateName, string description, bool? isActive, DateTime? dateCreated, DateTime? dateModified)
        {
            return Select(templateID, templateName, description, isActive, dateCreated, dateModified, null, Int32.MaxValue, 0, SelectView);
        }
        
        public XIOT.Data.Objects.CB_QueryTemplate SelectSingle(int? templateID)
        {
            List<XIOT.Data.Objects.CB_QueryTemplate> list = Select(templateID, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<XIOT.Data.Objects.CB_QueryTemplate> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("CB_QueryTemplate", dataView, request);
            return page.ToList<XIOT.Data.Objects.CB_QueryTemplate>();
        }
        
        public List<XIOT.Data.Objects.CB_QueryTemplate> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<XIOT.Data.Objects.CB_QueryTemplate> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public XIOT.Data.Objects.CB_QueryTemplate SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<XIOT.Data.Objects.CB_QueryTemplate> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(XIOT.Data.Objects.CB_QueryTemplate theCB_QueryTemplate, XIOT.Data.Objects.CB_QueryTemplate original_CB_QueryTemplate)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("TemplateID", original_CB_QueryTemplate.TemplateID, theCB_QueryTemplate.TemplateID));
            values.Add(new FieldValue("TemplateName", original_CB_QueryTemplate.TemplateName, theCB_QueryTemplate.TemplateName));
            values.Add(new FieldValue("Description", original_CB_QueryTemplate.Description, theCB_QueryTemplate.Description));
            values.Add(new FieldValue("Body", original_CB_QueryTemplate.Body, theCB_QueryTemplate.Body));
            values.Add(new FieldValue("IsActive", original_CB_QueryTemplate.IsActive, theCB_QueryTemplate.IsActive));
            values.Add(new FieldValue("DateCreated", original_CB_QueryTemplate.DateCreated, theCB_QueryTemplate.DateCreated));
            values.Add(new FieldValue("DateModified", original_CB_QueryTemplate.DateModified, theCB_QueryTemplate.DateModified));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(XIOT.Data.Objects.CB_QueryTemplate theCB_QueryTemplate, XIOT.Data.Objects.CB_QueryTemplate original_CB_QueryTemplate, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "CB_QueryTemplate";
            args.View = dataView;
            args.Values = CreateFieldValues(theCB_QueryTemplate, original_CB_QueryTemplate);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("CB_QueryTemplate", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theCB_QueryTemplate);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(XIOT.Data.Objects.CB_QueryTemplate theCB_QueryTemplate, XIOT.Data.Objects.CB_QueryTemplate original_CB_QueryTemplate)
        {
            return ExecuteAction(theCB_QueryTemplate, original_CB_QueryTemplate, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(XIOT.Data.Objects.CB_QueryTemplate theCB_QueryTemplate)
        {
            return Update(theCB_QueryTemplate, SelectSingle(theCB_QueryTemplate.TemplateID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(XIOT.Data.Objects.CB_QueryTemplate theCB_QueryTemplate)
        {
            return ExecuteAction(theCB_QueryTemplate, new CB_QueryTemplate(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(XIOT.Data.Objects.CB_QueryTemplate theCB_QueryTemplate)
        {
            return ExecuteAction(theCB_QueryTemplate, theCB_QueryTemplate, "Select", "Delete", DeleteView);
        }
    }
}
