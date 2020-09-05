using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("TraceFlagType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class TraceFlag
    {
        /// <remarks/>
        [XmlAttribute()]
        public ulong Value { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public TraceFlagScope Scope { get; set; }
    }
}
