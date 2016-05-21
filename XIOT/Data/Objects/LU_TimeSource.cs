using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace XIOT.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class LU_TimeSource
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _timeSourceID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _dateCreated;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _dateModified;
        
        public LU_TimeSource()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
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
        
        public static List<XIOT.Data.Objects.LU_TimeSource> Select(int? timeSourceID, string code, DateTime? dateCreated, DateTime? dateModified)
        {
            return new LU_TimeSourceFactory().Select(timeSourceID, code, dateCreated, dateModified);
        }
        
        public static List<XIOT.Data.Objects.LU_TimeSource> Select(XIOT.Data.Objects.LU_TimeSource qbe)
        {
            return new LU_TimeSourceFactory().Select(qbe);
        }
        
        public static List<XIOT.Data.Objects.LU_TimeSource> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new LU_TimeSourceFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<XIOT.Data.Objects.LU_TimeSource> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new LU_TimeSourceFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<XIOT.Data.Objects.LU_TimeSource> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new LU_TimeSourceFactory().Select(filter, sort, LU_TimeSourceFactory.SelectView, parameters);
        }
        
        public static List<XIOT.Data.Objects.LU_TimeSource> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new LU_TimeSourceFactory().Select(filter, sort, LU_TimeSourceFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<XIOT.Data.Objects.LU_TimeSource> Select(string filter, BusinessObjectParameters parameters)
        {
            return new LU_TimeSourceFactory().Select(filter, null, LU_TimeSourceFactory.SelectView, parameters);
        }
        
        public static List<XIOT.Data.Objects.LU_TimeSource> Select(string filter, params FieldValue[] parameters)
        {
            return new LU_TimeSourceFactory().Select(filter, null, LU_TimeSourceFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static XIOT.Data.Objects.LU_TimeSource SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new LU_TimeSourceFactory().SelectSingle(filter, parameters);
        }
        
        public static XIOT.Data.Objects.LU_TimeSource SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new LU_TimeSourceFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static XIOT.Data.Objects.LU_TimeSource SelectSingle(int? timeSourceID)
        {
            return new LU_TimeSourceFactory().SelectSingle(timeSourceID);
        }
        
        public int Insert()
        {
            return new LU_TimeSourceFactory().Insert(this);
        }
        
        public int Update()
        {
            return new LU_TimeSourceFactory().Update(this);
        }
        
        public int Delete()
        {
            return new LU_TimeSourceFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("TimeSourceID: {0}", this.TimeSourceID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class LU_TimeSourceFactory
    {
        
        public LU_TimeSourceFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("LU_TimeSource");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("LU_TimeSource");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("LU_TimeSource");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("LU_TimeSource");
            }
        }
        
        public static LU_TimeSourceFactory Create()
        {
            return new LU_TimeSourceFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? timeSourceID, string code, DateTime? dateCreated, DateTime? dateModified, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (timeSourceID.HasValue)
            	filter.Add(("TimeSourceID:=" + timeSourceID.Value.ToString()));
            if (!(String.IsNullOrEmpty(code)))
            	filter.Add(("Code:*" + code));
            if (dateCreated.HasValue)
            	filter.Add(("DateCreated:=" + dateCreated.Value.ToString()));
            if (dateModified.HasValue)
            	filter.Add(("DateModified:=" + dateModified.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<XIOT.Data.Objects.LU_TimeSource> Select(int? timeSourceID, string code, DateTime? dateCreated, DateTime? dateModified, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(timeSourceID, code, dateCreated, dateModified, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("LU_TimeSource", dataView, request);
            return page.ToList<XIOT.Data.Objects.LU_TimeSource>();
        }
        
        public List<XIOT.Data.Objects.LU_TimeSource> Select(XIOT.Data.Objects.LU_TimeSource qbe)
        {
            return Select(qbe.TimeSourceID, qbe.Code, qbe.DateCreated, qbe.DateModified);
        }
        
        public int SelectCount(int? timeSourceID, string code, DateTime? dateCreated, DateTime? dateModified, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(timeSourceID, code, dateCreated, dateModified, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("LU_TimeSource", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<XIOT.Data.Objects.LU_TimeSource> Select(int? timeSourceID, string code, DateTime? dateCreated, DateTime? dateModified)
        {
            return Select(timeSourceID, code, dateCreated, dateModified, null, Int32.MaxValue, 0, SelectView);
        }
        
        public XIOT.Data.Objects.LU_TimeSource SelectSingle(int? timeSourceID)
        {
            string emptyCode = null;
            DateTime? emptyDateCreated = null;
            DateTime? emptyDateModified = null;
            List<XIOT.Data.Objects.LU_TimeSource> list = Select(timeSourceID, emptyCode, emptyDateCreated, emptyDateModified);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<XIOT.Data.Objects.LU_TimeSource> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("LU_TimeSource", dataView, request);
            return page.ToList<XIOT.Data.Objects.LU_TimeSource>();
        }
        
        public List<XIOT.Data.Objects.LU_TimeSource> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<XIOT.Data.Objects.LU_TimeSource> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public XIOT.Data.Objects.LU_TimeSource SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<XIOT.Data.Objects.LU_TimeSource> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(XIOT.Data.Objects.LU_TimeSource theLU_TimeSource, XIOT.Data.Objects.LU_TimeSource original_LU_TimeSource)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("TimeSourceID", original_LU_TimeSource.TimeSourceID, theLU_TimeSource.TimeSourceID));
            values.Add(new FieldValue("Code", original_LU_TimeSource.Code, theLU_TimeSource.Code));
            values.Add(new FieldValue("DateCreated", original_LU_TimeSource.DateCreated, theLU_TimeSource.DateCreated));
            values.Add(new FieldValue("DateModified", original_LU_TimeSource.DateModified, theLU_TimeSource.DateModified));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(XIOT.Data.Objects.LU_TimeSource theLU_TimeSource, XIOT.Data.Objects.LU_TimeSource original_LU_TimeSource, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "LU_TimeSource";
            args.View = dataView;
            args.Values = CreateFieldValues(theLU_TimeSource, original_LU_TimeSource);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("LU_TimeSource", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theLU_TimeSource);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(XIOT.Data.Objects.LU_TimeSource theLU_TimeSource, XIOT.Data.Objects.LU_TimeSource original_LU_TimeSource)
        {
            return ExecuteAction(theLU_TimeSource, original_LU_TimeSource, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(XIOT.Data.Objects.LU_TimeSource theLU_TimeSource)
        {
            return Update(theLU_TimeSource, SelectSingle(theLU_TimeSource.TimeSourceID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(XIOT.Data.Objects.LU_TimeSource theLU_TimeSource)
        {
            return ExecuteAction(theLU_TimeSource, new LU_TimeSource(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(XIOT.Data.Objects.LU_TimeSource theLU_TimeSource)
        {
            return ExecuteAction(theLU_TimeSource, theLU_TimeSource, "Select", "Delete", DeleteView);
        }
    }
}
