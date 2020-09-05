using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("InternalInfoType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class InternalInfo
    {
        /// <remarks/>
        [XmlAnyElement()]
        public System.Xml.XmlElement[] Any { get; set; }

        /// <remarks/>
        [XmlAnyAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr { get; set; }
    }
}
