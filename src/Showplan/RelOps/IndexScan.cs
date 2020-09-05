using System.Xml.Serialization;

namespace Showplan.RelOps
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("IndexScanType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class IndexScan : Rowset
    {
        /// <remarks/>
        public SeekPredicates SeekPredicates { get; set; }

        /// <remarks/>
        [XmlElement("Predicate")]
        public ScalarExpression[] Predicate { get; set; }

        /// <remarks/>
        public SingleColumnReference PartitionId { get; set; }

        /// <remarks/>
        [XmlArrayItem("Object", IsNullable = false)]
        public DatabaseObject[] IndexedViewInfo { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool Lookup { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool LookupSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool Ordered { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public Order ScanDirection { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ScanDirectionSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool ForcedIndex { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ForcedIndexSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool ForceSeek { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ForceSeekSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int ForceSeekColumnCount { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ForceSeekColumnCountSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool ForceScan { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ForceScanSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool NoExpandHint { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool NoExpandHintSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public Storage Storage { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool StorageSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool DynamicSeek { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool DynamicSeekSpecified { get; set; }
    }
}
