using System.Xml.Serialization;

namespace Showplan.RelOps
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("TopSortType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class TopSort : Sort
    {
        /// <remarks/>
        [XmlAttribute()]
        public int Rows { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool WithTies { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool WithTiesSpecified { get; set; }
    }
}
