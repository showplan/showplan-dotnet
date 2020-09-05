using System.Xml.Serialization;

namespace Showplan.RelOps
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("UdxType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class Udx : RelOpBase
    {
        /// <remarks/>
        [XmlArrayItem("ColumnReference", IsNullable = false)]
        public ColumnReference[] UsedUdxColumns { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string UdxName { get; set; }
    }
}
