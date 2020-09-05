using System.Xml.Serialization;

namespace Showplan.RelOps
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("ForeignKeyReferencesCheckType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class ForeignKeyReferencesCheck : RelOpBase
    {
        /// <remarks/>
        [XmlElement("ForeignKeyReferenceCheck")]
        public ForeignKeyReferenceCheck[] ForeignKeyReferenceCheck { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int ForeignKeyReferencesCount { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ForeignKeyReferencesCountSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int NoMatchingIndexCount { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool NoMatchingIndexCountSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int PartialMatchingIndexCount { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool PartialMatchingIndexCountSpecified { get; set; }
    }
}
