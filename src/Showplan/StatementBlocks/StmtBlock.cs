using System.Xml.Serialization;

namespace Showplan.StatementBlocks
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("StmtBlockType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class StmtBlock
    {
        /// <remarks/>
        [XmlElement("StmtCond", typeof(StmtCond))]
        [XmlElement("StmtCursor", typeof(StmtCursor))]
        [XmlElement("StmtReceive", typeof(StmtReceive))]
        [XmlElement("StmtSimple", typeof(StmtSimple))]
        [XmlElement("StmtUseDb", typeof(StmtUseDb))]
        public BaseStmtInfo[] Items { get; set; }
    }
}
