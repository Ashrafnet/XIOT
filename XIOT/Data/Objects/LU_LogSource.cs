using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace XIOT.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class LU_LogSource
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _logSourceID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _dateCreated;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _dateModified;
        
        public LU_LogSource()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
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
        
        public static List<XIOT.Data.Objects.LU_LogSource> Select(int? logSourceID, string code, DateTime? dateCreated, DateTime? dateModified)
        {
            return new LU_LogSourceFactory().Select(logSourceID, code, dateCreated, dateModified);
        }
        
        public static List<XIOT.Data.Objects.LU_LogSource> Select(XIOT.Data.Objects.LU_LogSource qbe)
        {
            return new LU_LogSourceFactory().Select(qbe);
        }
        
        public static List<XIOT.Data.Objects.LU_LogSource> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new LU_LogSourceFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<XIOT.Data.Objects.LU_LogSource> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new LU_LogSourceFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<XIOT.Data.Objects.LU_LogSource> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new LU_LogSourceFactory().Select(filter, sort, LU_LogSourceFactory.SelectView, parameters);
        }
        
        public static List<XIOT.Data.Objects.LU_LogSource> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new LU_LogSourceFactory().Select(filter, sort, LU_LogSourceFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<XIOT.Data.Objects.LU_LogSource> Select(string filter, BusinessObjectParameters parameters)
        {
            return new LU_LogSourceFactory().Select(filter, null, LU_LogSourceFactory.SelectView, parameters);
        }
        
        public static List<XIOT.Data.Objects.LU_LogSource> Select(string filter, params FieldValue[] parameters)
        {
            return new LU_LogSourceFactory().Select(filter, null, LU_LogSourceFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static XIOT.Data.Objects.LU_LogSource SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new LU_LogSourceFactory().SelectSingle(filter, parameters);
        }
        
        public static XIOT.Data.Objects.LU_LogSource SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new LU_LogSourceFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static XIOT.Data.Objects.LU_LogSource SelectSingle(int? logSourceID)
        {
            return new LU_LogSourceFactory().SelectSingle(logSourceID);
        }
        
        public int Insert()
        {
            return new LU_LogSourceFactory().Insert(this);
        }
        
        public int Update()
        {
            return new LU_LogSourceFactory().Update(this);
        }
        
        public int Delete()
        {
            return new LU_LogSourceFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("LogSourceID: {0}", this.LogSourceID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class LU_LogSourceFactory
    {
        
        public LU_LogSourceFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("LU_LogSource");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("LU_LogSource");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("LU_LogSource");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("LU_LogSource");
            }
        }
        
        public static LU_LogSourceFactory Create()
        {
            return new LU_LogSourceFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? logSourceID, string code, DateTime? dateCreated, DateTime? dateModified, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (logSourceID.HasValue)
            	filter.Add(("LogSourceID:=" + logSourceID.Value.ToString()));
            if (!(String.IsNullOrEmpty(code)))
            	filter.Add(("Code:*" + code));
            if (dateCreated.HasValue)
            	filter.Add(("DateCreated:=" + dateCreated.Value.ToString()));
            if (dateModified.HasValue)
            	filter.Add(("DateModified:=" + dateModified.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<XIOT.Data.Objects.LU_LogSource> Select(int? logSourceID, string code, DateTime? dateCreated, DateTime? dateModified, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(logSourceID, code, dateCreated, dateModified, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("LU_LogSource", dataView, request);
            return page.ToList<XIOT.Data.Objects.LU_LogSource>();
        }
        
        public List<XIOT.Data.Objects.LU_LogSource> Select(XIOT.Data.Objects.LU_LogSource qbe)
        {
            return Select(qbe.LogSourceID, qbe.Code, qbe.DateCreated, qbe.DateModified);
        }
        
        public int SelectCount(int? logSourceID, string code, DateTime? dateCreated, DateTime? dateModified, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(logSourceID, code, dateCreated, dateModified, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("LU_LogSource", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<XIOT.Data.Objects.LU_LogSource> Select(int? logSourceID, string code, DateTime? dateCreated, DateTime? dateModified)
        {
            return Select(logSourceID, code, dateCreated, dateModified, null, Int32.MaxValue, 0, SelectView);
        }
        
        public XIOT.Data.Objects.LU_LogSource SelectSingle(int? logSourceID)
        {
            string emptyCode = null;
            DateTime? emptyDateCreated = null;
            DateTime? emptyDateModified = null;
            List<XIOT.Data.Objects.LU_LogSource> list = Select(logSourceID, emptyCode, emptyDateCreated, emptyDateModified);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<XIOT.Data.Objects.LU_LogSource> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("LU_LogSource", dataView, request);
            return page.ToList<XIOT.Data.Objects.LU_LogSource>();
        }
        
        public List<XIOT.Data.Objects.LU_LogSource> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<XIOT.Data.Objects.LU_LogSource> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public XIOT.Data.Objects.LU_LogSource SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<XIOT.Data.Objects.LU_LogSource> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(XIOT.Data.Objects.LU_LogSource theLU_LogSource, XIOT.Data.Objects.LU_LogSource original_LU_LogSource)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("LogSourceID", original_LU_LogSource.LogSourceID, theLU_LogSource.LogSourceID));
            values.Add(new FieldValue("Code", original_LU_LogSource.Code, theLU_LogSource.Code));
            values.Add(new FieldValue("DateCreated", original_LU_LogSource.DateCreated, theLU_LogSource.DateCreated));
            values.Add(new FieldValue("DateModified", original_LU_LogSource.DateModified, theLU_LogSource.DateModified));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(XIOT.Data.Objects.LU_LogSource theLU_LogSource, XIOT.Data.Objects.LU_LogSource original_LU_LogSource, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "LU_LogSource";
            args.View = dataView;
            args.Values = CreateFieldValues(theLU_LogSource, original_LU_LogSource);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("LU_LogSource", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theLU_LogSource);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(XIOT.Data.Objects.LU_LogSource theLU_LogSource, XIOT.Data.Objects.LU_LogSource original_LU_LogSource)
        {
            return ExecuteAction(theLU_LogSource, original_LU_LogSource, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(XIOT.Data.Objects.LU_LogSource theLU_LogSource)
        {
            return Update(theLU_LogSource, SelectSingle(theLU_LogSource.LogSourceID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(XIOT.Data.Objects.LU_LogSource theLU_LogSource)
        {
            return ExecuteAction(theLU_LogSource, new LU_LogSource(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(XIOT.Data.Objects.LU_LogSource theLU_LogSource)
        {
            return ExecuteAction(theLU_LogSource, theLU_LogSource, "Select", "Delete", DeleteView);
        }
    }
}
