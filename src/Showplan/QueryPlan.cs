using System.Xml.Serialization;
using Showplan.RelOps;
using Showplan.StatementBlocks;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("QueryPlanType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class QueryPlan
    {
        /// <remarks/>
        public InternalInfo InternalInfo { get; set; }

        /// <remarks/>
        public ThreadStat ThreadStat { get; set; }

        /// <remarks/>
        [XmlArrayItem("MissingIndexGroup", IsNullable = false)]
        public MissingIndexGroup[] MissingIndexes { get; set; }

        /// <remarks/>
        public GuessedSelectivity GuessedSelectivity { get; set; }

        /// <remarks/>
        public UnmatchedIndexes UnmatchedIndexes { get; set; }

        /// <remarks/>
        public Warnings Warnings { get; set; }

        /// <remarks/>
        public MemoryGrant MemoryGrantInfo { get; set; }

        /// <remarks/>
        public OptimizerHardwareDependentProperties OptimizerHardwareDependentProperties { get; set; }

        /// <remarks/>
        [XmlArrayItem("StatisticsInfo", IsNullable = false)]
        public StatsInfo[] OptimizerStatsUsage { get; set; }

        /// <remarks/>
        [XmlElement("TraceFlags")]
        public TraceFlagList[] TraceFlags { get; set; }

        /// <remarks/>
        [XmlArrayItem("Wait", IsNullable = false)]
        public WaitStat[] WaitStats { get; set; }

        /// <remarks/>
        public QueryExecTime QueryTimeStats { get; set; }

        /// <remarks/>
        public RelOp RelOp { get; set; }

        /// <remarks/>
        [XmlArrayItem("ColumnReference", IsNullable = false)]
        public ColumnReference[] ParameterList { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int DegreeOfParallelism { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool DegreeOfParallelismSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int EffectiveDegreeOfParallelism { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool EffectiveDegreeOfParallelismSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string NonParallelPlanReason { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong MemoryGrant { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool MemoryGrantSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong CachedPlanSize { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool CachedPlanSizeSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong CompileTime { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool CompileTimeSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong CompileCpu { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool CompileCpuSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong CompileMemory { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool CompileMemorySpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool UsePlan { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool UsePlanSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool ContainsInterleavedExecutionCandidates { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ContainsInterleavedExecutionCandidatesSpecified { get; set; }

        [XmlIgnore()]
        public StmtSimple Statement { get; set; }
    }
}
