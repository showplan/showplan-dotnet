namespace Showplan.Tests.Interceptor7.Data
{
    public partial class LinkType
    {
        public LinkType()
        {
            PostLinks = new HashSet<PostLink>();
        }

        public int Id { get; set; }
        public string Type { get; set; } = null!;

        public virtual ICollection<PostLink> PostLinks { get; set; }
    }
}
