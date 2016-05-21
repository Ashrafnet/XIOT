using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace XIOT.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class CB_TestExpressions
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _testID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _testTestName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _testExpressionID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _parentTestExpressionID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _parentTestExpressionJoinCriteria;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _parentTestExpressionLeftDataElementDataElementName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _parentTestExpressionLeftDataElementEventName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _parentTestExpressionRightDataElementDataElementName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _parentTestExpressionRightDataElementEventName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _parentTestExpressionOperatorCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _parentTestExpressionTemplateTemplateName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _parentTestExpressionTestTestName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _parentTestExpressionAtrributeEventAttributeID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _parentTestExpressionLeftEventName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _parentTestExpressionLeftEventEventTypeEventType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _parentTestExpressionLeftEventLogSourceCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _parentTestExpressionLeftEventTimeSourceCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _parentTestExpressionRightEventName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _parentTestExpressionRightEventEventTypeEventType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _parentTestExpressionRightEventLogSourceCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _parentTestExpressionRightEventTimeSourceCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _leftEventID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _leftEventName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _leftEventEventTypeEventType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _leftEventLogSourceCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _leftEventTimeSourceCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _leftDataElementID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _leftDataElementDataElementName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _leftDataElementEventName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _leftDataElementEventEventTypeEventType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _leftDataElementEventLogSourceCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _leftDataElementEventTimeSourceCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _operatorID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _operatorCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _rightEventID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rightEventName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rightEventEventTypeEventType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rightEventLogSourceCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rightEventTimeSourceCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _rightDataElementID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rightDataElementDataElementName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rightDataElementEventName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rightDataElementEventEventTypeEventType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rightDataElementEventLogSourceCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rightDataElementEventTimeSourceCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _startDateRange;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _endDateRange;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _orderSeq;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _atrributeEventID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _atrributeEventAttributeID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _weight;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _threshold;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _templateID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _templateTemplateName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _joinCriteria;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _dateCreated;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _dateModified;
        
        public CB_TestExpressions()
        {
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public int? TestID
        {
            get
            {
                return _testID;
            }
            set
            {
                _testID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string TestTestName
        {
            get
            {
                return _testTestName;
            }
            set
            {
                _testTestName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
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
        public int? ParentTestExpressionID
        {
            get
            {
                return _parentTestExpressionID;
            }
            set
            {
                _parentTestExpressionID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ParentTestExpressionJoinCriteria
        {
            get
            {
                return _parentTestExpressionJoinCriteria;
            }
            set
            {
                _parentTestExpressionJoinCriteria = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ParentTestExpressionLeftDataElementDataElementName
        {
            get
            {
                return _parentTestExpressionLeftDataElementDataElementName;
            }
            set
            {
                _parentTestExpressionLeftDataElementDataElementName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ParentTestExpressionLeftDataElementEventName
        {
            get
            {
                return _parentTestExpressionLeftDataElementEventName;
            }
            set
            {
                _parentTestExpressionLeftDataElementEventName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ParentTestExpressionRightDataElementDataElementName
        {
            get
            {
                return _parentTestExpressionRightDataElementDataElementName;
            }
            set
            {
                _parentTestExpressionRightDataElementDataElementName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ParentTestExpressionRightDataElementEventName
        {
            get
            {
                return _parentTestExpressionRightDataElementEventName;
            }
            set
            {
                _parentTestExpressionRightDataElementEventName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ParentTestExpressionOperatorCode
        {
            get
            {
                return _parentTestExpressionOperatorCode;
            }
            set
            {
                _parentTestExpressionOperatorCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ParentTestExpressionTemplateTemplateName
        {
            get
            {
                return _parentTestExpressionTemplateTemplateName;
            }
            set
            {
                _parentTestExpressionTemplateTemplateName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ParentTestExpressionTestTestName
        {
            get
            {
                return _parentTestExpressionTestTestName;
            }
            set
            {
                _parentTestExpressionTestTestName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ParentTestExpressionAtrributeEventAttributeID
        {
            get
            {
                return _parentTestExpressionAtrributeEventAttributeID;
            }
            set
            {
                _parentTestExpressionAtrributeEventAttributeID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ParentTestExpressionLeftEventName
        {
            get
            {
                return _parentTestExpressionLeftEventName;
            }
            set
            {
                _parentTestExpressionLeftEventName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ParentTestExpressionLeftEventEventTypeEventType
        {
            get
            {
                return _parentTestExpressionLeftEventEventTypeEventType;
            }
            set
            {
                _parentTestExpressionLeftEventEventTypeEventType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ParentTestExpressionLeftEventLogSourceCode
        {
            get
            {
                return _parentTestExpressionLeftEventLogSourceCode;
            }
            set
            {
                _parentTestExpressionLeftEventLogSourceCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ParentTestExpressionLeftEventTimeSourceCode
        {
            get
            {
                return _parentTestExpressionLeftEventTimeSourceCode;
            }
            set
            {
                _parentTestExpressionLeftEventTimeSourceCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ParentTestExpressionRightEventName
        {
            get
            {
                return _parentTestExpressionRightEventName;
            }
            set
            {
                _parentTestExpressionRightEventName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ParentTestExpressionRightEventEventTypeEventType
        {
            get
            {
                return _parentTestExpressionRightEventEventTypeEventType;
            }
            set
            {
                _parentTestExpressionRightEventEventTypeEventType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ParentTestExpressionRightEventLogSourceCode
        {
            get
            {
                return _parentTestExpressionRightEventLogSourceCode;
            }
            set
            {
                _parentTestExpressionRightEventLogSourceCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ParentTestExpressionRightEventTimeSourceCode
        {
            get
            {
                return _parentTestExpressionRightEventTimeSourceCode;
            }
            set
            {
                _parentTestExpressionRightEventTimeSourceCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public int? LeftEventID
        {
            get
            {
                return _leftEventID;
            }
            set
            {
                _leftEventID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LeftEventName
        {
            get
            {
                return _leftEventName;
            }
            set
            {
                _leftEventName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LeftEventEventTypeEventType
        {
            get
            {
                return _leftEventEventTypeEventType;
            }
            set
            {
                _leftEventEventTypeEventType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LeftEventLogSourceCode
        {
            get
            {
                return _leftEventLogSourceCode;
            }
            set
            {
                _leftEventLogSourceCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LeftEventTimeSourceCode
        {
            get
            {
                return _leftEventTimeSourceCode;
            }
            set
            {
                _leftEventTimeSourceCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? LeftDataElementID
        {
            get
            {
                return _leftDataElementID;
            }
            set
            {
                _leftDataElementID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LeftDataElementDataElementName
        {
            get
            {
                return _leftDataElementDataElementName;
            }
            set
            {
                _leftDataElementDataElementName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LeftDataElementEventName
        {
            get
            {
                return _leftDataElementEventName;
            }
            set
            {
                _leftDataElementEventName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LeftDataElementEventEventTypeEventType
        {
            get
            {
                return _leftDataElementEventEventTypeEventType;
            }
            set
            {
                _leftDataElementEventEventTypeEventType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LeftDataElementEventLogSourceCode
        {
            get
            {
                return _leftDataElementEventLogSourceCode;
            }
            set
            {
                _leftDataElementEventLogSourceCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LeftDataElementEventTimeSourceCode
        {
            get
            {
                return _leftDataElementEventTimeSourceCode;
            }
            set
            {
                _leftDataElementEventTimeSourceCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public int? OperatorID
        {
            get
            {
                return _operatorID;
            }
            set
            {
                _operatorID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OperatorCode
        {
            get
            {
                return _operatorCode;
            }
            set
            {
                _operatorCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? RightEventID
        {
            get
            {
                return _rightEventID;
            }
            set
            {
                _rightEventID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RightEventName
        {
            get
            {
                return _rightEventName;
            }
            set
            {
                _rightEventName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RightEventEventTypeEventType
        {
            get
            {
                return _rightEventEventTypeEventType;
            }
            set
            {
                _rightEventEventTypeEventType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RightEventLogSourceCode
        {
            get
            {
                return _rightEventLogSourceCode;
            }
            set
            {
                _rightEventLogSourceCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RightEventTimeSourceCode
        {
            get
            {
                return _rightEventTimeSourceCode;
            }
            set
            {
                _rightEventTimeSourceCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? RightDataElementID
        {
            get
            {
                return _rightDataElementID;
            }
            set
            {
                _rightDataElementID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RightDataElementDataElementName
        {
            get
            {
                return _rightDataElementDataElementName;
            }
            set
            {
                _rightDataElementDataElementName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RightDataElementEventName
        {
            get
            {
                return _rightDataElementEventName;
            }
            set
            {
                _rightDataElementEventName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RightDataElementEventEventTypeEventType
        {
            get
            {
                return _rightDataElementEventEventTypeEventType;
            }
            set
            {
                _rightDataElementEventEventTypeEventType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RightDataElementEventLogSourceCode
        {
            get
            {
                return _rightDataElementEventLogSourceCode;
            }
            set
            {
                _rightDataElementEventLogSourceCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RightDataElementEventTimeSourceCode
        {
            get
            {
                return _rightDataElementEventTimeSourceCode;
            }
            set
            {
                _rightDataElementEventTimeSourceCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? StartDateRange
        {
            get
            {
                return _startDateRange;
            }
            set
            {
                _startDateRange = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? EndDateRange
        {
            get
            {
                return _endDateRange;
            }
            set
            {
                _endDateRange = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public int? OrderSeq
        {
            get
            {
                return _orderSeq;
            }
            set
            {
                _orderSeq = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? AtrributeEventID
        {
            get
            {
                return _atrributeEventID;
            }
            set
            {
                _atrributeEventID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AtrributeEventAttributeID
        {
            get
            {
                return _atrributeEventAttributeID;
            }
            set
            {
                _atrributeEventAttributeID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public decimal? Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                _weight = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public decimal? Threshold
        {
            get
            {
                return _threshold;
            }
            set
            {
                _threshold = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string TemplateTemplateName
        {
            get
            {
                return _templateTemplateName;
            }
            set
            {
                _templateTemplateName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string JoinCriteria
        {
            get
            {
                return _joinCriteria;
            }
            set
            {
                _joinCriteria = value;
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
        
        public static List<XIOT.Data.Objects.CB_TestExpressions> Select(
                    int? testID, 
                    string testTestName, 
                    int? testExpressionID, 
                    int? parentTestExpressionID, 
                    string parentTestExpressionJoinCriteria, 
                    string parentTestExpressionLeftDataElementDataElementName, 
                    string parentTestExpressionLeftDataElementEventName, 
                    string parentTestExpressionRightDataElementDataElementName, 
                    string parentTestExpressionRightDataElementEventName, 
                    string parentTestExpressionOperatorCode, 
                    string parentTestExpressionTemplateTemplateName, 
                    string parentTestExpressionTestTestName, 
                    string parentTestExpressionAtrributeEventAttributeID, 
                    string parentTestExpressionLeftEventName, 
                    string parentTestExpressionLeftEventEventTypeEventType, 
                    string parentTestExpressionLeftEventLogSourceCode, 
                    string parentTestExpressionLeftEventTimeSourceCode, 
                    string parentTestExpressionRightEventName, 
                    string parentTestExpressionRightEventEventTypeEventType, 
                    string parentTestExpressionRightEventLogSourceCode, 
                    string parentTestExpressionRightEventTimeSourceCode, 
                    int? leftEventID, 
                    string leftEventName, 
                    string leftEventEventTypeEventType, 
                    string leftEventLogSourceCode, 
                    string leftEventTimeSourceCode, 
                    int? leftDataElementID, 
                    string leftDataElementDataElementName, 
                    string leftDataElementEventName, 
                    string leftDataElementEventEventTypeEventType, 
                    string leftDataElementEventLogSourceCode, 
                    string leftDataElementEventTimeSourceCode, 
                    int? operatorID, 
                    string operatorCode, 
                    int? rightEventID, 
                    string rightEventName, 
                    string rightEventEventTypeEventType, 
                    string rightEventLogSourceCode, 
                    string rightEventTimeSourceCode, 
                    int? rightDataElementID, 
                    string rightDataElementDataElementName, 
                    string rightDataElementEventName, 
                    string rightDataElementEventEventTypeEventType, 
                    string rightDataElementEventLogSourceCode, 
                    string rightDataElementEventTimeSourceCode, 
                    DateTime? startDateRange, 
                    DateTime? endDateRange, 
                    int? orderSeq, 
                    int? atrributeEventID, 
                    string atrributeEventAttributeID, 
                    decimal? weight, 
                    decimal? threshold, 
                    int? templateID, 
                    string templateTemplateName, 
                    string joinCriteria, 
                    DateTime? dateCreated, 
                    DateTime? dateModified)
        {
            return new CB_TestExpressionsFactory().Select(testID, testTestName, testExpressionID, parentTestExpressionID, parentTestExpressionJoinCriteria, parentTestExpressionLeftDataElementDataElementName, parentTestExpressionLeftDataElementEventName, parentTestExpressionRightDataElementDataElementName, parentTestExpressionRightDataElementEventName, parentTestExpressionOperatorCode, parentTestExpressionTemplateTemplateName, parentTestExpressionTestTestName, parentTestExpressionAtrributeEventAttributeID, parentTestExpressionLeftEventName, parentTestExpressionLeftEventEventTypeEventType, parentTestExpressionLeftEventLogSourceCode, parentTestExpressionLeftEventTimeSourceCode, parentTestExpressionRightEventName, parentTestExpressionRightEventEventTypeEventType, parentTestExpressionRightEventLogSourceCode, parentTestExpressionRightEventTimeSourceCode, leftEventID, leftEventName, leftEventEventTypeEventType, leftEventLogSourceCode, leftEventTimeSourceCode, leftDataElementID, leftDataElementDataElementName, leftDataElementEventName, leftDataElementEventEventTypeEventType, leftDataElementEventLogSourceCode, leftDataElementEventTimeSourceCode, operatorID, operatorCode, rightEventID, rightEventName, rightEventEventTypeEventType, rightEventLogSourceCode, rightEventTimeSourceCode, rightDataElementID, rightDataElementDataElementName, rightDataElementEventName, rightDataElementEventEventTypeEventType, rightDataElementEventLogSourceCode, rightDataElementEventTimeSourceCode, startDateRange, endDateRange, orderSeq, atrributeEventID, atrributeEventAttributeID, weight, threshold, templateID, templateTemplateName, joinCriteria, dateCreated, dateModified);
        }
        
        public static List<XIOT.Data.Objects.CB_TestExpressions> Select(XIOT.Data.Objects.CB_TestExpressions qbe)
        {
            return new CB_TestExpressionsFactory().Select(qbe);
        }
        
        public static List<XIOT.Data.Objects.CB_TestExpressions> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new CB_TestExpressionsFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<XIOT.Data.Objects.CB_TestExpressions> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new CB_TestExpressionsFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<XIOT.Data.Objects.CB_TestExpressions> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new CB_TestExpressionsFactory().Select(filter, sort, CB_TestExpressionsFactory.SelectView, parameters);
        }
        
        public static List<XIOT.Data.Objects.CB_TestExpressions> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new CB_TestExpressionsFactory().Select(filter, sort, CB_TestExpressionsFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<XIOT.Data.Objects.CB_TestExpressions> Select(string filter, BusinessObjectParameters parameters)
        {
            return new CB_TestExpressionsFactory().Select(filter, null, CB_TestExpressionsFactory.SelectView, parameters);
        }
        
        public static List<XIOT.Data.Objects.CB_TestExpressions> Select(string filter, params FieldValue[] parameters)
        {
            return new CB_TestExpressionsFactory().Select(filter, null, CB_TestExpressionsFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static XIOT.Data.Objects.CB_TestExpressions SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new CB_TestExpressionsFactory().SelectSingle(filter, parameters);
        }
        
        public static XIOT.Data.Objects.CB_TestExpressions SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new CB_TestExpressionsFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static XIOT.Data.Objects.CB_TestExpressions SelectSingle(int? testExpressionID)
        {
            return new CB_TestExpressionsFactory().SelectSingle(testExpressionID);
        }
        
        public int Insert()
        {
            return new CB_TestExpressionsFactory().Insert(this);
        }
        
        public int Update()
        {
            return new CB_TestExpressionsFactory().Update(this);
        }
        
        public int Delete()
        {
            return new CB_TestExpressionsFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("TestExpressionID: {0}", this.TestExpressionID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class CB_TestExpressionsFactory
    {
        
        public CB_TestExpressionsFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("CB_TestExpressions");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("CB_TestExpressions");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("CB_TestExpressions");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("CB_TestExpressions");
            }
        }
        
        public static CB_TestExpressionsFactory Create()
        {
            return new CB_TestExpressionsFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    int? testID, 
                    string testTestName, 
                    int? testExpressionID, 
                    int? parentTestExpressionID, 
                    string parentTestExpressionJoinCriteria, 
                    string parentTestExpressionLeftDataElementDataElementName, 
                    string parentTestExpressionLeftDataElementEventName, 
                    string parentTestExpressionRightDataElementDataElementName, 
                    string parentTestExpressionRightDataElementEventName, 
                    string parentTestExpressionOperatorCode, 
                    string parentTestExpressionTemplateTemplateName, 
                    string parentTestExpressionTestTestName, 
                    string parentTestExpressionAtrributeEventAttributeID, 
                    string parentTestExpressionLeftEventName, 
                    string parentTestExpressionLeftEventEventTypeEventType, 
                    string parentTestExpressionLeftEventLogSourceCode, 
                    string parentTestExpressionLeftEventTimeSourceCode, 
                    string parentTestExpressionRightEventName, 
                    string parentTestExpressionRightEventEventTypeEventType, 
                    string parentTestExpressionRightEventLogSourceCode, 
                    string parentTestExpressionRightEventTimeSourceCode, 
                    int? leftEventID, 
                    string leftEventName, 
                    string leftEventEventTypeEventType, 
                    string leftEventLogSourceCode, 
                    string leftEventTimeSourceCode, 
                    int? leftDataElementID, 
                    string leftDataElementDataElementName, 
                    string leftDataElementEventName, 
                    string leftDataElementEventEventTypeEventType, 
                    string leftDataElementEventLogSourceCode, 
                    string leftDataElementEventTimeSourceCode, 
                    int? operatorID, 
                    string operatorCode, 
                    int? rightEventID, 
                    string rightEventName, 
                    string rightEventEventTypeEventType, 
                    string rightEventLogSourceCode, 
                    string rightEventTimeSourceCode, 
                    int? rightDataElementID, 
                    string rightDataElementDataElementName, 
                    string rightDataElementEventName, 
                    string rightDataElementEventEventTypeEventType, 
                    string rightDataElementEventLogSourceCode, 
                    string rightDataElementEventTimeSourceCode, 
                    DateTime? startDateRange, 
                    DateTime? endDateRange, 
                    int? orderSeq, 
                    int? atrributeEventID, 
                    string atrributeEventAttributeID, 
                    decimal? weight, 
                    decimal? threshold, 
                    int? templateID, 
                    string templateTemplateName, 
                    string joinCriteria, 
                    DateTime? dateCreated, 
                    DateTime? dateModified, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (testID.HasValue)
            	filter.Add(("TestID:=" + testID.Value.ToString()));
            if (!(String.IsNullOrEmpty(testTestName)))
            	filter.Add(("TestTestName:*" + testTestName));
            if (testExpressionID.HasValue)
            	filter.Add(("TestExpressionID:=" + testExpressionID.Value.ToString()));
            if (parentTestExpressionID.HasValue)
            	filter.Add(("ParentTestExpressionID:=" + parentTestExpressionID.Value.ToString()));
            if (!(String.IsNullOrEmpty(parentTestExpressionJoinCriteria)))
            	filter.Add(("ParentTestExpressionJoinCriteria:*" + parentTestExpressionJoinCriteria));
            if (!(String.IsNullOrEmpty(parentTestExpressionLeftDataElementDataElementName)))
            	filter.Add(("ParentTestExpressionLeftDataElementDataElementName:*" + parentTestExpressionLeftDataElementDataElementName));
            if (!(String.IsNullOrEmpty(parentTestExpressionLeftDataElementEventName)))
            	filter.Add(("ParentTestExpressionLeftDataElementEventName:*" + parentTestExpressionLeftDataElementEventName));
            if (!(String.IsNullOrEmpty(parentTestExpressionRightDataElementDataElementName)))
            	filter.Add(("ParentTestExpressionRightDataElementDataElementName:*" + parentTestExpressionRightDataElementDataElementName));
            if (!(String.IsNullOrEmpty(parentTestExpressionRightDataElementEventName)))
            	filter.Add(("ParentTestExpressionRightDataElementEventName:*" + parentTestExpressionRightDataElementEventName));
            if (!(String.IsNullOrEmpty(parentTestExpressionOperatorCode)))
            	filter.Add(("ParentTestExpressionOperatorCode:*" + parentTestExpressionOperatorCode));
            if (!(String.IsNullOrEmpty(parentTestExpressionTemplateTemplateName)))
            	filter.Add(("ParentTestExpressionTemplateTemplateName:*" + parentTestExpressionTemplateTemplateName));
            if (!(String.IsNullOrEmpty(parentTestExpressionTestTestName)))
            	filter.Add(("ParentTestExpressionTestTestName:*" + parentTestExpressionTestTestName));
            if (!(String.IsNullOrEmpty(parentTestExpressionAtrributeEventAttributeID)))
            	filter.Add(("ParentTestExpressionAtrributeEventAttributeID:*" + parentTestExpressionAtrributeEventAttributeID));
            if (!(String.IsNullOrEmpty(parentTestExpressionLeftEventName)))
            	filter.Add(("ParentTestExpressionLeftEventName:*" + parentTestExpressionLeftEventName));
            if (!(String.IsNullOrEmpty(parentTestExpressionLeftEventEventTypeEventType)))
            	filter.Add(("ParentTestExpressionLeftEventEventTypeEventType:*" + parentTestExpressionLeftEventEventTypeEventType));
            if (!(String.IsNullOrEmpty(parentTestExpressionLeftEventLogSourceCode)))
            	filter.Add(("ParentTestExpressionLeftEventLogSourceCode:*" + parentTestExpressionLeftEventLogSourceCode));
            if (!(String.IsNullOrEmpty(parentTestExpressionLeftEventTimeSourceCode)))
            	filter.Add(("ParentTestExpressionLeftEventTimeSourceCode:*" + parentTestExpressionLeftEventTimeSourceCode));
            if (!(String.IsNullOrEmpty(parentTestExpressionRightEventName)))
            	filter.Add(("ParentTestExpressionRightEventName:*" + parentTestExpressionRightEventName));
            if (!(String.IsNullOrEmpty(parentTestExpressionRightEventEventTypeEventType)))
            	filter.Add(("ParentTestExpressionRightEventEventTypeEventType:*" + parentTestExpressionRightEventEventTypeEventType));
            if (!(String.IsNullOrEmpty(parentTestExpressionRightEventLogSourceCode)))
            	filter.Add(("ParentTestExpressionRightEventLogSourceCode:*" + parentTestExpressionRightEventLogSourceCode));
            if (!(String.IsNullOrEmpty(parentTestExpressionRightEventTimeSourceCode)))
            	filter.Add(("ParentTestExpressionRightEventTimeSourceCode:*" + parentTestExpressionRightEventTimeSourceCode));
            if (leftEventID.HasValue)
            	filter.Add(("LeftEventID:=" + leftEventID.Value.ToString()));
            if (!(String.IsNullOrEmpty(leftEventName)))
            	filter.Add(("LeftEventName:*" + leftEventName));
            if (!(String.IsNullOrEmpty(leftEventEventTypeEventType)))
            	filter.Add(("LeftEventEventTypeEventType:*" + leftEventEventTypeEventType));
            if (!(String.IsNullOrEmpty(leftEventLogSourceCode)))
            	filter.Add(("LeftEventLogSourceCode:*" + leftEventLogSourceCode));
            if (!(String.IsNullOrEmpty(leftEventTimeSourceCode)))
            	filter.Add(("LeftEventTimeSourceCode:*" + leftEventTimeSourceCode));
            if (leftDataElementID.HasValue)
            	filter.Add(("LeftDataElementID:=" + leftDataElementID.Value.ToString()));
            if (!(String.IsNullOrEmpty(leftDataElementDataElementName)))
            	filter.Add(("LeftDataElementDataElementName:*" + leftDataElementDataElementName));
            if (!(String.IsNullOrEmpty(leftDataElementEventName)))
            	filter.Add(("LeftDataElementEventName:*" + leftDataElementEventName));
            if (!(String.IsNullOrEmpty(leftDataElementEventEventTypeEventType)))
            	filter.Add(("LeftDataElementEventEventTypeEventType:*" + leftDataElementEventEventTypeEventType));
            if (!(String.IsNullOrEmpty(leftDataElementEventLogSourceCode)))
            	filter.Add(("LeftDataElementEventLogSourceCode:*" + leftDataElementEventLogSourceCode));
            if (!(String.IsNullOrEmpty(leftDataElementEventTimeSourceCode)))
            	filter.Add(("LeftDataElementEventTimeSourceCode:*" + leftDataElementEventTimeSourceCode));
            if (operatorID.HasValue)
            	filter.Add(("OperatorID:=" + operatorID.Value.ToString()));
            if (!(String.IsNullOrEmpty(operatorCode)))
            	filter.Add(("OperatorCode:*" + operatorCode));
            if (rightEventID.HasValue)
            	filter.Add(("RightEventID:=" + rightEventID.Value.ToString()));
            if (!(String.IsNullOrEmpty(rightEventName)))
            	filter.Add(("RightEventName:*" + rightEventName));
            if (!(String.IsNullOrEmpty(rightEventEventTypeEventType)))
            	filter.Add(("RightEventEventTypeEventType:*" + rightEventEventTypeEventType));
            if (!(String.IsNullOrEmpty(rightEventLogSourceCode)))
            	filter.Add(("RightEventLogSourceCode:*" + rightEventLogSourceCode));
            if (!(String.IsNullOrEmpty(rightEventTimeSourceCode)))
            	filter.Add(("RightEventTimeSourceCode:*" + rightEventTimeSourceCode));
            if (rightDataElementID.HasValue)
            	filter.Add(("RightDataElementID:=" + rightDataElementID.Value.ToString()));
            if (!(String.IsNullOrEmpty(rightDataElementDataElementName)))
            	filter.Add(("RightDataElementDataElementName:*" + rightDataElementDataElementName));
            if (!(String.IsNullOrEmpty(rightDataElementEventName)))
            	filter.Add(("RightDataElementEventName:*" + rightDataElementEventName));
            if (!(String.IsNullOrEmpty(rightDataElementEventEventTypeEventType)))
            	filter.Add(("RightDataElementEventEventTypeEventType:*" + rightDataElementEventEventTypeEventType));
            if (!(String.IsNullOrEmpty(rightDataElementEventLogSourceCode)))
            	filter.Add(("RightDataElementEventLogSourceCode:*" + rightDataElementEventLogSourceCode));
            if (!(String.IsNullOrEmpty(rightDataElementEventTimeSourceCode)))
            	filter.Add(("RightDataElementEventTimeSourceCode:*" + rightDataElementEventTimeSourceCode));
            if (startDateRange.HasValue)
            	filter.Add(("StartDateRange:=" + startDateRange.Value.ToString()));
            if (endDateRange.HasValue)
            	filter.Add(("EndDateRange:=" + endDateRange.Value.ToString()));
            if (orderSeq.HasValue)
            	filter.Add(("OrderSeq:=" + orderSeq.Value.ToString()));
            if (atrributeEventID.HasValue)
            	filter.Add(("AtrributeEventID:=" + atrributeEventID.Value.ToString()));
            if (!(String.IsNullOrEmpty(atrributeEventAttributeID)))
            	filter.Add(("AtrributeEventAttributeID:*" + atrributeEventAttributeID));
            if (weight.HasValue)
            	filter.Add(("Weight:=" + weight.Value.ToString()));
            if (threshold.HasValue)
            	filter.Add(("Threshold:=" + threshold.Value.ToString()));
            if (templateID.HasValue)
            	filter.Add(("TemplateID:=" + templateID.Value.ToString()));
            if (!(String.IsNullOrEmpty(templateTemplateName)))
            	filter.Add(("TemplateTemplateName:*" + templateTemplateName));
            if (!(String.IsNullOrEmpty(joinCriteria)))
            	filter.Add(("JoinCriteria:*" + joinCriteria));
            if (dateCreated.HasValue)
            	filter.Add(("DateCreated:=" + dateCreated.Value.ToString()));
            if (dateModified.HasValue)
            	filter.Add(("DateModified:=" + dateModified.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<XIOT.Data.Objects.CB_TestExpressions> Select(
                    int? testID, 
                    string testTestName, 
                    int? testExpressionID, 
                    int? parentTestExpressionID, 
                    string parentTestExpressionJoinCriteria, 
                    string parentTestExpressionLeftDataElementDataElementName, 
                    string parentTestExpressionLeftDataElementEventName, 
                    string parentTestExpressionRightDataElementDataElementName, 
                    string parentTestExpressionRightDataElementEventName, 
                    string parentTestExpressionOperatorCode, 
                    string parentTestExpressionTemplateTemplateName, 
                    string parentTestExpressionTestTestName, 
                    string parentTestExpressionAtrributeEventAttributeID, 
                    string parentTestExpressionLeftEventName, 
                    string parentTestExpressionLeftEventEventTypeEventType, 
                    string parentTestExpressionLeftEventLogSourceCode, 
                    string parentTestExpressionLeftEventTimeSourceCode, 
                    string parentTestExpressionRightEventName, 
                    string parentTestExpressionRightEventEventTypeEventType, 
                    string parentTestExpressionRightEventLogSourceCode, 
                    string parentTestExpressionRightEventTimeSourceCode, 
                    int? leftEventID, 
                    string leftEventName, 
                    string leftEventEventTypeEventType, 
                    string leftEventLogSourceCode, 
                    string leftEventTimeSourceCode, 
                    int? leftDataElementID, 
                    string leftDataElementDataElementName, 
                    string leftDataElementEventName, 
                    string leftDataElementEventEventTypeEventType, 
                    string leftDataElementEventLogSourceCode, 
                    string leftDataElementEventTimeSourceCode, 
                    int? operatorID, 
                    string operatorCode, 
                    int? rightEventID, 
                    string rightEventName, 
                    string rightEventEventTypeEventType, 
                    string rightEventLogSourceCode, 
                    string rightEventTimeSourceCode, 
                    int? rightDataElementID, 
                    string rightDataElementDataElementName, 
                    string rightDataElementEventName, 
                    string rightDataElementEventEventTypeEventType, 
                    string rightDataElementEventLogSourceCode, 
                    string rightDataElementEventTimeSourceCode, 
                    DateTime? startDateRange, 
                    DateTime? endDateRange, 
                    int? orderSeq, 
                    int? atrributeEventID, 
                    string atrributeEventAttributeID, 
                    decimal? weight, 
                    decimal? threshold, 
                    int? templateID, 
                    string templateTemplateName, 
                    string joinCriteria, 
                    DateTime? dateCreated, 
                    DateTime? dateModified, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(testID, testTestName, testExpressionID, parentTestExpressionID, parentTestExpressionJoinCriteria, parentTestExpressionLeftDataElementDataElementName, parentTestExpressionLeftDataElementEventName, parentTestExpressionRightDataElementDataElementName, parentTestExpressionRightDataElementEventName, parentTestExpressionOperatorCode, parentTestExpressionTemplateTemplateName, parentTestExpressionTestTestName, parentTestExpressionAtrributeEventAttributeID, parentTestExpressionLeftEventName, parentTestExpressionLeftEventEventTypeEventType, parentTestExpressionLeftEventLogSourceCode, parentTestExpressionLeftEventTimeSourceCode, parentTestExpressionRightEventName, parentTestExpressionRightEventEventTypeEventType, parentTestExpressionRightEventLogSourceCode, parentTestExpressionRightEventTimeSourceCode, leftEventID, leftEventName, leftEventEventTypeEventType, leftEventLogSourceCode, leftEventTimeSourceCode, leftDataElementID, leftDataElementDataElementName, leftDataElementEventName, leftDataElementEventEventTypeEventType, leftDataElementEventLogSourceCode, leftDataElementEventTimeSourceCode, operatorID, operatorCode, rightEventID, rightEventName, rightEventEventTypeEventType, rightEventLogSourceCode, rightEventTimeSourceCode, rightDataElementID, rightDataElementDataElementName, rightDataElementEventName, rightDataElementEventEventTypeEventType, rightDataElementEventLogSourceCode, rightDataElementEventTimeSourceCode, startDateRange, endDateRange, orderSeq, atrributeEventID, atrributeEventAttributeID, weight, threshold, templateID, templateTemplateName, joinCriteria, dateCreated, dateModified, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("CB_TestExpressions", dataView, request);
            return page.ToList<XIOT.Data.Objects.CB_TestExpressions>();
        }
        
        public List<XIOT.Data.Objects.CB_TestExpressions> Select(XIOT.Data.Objects.CB_TestExpressions qbe)
        {
            return Select(qbe.TestID, qbe.TestTestName, qbe.TestExpressionID, qbe.ParentTestExpressionID, qbe.ParentTestExpressionJoinCriteria, qbe.ParentTestExpressionLeftDataElementDataElementName, qbe.ParentTestExpressionLeftDataElementEventName, qbe.ParentTestExpressionRightDataElementDataElementName, qbe.ParentTestExpressionRightDataElementEventName, qbe.ParentTestExpressionOperatorCode, qbe.ParentTestExpressionTemplateTemplateName, qbe.ParentTestExpressionTestTestName, qbe.ParentTestExpressionAtrributeEventAttributeID, qbe.ParentTestExpressionLeftEventName, qbe.ParentTestExpressionLeftEventEventTypeEventType, qbe.ParentTestExpressionLeftEventLogSourceCode, qbe.ParentTestExpressionLeftEventTimeSourceCode, qbe.ParentTestExpressionRightEventName, qbe.ParentTestExpressionRightEventEventTypeEventType, qbe.ParentTestExpressionRightEventLogSourceCode, qbe.ParentTestExpressionRightEventTimeSourceCode, qbe.LeftEventID, qbe.LeftEventName, qbe.LeftEventEventTypeEventType, qbe.LeftEventLogSourceCode, qbe.LeftEventTimeSourceCode, qbe.LeftDataElementID, qbe.LeftDataElementDataElementName, qbe.LeftDataElementEventName, qbe.LeftDataElementEventEventTypeEventType, qbe.LeftDataElementEventLogSourceCode, qbe.LeftDataElementEventTimeSourceCode, qbe.OperatorID, qbe.OperatorCode, qbe.RightEventID, qbe.RightEventName, qbe.RightEventEventTypeEventType, qbe.RightEventLogSourceCode, qbe.RightEventTimeSourceCode, qbe.RightDataElementID, qbe.RightDataElementDataElementName, qbe.RightDataElementEventName, qbe.RightDataElementEventEventTypeEventType, qbe.RightDataElementEventLogSourceCode, qbe.RightDataElementEventTimeSourceCode, qbe.StartDateRange, qbe.EndDateRange, qbe.OrderSeq, qbe.AtrributeEventID, qbe.AtrributeEventAttributeID, qbe.Weight, qbe.Threshold, qbe.TemplateID, qbe.TemplateTemplateName, qbe.JoinCriteria, qbe.DateCreated, qbe.DateModified);
        }
        
        public int SelectCount(
                    int? testID, 
                    string testTestName, 
                    int? testExpressionID, 
                    int? parentTestExpressionID, 
                    string parentTestExpressionJoinCriteria, 
                    string parentTestExpressionLeftDataElementDataElementName, 
                    string parentTestExpressionLeftDataElementEventName, 
                    string parentTestExpressionRightDataElementDataElementName, 
                    string parentTestExpressionRightDataElementEventName, 
                    string parentTestExpressionOperatorCode, 
                    string parentTestExpressionTemplateTemplateName, 
                    string parentTestExpressionTestTestName, 
                    string parentTestExpressionAtrributeEventAttributeID, 
                    string parentTestExpressionLeftEventName, 
                    string parentTestExpressionLeftEventEventTypeEventType, 
                    string parentTestExpressionLeftEventLogSourceCode, 
                    string parentTestExpressionLeftEventTimeSourceCode, 
                    string parentTestExpressionRightEventName, 
                    string parentTestExpressionRightEventEventTypeEventType, 
                    string parentTestExpressionRightEventLogSourceCode, 
                    string parentTestExpressionRightEventTimeSourceCode, 
                    int? leftEventID, 
                    string leftEventName, 
                    string leftEventEventTypeEventType, 
                    string leftEventLogSourceCode, 
                    string leftEventTimeSourceCode, 
                    int? leftDataElementID, 
                    string leftDataElementDataElementName, 
                    string leftDataElementEventName, 
                    string leftDataElementEventEventTypeEventType, 
                    string leftDataElementEventLogSourceCode, 
                    string leftDataElementEventTimeSourceCode, 
                    int? operatorID, 
                    string operatorCode, 
                    int? rightEventID, 
                    string rightEventName, 
                    string rightEventEventTypeEventType, 
                    string rightEventLogSourceCode, 
                    string rightEventTimeSourceCode, 
                    int? rightDataElementID, 
                    string rightDataElementDataElementName, 
                    string rightDataElementEventName, 
                    string rightDataElementEventEventTypeEventType, 
                    string rightDataElementEventLogSourceCode, 
                    string rightDataElementEventTimeSourceCode, 
                    DateTime? startDateRange, 
                    DateTime? endDateRange, 
                    int? orderSeq, 
                    int? atrributeEventID, 
                    string atrributeEventAttributeID, 
                    decimal? weight, 
                    decimal? threshold, 
                    int? templateID, 
                    string templateTemplateName, 
                    string joinCriteria, 
                    DateTime? dateCreated, 
                    DateTime? dateModified, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(testID, testTestName, testExpressionID, parentTestExpressionID, parentTestExpressionJoinCriteria, parentTestExpressionLeftDataElementDataElementName, parentTestExpressionLeftDataElementEventName, parentTestExpressionRightDataElementDataElementName, parentTestExpressionRightDataElementEventName, parentTestExpressionOperatorCode, parentTestExpressionTemplateTemplateName, parentTestExpressionTestTestName, parentTestExpressionAtrributeEventAttributeID, parentTestExpressionLeftEventName, parentTestExpressionLeftEventEventTypeEventType, parentTestExpressionLeftEventLogSourceCode, parentTestExpressionLeftEventTimeSourceCode, parentTestExpressionRightEventName, parentTestExpressionRightEventEventTypeEventType, parentTestExpressionRightEventLogSourceCode, parentTestExpressionRightEventTimeSourceCode, leftEventID, leftEventName, leftEventEventTypeEventType, leftEventLogSourceCode, leftEventTimeSourceCode, leftDataElementID, leftDataElementDataElementName, leftDataElementEventName, leftDataElementEventEventTypeEventType, leftDataElementEventLogSourceCode, leftDataElementEventTimeSourceCode, operatorID, operatorCode, rightEventID, rightEventName, rightEventEventTypeEventType, rightEventLogSourceCode, rightEventTimeSourceCode, rightDataElementID, rightDataElementDataElementName, rightDataElementEventName, rightDataElementEventEventTypeEventType, rightDataElementEventLogSourceCode, rightDataElementEventTimeSourceCode, startDateRange, endDateRange, orderSeq, atrributeEventID, atrributeEventAttributeID, weight, threshold, templateID, templateTemplateName, joinCriteria, dateCreated, dateModified, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("CB_TestExpressions", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<XIOT.Data.Objects.CB_TestExpressions> Select(
                    int? testID, 
                    string testTestName, 
                    int? testExpressionID, 
                    int? parentTestExpressionID, 
                    string parentTestExpressionJoinCriteria, 
                    string parentTestExpressionLeftDataElementDataElementName, 
                    string parentTestExpressionLeftDataElementEventName, 
                    string parentTestExpressionRightDataElementDataElementName, 
                    string parentTestExpressionRightDataElementEventName, 
                    string parentTestExpressionOperatorCode, 
                    string parentTestExpressionTemplateTemplateName, 
                    string parentTestExpressionTestTestName, 
                    string parentTestExpressionAtrributeEventAttributeID, 
                    string parentTestExpressionLeftEventName, 
                    string parentTestExpressionLeftEventEventTypeEventType, 
                    string parentTestExpressionLeftEventLogSourceCode, 
                    string parentTestExpressionLeftEventTimeSourceCode, 
                    string parentTestExpressionRightEventName, 
                    string parentTestExpressionRightEventEventTypeEventType, 
                    string parentTestExpressionRightEventLogSourceCode, 
                    string parentTestExpressionRightEventTimeSourceCode, 
                    int? leftEventID, 
                    string leftEventName, 
                    string leftEventEventTypeEventType, 
                    string leftEventLogSourceCode, 
                    string leftEventTimeSourceCode, 
                    int? leftDataElementID, 
                    string leftDataElementDataElementName, 
                    string leftDataElementEventName, 
                    string leftDataElementEventEventTypeEventType, 
                    string leftDataElementEventLogSourceCode, 
                    string leftDataElementEventTimeSourceCode, 
                    int? operatorID, 
                    string operatorCode, 
                    int? rightEventID, 
                    string rightEventName, 
                    string rightEventEventTypeEventType, 
                    string rightEventLogSourceCode, 
                    string rightEventTimeSourceCode, 
                    int? rightDataElementID, 
                    string rightDataElementDataElementName, 
                    string rightDataElementEventName, 
                    string rightDataElementEventEventTypeEventType, 
                    string rightDataElementEventLogSourceCode, 
                    string rightDataElementEventTimeSourceCode, 
                    DateTime? startDateRange, 
                    DateTime? endDateRange, 
                    int? orderSeq, 
                    int? atrributeEventID, 
                    string atrributeEventAttributeID, 
                    decimal? weight, 
                    decimal? threshold, 
                    int? templateID, 
                    string templateTemplateName, 
                    string joinCriteria, 
                    DateTime? dateCreated, 
                    DateTime? dateModified)
        {
            return Select(testID, testTestName, testExpressionID, parentTestExpressionID, parentTestExpressionJoinCriteria, parentTestExpressionLeftDataElementDataElementName, parentTestExpressionLeftDataElementEventName, parentTestExpressionRightDataElementDataElementName, parentTestExpressionRightDataElementEventName, parentTestExpressionOperatorCode, parentTestExpressionTemplateTemplateName, parentTestExpressionTestTestName, parentTestExpressionAtrributeEventAttributeID, parentTestExpressionLeftEventName, parentTestExpressionLeftEventEventTypeEventType, parentTestExpressionLeftEventLogSourceCode, parentTestExpressionLeftEventTimeSourceCode, parentTestExpressionRightEventName, parentTestExpressionRightEventEventTypeEventType, parentTestExpressionRightEventLogSourceCode, parentTestExpressionRightEventTimeSourceCode, leftEventID, leftEventName, leftEventEventTypeEventType, leftEventLogSourceCode, leftEventTimeSourceCode, leftDataElementID, leftDataElementDataElementName, leftDataElementEventName, leftDataElementEventEventTypeEventType, leftDataElementEventLogSourceCode, leftDataElementEventTimeSourceCode, operatorID, operatorCode, rightEventID, rightEventName, rightEventEventTypeEventType, rightEventLogSourceCode, rightEventTimeSourceCode, rightDataElementID, rightDataElementDataElementName, rightDataElementEventName, rightDataElementEventEventTypeEventType, rightDataElementEventLogSourceCode, rightDataElementEventTimeSourceCode, startDateRange, endDateRange, orderSeq, atrributeEventID, atrributeEventAttributeID, weight, threshold, templateID, templateTemplateName, joinCriteria, dateCreated, dateModified, null, Int32.MaxValue, 0, SelectView);
        }
        
        public XIOT.Data.Objects.CB_TestExpressions SelectSingle(int? testExpressionID)
        {
            List<XIOT.Data.Objects.CB_TestExpressions> list = Select(null, null, testExpressionID, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<XIOT.Data.Objects.CB_TestExpressions> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("CB_TestExpressions", dataView, request);
            return page.ToList<XIOT.Data.Objects.CB_TestExpressions>();
        }
        
        public List<XIOT.Data.Objects.CB_TestExpressions> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<XIOT.Data.Objects.CB_TestExpressions> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public XIOT.Data.Objects.CB_TestExpressions SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<XIOT.Data.Objects.CB_TestExpressions> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(XIOT.Data.Objects.CB_TestExpressions theCB_TestExpressions, XIOT.Data.Objects.CB_TestExpressions original_CB_TestExpressions)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("TestID", original_CB_TestExpressions.TestID, theCB_TestExpressions.TestID));
            values.Add(new FieldValue("TestTestName", original_CB_TestExpressions.TestTestName, theCB_TestExpressions.TestTestName));
            values.Add(new FieldValue("TestExpressionID", original_CB_TestExpressions.TestExpressionID, theCB_TestExpressions.TestExpressionID));
            values.Add(new FieldValue("ParentTestExpressionID", original_CB_TestExpressions.ParentTestExpressionID, theCB_TestExpressions.ParentTestExpressionID));
            values.Add(new FieldValue("ParentTestExpressionJoinCriteria", original_CB_TestExpressions.ParentTestExpressionJoinCriteria, theCB_TestExpressions.ParentTestExpressionJoinCriteria));
            values.Add(new FieldValue("ParentTestExpressionLeftDataElementDataElementName", original_CB_TestExpressions.ParentTestExpressionLeftDataElementDataElementName, theCB_TestExpressions.ParentTestExpressionLeftDataElementDataElementName));
            values.Add(new FieldValue("ParentTestExpressionLeftDataElementEventName", original_CB_TestExpressions.ParentTestExpressionLeftDataElementEventName, theCB_TestExpressions.ParentTestExpressionLeftDataElementEventName));
            values.Add(new FieldValue("ParentTestExpressionRightDataElementDataElementName", original_CB_TestExpressions.ParentTestExpressionRightDataElementDataElementName, theCB_TestExpressions.ParentTestExpressionRightDataElementDataElementName));
            values.Add(new FieldValue("ParentTestExpressionRightDataElementEventName", original_CB_TestExpressions.ParentTestExpressionRightDataElementEventName, theCB_TestExpressions.ParentTestExpressionRightDataElementEventName));
            values.Add(new FieldValue("ParentTestExpressionOperatorCode", original_CB_TestExpressions.ParentTestExpressionOperatorCode, theCB_TestExpressions.ParentTestExpressionOperatorCode));
            values.Add(new FieldValue("ParentTestExpressionTemplateTemplateName", original_CB_TestExpressions.ParentTestExpressionTemplateTemplateName, theCB_TestExpressions.ParentTestExpressionTemplateTemplateName));
            values.Add(new FieldValue("ParentTestExpressionTestTestName", original_CB_TestExpressions.ParentTestExpressionTestTestName, theCB_TestExpressions.ParentTestExpressionTestTestName));
            values.Add(new FieldValue("ParentTestExpressionAtrributeEventAttributeID", original_CB_TestExpressions.ParentTestExpressionAtrributeEventAttributeID, theCB_TestExpressions.ParentTestExpressionAtrributeEventAttributeID));
            values.Add(new FieldValue("ParentTestExpressionLeftEventName", original_CB_TestExpressions.ParentTestExpressionLeftEventName, theCB_TestExpressions.ParentTestExpressionLeftEventName));
            values.Add(new FieldValue("ParentTestExpressionLeftEventEventTypeEventType", original_CB_TestExpressions.ParentTestExpressionLeftEventEventTypeEventType, theCB_TestExpressions.ParentTestExpressionLeftEventEventTypeEventType));
            values.Add(new FieldValue("ParentTestExpressionLeftEventLogSourceCode", original_CB_TestExpressions.ParentTestExpressionLeftEventLogSourceCode, theCB_TestExpressions.ParentTestExpressionLeftEventLogSourceCode));
            values.Add(new FieldValue("ParentTestExpressionLeftEventTimeSourceCode", original_CB_TestExpressions.ParentTestExpressionLeftEventTimeSourceCode, theCB_TestExpressions.ParentTestExpressionLeftEventTimeSourceCode));
            values.Add(new FieldValue("ParentTestExpressionRightEventName", original_CB_TestExpressions.ParentTestExpressionRightEventName, theCB_TestExpressions.ParentTestExpressionRightEventName));
            values.Add(new FieldValue("ParentTestExpressionRightEventEventTypeEventType", original_CB_TestExpressions.ParentTestExpressionRightEventEventTypeEventType, theCB_TestExpressions.ParentTestExpressionRightEventEventTypeEventType));
            values.Add(new FieldValue("ParentTestExpressionRightEventLogSourceCode", original_CB_TestExpressions.ParentTestExpressionRightEventLogSourceCode, theCB_TestExpressions.ParentTestExpressionRightEventLogSourceCode));
            values.Add(new FieldValue("ParentTestExpressionRightEventTimeSourceCode", original_CB_TestExpressions.ParentTestExpressionRightEventTimeSourceCode, theCB_TestExpressions.ParentTestExpressionRightEventTimeSourceCode));
            values.Add(new FieldValue("LeftEventID", original_CB_TestExpressions.LeftEventID, theCB_TestExpressions.LeftEventID));
            values.Add(new FieldValue("LeftEventName", original_CB_TestExpressions.LeftEventName, theCB_TestExpressions.LeftEventName));
            values.Add(new FieldValue("LeftEventEventTypeEventType", original_CB_TestExpressions.LeftEventEventTypeEventType, theCB_TestExpressions.LeftEventEventTypeEventType));
            values.Add(new FieldValue("LeftEventLogSourceCode", original_CB_TestExpressions.LeftEventLogSourceCode, theCB_TestExpressions.LeftEventLogSourceCode));
            values.Add(new FieldValue("LeftEventTimeSourceCode", original_CB_TestExpressions.LeftEventTimeSourceCode, theCB_TestExpressions.LeftEventTimeSourceCode));
            values.Add(new FieldValue("LeftDataElementID", original_CB_TestExpressions.LeftDataElementID, theCB_TestExpressions.LeftDataElementID));
            values.Add(new FieldValue("LeftDataElementDataElementName", original_CB_TestExpressions.LeftDataElementDataElementName, theCB_TestExpressions.LeftDataElementDataElementName));
            values.Add(new FieldValue("LeftDataElementEventName", original_CB_TestExpressions.LeftDataElementEventName, theCB_TestExpressions.LeftDataElementEventName));
            values.Add(new FieldValue("LeftDataElementEventEventTypeEventType", original_CB_TestExpressions.LeftDataElementEventEventTypeEventType, theCB_TestExpressions.LeftDataElementEventEventTypeEventType));
            values.Add(new FieldValue("LeftDataElementEventLogSourceCode", original_CB_TestExpressions.LeftDataElementEventLogSourceCode, theCB_TestExpressions.LeftDataElementEventLogSourceCode));
            values.Add(new FieldValue("LeftDataElementEventTimeSourceCode", original_CB_TestExpressions.LeftDataElementEventTimeSourceCode, theCB_TestExpressions.LeftDataElementEventTimeSourceCode));
            values.Add(new FieldValue("OperatorID", original_CB_TestExpressions.OperatorID, theCB_TestExpressions.OperatorID));
            values.Add(new FieldValue("OperatorCode", original_CB_TestExpressions.OperatorCode, theCB_TestExpressions.OperatorCode));
            values.Add(new FieldValue("RightEventID", original_CB_TestExpressions.RightEventID, theCB_TestExpressions.RightEventID));
            values.Add(new FieldValue("RightEventName", original_CB_TestExpressions.RightEventName, theCB_TestExpressions.RightEventName));
            values.Add(new FieldValue("RightEventEventTypeEventType", original_CB_TestExpressions.RightEventEventTypeEventType, theCB_TestExpressions.RightEventEventTypeEventType));
            values.Add(new FieldValue("RightEventLogSourceCode", original_CB_TestExpressions.RightEventLogSourceCode, theCB_TestExpressions.RightEventLogSourceCode));
            values.Add(new FieldValue("RightEventTimeSourceCode", original_CB_TestExpressions.RightEventTimeSourceCode, theCB_TestExpressions.RightEventTimeSourceCode));
            values.Add(new FieldValue("RightDataElementID", original_CB_TestExpressions.RightDataElementID, theCB_TestExpressions.RightDataElementID));
            values.Add(new FieldValue("RightDataElementDataElementName", original_CB_TestExpressions.RightDataElementDataElementName, theCB_TestExpressions.RightDataElementDataElementName));
            values.Add(new FieldValue("RightDataElementEventName", original_CB_TestExpressions.RightDataElementEventName, theCB_TestExpressions.RightDataElementEventName));
            values.Add(new FieldValue("RightDataElementEventEventTypeEventType", original_CB_TestExpressions.RightDataElementEventEventTypeEventType, theCB_TestExpressions.RightDataElementEventEventTypeEventType));
            values.Add(new FieldValue("RightDataElementEventLogSourceCode", original_CB_TestExpressions.RightDataElementEventLogSourceCode, theCB_TestExpressions.RightDataElementEventLogSourceCode));
            values.Add(new FieldValue("RightDataElementEventTimeSourceCode", original_CB_TestExpressions.RightDataElementEventTimeSourceCode, theCB_TestExpressions.RightDataElementEventTimeSourceCode));
            values.Add(new FieldValue("StartDateRange", original_CB_TestExpressions.StartDateRange, theCB_TestExpressions.StartDateRange));
            values.Add(new FieldValue("EndDateRange", original_CB_TestExpressions.EndDateRange, theCB_TestExpressions.EndDateRange));
            values.Add(new FieldValue("OrderSeq", original_CB_TestExpressions.OrderSeq, theCB_TestExpressions.OrderSeq));
            values.Add(new FieldValue("AtrributeEventID", original_CB_TestExpressions.AtrributeEventID, theCB_TestExpressions.AtrributeEventID));
            values.Add(new FieldValue("AtrributeEventAttributeID", original_CB_TestExpressions.AtrributeEventAttributeID, theCB_TestExpressions.AtrributeEventAttributeID));
            values.Add(new FieldValue("Weight", original_CB_TestExpressions.Weight, theCB_TestExpressions.Weight));
            values.Add(new FieldValue("Threshold", original_CB_TestExpressions.Threshold, theCB_TestExpressions.Threshold));
            values.Add(new FieldValue("TemplateID", original_CB_TestExpressions.TemplateID, theCB_TestExpressions.TemplateID));
            values.Add(new FieldValue("TemplateTemplateName", original_CB_TestExpressions.TemplateTemplateName, theCB_TestExpressions.TemplateTemplateName));
            values.Add(new FieldValue("JoinCriteria", original_CB_TestExpressions.JoinCriteria, theCB_TestExpressions.JoinCriteria));
            values.Add(new FieldValue("DateCreated", original_CB_TestExpressions.DateCreated, theCB_TestExpressions.DateCreated));
            values.Add(new FieldValue("DateModified", original_CB_TestExpressions.DateModified, theCB_TestExpressions.DateModified));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(XIOT.Data.Objects.CB_TestExpressions theCB_TestExpressions, XIOT.Data.Objects.CB_TestExpressions original_CB_TestExpressions, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "CB_TestExpressions";
            args.View = dataView;
            args.Values = CreateFieldValues(theCB_TestExpressions, original_CB_TestExpressions);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("CB_TestExpressions", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theCB_TestExpressions);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(XIOT.Data.Objects.CB_TestExpressions theCB_TestExpressions, XIOT.Data.Objects.CB_TestExpressions original_CB_TestExpressions)
        {
            return ExecuteAction(theCB_TestExpressions, original_CB_TestExpressions, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(XIOT.Data.Objects.CB_TestExpressions theCB_TestExpressions)
        {
            return Update(theCB_TestExpressions, SelectSingle(theCB_TestExpressions.TestExpressionID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(XIOT.Data.Objects.CB_TestExpressions theCB_TestExpressions)
        {
            return ExecuteAction(theCB_TestExpressions, new CB_TestExpressions(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(XIOT.Data.Objects.CB_TestExpressions theCB_TestExpressions)
        {
            return ExecuteAction(theCB_TestExpressions, theCB_TestExpressions, "Select", "Delete", DeleteView);
        }
    }
}
