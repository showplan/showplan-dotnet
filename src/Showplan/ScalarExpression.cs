using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [XmlInclude(typeof(SetPredicateElement))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("ScalarExpressionType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class ScalarExpression
    {
        /// <remarks/>
        public Scalar ScalarOperator { get; set; }
    }
}
