using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType("PhysicalOpType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public enum PhysicalOp
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
}
