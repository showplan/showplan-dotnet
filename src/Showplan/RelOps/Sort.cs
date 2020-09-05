using System.Xml.Serialization;

namespace Showplan.RelOps
{
    /// <remarks/>
    [XmlInclude(typeof(TopSort))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("SortType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class Sort : RelOpBase
    {
        /// <remarks/>
        [XmlArrayItem("OrderByColumn", IsNullable = false)]
        public OrderByTypeOrderByColumn[] OrderBy { get; set; }

        /// <remarks/>
        public SingleColumnReference PartitionId { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool Distinct { get; set; }
    }
}
