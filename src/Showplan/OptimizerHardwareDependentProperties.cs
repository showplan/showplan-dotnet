using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("OptimizerHardwareDependentPropertiesType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class OptimizerHardwareDependentProperties
    {
        /// <remarks/>
        [XmlAttribute()]
        public ulong EstimatedAvailableMemoryGrant { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong EstimatedPagesCached { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong EstimatedAvailableDegreeOfParallelism { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool EstimatedAvailableDegreeOfParallelismSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong MaxCompileMemory { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool MaxCompileMemorySpecified { get; set; }
    }
}
