using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("TraceFlagListType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class TraceFlagList
    {
        /// <remarks/>
        [XmlElement("TraceFlag")]
        public TraceFlag[] TraceFlag { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool IsCompileTime { get; set; }
    }
}
