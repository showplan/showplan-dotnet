using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("SetOptionsType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class SetOptions
    {
        /// <remarks/>
        [XmlAttribute()]
        public bool AnsiNulls { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool AnsiNullsSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool AnsiPadding { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool AnsiPaddingSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool AnsiWarnings { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool AnsiWarningsSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool Arithabort { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ArithabortSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool ConcatNullYieldsNull { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ConcatNullYieldsNullSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool NumericRoundabort { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool NumericRoundabortSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool QuotedIdentifier { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool QuotedIdentifierSpecified { get; set; }
    }
}
