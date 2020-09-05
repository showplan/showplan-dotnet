using System.Xml.Serialization;

namespace Showplan.RelOps
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("UpdateType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class Update : Rowset
    {
        /// <remarks/>
        [XmlElement("SetPredicate")]
        public SetPredicateElement[] SetPredicate { get; set; }

        /// <remarks/>
        public SingleColumnReference ProbeColumn { get; set; }

        /// <remarks/>
        public SingleColumnReference ActionColumn { get; set; }

        /// <remarks/>
        public SingleColumnReference OriginalActionColumn { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool WithOrderedPrefetch { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool WithOrderedPrefetchSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool WithUnorderedPrefetch { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool WithUnorderedPrefetchSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool DmlRequestSort { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool DmlRequestSortSpecified { get; set; }
    }
}
