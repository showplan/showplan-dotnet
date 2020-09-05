using System.Xml.Serialization;

namespace Showplan.StatementBlocks
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("StmtReceiveType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class StmtReceive : BaseStmtInfo
    {
        /// <remarks/>
        [XmlArrayItem("Operation", IsNullable = false)]
        public ReceivePlanTypeOperation[] ReceivePlan { get; set; }
    }
}
