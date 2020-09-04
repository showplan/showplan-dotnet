// ReSharper disable PartialTypeWithSinglePart

using System.Xml.Serialization;

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
        public StmtBlockType[][] BatchSequence { get; set; }

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

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class StmtBlockType
    {
        /// <remarks/>
        [XmlElement("StmtCond", typeof(StmtCondType))]
        [XmlElement("StmtCursor", typeof(StmtCursorType))]
        [XmlElement("StmtReceive", typeof(StmtReceiveType))]
        [XmlElement("StmtSimple", typeof(StmtSimpleType))]
        [XmlElement("StmtUseDb", typeof(StmtUseDbType))]
        public BaseStmtInfoType[] Items { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class StmtCondType : BaseStmtInfoType
    {
        /// <remarks/>
        public StmtCondTypeCondition Condition { get; set; }

        /// <remarks/>
        public StmtCondTypeThen Then { get; set; }

        /// <remarks/>
        public StmtCondTypeElse Else { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true,
        Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class StmtCondTypeCondition
    {
        /// <remarks/>
        public QueryPlanType QueryPlan { get; set; }

        /// <remarks/>
        [XmlElement("UDF")]
        public FunctionType[] Udf { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class QueryPlanType
    {
        /// <remarks/>
        public InternalInfoType InternalInfo { get; set; }

        /// <remarks/>
        public ThreadStatType ThreadStat { get; set; }

        /// <remarks/>
        [XmlArrayItem("MissingIndexGroup", IsNullable = false)]
        public MissingIndexGroupType[] MissingIndexes { get; set; }

        /// <remarks/>
        public GuessedSelectivityType GuessedSelectivity { get; set; }

        /// <remarks/>
        public UnmatchedIndexesType UnmatchedIndexes { get; set; }

        /// <remarks/>
        public WarningsType Warnings { get; set; }

        /// <remarks/>
        public MemoryGrantType MemoryGrantInfo { get; set; }

        /// <remarks/>
        public OptimizerHardwareDependentPropertiesType OptimizerHardwareDependentProperties { get; set; }

        /// <remarks/>
        [XmlArrayItem("StatisticsInfo", IsNullable = false)]
        public StatsInfoType[] OptimizerStatsUsage { get; set; }

        /// <remarks/>
        [XmlElement("TraceFlags")]
        public TraceFlagListType[] TraceFlags { get; set; }

        /// <remarks/>
        [XmlArrayItem("Wait", IsNullable = false)]
        public WaitStatType[] WaitStats { get; set; }

        /// <remarks/>
        public QueryExecTimeType QueryTimeStats { get; set; }

        /// <remarks/>
        public RelOpType RelOp { get; set; }

        /// <remarks/>
        [XmlArrayItem("ColumnReference", IsNullable = false)]
        public ColumnReferenceType[] ParameterList { get; set; }

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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class InternalInfoType
    {
        /// <remarks/>
        [XmlAnyElement()]
        public System.Xml.XmlElement[] Any { get; set; }

        /// <remarks/>
        [XmlAnyAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class CursorPlanType
    {
        /// <remarks/>
        [XmlElement("Operation")]
        public CursorPlanTypeOperation[] Operation { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string CursorName { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public CursorType CursorActualType { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool CursorActualTypeSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public CursorType CursorRequestedType { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool CursorRequestedTypeSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public CursorPlanTypeCursorConcurrency CursorConcurrency { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool CursorConcurrencySpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool ForwardOnly { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ForwardOnlySpecified { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true,
        Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class CursorPlanTypeOperation
    {
        /// <remarks/>
        public QueryPlanType QueryPlan { get; set; }

        /// <remarks/>
        [XmlElement("UDF")]
        public FunctionType[] Udf { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public CursorPlanTypeOperationOperationType OperationType { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class FunctionType
    {
        /// <remarks/>
        public StmtBlockType Statements { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string ProcName { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool IsNativelyCompiled { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool IsNativelyCompiledSpecified { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true,
        Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public enum CursorPlanTypeOperationOperationType
    {
        /// <remarks/>
        FetchQuery,

        /// <remarks/>
        PopulateQuery,

        /// <remarks/>
        RefreshQuery,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public enum CursorType
    {
        /// <remarks/>
        Dynamic,

        /// <remarks/>
        FastForward,

        /// <remarks/>
        Keyset,

        /// <remarks/>
        SnapShot,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true,
        Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public enum CursorPlanTypeCursorConcurrency
    {
        /// <remarks/>
        [XmlEnum("Read Only")] ReadOnly,

        /// <remarks/>
        Pessimistic,

        /// <remarks/>
        Optimistic,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class QueryExecTimeType
    {
        /// <remarks/>
        [XmlAttribute()]
        public ulong CpuTime { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong ElapsedTime { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class WaitStatType
    {
        /// <remarks/>
        [XmlAttribute()]
        public string WaitType { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong WaitTimeMs { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong WaitCount { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class TraceFlagType
    {
        /// <remarks/>
        [XmlAttribute()]
        public ulong Value { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public TraceFlagScopeType Scope { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public enum TraceFlagScopeType
    {
        /// <remarks/>
        Global,

        /// <remarks/>
        Session,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class TraceFlagListType
    {
        /// <remarks/>
        [XmlElement("TraceFlag")]
        public TraceFlagType[] TraceFlag { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool IsCompileTime { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class StatsInfoType
    {
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
        public string Statistics { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong ModificationCount { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public double SamplingPercent { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public System.DateTime LastUpdate { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool LastUpdateSpecified { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class OptimizerHardwareDependentPropertiesType
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

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class MemoryGrantType
    {
        /// <remarks/>
        [XmlAttribute()]
        public ulong SerialRequiredMemory { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong SerialDesiredMemory { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong RequiredMemory { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool RequiredMemorySpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong DesiredMemory { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool DesiredMemorySpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong RequestedMemory { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool RequestedMemorySpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong GrantWaitTime { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool GrantWaitTimeSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong GrantedMemory { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool GrantedMemorySpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong MaxUsedMemory { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool MaxUsedMemorySpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong MaxQueryMemory { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool MaxQueryMemorySpecified { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class MemoryGrantWarningInfo
    {
        /// <remarks/>
        [XmlAttribute()]
        public MemoryGrantWarningType GrantWarningKind { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong RequestedMemory { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong GrantedMemory { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong MaxUsedMemory { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public enum MemoryGrantWarningType
    {
        /// <remarks/>
        [XmlEnum("Excessive Grant")] ExcessiveGrant,

        /// <remarks/>
        [XmlEnum("Used More Than Granted")] UsedMoreThanGranted,

        /// <remarks/>
        [XmlEnum("Grant Increase")] GrantIncrease,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class HashSpillDetailsType
    {
        /// <remarks/>
        [XmlAttribute()]
        public ulong GrantedMemoryKb { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool GrantedMemoryKbSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong UsedMemoryKb { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool UsedMemoryKbSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong WritesToTempDb { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool WritesToTempDbSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong ReadsFromTempDb { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ReadsFromTempDbSpecified { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class SortSpillDetailsType
    {
        /// <remarks/>
        [XmlAttribute()]
        public ulong GrantedMemoryKb { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool GrantedMemoryKbSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong UsedMemoryKb { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool UsedMemoryKbSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong WritesToTempDb { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool WritesToTempDbSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong ReadsFromTempDb { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ReadsFromTempDbSpecified { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class AffectingConvertWarningType
    {
        /// <remarks/>
        [XmlAttribute()]
        public AffectingConvertWarningTypeConvertIssue ConvertIssue { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Expression { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true,
        Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public enum AffectingConvertWarningTypeConvertIssue
    {
        /// <remarks/>
        [XmlEnum("Cardinality Estimate")] CardinalityEstimate,

        /// <remarks/>
        [XmlEnum("Seek Plan")] SeekPlan,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class WaitWarningType
    {
        /// <remarks/>
        [XmlAttribute()]
        public WaitWarningTypeWaitType WaitType { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong WaitTime { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool WaitTimeSpecified { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true,
        Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public enum WaitWarningTypeWaitType
    {
        /// <remarks/>
        [XmlEnum("Memory Grant")] MemoryGrant,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class SpillToTempDbType
    {
        /// <remarks/>
        [XmlAttribute()]
        public ulong SpillLevel { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool SpillLevelSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong SpilledThreadCount { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool SpilledThreadCountSpecified { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(TypeName = "ColumnReferenceListType",
        Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class ColumnReferenceListType1
    {
        /// <remarks/>
        [XmlElement("ColumnReference")]
        public ColumnReferenceType[] ColumnReference { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class ColumnReferenceType
    {
        /// <remarks/>
        public ScalarType ScalarOperator { get; set; }

        /// <remarks/>
        public InternalInfoType InternalInfo { get; set; }

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
        public string Alias { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Column { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool ComputedColumn { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ComputedColumnSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string ParameterDataType { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string ParameterCompiledValue { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string ParameterRuntimeValue { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class ScalarType
    {
        /// <remarks/>
        [XmlElement("Aggregate", typeof(AggregateType))]
        [XmlElement("Arithmetic", typeof(ArithmeticType))]
        [XmlElement("Assign", typeof(AssignType))]
        [XmlElement("Compare", typeof(CompareType))]
        [XmlElement("Const", typeof(ConstType))]
        [XmlElement("Convert", typeof(ConvertType))]
        [XmlElement("IF", typeof(ConditionalType))]
        [XmlElement("Identifier", typeof(IdentType))]
        [XmlElement("Intrinsic", typeof(IntrinsicType))]
        [XmlElement("Logical", typeof(LogicalType))]
        [XmlElement("MultipleAssign", typeof(MultAssignType))]
        [XmlElement("ScalarExpressionList", typeof(ScalarExpressionListType))]
        [XmlElement("Sequence", typeof(ScalarSequenceType))]
        [XmlElement("Subquery", typeof(SubqueryType))]
        [XmlElement("UDTMethod", typeof(UdtMethodType))]
        [XmlElement("UserDefinedAggregate", typeof(UdAggregateType))]
        [XmlElement("UserDefinedFunction", typeof(UdfType))]
        public object Item { get; set; }

        /// <remarks/>
        public InternalInfoType InternalInfo { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string ScalarString { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class AggregateType
    {
        /// <remarks/>
        [XmlElement("ScalarOperator")]
        public ScalarType[] ScalarOperator { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string AggType { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool Distinct { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class ArithmeticType
    {
        /// <remarks/>
        [XmlElement("ScalarOperator")]
        public ScalarType[] ScalarOperator { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ArithmeticOperationType Operation { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public enum ArithmeticOperationType
    {
        /// <remarks/>
        [XmlEnum("ADD")] Add,

        /// <remarks/>
        [XmlEnum("BIT_ADD")] BitAdd,

        /// <remarks/>
        [XmlEnum("BIT_AND")] BitAnd,

        /// <remarks/>
        [XmlEnum("BIT_COMBINE")] BitCombine,

        /// <remarks/>
        [XmlEnum("BIT_NOT")] BitNot,

        /// <remarks/>
        [XmlEnum("BIT_OR")] BitOr,

        /// <remarks/>
        [XmlEnum("BIT_XOR")] BitXor,

        /// <remarks/>
        [XmlEnum("DIV")] Div,

        /// <remarks/>
        [XmlEnum("HASH")] Hash,

        /// <remarks/>
        [XmlEnum("MINUS")] Minus,

        /// <remarks/>
        [XmlEnum("MOD")] Mod,

        /// <remarks/>
        [XmlEnum("MULT")] Mult,

        /// <remarks/>
        [XmlEnum("SUB")] Sub,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class AssignType
    {
        /// <remarks/>
        [XmlElement("ColumnReference", typeof(ColumnReferenceType), Order = 0)]
        [XmlElement("ScalarOperator", typeof(ScalarType), Order = 0)]
        public object Item { get; set; }

        /// <remarks/>
        [XmlElement(Order = 1)]
        public ScalarType ScalarOperator { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class CompareType
    {
        /// <remarks/>
        [XmlElement("ScalarOperator")]
        public ScalarType[] ScalarOperator { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public CompareOpType CompareOp { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public enum CompareOpType
    {
        /// <remarks/>
        [XmlEnum("BINARY IS")] BinaryIs,

        /// <remarks/>
        [XmlEnum("BOTH NULL")] BothNull,

        /// <remarks/>
        [XmlEnum("EQ")] Eq,

        /// <remarks/>
        [XmlEnum("GE")] Ge,

        /// <remarks/>
        [XmlEnum("GT")] Gt,

        /// <remarks/>
        [XmlEnum("IS")] Is,

        /// <remarks/>
        [XmlEnum("IS NOT")] IsNot,

        /// <remarks/>
        [XmlEnum("IS NOT NULL")] IsNotNull,

        /// <remarks/>
        [XmlEnum("IS NULL")] IsNull,

        /// <remarks/>
        [XmlEnum("LE")] Le,

        /// <remarks/>
        [XmlEnum("LT")] Lt,

        /// <remarks/>
        [XmlEnum("NE")] Ne,

        /// <remarks/>
        [XmlEnum("ONE NULL")] OneNull,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class ConstType
    {
        /// <remarks/>
        [XmlAttribute()]
        public string ConstValue { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class ConvertType
    {
        /// <remarks/>
        public ScalarExpressionType Style { get; set; }

        /// <remarks/>
        public ScalarType ScalarOperator { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string DataType { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int Length { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool LengthSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int Precision { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool PrecisionSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int Scale { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ScaleSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute("Style")]
        public int Style1 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool Implicit { get; set; }
    }

    /// <remarks/>
    [XmlInclude(typeof(SetPredicateElementType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class ScalarExpressionType
    {
        /// <remarks/>
        public ScalarType ScalarOperator { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class SetPredicateElementType : ScalarExpressionType
    {
        /// <remarks/>
        [XmlAttribute()]
        public SetPredicateType SetPredicateType { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool SetPredicateTypeSpecified { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public enum SetPredicateType
    {
        /// <remarks/>
        Update,

        /// <remarks/>
        Insert,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class ConditionalType
    {
        /// <remarks/>
        public ScalarExpressionType Condition { get; set; }

        /// <remarks/>
        public ScalarExpressionType Then { get; set; }

        /// <remarks/>
        public ScalarExpressionType Else { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class IdentType
    {
        /// <remarks/>
        public ColumnReferenceType ColumnReference { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Table { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class IntrinsicType
    {
        /// <remarks/>
        [XmlElement("ScalarOperator")]
        public ScalarType[] ScalarOperator { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string FunctionName { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class LogicalType
    {
        /// <remarks/>
        [XmlElement("ScalarOperator")]
        public ScalarType[] ScalarOperator { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public LogicalOperationType Operation { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public enum LogicalOperationType
    {
        /// <remarks/>
        [XmlEnum("AND")] And,

        /// <remarks/>
        [XmlEnum("IMPLIES")] Implies,

        /// <remarks/>
        [XmlEnum("IS NOT NULL")] IsNotNull,

        /// <remarks/>
        [XmlEnum("IS NULL")] Isnull,

        /// <remarks/>
        [XmlEnum("IS")] Is,

        /// <remarks/>
        [XmlEnum("IsFalseOrNull")] IsFalseOrNull,

        /// <remarks/>
        [XmlEnum("NOT")] Not,

        /// <remarks/>
        [XmlEnum("OR")] Or,

        /// <remarks/>
        [XmlEnum("XOR")] Xor,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class MultAssignType
    {
        /// <remarks/>
        [XmlElement("Assign")]
        public AssignType[] Assign { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class ScalarExpressionListType
    {
        /// <remarks/>
        [XmlElement("ScalarOperator")]
        public ScalarType[] ScalarOperator { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class ScalarSequenceType
    {
        /// <remarks/>
        [XmlAttribute()]
        public string FunctionName { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class SubqueryType
    {
        /// <remarks/>
        public ScalarType ScalarOperator { get; set; }

        /// <remarks/>
        public RelOpType RelOp { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public SubqueryOperationType Operation { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class RelOpType
    {
        /// <remarks/>
        [XmlArrayItem("ColumnReference", IsNullable = false)]
        public ColumnReferenceType[] OutputList { get; set; }

        /// <remarks/>
        public WarningsType Warnings { get; set; }

        /// <remarks/>
        public MemoryFractionsType MemoryFractions { get; set; }

        /// <remarks/>
        [XmlArrayItem("RunTimeCountersPerThread", IsNullable = false)]
        public RunTimeInformationTypeRunTimeCountersPerThread[] RunTimeInformation { get; set; }

        /// <remarks/>
        public RunTimePartitionSummaryType RunTimePartitionSummary { get; set; }

        /// <remarks/>
        public InternalInfoType InternalInfo { get; set; }

        /// <remarks/>
        [XmlElement("AdaptiveJoin", typeof(AdaptiveJoinType))]
        [XmlElement("Assert", typeof(FilterType))]
        [XmlElement("BatchHashTableBuild", typeof(BatchHashTableBuildType))]
        [XmlElement("Bitmap", typeof(BitmapType))]
        [XmlElement("Collapse", typeof(CollapseType))]
        [XmlElement("ComputeScalar", typeof(ComputeScalarType))]
        [XmlElement("Concat", typeof(ConcatType))]
        [XmlElement("ConstantScan", typeof(ConstantScanType))]
        [XmlElement("CreateIndex", typeof(CreateIndexType))]
        [XmlElement("DeletedScan", typeof(RowsetType))]
        [XmlElement("Extension", typeof(UdxType))]
        [XmlElement("Filter", typeof(FilterType))]
        [XmlElement("ForeignKeyReferencesCheck", typeof(ForeignKeyReferencesCheckType))]
        [XmlElement("Generic", typeof(GenericType))]
        [XmlElement("Hash", typeof(HashType))]
        [XmlElement("IndexScan", typeof(IndexScanType))]
        [XmlElement("InsertedScan", typeof(RowsetType))]
        [XmlElement("LogRowScan", typeof(RelOpBaseType))]
        [XmlElement("Merge", typeof(MergeType))]
        [XmlElement("MergeInterval", typeof(SimpleIteratorOneChildType))]
        [XmlElement("NestedLoops", typeof(NestedLoopsType))]
        [XmlElement("OnlineIndex", typeof(CreateIndexType))]
        [XmlElement("Parallelism", typeof(ParallelismType))]
        [XmlElement("ParameterTableScan", typeof(RelOpBaseType))]
        [XmlElement("PrintDataflow", typeof(RelOpBaseType))]
        [XmlElement("Put", typeof(PutType))]
        [XmlElement("RemoteFetch", typeof(RemoteFetchType))]
        [XmlElement("RemoteModify", typeof(RemoteModifyType))]
        [XmlElement("RemoteQuery", typeof(RemoteQueryType))]
        [XmlElement("RemoteRange", typeof(RemoteRangeType))]
        [XmlElement("RemoteScan", typeof(RemoteType))]
        [XmlElement("RowCountSpool", typeof(SpoolType))]
        [XmlElement("ScalarInsert", typeof(ScalarInsertType))]
        [XmlElement("Segment", typeof(SegmentType))]
        [XmlElement("Sequence", typeof(SequenceType))]
        [XmlElement("SequenceProject", typeof(ComputeScalarType))]
        [XmlElement("SimpleUpdate", typeof(SimpleUpdateType))]
        [XmlElement("Sort", typeof(SortType))]
        [XmlElement("Split", typeof(SplitType))]
        [XmlElement("Spool", typeof(SpoolType))]
        [XmlElement("StreamAggregate", typeof(StreamAggregateType))]
        [XmlElement("Switch", typeof(SwitchType))]
        [XmlElement("TableScan", typeof(TableScanType))]
        [XmlElement("TableValuedFunction", typeof(TableValuedFunctionType))]
        [XmlElement("Top", typeof(TopType))]
        [XmlElement("TopSort", typeof(TopSortType))]
        [XmlElement("Update", typeof(UpdateType))]
        [XmlElement("WindowAggregate", typeof(WindowAggregateType))]
        [XmlElement("WindowSpool", typeof(WindowType))]
        [XmlChoiceIdentifier("ItemElementName")]
        public RelOpBaseType Item { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public ItemChoiceType ItemElementName { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public double AvgRowSize { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public double EstimateCpu { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public double EstimateIo { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public double EstimateRebinds { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public double EstimateRewinds { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ExecutionModeType EstimatedExecutionMode { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool EstimatedExecutionModeSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool GroupExecuted { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool GroupExecutedSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public double EstimateRows { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public double EstimatedRowsRead { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool EstimatedRowsReadSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public LogicalOpType LogicalOp { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int NodeId { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool Parallel { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool RemoteDataAccess { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool RemoteDataAccessSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool Partitioned { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool PartitionedSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public PhysicalOpType PhysicalOp { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool IsAdaptive { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool IsAdaptiveSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public double AdaptiveThresholdRows { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool AdaptiveThresholdRowsSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public double EstimatedTotalSubtreeCost { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public double TableCardinality { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool TableCardinalitySpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong StatsCollectionId { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool StatsCollectionIdSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public PhysicalOpType EstimatedJoinType { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool EstimatedJoinTypeSpecified { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class WarningsType
    {
        /// <remarks/>
        [XmlElement("ColumnsWithNoStatistics", typeof(ColumnReferenceListType1))]
        [XmlElement("HashSpillDetails", typeof(HashSpillDetailsType))]
        [XmlElement("MemoryGrantWarning", typeof(MemoryGrantWarningInfo))]
        [XmlElement("PlanAffectingConvert", typeof(AffectingConvertWarningType))]
        [XmlElement("SortSpillDetails", typeof(SortSpillDetailsType))]
        [XmlElement("SpillToTempDb", typeof(SpillToTempDbType))]
        [XmlElement("Wait", typeof(WaitWarningType))]
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

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class MemoryFractionsType
    {
        /// <remarks/>
        [XmlAttribute()]
        public double Input { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public double Output { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true,
        Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class RunTimeInformationTypeRunTimeCountersPerThread
    {
        /// <remarks/>
        [XmlAttribute()]
        public int Thread { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int BrickId { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool BrickIdSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong ActualRebinds { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ActualRebindsSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong ActualRewinds { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ActualRewindsSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong ActualRows { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong ActualRowsRead { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ActualRowsReadSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong Batches { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool BatchesSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong ActualEndOfScans { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong ActualExecutions { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ExecutionModeType ActualExecutionMode { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ActualExecutionModeSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong TaskAddr { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool TaskAddrSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong SchedulerId { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool SchedulerIdSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong FirstActiveTime { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool FirstActiveTimeSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong LastActiveTime { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool LastActiveTimeSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong OpenTime { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool OpenTimeSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong FirstRowTime { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool FirstRowTimeSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong LastRowTime { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool LastRowTimeSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong CloseTime { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool CloseTimeSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong ActualElapsedms { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ActualElapsedmsSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong ActualCpUms { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ActualCpUmsSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong ActualScans { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ActualScansSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong ActualLogicalReads { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ActualLogicalReadsSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong ActualPhysicalReads { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ActualPhysicalReadsSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong ActualReadAheads { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ActualReadAheadsSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong ActualLobLogicalReads { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ActualLobLogicalReadsSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong ActualLobPhysicalReads { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ActualLobPhysicalReadsSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong ActualLobReadAheads { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ActualLobReadAheadsSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int SegmentReads { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool SegmentReadsSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int SegmentSkips { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool SegmentSkipsSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong ActualLocallyAggregatedRows { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ActualLocallyAggregatedRowsSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong InputMemoryGrant { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool InputMemoryGrantSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong OutputMemoryGrant { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool OutputMemoryGrantSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong UsedMemoryGrant { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool UsedMemoryGrantSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool IsInterleavedExecuted { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool IsInterleavedExecutedSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public PhysicalOpType ActualJoinType { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ActualJoinTypeSpecified { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public enum ExecutionModeType
    {
        /// <remarks/>
        Row,

        /// <remarks/>
        Batch,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public enum PhysicalOpType
    {
        /// <remarks/>
        [XmlEnum("Adaptive Join")] AdaptiveJoin,

        /// <remarks/>
        Assert,

        /// <remarks/>
        [XmlEnum("Batch Hash Table Build")] BatchHashTableBuild,

        /// <remarks/>
        Bitmap,

        /// <remarks/>
        [XmlEnum("Clustered Index Delete")] ClusteredIndexDelete,

        /// <remarks/>
        [XmlEnum("Clustered Index Insert")] ClusteredIndexInsert,

        /// <remarks/>
        [XmlEnum("Clustered Index Scan")] ClusteredIndexScan,

        /// <remarks/>
        [XmlEnum("Clustered Index Seek")] ClusteredIndexSeek,

        /// <remarks/>
        [XmlEnum("Clustered Index Update")] ClusteredIndexUpdate,

        /// <remarks/>
        [XmlEnum("Clustered Index Merge")] ClusteredIndexMerge,

        /// <remarks/>
        [XmlEnum("Clustered Update")] ClusteredUpdate,

        /// <remarks/>
        Collapse,

        /// <remarks/>
        [XmlEnum("Columnstore Index Delete")] ColumnstoreIndexDelete,

        /// <remarks/>
        [XmlEnum("Columnstore Index Insert")] ColumnstoreIndexInsert,

        /// <remarks/>
        [XmlEnum("Columnstore Index Merge")] ColumnstoreIndexMerge,

        /// <remarks/>
        [XmlEnum("Columnstore Index Scan")] ColumnstoreIndexScan,

        /// <remarks/>
        [XmlEnum("Columnstore Index Update")] ColumnstoreIndexUpdate,

        /// <remarks/>
        [XmlEnum("Compute Scalar")] ComputeScalar,

        /// <remarks/>
        Concatenation,

        /// <remarks/>
        [XmlEnum("Constant Scan")] ConstantScan,

        /// <remarks/>
        [XmlEnum("Deleted Scan")] DeletedScan,

        /// <remarks/>
        Filter,

        /// <remarks/>
        [XmlEnum("Foreign Key References Check")]
        ForeignKeyReferencesCheck,

        /// <remarks/>
        Generic,

        /// <remarks/>
        [XmlEnum("Hash Match")] HashMatch,

        /// <remarks/>
        [XmlEnum("Index Delete")] IndexDelete,

        /// <remarks/>
        [XmlEnum("Index Insert")] IndexInsert,

        /// <remarks/>
        [XmlEnum("Index Scan")] IndexScan,

        /// <remarks/>
        [XmlEnum("Index Seek")] IndexSeek,

        /// <remarks/>
        [XmlEnum("Index Spool")] IndexSpool,

        /// <remarks/>
        [XmlEnum("Index Update")] IndexUpdate,

        /// <remarks/>
        [XmlEnum("Inserted Scan")] InsertedScan,

        /// <remarks/>
        [XmlEnum("Log Row Scan")] LogRowScan,

        /// <remarks/>
        [XmlEnum("Merge Interval")] MergeInterval,

        /// <remarks/>
        [XmlEnum("Merge Join")] MergeJoin,

        /// <remarks/>
        [XmlEnum("Nested Loops")] NestedLoops,

        /// <remarks/>
        [XmlEnum("Online Index Insert")] OnlineIndexInsert,

        /// <remarks/>
        Parallelism,

        /// <remarks/>
        [XmlEnum("Parameter Table Scan")] ParameterTableScan,

        /// <remarks/>
        Print,

        /// <remarks/>
        Put,

        /// <remarks/>
        Rank,

        /// <remarks/>
        [XmlEnum("Remote Delete")] RemoteDelete,

        /// <remarks/>
        [XmlEnum("Remote Index Scan")] RemoteIndexScan,

        /// <remarks/>
        [XmlEnum("Remote Index Seek")] RemoteIndexSeek,

        /// <remarks/>
        [XmlEnum("Remote Insert")] RemoteInsert,

        /// <remarks/>
        [XmlEnum("Remote Query")] RemoteQuery,

        /// <remarks/>
        [XmlEnum("Remote Scan")] RemoteScan,

        /// <remarks/>
        [XmlEnum("Remote Update")] RemoteUpdate,

        /// <remarks/>
        [XmlEnum("RID Lookup")] RidLookup,

        /// <remarks/>
        [XmlEnum("Row Count Spool")] RowCountSpool,

        /// <remarks/>
        Segment,

        /// <remarks/>
        Sequence,

        /// <remarks/>
        [XmlEnum("Sequence Project")] SequenceProject,

        /// <remarks/>
        Sort,

        /// <remarks/>
        Split,

        /// <remarks/>
        [XmlEnum("Stream Aggregate")] StreamAggregate,

        /// <remarks/>
        Switch,

        /// <remarks/>
        [XmlEnum("Table Delete")] TableDelete,

        /// <remarks/>
        [XmlEnum("Table Insert")] TableInsert,

        /// <remarks/>
        [XmlEnum("Table Merge")] TableMerge,

        /// <remarks/>
        [XmlEnum("Table Scan")] TableScan,

        /// <remarks/>
        [XmlEnum("Table Spool")] TableSpool,

        /// <remarks/>
        [XmlEnum("Table Update")] TableUpdate,

        /// <remarks/>
        [XmlEnum("Table-valued function")] Tablevaluedfunction,

        /// <remarks/>
        Top,

        /// <remarks/>
        Udx,

        /// <remarks/>
        [XmlEnum("Window Aggregate")] WindowAggregate,

        /// <remarks/>
        [XmlEnum("Window Spool")] WindowSpool,

        /// <remarks/>
        [XmlEnum("Key Lookup")] KeyLookup,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class RunTimePartitionSummaryType
    {
        /// <remarks/>
        public RunTimePartitionSummaryTypePartitionsAccessed PartitionsAccessed { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true,
        Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class RunTimePartitionSummaryTypePartitionsAccessed
    {
        /// <remarks/>
        [XmlElement("PartitionRange")]
        public RunTimePartitionSummaryTypePartitionsAccessedPartitionRange[] PartitionRange { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong PartitionCount { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true,
        Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class RunTimePartitionSummaryTypePartitionsAccessedPartitionRange
    {
        /// <remarks/>
        [XmlAttribute()]
        public ulong Start { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong End { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class AdaptiveJoinType : RelOpBaseType
    {
        /// <remarks/>
        [XmlArrayItem("ColumnReference", IsNullable = false)]
        public ColumnReferenceType[] HashKeysBuild { get; set; }

        /// <remarks/>
        [XmlArrayItem("ColumnReference", IsNullable = false)]
        public ColumnReferenceType[] HashKeysProbe { get; set; }

        /// <remarks/>
        public ScalarExpressionType BuildResidual { get; set; }

        /// <remarks/>
        public ScalarExpressionType ProbeResidual { get; set; }

        /// <remarks/>
        public StarJoinInfoType StarJoinInfo { get; set; }

        /// <remarks/>
        public ScalarExpressionType Predicate { get; set; }

        /// <remarks/>
        public ScalarExpressionType PassThru { get; set; }

        /// <remarks/>
        [XmlArrayItem("ColumnReference", IsNullable = false)]
        public ColumnReferenceType[] OuterReferences { get; set; }

        /// <remarks/>
        public SingleColumnReferenceType PartitionId { get; set; }

        /// <remarks/>
        [XmlElement("RelOp")]
        public RelOpType[] RelOp { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool BitmapCreator { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool BitmapCreatorSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool Optimized { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class StarJoinInfoType
    {
        /// <remarks/>
        [XmlAttribute()]
        public bool Root { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool RootSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public StarJoinInfoTypeOperationType OperationType { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true,
        Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public enum StarJoinInfoTypeOperationType
    {
        /// <remarks/>
        Fetch,

        /// <remarks/>
        [XmlEnum("Index Intersection")] IndexIntersection,

        /// <remarks/>
        [XmlEnum("Index Filter")] IndexFilter,

        /// <remarks/>
        [XmlEnum("Index Lookup")] IndexLookup,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class SingleColumnReferenceType
    {
        /// <remarks/>
        public ColumnReferenceType ColumnReference { get; set; }
    }

    /// <remarks/>
    [XmlInclude(typeof(GenericType))]
    [XmlInclude(typeof(RemoteType))]
    [XmlInclude(typeof(RemoteQueryType))]
    [XmlInclude(typeof(PutType))]
    [XmlInclude(typeof(RemoteModifyType))]
    [XmlInclude(typeof(RemoteFetchType))]
    [XmlInclude(typeof(RemoteRangeType))]
    [XmlInclude(typeof(BatchHashTableBuildType))]
    [XmlInclude(typeof(SpoolType))]
    [XmlInclude(typeof(WindowAggregateType))]
    [XmlInclude(typeof(WindowType))]
    [XmlInclude(typeof(UdxType))]
    [XmlInclude(typeof(TopType))]
    [XmlInclude(typeof(SplitType))]
    [XmlInclude(typeof(SequenceType))]
    [XmlInclude(typeof(SegmentType))]
    [XmlInclude(typeof(NestedLoopsType))]
    [XmlInclude(typeof(MergeType))]
    [XmlInclude(typeof(ConcatType))]
    [XmlInclude(typeof(SwitchType))]
    [XmlInclude(typeof(CollapseType))]
    [XmlInclude(typeof(BitmapType))]
    [XmlInclude(typeof(SortType))]
    [XmlInclude(typeof(TopSortType))]
    [XmlInclude(typeof(StreamAggregateType))]
    [XmlInclude(typeof(ParallelismType))]
    [XmlInclude(typeof(ComputeScalarType))]
    [XmlInclude(typeof(HashType))]
    [XmlInclude(typeof(TableValuedFunctionType))]
    [XmlInclude(typeof(ConstantScanType))]
    [XmlInclude(typeof(FilterType))]
    [XmlInclude(typeof(SimpleIteratorOneChildType))]
    [XmlInclude(typeof(RowsetType))]
    [XmlInclude(typeof(ScalarInsertType))]
    [XmlInclude(typeof(CreateIndexType))]
    [XmlInclude(typeof(UpdateType))]
    [XmlInclude(typeof(SimpleUpdateType))]
    [XmlInclude(typeof(IndexScanType))]
    [XmlInclude(typeof(TableScanType))]
    [XmlInclude(typeof(ForeignKeyReferencesCheckType))]
    [XmlInclude(typeof(AdaptiveJoinType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class RelOpBaseType
    {
        /// <remarks/>
        [XmlArrayItem("DefinedValue", IsNullable = false)]
        public DefinedValuesListTypeDefinedValue[] DefinedValues { get; set; }

        /// <remarks/>
        public InternalInfoType InternalInfo { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true,
        Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class DefinedValuesListTypeDefinedValue
    {
        /// <remarks/>
        [XmlElement("ColumnReference", typeof(ColumnReferenceType), Order = 0)]
        [XmlElement("ValueVector", typeof(DefinedValuesListTypeDefinedValueValueVector),
            Order = 0)]
        public object Item { get; set; }

        /// <remarks/>
        [XmlElement("ColumnReference", typeof(ColumnReferenceType), Order = 1)]
        [XmlElement("ScalarOperator", typeof(ScalarType), Order = 1)]
        public object[] Items { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true,
        Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class DefinedValuesListTypeDefinedValueValueVector
    {
        /// <remarks/>
        [XmlElement("ColumnReference")]
        public ColumnReferenceType[] ColumnReference { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class GenericType : RelOpBaseType
    {
        /// <remarks/>
        [XmlElement("RelOp")]
        public RelOpType[] RelOp { get; set; }
    }

    /// <remarks/>
    [XmlInclude(typeof(RemoteQueryType))]
    [XmlInclude(typeof(PutType))]
    [XmlInclude(typeof(RemoteModifyType))]
    [XmlInclude(typeof(RemoteFetchType))]
    [XmlInclude(typeof(RemoteRangeType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class RemoteType : RelOpBaseType
    {
        /// <remarks/>
        [XmlAttribute()]
        public string RemoteDestination { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string RemoteSource { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string RemoteObject { get; set; }
    }

    /// <remarks/>
    [XmlInclude(typeof(PutType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class RemoteQueryType : RemoteType
    {
        /// <remarks/>
        [XmlAttribute()]
        public string RemoteQuery { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class PutType : RemoteQueryType
    {
        /// <remarks/>
        public RelOpType RelOp { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string ShuffleType { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string ShuffleColumn { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class RemoteModifyType : RemoteType
    {
        /// <remarks/>
        public ScalarExpressionType SetPredicate { get; set; }

        /// <remarks/>
        public RelOpType RelOp { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class RemoteFetchType : RemoteType
    {
        /// <remarks/>
        public RelOpType RelOp { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class RemoteRangeType : RemoteType
    {
        /// <remarks/>
        public SeekPredicatesType SeekPredicates { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class SeekPredicatesType
    {
        /// <remarks/>
        [XmlElement("SeekPredicate", typeof(SeekPredicateType))]
        [XmlElement("SeekPredicateNew", typeof(SeekPredicateNewType))]
        [XmlElement("SeekPredicatePart", typeof(SeekPredicatePartType))]
        public object[] Items { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class SeekPredicateType
    {
        /// <remarks/>
        public ScanRangeType Prefix { get; set; }

        /// <remarks/>
        public ScanRangeType StartRange { get; set; }

        /// <remarks/>
        public ScanRangeType EndRange { get; set; }

        /// <remarks/>
        public SingleColumnReferenceType IsNotNull { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class ScanRangeType
    {
        /// <remarks/>
        [XmlArrayItem("ColumnReference", IsNullable = false)]
        public ColumnReferenceType[] RangeColumns { get; set; }

        /// <remarks/>
        [XmlArrayItem("ScalarOperator", IsNullable = false)]
        public ScalarType[] RangeExpressions { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public CompareOpType ScanType { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class SeekPredicateNewType
    {
        /// <remarks/>
        [XmlElement("SeekKeys")]
        public SeekPredicateType[] SeekKeys { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class SeekPredicatePartType
    {
        /// <remarks/>
        [XmlElement("SeekPredicateNew")]
        public SeekPredicateNewType[] Items { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class BatchHashTableBuildType : RelOpBaseType
    {
        /// <remarks/>
        public RelOpType RelOp { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool BitmapCreator { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool BitmapCreatorSpecified { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class SpoolType : RelOpBaseType
    {
        /// <remarks/>
        [XmlElement("SeekPredicate", typeof(SeekPredicateType))]
        [XmlElement("SeekPredicateNew", typeof(SeekPredicateNewType))]
        public object Item { get; set; }

        /// <remarks/>
        public RelOpType RelOp { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool Stack { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool StackSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int PrimaryNodeId { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool PrimaryNodeIdSpecified { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class WindowAggregateType : RelOpBaseType
    {
        /// <remarks/>
        public RelOpType RelOp { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class WindowType : RelOpBaseType
    {
        /// <remarks/>
        public RelOpType RelOp { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class UdxType : RelOpBaseType
    {
        /// <remarks/>
        [XmlArrayItem("ColumnReference", IsNullable = false)]
        public ColumnReferenceType[] UsedUdxColumns { get; set; }

        /// <remarks/>
        public RelOpType RelOp { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string UdxName { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class TopType : RelOpBaseType
    {
        /// <remarks/>
        [XmlArrayItem("ColumnReference", IsNullable = false)]
        public ColumnReferenceType[] TieColumns { get; set; }

        /// <remarks/>
        public ScalarExpressionType OffsetExpression { get; set; }

        /// <remarks/>
        public ScalarExpressionType TopExpression { get; set; }

        /// <remarks/>
        public RelOpType RelOp { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool RowCount { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool RowCountSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int Rows { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool RowsSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool IsPercent { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool IsPercentSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool WithTies { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool WithTiesSpecified { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class SplitType : RelOpBaseType
    {
        /// <remarks/>
        public SingleColumnReferenceType ActionColumn { get; set; }

        /// <remarks/>
        public RelOpType RelOp { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class SequenceType : RelOpBaseType
    {
        /// <remarks/>
        [XmlElement("RelOp")]
        public RelOpType[] RelOp { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class SegmentType : RelOpBaseType
    {
        /// <remarks/>
        [XmlArrayItem("ColumnReference", IsNullable = false)]
        public ColumnReferenceType[] GroupBy { get; set; }

        /// <remarks/>
        public SingleColumnReferenceType SegmentColumn { get; set; }

        /// <remarks/>
        public RelOpType RelOp { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class NestedLoopsType : RelOpBaseType
    {
        /// <remarks/>
        public ScalarExpressionType Predicate { get; set; }

        /// <remarks/>
        public ScalarExpressionType PassThru { get; set; }

        /// <remarks/>
        [XmlArrayItem("ColumnReference", IsNullable = false)]
        public ColumnReferenceType[] OuterReferences { get; set; }

        /// <remarks/>
        public SingleColumnReferenceType PartitionId { get; set; }

        /// <remarks/>
        public SingleColumnReferenceType ProbeColumn { get; set; }

        /// <remarks/>
        public StarJoinInfoType StarJoinInfo { get; set; }

        /// <remarks/>
        [XmlElement("RelOp")]
        public RelOpType[] RelOp { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool Optimized { get; set; }

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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class MergeType : RelOpBaseType
    {
        /// <remarks/>
        [XmlArrayItem("ColumnReference", IsNullable = false)]
        public ColumnReferenceType[] InnerSideJoinColumns { get; set; }

        /// <remarks/>
        [XmlArrayItem("ColumnReference", IsNullable = false)]
        public ColumnReferenceType[] OuterSideJoinColumns { get; set; }

        /// <remarks/>
        public ScalarExpressionType Residual { get; set; }

        /// <remarks/>
        public ScalarExpressionType PassThru { get; set; }

        /// <remarks/>
        public StarJoinInfoType StarJoinInfo { get; set; }

        /// <remarks/>
        [XmlElement("RelOp")]
        public RelOpType[] RelOp { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool ManyToMany { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ManyToManySpecified { get; set; }
    }

    /// <remarks/>
    [XmlInclude(typeof(SwitchType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class ConcatType : RelOpBaseType
    {
        /// <remarks/>
        [XmlElement("RelOp")]
        public RelOpType[] RelOp { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class SwitchType : ConcatType
    {
        /// <remarks/>
        public ScalarExpressionType Predicate { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class CollapseType : RelOpBaseType
    {
        /// <remarks/>
        [XmlArrayItem("ColumnReference", IsNullable = false)]
        public ColumnReferenceType[] GroupBy { get; set; }

        /// <remarks/>
        public RelOpType RelOp { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class BitmapType : RelOpBaseType
    {
        /// <remarks/>
        [XmlArrayItem("ColumnReference", IsNullable = false)]
        public ColumnReferenceType[] HashKeys { get; set; }

        /// <remarks/>
        public RelOpType RelOp { get; set; }
    }

    /// <remarks/>
    [XmlInclude(typeof(TopSortType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class SortType : RelOpBaseType
    {
        /// <remarks/>
        [XmlArrayItem("OrderByColumn", IsNullable = false)]
        public OrderByTypeOrderByColumn[] OrderBy { get; set; }

        /// <remarks/>
        public SingleColumnReferenceType PartitionId { get; set; }

        /// <remarks/>
        public RelOpType RelOp { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool Distinct { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true,
        Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class OrderByTypeOrderByColumn
    {
        /// <remarks/>
        public ColumnReferenceType ColumnReference { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool Ascending { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class TopSortType : SortType
    {
        /// <remarks/>
        [XmlAttribute()]
        public int Rows { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool WithTies { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool WithTiesSpecified { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class StreamAggregateType : RelOpBaseType
    {
        /// <remarks/>
        [XmlArrayItem("ColumnReference", IsNullable = false)]
        public ColumnReferenceType[] GroupBy { get; set; }

        /// <remarks/>
        public RollupInfoType RollupInfo { get; set; }

        /// <remarks/>
        public RelOpType RelOp { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class RollupInfoType
    {
        /// <remarks/>
        [XmlElement("RollupLevel")]
        public RollupLevelType[] RollupLevel { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int HighestLevel { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class RollupLevelType
    {
        /// <remarks/>
        [XmlAttribute()]
        public int Level { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class ParallelismType : RelOpBaseType
    {
        /// <remarks/>
        [XmlArrayItem("ColumnReference", IsNullable = false)]
        public ColumnReferenceType[] PartitionColumns { get; set; }

        /// <remarks/>
        [XmlArrayItem("OrderByColumn", IsNullable = false)]
        public OrderByTypeOrderByColumn[] OrderBy { get; set; }

        /// <remarks/>
        [XmlArrayItem("ColumnReference", IsNullable = false)]
        public ColumnReferenceType[] HashKeys { get; set; }

        /// <remarks/>
        public SingleColumnReferenceType ProbeColumn { get; set; }

        /// <remarks/>
        public ScalarExpressionType Predicate { get; set; }

        /// <remarks/>
        public ParallelismTypeActivation Activation { get; set; }

        /// <remarks/>
        public ParallelismTypeBrickRouting BrickRouting { get; set; }

        /// <remarks/>
        public RelOpType RelOp { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public PartitionType PartitioningType { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool PartitioningTypeSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool Remoting { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool RemotingSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool LocalParallelism { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool LocalParallelismSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool InRow { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool InRowSpecified { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true,
        Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class ParallelismTypeActivation
    {
        /// <remarks/>
        public ObjectType Object { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ParallelismTypeActivationType Type { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string FragmentElimination { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class ObjectType
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
        public IndexKindType IndexKind { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool IndexKindSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public CloneAccessScopeType CloneAccessScope { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool CloneAccessScopeSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public StorageType Storage { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool StorageSpecified { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public enum IndexKindType
    {
        /// <remarks/>
        Heap,

        /// <remarks/>
        Clustered,

        /// <remarks/>
        FtsChangeTracking,

        /// <remarks/>
        FtsMapping,

        /// <remarks/>
        NonClustered,

        /// <remarks/>
        PrimaryXml,

        /// <remarks/>
        SecondaryXml,

        /// <remarks/>
        Spatial,

        /// <remarks/>
        ViewClustered,

        /// <remarks/>
        ViewNonClustered,

        /// <remarks/>
        NonClusteredHash,

        /// <remarks/>
        SelectiveXml,

        /// <remarks/>
        SecondarySelectiveXml,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public enum CloneAccessScopeType
    {
        /// <remarks/>
        Primary,

        /// <remarks/>
        Secondary,

        /// <remarks/>
        Both,

        /// <remarks/>
        Either,

        /// <remarks/>
        ExactMatch,

        /// <remarks/>
        Local,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public enum StorageType
    {
        /// <remarks/>
        RowStore,

        /// <remarks/>
        ColumnStore,

        /// <remarks/>
        MemoryOptimized,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true,
        Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public enum ParallelismTypeActivationType
    {
        /// <remarks/>
        CloneLocation,

        /// <remarks/>
        Resource,

        /// <remarks/>
        SingleBrick,

        /// <remarks/>
        Region,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true,
        Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class ParallelismTypeBrickRouting
    {
        /// <remarks/>
        public ObjectType Object { get; set; }

        /// <remarks/>
        public SingleColumnReferenceType FragmentIdColumn { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public enum PartitionType
    {
        /// <remarks/>
        Broadcast,

        /// <remarks/>
        Demand,

        /// <remarks/>
        Hash,

        /// <remarks/>
        NoPartitioning,

        /// <remarks/>
        Range,

        /// <remarks/>
        RoundRobin,

        /// <remarks/>
        CloneLocation,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class ComputeScalarType : RelOpBaseType
    {
        /// <remarks/>
        public RelOpType RelOp { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool ComputeSequence { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ComputeSequenceSpecified { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class HashType : RelOpBaseType
    {
        /// <remarks/>
        [XmlArrayItem("ColumnReference", IsNullable = false)]
        public ColumnReferenceType[] HashKeysBuild { get; set; }

        /// <remarks/>
        [XmlArrayItem("ColumnReference", IsNullable = false)]
        public ColumnReferenceType[] HashKeysProbe { get; set; }

        /// <remarks/>
        public ScalarExpressionType BuildResidual { get; set; }

        /// <remarks/>
        public ScalarExpressionType ProbeResidual { get; set; }

        /// <remarks/>
        public StarJoinInfoType StarJoinInfo { get; set; }

        /// <remarks/>
        [XmlElement("RelOp")]
        public RelOpType[] RelOp { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool BitmapCreator { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool BitmapCreatorSpecified { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class TableValuedFunctionType : RelOpBaseType
    {
        /// <remarks/>
        public ObjectType Object { get; set; }

        /// <remarks/>
        public ScalarExpressionType Predicate { get; set; }

        /// <remarks/>
        public RelOpType RelOp { get; set; }

        /// <remarks/>
        [XmlArrayItem("ScalarOperator", IsNullable = false)]
        public ScalarType[] ParameterList { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class ConstantScanType : RelOpBaseType
    {
        /// <remarks/>
        [XmlArrayItem("Row", IsNullable = false)]
        [XmlArrayItem("ScalarOperator", IsNullable = false, NestingLevel = 1)]
        public ScalarType[][] Values { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class FilterType : RelOpBaseType
    {
        /// <remarks/>
        public RelOpType RelOp { get; set; }

        /// <remarks/>
        public ScalarExpressionType Predicate { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool StartupExpression { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class SimpleIteratorOneChildType : RelOpBaseType
    {
        /// <remarks/>
        public RelOpType RelOp { get; set; }
    }

    /// <remarks/>
    [XmlInclude(typeof(ScalarInsertType))]
    [XmlInclude(typeof(CreateIndexType))]
    [XmlInclude(typeof(UpdateType))]
    [XmlInclude(typeof(SimpleUpdateType))]
    [XmlInclude(typeof(IndexScanType))]
    [XmlInclude(typeof(TableScanType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class RowsetType : RelOpBaseType
    {
        /// <remarks/>
        [XmlElement("Object")]
        public ObjectType[] Object { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class ScalarInsertType : RowsetType
    {
        /// <remarks/>
        public ScalarExpressionType SetPredicate { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool DmlRequestSort { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool DmlRequestSortSpecified { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class CreateIndexType : RowsetType
    {
        /// <remarks/>
        public RelOpType RelOp { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class UpdateType : RowsetType
    {
        /// <remarks/>
        [XmlElement("SetPredicate")]
        public SetPredicateElementType[] SetPredicate { get; set; }

        /// <remarks/>
        public SingleColumnReferenceType ProbeColumn { get; set; }

        /// <remarks/>
        public SingleColumnReferenceType ActionColumn { get; set; }

        /// <remarks/>
        public SingleColumnReferenceType OriginalActionColumn { get; set; }

        /// <remarks/>
        public RelOpType RelOp { get; set; }

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

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class SimpleUpdateType : RowsetType
    {
        /// <remarks/>
        [XmlElement("SeekPredicate", typeof(SeekPredicateType))]
        [XmlElement("SeekPredicateNew", typeof(SeekPredicateNewType))]
        public object Item { get; set; }

        /// <remarks/>
        public ScalarExpressionType SetPredicate { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool DmlRequestSort { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool DmlRequestSortSpecified { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class IndexScanType : RowsetType
    {
        /// <remarks/>
        public SeekPredicatesType SeekPredicates { get; set; }

        /// <remarks/>
        [XmlElement("Predicate")]
        public ScalarExpressionType[] Predicate { get; set; }

        /// <remarks/>
        public SingleColumnReferenceType PartitionId { get; set; }

        /// <remarks/>
        [XmlArrayItem("Object", IsNullable = false)]
        public ObjectType[] IndexedViewInfo { get; set; }

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
        public OrderType ScanDirection { get; set; }

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
        public StorageType Storage { get; set; }

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

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public enum OrderType
    {
        /// <remarks/>
        [XmlEnum("BACKWARD")] Backward,

        /// <remarks/>
        [XmlEnum("FORWARD")] Forward,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class TableScanType : RowsetType
    {
        /// <remarks/>
        public ScalarExpressionType Predicate { get; set; }

        /// <remarks/>
        public SingleColumnReferenceType PartitionId { get; set; }

        /// <remarks/>
        [XmlArrayItem("Object", IsNullable = false)]
        public ObjectType[] IndexedViewInfo { get; set; }

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
        public StorageType Storage { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool StorageSpecified { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class ForeignKeyReferencesCheckType : RelOpBaseType
    {
        /// <remarks/>
        public RelOpType RelOp { get; set; }

        /// <remarks/>
        [XmlElement("ForeignKeyReferenceCheck")]
        public ForeignKeyReferenceCheckType[] ForeignKeyReferenceCheck { get; set; }

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

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class ForeignKeyReferenceCheckType
    {
        /// <remarks/>
        public IndexScanType IndexScan { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan",
        IncludeInSchema = false)]
    public enum ItemChoiceType
    {
        /// <remarks/>
        AdaptiveJoin,

        /// <remarks/>
        Assert,

        /// <remarks/>
        BatchHashTableBuild,

        /// <remarks/>
        Bitmap,

        /// <remarks/>
        Collapse,

        /// <remarks/>
        ComputeScalar,

        /// <remarks/>
        Concat,

        /// <remarks/>
        ConstantScan,

        /// <remarks/>
        CreateIndex,

        /// <remarks/>
        DeletedScan,

        /// <remarks/>
        Extension,

        /// <remarks/>
        Filter,

        /// <remarks/>
        ForeignKeyReferencesCheck,

        /// <remarks/>
        Generic,

        /// <remarks/>
        Hash,

        /// <remarks/>
        IndexScan,

        /// <remarks/>
        InsertedScan,

        /// <remarks/>
        LogRowScan,

        /// <remarks/>
        Merge,

        /// <remarks/>
        MergeInterval,

        /// <remarks/>
        NestedLoops,

        /// <remarks/>
        OnlineIndex,

        /// <remarks/>
        Parallelism,

        /// <remarks/>
        ParameterTableScan,

        /// <remarks/>
        PrintDataflow,

        /// <remarks/>
        Put,

        /// <remarks/>
        RemoteFetch,

        /// <remarks/>
        RemoteModify,

        /// <remarks/>
        RemoteQuery,

        /// <remarks/>
        RemoteRange,

        /// <remarks/>
        RemoteScan,

        /// <remarks/>
        RowCountSpool,

        /// <remarks/>
        ScalarInsert,

        /// <remarks/>
        Segment,

        /// <remarks/>
        Sequence,

        /// <remarks/>
        SequenceProject,

        /// <remarks/>
        SimpleUpdate,

        /// <remarks/>
        Sort,

        /// <remarks/>
        Split,

        /// <remarks/>
        Spool,

        /// <remarks/>
        StreamAggregate,

        /// <remarks/>
        Switch,

        /// <remarks/>
        TableScan,

        /// <remarks/>
        TableValuedFunction,

        /// <remarks/>
        Top,

        /// <remarks/>
        TopSort,

        /// <remarks/>
        Update,

        /// <remarks/>
        WindowAggregate,

        /// <remarks/>
        WindowSpool,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public enum LogicalOpType
    {
        /// <remarks/>
        Aggregate,

        /// <remarks/>
        [XmlEnum("Anti Diff")] AntiDiff,

        /// <remarks/>
        Assert,

        /// <remarks/>
        [XmlEnum("Async Concat")] AsyncConcat,

        /// <remarks/>
        [XmlEnum("Batch Hash Table Build")] BatchHashTableBuild,

        /// <remarks/>
        [XmlEnum("Bitmap Create")] BitmapCreate,

        /// <remarks/>
        [XmlEnum("Clustered Index Scan")] ClusteredIndexScan,

        /// <remarks/>
        [XmlEnum("Clustered Index Seek")] ClusteredIndexSeek,

        /// <remarks/>
        [XmlEnum("Clustered Update")] ClusteredUpdate,

        /// <remarks/>
        Collapse,

        /// <remarks/>
        [XmlEnum("Compute Scalar")] ComputeScalar,

        /// <remarks/>
        Concatenation,

        /// <remarks/>
        [XmlEnum("Constant Scan")] ConstantScan,

        /// <remarks/>
        [XmlEnum("Cross Join")] CrossJoin,

        /// <remarks/>
        Delete,

        /// <remarks/>
        [XmlEnum("Deleted Scan")] DeletedScan,

        /// <remarks/>
        [XmlEnum("Distinct Sort")] DistinctSort,

        /// <remarks/>
        Distinct,

        /// <remarks/>
        [XmlEnum("Distribute Streams")] DistributeStreams,

        /// <remarks/>
        [XmlEnum("Eager Spool")] EagerSpool,

        /// <remarks/>
        Filter,

        /// <remarks/>
        [XmlEnum("Flow Distinct")] FlowDistinct,

        /// <remarks/>
        [XmlEnum("Foreign Key References Check")]
        ForeignKeyReferencesCheck,

        /// <remarks/>
        [XmlEnum("Full Outer Join")] FullOuterJoin,

        /// <remarks/>
        [XmlEnum("Gather Streams")] GatherStreams,

        /// <remarks/>
        Generic,

        /// <remarks/>
        [XmlEnum("Index Scan")] IndexScan,

        /// <remarks/>
        [XmlEnum("Index Seek")] IndexSeek,

        /// <remarks/>
        [XmlEnum("Inner Join")] InnerJoin,

        /// <remarks/>
        Insert,

        /// <remarks/>
        [XmlEnum("Inserted Scan")] InsertedScan,

        /// <remarks/>
        Intersect,

        /// <remarks/>
        [XmlEnum("Intersect All")] IntersectAll,

        /// <remarks/>
        [XmlEnum("Lazy Spool")] LazySpool,

        /// <remarks/>
        [XmlEnum("Left Anti Semi Join")] LeftAntiSemiJoin,

        /// <remarks/>
        [XmlEnum("Left Diff")] LeftDiff,

        /// <remarks/>
        [XmlEnum("Left Diff All")] LeftDiffAll,

        /// <remarks/>
        [XmlEnum("Left Outer Join")] LeftOuterJoin,

        /// <remarks/>
        [XmlEnum("Left Semi Join")] LeftSemiJoin,

        /// <remarks/>
        [XmlEnum("Log Row Scan")] LogRowScan,

        /// <remarks/>
        Merge,

        /// <remarks/>
        [XmlEnum("Merge Interval")] MergeInterval,

        /// <remarks/>
        [XmlEnum("Merge Stats")] MergeStats,

        /// <remarks/>
        [XmlEnum("Parameter Table Scan")] ParameterTableScan,

        /// <remarks/>
        [XmlEnum("Partial Aggregate")] PartialAggregate,

        /// <remarks/>
        Print,

        /// <remarks/>
        Put,

        /// <remarks/>
        Rank,

        /// <remarks/>
        [XmlEnum("Remote Delete")] RemoteDelete,

        /// <remarks/>
        [XmlEnum("Remote Index Scan")] RemoteIndexScan,

        /// <remarks/>
        [XmlEnum("Remote Index Seek")] RemoteIndexSeek,

        /// <remarks/>
        [XmlEnum("Remote Insert")] RemoteInsert,

        /// <remarks/>
        [XmlEnum("Remote Query")] RemoteQuery,

        /// <remarks/>
        [XmlEnum("Remote Scan")] RemoteScan,

        /// <remarks/>
        [XmlEnum("Remote Update")] RemoteUpdate,

        /// <remarks/>
        [XmlEnum("Repartition Streams")] RepartitionStreams,

        /// <remarks/>
        [XmlEnum("RID Lookup")] RidLookup,

        /// <remarks/>
        [XmlEnum("Right Anti Semi Join")] RightAntiSemiJoin,

        /// <remarks/>
        [XmlEnum("Right Diff")] RightDiff,

        /// <remarks/>
        [XmlEnum("Right Diff All")] RightDiffAll,

        /// <remarks/>
        [XmlEnum("Right Outer Join")] RightOuterJoin,

        /// <remarks/>
        [XmlEnum("Right Semi Join")] RightSemiJoin,

        /// <remarks/>
        Segment,

        /// <remarks/>
        Sequence,

        /// <remarks/>
        Sort,

        /// <remarks/>
        Split,

        /// <remarks/>
        Switch,

        /// <remarks/>
        [XmlEnum("Table-valued function")] Tablevaluedfunction,

        /// <remarks/>
        [XmlEnum("Table Scan")] TableScan,

        /// <remarks/>
        Top,

        /// <remarks/>
        [XmlEnum("TopN Sort")] TopNSort,

        /// <remarks/>
        Udx,

        /// <remarks/>
        Union,

        /// <remarks/>
        Update,

        /// <remarks/>
        [XmlEnum("Local Stats")] LocalStats,

        /// <remarks/>
        [XmlEnum("Window Spool")] WindowSpool,

        /// <remarks/>
        [XmlEnum("Window Aggregate")] WindowAggregate,

        /// <remarks/>
        [XmlEnum("Key Lookup")] KeyLookup,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public enum SubqueryOperationType
    {
        /// <remarks/>
        [XmlEnum("EQ ALL")] EqAll,

        /// <remarks/>
        [XmlEnum("EQ ANY")] EqAny,

        /// <remarks/>
        [XmlEnum("EXISTS")] Exists,

        /// <remarks/>
        [XmlEnum("GE ALL")] GeAll,

        /// <remarks/>
        [XmlEnum("GE ANY")] GeAny,

        /// <remarks/>
        [XmlEnum("GT ALL")] GtAll,

        /// <remarks/>
        [XmlEnum("GT ANY")] GtAny,

        /// <remarks/>
        [XmlEnum("IN")] In,

        /// <remarks/>
        [XmlEnum("LE ALL")] LeAll,

        /// <remarks/>
        [XmlEnum("LE ANY")] LeAny,

        /// <remarks/>
        [XmlEnum("LT ALL")] LtAll,

        /// <remarks/>
        [XmlEnum("LT ANY")] LtAny,

        /// <remarks/>
        [XmlEnum("NE ALL")] NeAll,

        /// <remarks/>
        [XmlEnum("NE ANY")] NeAny,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class UdtMethodType
    {
        /// <remarks/>
        public ClrFunctionType ClrFunction { get; set; }

        /// <remarks/>
        [XmlElement("ScalarOperator")]
        public ScalarType[] ScalarOperator { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class ClrFunctionType
    {
        /// <remarks/>
        [XmlAttribute()]
        public string Assembly { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Class { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Method { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class UdAggregateType
    {
        /// <remarks/>
        public ObjectType UdAggObject { get; set; }

        /// <remarks/>
        [XmlElement("ScalarOperator")]
        public ScalarType[] ScalarOperator { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool Distinct { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class UdfType
    {
        /// <remarks/>
        [XmlElement("ScalarOperator")]
        public ScalarType[] ScalarOperator { get; set; }

        /// <remarks/>
        public ClrFunctionType ClrFunction { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string FunctionName { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool IsClrFunction { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool IsClrFunctionSpecified { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class UnmatchedIndexesType
    {
        /// <remarks/>
        [XmlArrayItem("Object", IsNullable = false)]
        public ObjectType[] Parameterization { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class GuessedSelectivityType
    {
        /// <remarks/>
        public ObjectType Spatial { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class ColumnType
    {
        /// <remarks/>
        [XmlAttribute()]
        public string Name { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int ColumnId { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class ColumnGroupType
    {
        /// <remarks/>
        [XmlElement("Column")]
        public ColumnType[] Column { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ColumnGroupTypeUsage Usage { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true,
        Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public enum ColumnGroupTypeUsage
    {
        /// <remarks/>
        [XmlEnum("EQUALITY")] Equality,

        /// <remarks/>
        [XmlEnum("INEQUALITY")] Inequality,

        /// <remarks/>
        [XmlEnum("INCLUDE")] Include,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class MissingIndexType
    {
        /// <remarks/>
        [XmlElement("ColumnGroup")]
        public ColumnGroupType[] ColumnGroup { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Database { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Schema { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Table { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class MissingIndexGroupType
    {
        /// <remarks/>
        [XmlElement("MissingIndex")]
        public MissingIndexType[] MissingIndex { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public double Impact { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class ThreadReservationType
    {
        /// <remarks/>
        [XmlAttribute()]
        public int NodeId { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int ReservedThreads { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class ThreadStatType
    {
        /// <remarks/>
        [XmlElement("ThreadReservation")]
        public ThreadReservationType[] ThreadReservation { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int Branches { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int UsedThreads { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool UsedThreadsSpecified { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class SetOptionsType
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

    /// <remarks/>
    [XmlInclude(typeof(StmtReceiveType))]
    [XmlInclude(typeof(StmtCursorType))]
    [XmlInclude(typeof(StmtCondType))]
    [XmlInclude(typeof(StmtUseDbType))]
    [XmlInclude(typeof(StmtSimpleType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class BaseStmtInfoType
    {
        /// <remarks/>
        public SetOptionsType StatementSetOptions { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int StatementCompId { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool StatementCompIdSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public double StatementEstRows { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool StatementEstRowsSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int StatementId { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool StatementIdSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string StatementOptmLevel { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public BaseStmtInfoTypeStatementOptmEarlyAbortReason StatementOptmEarlyAbortReason { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool StatementOptmEarlyAbortReasonSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string CardinalityEstimationModelVersion { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public double StatementSubTreeCost { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool StatementSubTreeCostSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string StatementText { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string StatementType { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string TemplatePlanGuideDb { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string TemplatePlanGuideName { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string PlanGuideDb { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string PlanGuideName { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string ParameterizedText { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string ParameterizedPlanHandle { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string QueryHash { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string QueryPlanHash { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string RetrievedFromCache { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string StatementSqlHandle { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong DatabaseContextSettingsId { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool DatabaseContextSettingsIdSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong ParentObjectId { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ParentObjectIdSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string BatchSqlHandle { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int StatementParameterizationType { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool StatementParameterizationTypeSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool SecurityPolicyApplied { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool SecurityPolicyAppliedSpecified { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true,
        Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public enum BaseStmtInfoTypeStatementOptmEarlyAbortReason
    {
        /// <remarks/>
        TimeOut,

        /// <remarks/>
        MemoryLimitExceeded,

        /// <remarks/>
        GoodEnoughPlanFound,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class StmtReceiveType : BaseStmtInfoType
    {
        /// <remarks/>
        [XmlArrayItem("Operation", IsNullable = false)]
        public ReceivePlanTypeOperation[] ReceivePlan { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true,
        Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class ReceivePlanTypeOperation
    {
        /// <remarks/>
        public QueryPlanType QueryPlan { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ReceivePlanTypeOperationOperationType OperationType { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool OperationTypeSpecified { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true,
        Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public enum ReceivePlanTypeOperationOperationType
    {
        /// <remarks/>
        ReceivePlanSelect,

        /// <remarks/>
        ReceivePlanUpdate,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class StmtCursorType : BaseStmtInfoType
    {
        /// <remarks/>
        public CursorPlanType CursorPlan { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class StmtUseDbType : BaseStmtInfoType
    {
        /// <remarks/>
        [XmlAttribute()]
        public string Database { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class StmtSimpleType : BaseStmtInfoType
    {
        /// <remarks/>
        public QueryPlanType QueryPlan { get; set; }

        /// <remarks/>
        [XmlElement("UDF")]
        public FunctionType[] Udf { get; set; }

        /// <remarks/>
        public FunctionType StoredProc { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true,
        Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class StmtCondTypeThen
    {
        /// <remarks/>
        public StmtBlockType Statements { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true,
        Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public partial class StmtCondTypeElse
    {
        /// <remarks/>
        public StmtBlockType Statements { get; set; }
    }
}
