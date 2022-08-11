namespace Showplan.Tests.Interceptor7.Data
{
    public partial class Tag
    {
        public int Id { get; set; }
        public string TagName { get; set; } = null!;
        public int Count { get; set; }
        public int? ExcerptPostId { get; set; }
        public int? WikiPostId { get; set; }
    }
}
