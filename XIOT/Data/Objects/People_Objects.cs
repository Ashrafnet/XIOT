using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace XIOT.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class People_Objects
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _peopleID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _peopleName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _objectID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _objectObjectName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _objectObjectTypeCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _dateCreated;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _dateModified;
        
        public People_Objects()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PeopleName
        {
            get
            {
                return _peopleName;
            }
            set
            {
                _peopleName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ObjectObjectName
        {
            get
            {
                return _objectObjectName;
            }
            set
            {
                _objectObjectName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ObjectObjectTypeCode
        {
            get
            {
                return _objectObjectTypeCode;
            }
            set
            {
                _objectObjectTypeCode = value;
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
        
        public static List<XIOT.Data.Objects.People_Objects> Select(int? peopleID, string peopleName, int? objectID, string objectObjectName, string objectObjectTypeCode, DateTime? dateCreated, DateTime? dateModified)
        {
            return new People_ObjectsFactory().Select(peopleID, peopleName, objectID, objectObjectName, objectObjectTypeCode, dateCreated, dateModified);
        }
        
        public static List<XIOT.Data.Objects.People_Objects> Select(XIOT.Data.Objects.People_Objects qbe)
        {
            return new People_ObjectsFactory().Select(qbe);
        }
        
        public static List<XIOT.Data.Objects.People_Objects> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new People_ObjectsFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<XIOT.Data.Objects.People_Objects> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new People_ObjectsFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<XIOT.Data.Objects.People_Objects> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new People_ObjectsFactory().Select(filter, sort, People_ObjectsFactory.SelectView, parameters);
        }
        
        public static List<XIOT.Data.Objects.People_Objects> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new People_ObjectsFactory().Select(filter, sort, People_ObjectsFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<XIOT.Data.Objects.People_Objects> Select(string filter, BusinessObjectParameters parameters)
        {
            return new People_ObjectsFactory().Select(filter, null, People_ObjectsFactory.SelectView, parameters);
        }
        
        public static List<XIOT.Data.Objects.People_Objects> Select(string filter, params FieldValue[] parameters)
        {
            return new People_ObjectsFactory().Select(filter, null, People_ObjectsFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static XIOT.Data.Objects.People_Objects SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new People_ObjectsFactory().SelectSingle(filter, parameters);
        }
        
        public static XIOT.Data.Objects.People_Objects SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new People_ObjectsFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static XIOT.Data.Objects.People_Objects SelectSingle(int? peopleID, int? objectID)
        {
            return new People_ObjectsFactory().SelectSingle(peopleID, objectID);
        }
        
        public int Insert()
        {
            return new People_ObjectsFactory().Insert(this);
        }
        
        public int Update()
        {
            return new People_ObjectsFactory().Update(this);
        }
        
        public int Delete()
        {
            return new People_ObjectsFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("PeopleID: {0}; ObjectID: {1}", this.PeopleID, this.ObjectID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class People_ObjectsFactory
    {
        
        public People_ObjectsFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("People_Objects");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("People_Objects");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("People_Objects");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("People_Objects");
            }
        }
        
        public static People_ObjectsFactory Create()
        {
            return new People_ObjectsFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? peopleID, string peopleName, int? objectID, string objectObjectName, string objectObjectTypeCode, DateTime? dateCreated, DateTime? dateModified, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (peopleID.HasValue)
            	filter.Add(("PeopleID:=" + peopleID.Value.ToString()));
            if (!(String.IsNullOrEmpty(peopleName)))
            	filter.Add(("PeopleName:*" + peopleName));
            if (objectID.HasValue)
            	filter.Add(("ObjectID:=" + objectID.Value.ToString()));
            if (!(String.IsNullOrEmpty(objectObjectName)))
            	filter.Add(("ObjectObjectName:*" + objectObjectName));
            if (!(String.IsNullOrEmpty(objectObjectTypeCode)))
            	filter.Add(("ObjectObjectTypeCode:*" + objectObjectTypeCode));
            if (dateCreated.HasValue)
            	filter.Add(("DateCreated:=" + dateCreated.Value.ToString()));
            if (dateModified.HasValue)
            	filter.Add(("DateModified:=" + dateModified.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<XIOT.Data.Objects.People_Objects> Select(int? peopleID, string peopleName, int? objectID, string objectObjectName, string objectObjectTypeCode, DateTime? dateCreated, DateTime? dateModified, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(peopleID, peopleName, objectID, objectObjectName, objectObjectTypeCode, dateCreated, dateModified, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("People_Objects", dataView, request);
            return page.ToList<XIOT.Data.Objects.People_Objects>();
        }
        
        public List<XIOT.Data.Objects.People_Objects> Select(XIOT.Data.Objects.People_Objects qbe)
        {
            return Select(qbe.PeopleID, qbe.PeopleName, qbe.ObjectID, qbe.ObjectObjectName, qbe.ObjectObjectTypeCode, qbe.DateCreated, qbe.DateModified);
        }
        
        public int SelectCount(int? peopleID, string peopleName, int? objectID, string objectObjectName, string objectObjectTypeCode, DateTime? dateCreated, DateTime? dateModified, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(peopleID, peopleName, objectID, objectObjectName, objectObjectTypeCode, dateCreated, dateModified, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("People_Objects", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<XIOT.Data.Objects.People_Objects> Select(int? peopleID, string peopleName, int? objectID, string objectObjectName, string objectObjectTypeCode, DateTime? dateCreated, DateTime? dateModified)
        {
            return Select(peopleID, peopleName, objectID, objectObjectName, objectObjectTypeCode, dateCreated, dateModified, null, Int32.MaxValue, 0, SelectView);
        }
        
        public XIOT.Data.Objects.People_Objects SelectSingle(int? peopleID, int? objectID)
        {
            List<XIOT.Data.Objects.People_Objects> list = Select(peopleID, null, objectID, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<XIOT.Data.Objects.People_Objects> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("People_Objects", dataView, request);
            return page.ToList<XIOT.Data.Objects.People_Objects>();
        }
        
        public List<XIOT.Data.Objects.People_Objects> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<XIOT.Data.Objects.People_Objects> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public XIOT.Data.Objects.People_Objects SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<XIOT.Data.Objects.People_Objects> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(XIOT.Data.Objects.People_Objects thePeople_Objects, XIOT.Data.Objects.People_Objects original_People_Objects)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("PeopleID", original_People_Objects.PeopleID, thePeople_Objects.PeopleID));
            values.Add(new FieldValue("PeopleName", original_People_Objects.PeopleName, thePeople_Objects.PeopleName));
            values.Add(new FieldValue("ObjectID", original_People_Objects.ObjectID, thePeople_Objects.ObjectID));
            values.Add(new FieldValue("ObjectObjectName", original_People_Objects.ObjectObjectName, thePeople_Objects.ObjectObjectName));
            values.Add(new FieldValue("ObjectObjectTypeCode", original_People_Objects.ObjectObjectTypeCode, thePeople_Objects.ObjectObjectTypeCode));
            values.Add(new FieldValue("DateCreated", original_People_Objects.DateCreated, thePeople_Objects.DateCreated));
            values.Add(new FieldValue("DateModified", original_People_Objects.DateModified, thePeople_Objects.DateModified));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(XIOT.Data.Objects.People_Objects thePeople_Objects, XIOT.Data.Objects.People_Objects original_People_Objects, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "People_Objects";
            args.View = dataView;
            args.Values = CreateFieldValues(thePeople_Objects, original_People_Objects);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("People_Objects", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(thePeople_Objects);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(XIOT.Data.Objects.People_Objects thePeople_Objects, XIOT.Data.Objects.People_Objects original_People_Objects)
        {
            return ExecuteAction(thePeople_Objects, original_People_Objects, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(XIOT.Data.Objects.People_Objects thePeople_Objects)
        {
            return Update(thePeople_Objects, SelectSingle(thePeople_Objects.PeopleID, thePeople_Objects.ObjectID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(XIOT.Data.Objects.People_Objects thePeople_Objects)
        {
            return ExecuteAction(thePeople_Objects, new People_Objects(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(XIOT.Data.Objects.People_Objects thePeople_Objects)
        {
            return ExecuteAction(thePeople_Objects, thePeople_Objects, "Select", "Delete", DeleteView);
        }
    }
}
