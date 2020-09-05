using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("ObjectType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class DatabaseObject
    {
        /// <remarks/>
        [XmlAttribute()]
        public string Server { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Database { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Schema { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Table { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Index { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool Filtered { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool FilteredSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Alias { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int TableReferenceId { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool TableReferenceIdSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public IndexKind IndexKind { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool IndexKindSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public CloneAccessScope CloneAccessScope { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool CloneAccessScopeSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public Storage Storage { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool StorageSpecified { get; set; }
    }
}
