using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("WarningsType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class Warnings
    {
        /// <remarks/>
        [XmlElement("ColumnsWithNoStatistics", typeof(ColumnReferenceList))]
        [XmlElement("HashSpillDetails", typeof(HashSpillDetails))]
        [XmlElement("MemoryGrantWarning", typeof(MemoryGrantWarningInfo))]
        [XmlElement("PlanAffectingConvert", typeof(AffectingConvertWarning))]
        [XmlElement("SortSpillDetails", typeof(SortSpillDetails))]
        [XmlElement("SpillToTempDb", typeof(SpillToTempDb))]
        [XmlElement("Wait", typeof(WaitWarning))]
        public object[] Items { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool NoJoinPredicate { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool NoJoinPredicateSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool SpatialGuess { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool SpatialGuessSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool UnmatchedIndexes { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool UnmatchedIndexesSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool FullUpdateForOnlineIndexBuild { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool FullUpdateForOnlineIndexBuildSpecified { get; set; }
    }
}
