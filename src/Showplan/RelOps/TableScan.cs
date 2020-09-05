using System.Xml.Serialization;

namespace Showplan.RelOps
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("TableScanType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class TableScan : Rowset
    {
        /// <remarks/>
        public ScalarExpression Predicate { get; set; }

        /// <remarks/>
        public SingleColumnReference PartitionId { get; set; }

        /// <remarks/>
        [XmlArrayItem("Object", IsNullable = false)]
        public DatabaseObject[] IndexedViewInfo { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool Ordered { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool ForcedIndex { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ForcedIndexSpecified { get; set; }

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
    }
}
