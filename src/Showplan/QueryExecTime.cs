using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("QueryExecTimeType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class QueryExecTime
    {
        /// <remarks/>
        [XmlAttribute()]
        public ulong CpuTime { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong ElapsedTime { get; set; }
    }
}
