using System.Xml.Serialization;
using Showplan.StatementBlocks;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("FunctionType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class Function
    {
        /// <remarks/>
        public StmtBlock Statements { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string ProcName { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool IsNativelyCompiled { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool IsNativelyCompiledSpecified { get; set; }
    }
}
