namespace Showplan.Tests.Interceptor7.Data
{
    public partial class PostLink
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public int PostId { get; set; }
        public int RelatedPostId { get; set; }
        public int LinkTypeId { get; set; }

        public virtual LinkType LinkType { get; set; } = null!;
        public virtual Post Post { get; set; } = null!;
        public virtual Post RelatedPost { get; set; } = null!;
    }
}
