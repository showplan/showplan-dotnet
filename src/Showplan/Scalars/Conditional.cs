using System.Xml.Serialization;

namespace Showplan.Scalars
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("ConditionalType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class Conditional
    {
        /// <remarks/>
        public ScalarExpression Condition { get; set; }

        /// <remarks/>
        public ScalarExpression Then { get; set; }

        /// <remarks/>
        public ScalarExpression Else { get; set; }
    }
}
