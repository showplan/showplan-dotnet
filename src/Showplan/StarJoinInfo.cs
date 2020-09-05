using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("StarJoinInfoType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class StarJoinInfo
    {
        /// <remarks/>
        [XmlAttribute()]
        public bool Root { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool RootSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public StarJoinInfoTypeOperationType OperationType { get; set; }
    }
}
