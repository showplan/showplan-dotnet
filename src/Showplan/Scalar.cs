using System.Xml.Serialization;
using Showplan.Scalars;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("ScalarType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class Scalar
    {
        /// <remarks/>
        [XmlElement("Aggregate", typeof(Aggregate))]
        [XmlElement("Arithmetic", typeof(Arithmetic))]
        [XmlElement("Assign", typeof(AssignType))]
        [XmlElement("Compare", typeof(Compare))]
        [XmlElement("Const", typeof(Const))]
        [XmlElement("Convert", typeof(Convert))]
        [XmlElement("IF", typeof(Conditional))]
        [XmlElement("Identifier", typeof(Ident))]
        [XmlElement("Intrinsic", typeof(Intrinsic))]
        [XmlElement("Logical", typeof(Logical))]
        [XmlElement("MultipleAssign", typeof(MultAssign))]
        [XmlElement("ScalarExpressionList", typeof(ScalarExpressionList))]
        [XmlElement("Sequence", typeof(ScalarSequence))]
        [XmlElement("Subquery", typeof(Subquery))]
        [XmlElement("UDTMethod", typeof(UdtMethod))]
        [XmlElement("UserDefinedAggregate", typeof(UdAggregate))]
        [XmlElement("UserDefinedFunction", typeof(Udf))]
        public object Item { get; set; }

        /// <remarks/>
        public InternalInfo InternalInfo { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string ScalarString { get; set; }
    }
}
