using System.Xml.Serialization;
using Showplan.StatementBlocks;

namespace Showplan
{
    /// <remarks/>
    [XmlInclude(typeof(StmtReceive))]
    [XmlInclude(typeof(StmtCursor))]
    [XmlInclude(typeof(StmtCond))]
    [XmlInclude(typeof(StmtUseDb))]
    [XmlInclude(typeof(StmtSimple))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("BaseStmtInfoType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class BaseStmtInfo
    {
        /// <remarks/>
        public SetOptions StatementSetOptions { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int StatementCompId { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool StatementCompIdSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public double StatementEstRows { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool StatementEstRowsSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int StatementId { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool StatementIdSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string StatementOptmLevel { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public BaseStmtInfoTypeStatementOptmEarlyAbortReason StatementOptmEarlyAbortReason { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool StatementOptmEarlyAbortReasonSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string CardinalityEstimationModelVersion { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public double StatementSubTreeCost { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool StatementSubTreeCostSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string StatementText { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string StatementType { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string TemplatePlanGuideDb { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string TemplatePlanGuideName { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string PlanGuideDb { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string PlanGuideName { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string ParameterizedText { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string ParameterizedPlanHandle { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string QueryHash { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string QueryPlanHash { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string RetrievedFromCache { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string StatementSqlHandle { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong DatabaseContextSettingsId { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool DatabaseContextSettingsIdSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong ParentObjectId { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ParentObjectIdSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string BatchSqlHandle { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int StatementParameterizationType { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool StatementParameterizationTypeSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool SecurityPolicyApplied { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool SecurityPolicyAppliedSpecified { get; set; }
    }
}
