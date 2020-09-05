using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType("LogicalOpType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public enum LogicalOp
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
}
