using System.Diagnostics;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Showplan.RelOps
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("RelOpType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    [DebuggerDisplay("{" + nameof(PhysicalOp) + "}")]
    public class RelOp
    {
        /// <remarks/>
        [XmlArrayItem("ColumnReference", IsNullable = false)]
        public ColumnReference[] OutputList { get; set; }

        /// <remarks/>
        public Warnings Warnings { get; set; }

        /// <remarks/>
        public MemoryFractions MemoryFractions { get; set; }

        /// <remarks/>
        [XmlArrayItem("RunTimeCountersPerThread", IsNullable = false)]
        public RunTimeInformationTypeRunTimeCountersPerThread[] RunTimeInformation { get; set; }

        /// <remarks/>
        public RunTimePartitionSummary RunTimePartitionSummary { get; set; }

        /// <remarks/>
        public InternalInfo InternalInfo { get; set; }

        /// <remarks/>
        [XmlElement("AdaptiveJoin", typeof(AdaptiveJoin))]
        [XmlElement("Assert", typeof(Filter))]
        [XmlElement("BatchHashTableBuild", typeof(BatchHashTableBuild))]
        [XmlElement("Bitmap", typeof(Bitmap))]
        [XmlElement("Collapse", typeof(Collapse))]
        [XmlElement("ComputeScalar", typeof(ComputeScalar))]
        [XmlElement("Concat", typeof(Concat))]
        [XmlElement("ConstantScan", typeof(ConstantScan))]
        [XmlElement("CreateIndex", typeof(CreateIndex))]
        [XmlElement("DeletedScan", typeof(Rowset))]
        [XmlElement("Extension", typeof(Udx))]
        [XmlElement("Filter", typeof(Filter))]
        [XmlElement("ForeignKeyReferencesCheck", typeof(ForeignKeyReferencesCheck))]
        [XmlElement("Generic", typeof(Generic))]
        [XmlElement("Hash", typeof(Hash))]
        [XmlElement("IndexScan", typeof(IndexScan))]
        [XmlElement("InsertedScan", typeof(Rowset))]
        [XmlElement("LogRowScan", typeof(RelOpBase))]
        [XmlElement("Merge", typeof(Merge))]
        [XmlElement("MergeInterval", typeof(SimpleIteratorOneChild))]
        [XmlElement("NestedLoops", typeof(NestedLoops))]
        [XmlElement("OnlineIndex", typeof(CreateIndex))]
        [XmlElement("Parallelism", typeof(Parallelism))]
        [XmlElement("ParameterTableScan", typeof(RelOpBase))]
        [XmlElement("PrintDataflow", typeof(RelOpBase))]
        [XmlElement("Put", typeof(Put))]
        [XmlElement("RemoteFetch", typeof(RemoteFetch))]
        [XmlElement("RemoteModify", typeof(RemoteModify))]
        [XmlElement("RemoteQuery", typeof(RemoteQuery))]
        [XmlElement("RemoteRange", typeof(RemoteRange))]
        [XmlElement("RemoteScan", typeof(Remote))]
        [XmlElement("RowCountSpool", typeof(Spool))]
        [XmlElement("ScalarInsert", typeof(ScalarInsert))]
        [XmlElement("Segment", typeof(Segment))]
        [XmlElement("Sequence", typeof(Sequence))]
        [XmlElement("SequenceProject", typeof(ComputeScalar))]
        [XmlElement("SimpleUpdate", typeof(SimpleUpdate))]
        [XmlElement("Sort", typeof(Sort))]
        [XmlElement("Split", typeof(Split))]
        [XmlElement("Spool", typeof(Spool))]
        [XmlElement("StreamAggregate", typeof(StreamAggregate))]
        [XmlElement("Switch", typeof(Switch))]
        [XmlElement("TableScan", typeof(TableScan))]
        [XmlElement("TableValuedFunction", typeof(TableValuedFunction))]
        [XmlElement("Top", typeof(Top))]
        [XmlElement("TopSort", typeof(TopSort))]
        [XmlElement("Update", typeof(Update))]
        [XmlElement("WindowAggregate", typeof(WindowAggregate))]
        [XmlElement("WindowSpool", typeof(Window))]
        [XmlChoiceIdentifier("ItemElementName")]
        public RelOpBase Item { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public ItemChoice ItemElementName { get; set; }

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
        public ExecutionMode EstimatedExecutionMode { get; set; }

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
        public LogicalOp LogicalOp { get; set; }

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
        public PhysicalOp PhysicalOp { get; set; }

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
        public PhysicalOp EstimatedJoinType { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool EstimatedJoinTypeSpecified { get; set; }
        
        public override string ToString()
        {
            if (!(this.Item is Rowset rowset) || rowset.Object.Length <= 0)
            {
                return $"{PhysicalOp} - [{NodeId}]";
            }

            var o = rowset.Object[0];
            var scannedObject = string.IsNullOrWhiteSpace(o.Index) ? o.Table : o.Index;
            return $"{PhysicalOp} - {scannedObject}";
        }
    }
}
