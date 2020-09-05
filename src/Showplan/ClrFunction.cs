using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("ClrFunctionType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class ClrFunction
    {
        /// <remarks/>
        [XmlAttribute()]
        public string Assembly { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Class { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Method { get; set; }
    }
}
