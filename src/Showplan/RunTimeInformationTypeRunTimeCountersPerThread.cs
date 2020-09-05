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
    public class RunTimeInformationTypeRunTimeCountersPerThread
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
        public ExecutionMode ActualExecutionMode { get; set; }

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
        public PhysicalOp ActualJoinType { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ActualJoinTypeSpecified { get; set; }
    }
}
