using System.Xml.Serialization;

namespace Showplan.RelOps
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("TableValuedFunctionType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class TableValuedFunction : RelOpBase
    {
        /// <remarks/>
        public DatabaseObject Object { get; set; }

        /// <remarks/>
        public ScalarExpression Predicate { get; set; }

        /// <remarks/>
        [XmlArrayItem("ScalarOperator", IsNullable = false)]
        public Scalar[] ParameterList { get; set; }
    }
}
