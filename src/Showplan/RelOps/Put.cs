using System.Xml.Serialization;

namespace Showplan.RelOps
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("PutType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class Put : RemoteQuery
    {
        /// <remarks/>
        [XmlAttribute()]
        public string ShuffleType { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string ShuffleColumn { get; set; }
    }
}
