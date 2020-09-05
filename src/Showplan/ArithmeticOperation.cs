using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType("ArithmeticOperationType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public enum ArithmeticOperation
    {
        /// <remarks/>
        [XmlEnum("ADD")] Add,

        /// <remarks/>
        [XmlEnum("BIT_ADD")] BitAdd,

        /// <remarks/>
        [XmlEnum("BIT_AND")] BitAnd,

        /// <remarks/>
        [XmlEnum("BIT_COMBINE")] BitCombine,

        /// <remarks/>
        [XmlEnum("BIT_NOT")] BitNot,

        /// <remarks/>
        [XmlEnum("BIT_OR")] BitOr,

        /// <remarks/>
        [XmlEnum("BIT_XOR")] BitXor,

        /// <remarks/>
        [XmlEnum("DIV")] Div,

        /// <remarks/>
        [XmlEnum("HASH")] Hash,

        /// <remarks/>
        [XmlEnum("MINUS")] Minus,

        /// <remarks/>
        [XmlEnum("MOD")] Mod,

        /// <remarks/>
        [XmlEnum("MULT")] Mult,

        /// <remarks/>
        [XmlEnum("SUB")] Sub,
    }
}
