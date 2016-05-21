using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace XIOT.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class CB_PassFailCriteria
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _testExpressionID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _testExpressionJoinCriteria;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _testExpressionLeftDataElementDataElementName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _testExpressionLeftDataElementEventName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _testExpressionRightDataElementDataElementName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _testExpressionRightDataElementEventName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _testExpressionOperatorCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _testExpressionTemplateTemplateName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _testExpressionTestTestName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _testExpressionAtrributeEventAttributeID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _testExpressionLeftEventName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _testExpressionLeftEventEventTypeEventType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _testExpressionLeftEventLogSourceCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _testExpressionLeftEventTimeSourceCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _testExpressionRightEventName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _testExpressionRightEventEventTypeEventType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _testExpressionRightEventLogSourceCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _testExpressionRightEventTimeSourceCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _testCriteriaID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _testCriteriaCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isPass;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _dateCreated;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _dateModified;
        
        public CB_PassFailCriteria()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public int? TestExpressionID
        {
            get
            {
                return _testExpressionID;
            }
            set
            {
                _testExpressionID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string TestExpressionJoinCriteria
        {
            get
            {
                return _testExpressionJoinCriteria;
            }
            set
            {
                _testExpressionJoinCriteria = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string TestExpressionLeftDataElementDataElementName
        {
            get
            {
                return _testExpressionLeftDataElementDataElementName;
            }
            set
            {
                _testExpressionLeftDataElementDataElementName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string TestExpressionLeftDataElementEventName
        {
            get
            {
                return _testExpressionLeftDataElementEventName;
            }
            set
            {
                _testExpressionLeftDataElementEventName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string TestExpressionRightDataElementDataElementName
        {
            get
            {
                return _testExpressionRightDataElementDataElementName;
            }
            set
            {
                _testExpressionRightDataElementDataElementName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string TestExpressionRightDataElementEventName
        {
            get
            {
                return _testExpressionRightDataElementEventName;
            }
            set
            {
                _testExpressionRightDataElementEventName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string TestExpressionOperatorCode
        {
            get
            {
                return _testExpressionOperatorCode;
            }
            set
            {
                _testExpressionOperatorCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string TestExpressionTemplateTemplateName
        {
            get
            {
                return _testExpressionTemplateTemplateName;
            }
            set
            {
                _testExpressionTemplateTemplateName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string TestExpressionTestTestName
        {
            get
            {
                return _testExpressionTestTestName;
            }
            set
            {
                _testExpressionTestTestName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string TestExpressionAtrributeEventAttributeID
        {
            get
            {
                return _testExpressionAtrributeEventAttributeID;
            }
            set
            {
                _testExpressionAtrributeEventAttributeID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string TestExpressionLeftEventName
        {
            get
            {
                return _testExpressionLeftEventName;
            }
            set
            {
                _testExpressionLeftEventName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string TestExpressionLeftEventEventTypeEventType
        {
            get
            {
                return _testExpressionLeftEventEventTypeEventType;
            }
            set
            {
                _testExpressionLeftEventEventTypeEventType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string TestExpressionLeftEventLogSourceCode
        {
            get
            {
                return _testExpressionLeftEventLogSourceCode;
            }
            set
            {
                _testExpressionLeftEventLogSourceCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string TestExpressionLeftEventTimeSourceCode
        {
            get
            {
                return _testExpressionLeftEventTimeSourceCode;
            }
            set
            {
                _testExpressionLeftEventTimeSourceCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string TestExpressionRightEventName
        {
            get
            {
                return _testExpressionRightEventName;
            }
            set
            {
                _testExpressionRightEventName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string TestExpressionRightEventEventTypeEventType
        {
            get
            {
                return _testExpressionRightEventEventTypeEventType;
            }
            set
            {
                _testExpressionRightEventEventTypeEventType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string TestExpressionRightEventLogSourceCode
        {
            get
            {
                return _testExpressionRightEventLogSourceCode;
            }
            set
            {
                _testExpressionRightEventLogSourceCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string TestExpressionRightEventTimeSourceCode
        {
            get
            {
                return _testExpressionRightEventTimeSourceCode;
            }
            set
            {
                _testExpressionRightEventTimeSourceCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public int? TestCriteriaID
        {
            get
            {
                return _testCriteriaID;
            }
            set
            {
                _testCriteriaID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string TestCriteriaCode
        {
            get
            {
                return _testCriteriaCode;
            }
            set
            {
                _testCriteriaCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? IsPass
        {
            get
            {
                return _isPass;
            }
            set
            {
                _isPass = value;
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
        
        public static List<XIOT.Data.Objects.CB_PassFailCriteria> Select(
                    int? testExpressionID, 
                    string testExpressionJoinCriteria, 
                    string testExpressionLeftDataElementDataElementName, 
                    string testExpressionLeftDataElementEventName, 
                    string testExpressionRightDataElementDataElementName, 
                    string testExpressionRightDataElementEventName, 
                    string testExpressionOperatorCode, 
                    string testExpressionTemplateTemplateName, 
                    string testExpressionTestTestName, 
                    string testExpressionAtrributeEventAttributeID, 
                    string testExpressionLeftEventName, 
                    string testExpressionLeftEventEventTypeEventType, 
                    string testExpressionLeftEventLogSourceCode, 
                    string testExpressionLeftEventTimeSourceCode, 
                    string testExpressionRightEventName, 
                    string testExpressionRightEventEventTypeEventType, 
                    string testExpressionRightEventLogSourceCode, 
                    string testExpressionRightEventTimeSourceCode, 
                    int? testCriteriaID, 
                    string testCriteriaCode, 
                    bool? isPass, 
                    DateTime? dateCreated, 
                    DateTime? dateModified)
        {
            return new CB_PassFailCriteriaFactory().Select(testExpressionID, testExpressionJoinCriteria, testExpressionLeftDataElementDataElementName, testExpressionLeftDataElementEventName, testExpressionRightDataElementDataElementName, testExpressionRightDataElementEventName, testExpressionOperatorCode, testExpressionTemplateTemplateName, testExpressionTestTestName, testExpressionAtrributeEventAttributeID, testExpressionLeftEventName, testExpressionLeftEventEventTypeEventType, testExpressionLeftEventLogSourceCode, testExpressionLeftEventTimeSourceCode, testExpressionRightEventName, testExpressionRightEventEventTypeEventType, testExpressionRightEventLogSourceCode, testExpressionRightEventTimeSourceCode, testCriteriaID, testCriteriaCode, isPass, dateCreated, dateModified);
        }
        
        public static List<XIOT.Data.Objects.CB_PassFailCriteria> Select(XIOT.Data.Objects.CB_PassFailCriteria qbe)
        {
            return new CB_PassFailCriteriaFactory().Select(qbe);
        }
        
        public static List<XIOT.Data.Objects.CB_PassFailCriteria> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new CB_PassFailCriteriaFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<XIOT.Data.Objects.CB_PassFailCriteria> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new CB_PassFailCriteriaFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<XIOT.Data.Objects.CB_PassFailCriteria> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new CB_PassFailCriteriaFactory().Select(filter, sort, CB_PassFailCriteriaFactory.SelectView, parameters);
        }
        
        public static List<XIOT.Data.Objects.CB_PassFailCriteria> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new CB_PassFailCriteriaFactory().Select(filter, sort, CB_PassFailCriteriaFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<XIOT.Data.Objects.CB_PassFailCriteria> Select(string filter, BusinessObjectParameters parameters)
        {
            return new CB_PassFailCriteriaFactory().Select(filter, null, CB_PassFailCriteriaFactory.SelectView, parameters);
        }
        
        public static List<XIOT.Data.Objects.CB_PassFailCriteria> Select(string filter, params FieldValue[] parameters)
        {
            return new CB_PassFailCriteriaFactory().Select(filter, null, CB_PassFailCriteriaFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static XIOT.Data.Objects.CB_PassFailCriteria SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new CB_PassFailCriteriaFactory().SelectSingle(filter, parameters);
        }
        
        public static XIOT.Data.Objects.CB_PassFailCriteria SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new CB_PassFailCriteriaFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static XIOT.Data.Objects.CB_PassFailCriteria SelectSingle(int? testExpressionID, int? testCriteriaID)
        {
            return new CB_PassFailCriteriaFactory().SelectSingle(testExpressionID, testCriteriaID);
        }
        
        public int Insert()
        {
            return new CB_PassFailCriteriaFactory().Insert(this);
        }
        
        public int Update()
        {
            return new CB_PassFailCriteriaFactory().Update(this);
        }
        
        public int Delete()
        {
            return new CB_PassFailCriteriaFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("TestExpressionID: {0}; TestCriteriaID: {1}", this.TestExpressionID, this.TestCriteriaID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class CB_PassFailCriteriaFactory
    {
        
        public CB_PassFailCriteriaFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("CB_PassFailCriteria");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("CB_PassFailCriteria");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("CB_PassFailCriteria");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("CB_PassFailCriteria");
            }
        }
        
        public static CB_PassFailCriteriaFactory Create()
        {
            return new CB_PassFailCriteriaFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    int? testExpressionID, 
                    string testExpressionJoinCriteria, 
                    string testExpressionLeftDataElementDataElementName, 
                    string testExpressionLeftDataElementEventName, 
                    string testExpressionRightDataElementDataElementName, 
                    string testExpressionRightDataElementEventName, 
                    string testExpressionOperatorCode, 
                    string testExpressionTemplateTemplateName, 
                    string testExpressionTestTestName, 
                    string testExpressionAtrributeEventAttributeID, 
                    string testExpressionLeftEventName, 
                    string testExpressionLeftEventEventTypeEventType, 
                    string testExpressionLeftEventLogSourceCode, 
                    string testExpressionLeftEventTimeSourceCode, 
                    string testExpressionRightEventName, 
                    string testExpressionRightEventEventTypeEventType, 
                    string testExpressionRightEventLogSourceCode, 
                    string testExpressionRightEventTimeSourceCode, 
                    int? testCriteriaID, 
                    string testCriteriaCode, 
                    bool? isPass, 
                    DateTime? dateCreated, 
                    DateTime? dateModified, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (testExpressionID.HasValue)
            	filter.Add(("TestExpressionID:=" + testExpressionID.Value.ToString()));
            if (!(String.IsNullOrEmpty(testExpressionJoinCriteria)))
            	filter.Add(("TestExpressionJoinCriteria:*" + testExpressionJoinCriteria));
            if (!(String.IsNullOrEmpty(testExpressionLeftDataElementDataElementName)))
            	filter.Add(("TestExpressionLeftDataElementDataElementName:*" + testExpressionLeftDataElementDataElementName));
            if (!(String.IsNullOrEmpty(testExpressionLeftDataElementEventName)))
            	filter.Add(("TestExpressionLeftDataElementEventName:*" + testExpressionLeftDataElementEventName));
            if (!(String.IsNullOrEmpty(testExpressionRightDataElementDataElementName)))
            	filter.Add(("TestExpressionRightDataElementDataElementName:*" + testExpressionRightDataElementDataElementName));
            if (!(String.IsNullOrEmpty(testExpressionRightDataElementEventName)))
            	filter.Add(("TestExpressionRightDataElementEventName:*" + testExpressionRightDataElementEventName));
            if (!(String.IsNullOrEmpty(testExpressionOperatorCode)))
            	filter.Add(("TestExpressionOperatorCode:*" + testExpressionOperatorCode));
            if (!(String.IsNullOrEmpty(testExpressionTemplateTemplateName)))
            	filter.Add(("TestExpressionTemplateTemplateName:*" + testExpressionTemplateTemplateName));
            if (!(String.IsNullOrEmpty(testExpressionTestTestName)))
            	filter.Add(("TestExpressionTestTestName:*" + testExpressionTestTestName));
            if (!(String.IsNullOrEmpty(testExpressionAtrributeEventAttributeID)))
            	filter.Add(("TestExpressionAtrributeEventAttributeID:*" + testExpressionAtrributeEventAttributeID));
            if (!(String.IsNullOrEmpty(testExpressionLeftEventName)))
            	filter.Add(("TestExpressionLeftEventName:*" + testExpressionLeftEventName));
            if (!(String.IsNullOrEmpty(testExpressionLeftEventEventTypeEventType)))
            	filter.Add(("TestExpressionLeftEventEventTypeEventType:*" + testExpressionLeftEventEventTypeEventType));
            if (!(String.IsNullOrEmpty(testExpressionLeftEventLogSourceCode)))
            	filter.Add(("TestExpressionLeftEventLogSourceCode:*" + testExpressionLeftEventLogSourceCode));
            if (!(String.IsNullOrEmpty(testExpressionLeftEventTimeSourceCode)))
            	filter.Add(("TestExpressionLeftEventTimeSourceCode:*" + testExpressionLeftEventTimeSourceCode));
            if (!(String.IsNullOrEmpty(testExpressionRightEventName)))
            	filter.Add(("TestExpressionRightEventName:*" + testExpressionRightEventName));
            if (!(String.IsNullOrEmpty(testExpressionRightEventEventTypeEventType)))
            	filter.Add(("TestExpressionRightEventEventTypeEventType:*" + testExpressionRightEventEventTypeEventType));
            if (!(String.IsNullOrEmpty(testExpressionRightEventLogSourceCode)))
            	filter.Add(("TestExpressionRightEventLogSourceCode:*" + testExpressionRightEventLogSourceCode));
            if (!(String.IsNullOrEmpty(testExpressionRightEventTimeSourceCode)))
            	filter.Add(("TestExpressionRightEventTimeSourceCode:*" + testExpressionRightEventTimeSourceCode));
            if (testCriteriaID.HasValue)
            	filter.Add(("TestCriteriaID:=" + testCriteriaID.Value.ToString()));
            if (!(String.IsNullOrEmpty(testCriteriaCode)))
            	filter.Add(("TestCriteriaCode:*" + testCriteriaCode));
            if (isPass.HasValue)
            	filter.Add(("IsPass:=" + isPass.Value.ToString()));
            if (dateCreated.HasValue)
            	filter.Add(("DateCreated:=" + dateCreated.Value.ToString()));
            if (dateModified.HasValue)
            	filter.Add(("DateModified:=" + dateModified.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<XIOT.Data.Objects.CB_PassFailCriteria> Select(
                    int? testExpressionID, 
                    string testExpressionJoinCriteria, 
                    string testExpressionLeftDataElementDataElementName, 
                    string testExpressionLeftDataElementEventName, 
                    string testExpressionRightDataElementDataElementName, 
                    string testExpressionRightDataElementEventName, 
                    string testExpressionOperatorCode, 
                    string testExpressionTemplateTemplateName, 
                    string testExpressionTestTestName, 
                    string testExpressionAtrributeEventAttributeID, 
                    string testExpressionLeftEventName, 
                    string testExpressionLeftEventEventTypeEventType, 
                    string testExpressionLeftEventLogSourceCode, 
                    string testExpressionLeftEventTimeSourceCode, 
                    string testExpressionRightEventName, 
                    string testExpressionRightEventEventTypeEventType, 
                    string testExpressionRightEventLogSourceCode, 
                    string testExpressionRightEventTimeSourceCode, 
                    int? testCriteriaID, 
                    string testCriteriaCode, 
                    bool? isPass, 
                    DateTime? dateCreated, 
                    DateTime? dateModified, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(testExpressionID, testExpressionJoinCriteria, testExpressionLeftDataElementDataElementName, testExpressionLeftDataElementEventName, testExpressionRightDataElementDataElementName, testExpressionRightDataElementEventName, testExpressionOperatorCode, testExpressionTemplateTemplateName, testExpressionTestTestName, testExpressionAtrributeEventAttributeID, testExpressionLeftEventName, testExpressionLeftEventEventTypeEventType, testExpressionLeftEventLogSourceCode, testExpressionLeftEventTimeSourceCode, testExpressionRightEventName, testExpressionRightEventEventTypeEventType, testExpressionRightEventLogSourceCode, testExpressionRightEventTimeSourceCode, testCriteriaID, testCriteriaCode, isPass, dateCreated, dateModified, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("CB_PassFailCriteria", dataView, request);
            return page.ToList<XIOT.Data.Objects.CB_PassFailCriteria>();
        }
        
        public List<XIOT.Data.Objects.CB_PassFailCriteria> Select(XIOT.Data.Objects.CB_PassFailCriteria qbe)
        {
            return Select(qbe.TestExpressionID, qbe.TestExpressionJoinCriteria, qbe.TestExpressionLeftDataElementDataElementName, qbe.TestExpressionLeftDataElementEventName, qbe.TestExpressionRightDataElementDataElementName, qbe.TestExpressionRightDataElementEventName, qbe.TestExpressionOperatorCode, qbe.TestExpressionTemplateTemplateName, qbe.TestExpressionTestTestName, qbe.TestExpressionAtrributeEventAttributeID, qbe.TestExpressionLeftEventName, qbe.TestExpressionLeftEventEventTypeEventType, qbe.TestExpressionLeftEventLogSourceCode, qbe.TestExpressionLeftEventTimeSourceCode, qbe.TestExpressionRightEventName, qbe.TestExpressionRightEventEventTypeEventType, qbe.TestExpressionRightEventLogSourceCode, qbe.TestExpressionRightEventTimeSourceCode, qbe.TestCriteriaID, qbe.TestCriteriaCode, qbe.IsPass, qbe.DateCreated, qbe.DateModified);
        }
        
        public int SelectCount(
                    int? testExpressionID, 
                    string testExpressionJoinCriteria, 
                    string testExpressionLeftDataElementDataElementName, 
                    string testExpressionLeftDataElementEventName, 
                    string testExpressionRightDataElementDataElementName, 
                    string testExpressionRightDataElementEventName, 
                    string testExpressionOperatorCode, 
                    string testExpressionTemplateTemplateName, 
                    string testExpressionTestTestName, 
                    string testExpressionAtrributeEventAttributeID, 
                    string testExpressionLeftEventName, 
                    string testExpressionLeftEventEventTypeEventType, 
                    string testExpressionLeftEventLogSourceCode, 
                    string testExpressionLeftEventTimeSourceCode, 
                    string testExpressionRightEventName, 
                    string testExpressionRightEventEventTypeEventType, 
                    string testExpressionRightEventLogSourceCode, 
                    string testExpressionRightEventTimeSourceCode, 
                    int? testCriteriaID, 
                    string testCriteriaCode, 
                    bool? isPass, 
                    DateTime? dateCreated, 
                    DateTime? dateModified, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(testExpressionID, testExpressionJoinCriteria, testExpressionLeftDataElementDataElementName, testExpressionLeftDataElementEventName, testExpressionRightDataElementDataElementName, testExpressionRightDataElementEventName, testExpressionOperatorCode, testExpressionTemplateTemplateName, testExpressionTestTestName, testExpressionAtrributeEventAttributeID, testExpressionLeftEventName, testExpressionLeftEventEventTypeEventType, testExpressionLeftEventLogSourceCode, testExpressionLeftEventTimeSourceCode, testExpressionRightEventName, testExpressionRightEventEventTypeEventType, testExpressionRightEventLogSourceCode, testExpressionRightEventTimeSourceCode, testCriteriaID, testCriteriaCode, isPass, dateCreated, dateModified, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("CB_PassFailCriteria", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<XIOT.Data.Objects.CB_PassFailCriteria> Select(
                    int? testExpressionID, 
                    string testExpressionJoinCriteria, 
                    string testExpressionLeftDataElementDataElementName, 
                    string testExpressionLeftDataElementEventName, 
                    string testExpressionRightDataElementDataElementName, 
                    string testExpressionRightDataElementEventName, 
                    string testExpressionOperatorCode, 
                    string testExpressionTemplateTemplateName, 
                    string testExpressionTestTestName, 
                    string testExpressionAtrributeEventAttributeID, 
                    string testExpressionLeftEventName, 
                    string testExpressionLeftEventEventTypeEventType, 
                    string testExpressionLeftEventLogSourceCode, 
                    string testExpressionLeftEventTimeSourceCode, 
                    string testExpressionRightEventName, 
                    string testExpressionRightEventEventTypeEventType, 
                    string testExpressionRightEventLogSourceCode, 
                    string testExpressionRightEventTimeSourceCode, 
                    int? testCriteriaID, 
                    string testCriteriaCode, 
                    bool? isPass, 
                    DateTime? dateCreated, 
                    DateTime? dateModified)
        {
            return Select(testExpressionID, testExpressionJoinCriteria, testExpressionLeftDataElementDataElementName, testExpressionLeftDataElementEventName, testExpressionRightDataElementDataElementName, testExpressionRightDataElementEventName, testExpressionOperatorCode, testExpressionTemplateTemplateName, testExpressionTestTestName, testExpressionAtrributeEventAttributeID, testExpressionLeftEventName, testExpressionLeftEventEventTypeEventType, testExpressionLeftEventLogSourceCode, testExpressionLeftEventTimeSourceCode, testExpressionRightEventName, testExpressionRightEventEventTypeEventType, testExpressionRightEventLogSourceCode, testExpressionRightEventTimeSourceCode, testCriteriaID, testCriteriaCode, isPass, dateCreated, dateModified, null, Int32.MaxValue, 0, SelectView);
        }
        
        public XIOT.Data.Objects.CB_PassFailCriteria SelectSingle(int? testExpressionID, int? testCriteriaID)
        {
            List<XIOT.Data.Objects.CB_PassFailCriteria> list = Select(testExpressionID, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, testCriteriaID, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<XIOT.Data.Objects.CB_PassFailCriteria> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("CB_PassFailCriteria", dataView, request);
            return page.ToList<XIOT.Data.Objects.CB_PassFailCriteria>();
        }
        
        public List<XIOT.Data.Objects.CB_PassFailCriteria> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<XIOT.Data.Objects.CB_PassFailCriteria> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public XIOT.Data.Objects.CB_PassFailCriteria SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<XIOT.Data.Objects.CB_PassFailCriteria> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(XIOT.Data.Objects.CB_PassFailCriteria theCB_PassFailCriteria, XIOT.Data.Objects.CB_PassFailCriteria original_CB_PassFailCriteria)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("TestExpressionID", original_CB_PassFailCriteria.TestExpressionID, theCB_PassFailCriteria.TestExpressionID));
            values.Add(new FieldValue("TestExpressionJoinCriteria", original_CB_PassFailCriteria.TestExpressionJoinCriteria, theCB_PassFailCriteria.TestExpressionJoinCriteria));
            values.Add(new FieldValue("TestExpressionLeftDataElementDataElementName", original_CB_PassFailCriteria.TestExpressionLeftDataElementDataElementName, theCB_PassFailCriteria.TestExpressionLeftDataElementDataElementName));
            values.Add(new FieldValue("TestExpressionLeftDataElementEventName", original_CB_PassFailCriteria.TestExpressionLeftDataElementEventName, theCB_PassFailCriteria.TestExpressionLeftDataElementEventName));
            values.Add(new FieldValue("TestExpressionRightDataElementDataElementName", original_CB_PassFailCriteria.TestExpressionRightDataElementDataElementName, theCB_PassFailCriteria.TestExpressionRightDataElementDataElementName));
            values.Add(new FieldValue("TestExpressionRightDataElementEventName", original_CB_PassFailCriteria.TestExpressionRightDataElementEventName, theCB_PassFailCriteria.TestExpressionRightDataElementEventName));
            values.Add(new FieldValue("TestExpressionOperatorCode", original_CB_PassFailCriteria.TestExpressionOperatorCode, theCB_PassFailCriteria.TestExpressionOperatorCode));
            values.Add(new FieldValue("TestExpressionTemplateTemplateName", original_CB_PassFailCriteria.TestExpressionTemplateTemplateName, theCB_PassFailCriteria.TestExpressionTemplateTemplateName));
            values.Add(new FieldValue("TestExpressionTestTestName", original_CB_PassFailCriteria.TestExpressionTestTestName, theCB_PassFailCriteria.TestExpressionTestTestName));
            values.Add(new FieldValue("TestExpressionAtrributeEventAttributeID", original_CB_PassFailCriteria.TestExpressionAtrributeEventAttributeID, theCB_PassFailCriteria.TestExpressionAtrributeEventAttributeID));
            values.Add(new FieldValue("TestExpressionLeftEventName", original_CB_PassFailCriteria.TestExpressionLeftEventName, theCB_PassFailCriteria.TestExpressionLeftEventName));
            values.Add(new FieldValue("TestExpressionLeftEventEventTypeEventType", original_CB_PassFailCriteria.TestExpressionLeftEventEventTypeEventType, theCB_PassFailCriteria.TestExpressionLeftEventEventTypeEventType));
            values.Add(new FieldValue("TestExpressionLeftEventLogSourceCode", original_CB_PassFailCriteria.TestExpressionLeftEventLogSourceCode, theCB_PassFailCriteria.TestExpressionLeftEventLogSourceCode));
            values.Add(new FieldValue("TestExpressionLeftEventTimeSourceCode", original_CB_PassFailCriteria.TestExpressionLeftEventTimeSourceCode, theCB_PassFailCriteria.TestExpressionLeftEventTimeSourceCode));
            values.Add(new FieldValue("TestExpressionRightEventName", original_CB_PassFailCriteria.TestExpressionRightEventName, theCB_PassFailCriteria.TestExpressionRightEventName));
            values.Add(new FieldValue("TestExpressionRightEventEventTypeEventType", original_CB_PassFailCriteria.TestExpressionRightEventEventTypeEventType, theCB_PassFailCriteria.TestExpressionRightEventEventTypeEventType));
            values.Add(new FieldValue("TestExpressionRightEventLogSourceCode", original_CB_PassFailCriteria.TestExpressionRightEventLogSourceCode, theCB_PassFailCriteria.TestExpressionRightEventLogSourceCode));
            values.Add(new FieldValue("TestExpressionRightEventTimeSourceCode", original_CB_PassFailCriteria.TestExpressionRightEventTimeSourceCode, theCB_PassFailCriteria.TestExpressionRightEventTimeSourceCode));
            values.Add(new FieldValue("TestCriteriaID", original_CB_PassFailCriteria.TestCriteriaID, theCB_PassFailCriteria.TestCriteriaID));
            values.Add(new FieldValue("TestCriteriaCode", original_CB_PassFailCriteria.TestCriteriaCode, theCB_PassFailCriteria.TestCriteriaCode));
            values.Add(new FieldValue("IsPass", original_CB_PassFailCriteria.IsPass, theCB_PassFailCriteria.IsPass));
            values.Add(new FieldValue("DateCreated", original_CB_PassFailCriteria.DateCreated, theCB_PassFailCriteria.DateCreated));
            values.Add(new FieldValue("DateModified", original_CB_PassFailCriteria.DateModified, theCB_PassFailCriteria.DateModified));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(XIOT.Data.Objects.CB_PassFailCriteria theCB_PassFailCriteria, XIOT.Data.Objects.CB_PassFailCriteria original_CB_PassFailCriteria, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "CB_PassFailCriteria";
            args.View = dataView;
            args.Values = CreateFieldValues(theCB_PassFailCriteria, original_CB_PassFailCriteria);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("CB_PassFailCriteria", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theCB_PassFailCriteria);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(XIOT.Data.Objects.CB_PassFailCriteria theCB_PassFailCriteria, XIOT.Data.Objects.CB_PassFailCriteria original_CB_PassFailCriteria)
        {
            return ExecuteAction(theCB_PassFailCriteria, original_CB_PassFailCriteria, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(XIOT.Data.Objects.CB_PassFailCriteria theCB_PassFailCriteria)
        {
            return Update(theCB_PassFailCriteria, SelectSingle(theCB_PassFailCriteria.TestExpressionID, theCB_PassFailCriteria.TestCriteriaID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(XIOT.Data.Objects.CB_PassFailCriteria theCB_PassFailCriteria)
        {
            return ExecuteAction(theCB_PassFailCriteria, new CB_PassFailCriteria(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(XIOT.Data.Objects.CB_PassFailCriteria theCB_PassFailCriteria)
        {
            return ExecuteAction(theCB_PassFailCriteria, theCB_PassFailCriteria, "Select", "Delete", DeleteView);
        }
    }
}
