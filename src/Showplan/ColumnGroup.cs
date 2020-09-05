using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("ColumnGroupType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class ColumnGroup
    {
        /// <remarks/>
        [XmlElement("Column")]
        public Column[] Column { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ColumnGroupTypeUsage Usage { get; set; }
    }
}
