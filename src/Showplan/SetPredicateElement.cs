using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("SetPredicateElementType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class SetPredicateElement : ScalarExpression
    {
        /// <remarks/>
        [XmlAttribute()]
        public SetPredicate SetPredicateType { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool SetPredicateTypeSpecified { get; set; }
    }
}
