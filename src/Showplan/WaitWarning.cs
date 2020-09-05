using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("WaitWarningType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class WaitWarning
    {
        /// <remarks/>
        [XmlAttribute()]
        public WaitWarningWaitType WaitType { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong WaitTime { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool WaitTimeSpecified { get; set; }
    }
}
