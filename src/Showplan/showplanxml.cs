// ReSharper disable PartialTypeWithSinglePart

using System.Xml.Serialization;
using Showplan.StatementBlocks;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true,
        Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    [XmlRoot(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan",
        IsNullable = false)]
    public partial class ShowPlanXML
    {
        /// <remarks/>
        [XmlArrayItem("Batch", IsNullable = false)]
        [XmlArrayItem("Statements", IsNullable = false, NestingLevel = 1)]
        public StmtBlock[][] BatchSequence { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Version { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Build { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool ClusteredMode { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ClusteredModeSpecified { get; set; }
    }
}
