using System.Xml.Serialization;

namespace Showplan.RelOps
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("StreamAggregateType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class StreamAggregate : RelOpBase
    {
        /// <remarks/>
        [XmlArrayItem("ColumnReference", IsNullable = false)]
        public ColumnReference[] GroupBy { get; set; }

        /// <remarks/>
        public RollupInfo RollupInfo { get; set; }
    }
}
