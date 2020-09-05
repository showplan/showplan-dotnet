using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true,
        Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class ReceivePlanTypeOperation
    {
        /// <remarks/>
        public QueryPlan QueryPlan { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ReceivePlanTypeOperationOperationType OperationType { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool OperationTypeSpecified { get; set; }
    }
}
