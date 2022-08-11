namespace Showplan.Tests.Interceptor7.Data
{
    public partial class PostType
    {
        public PostType()
        {
            Posts = new HashSet<Post>();
        }

        public int Id { get; set; }
        public string Type { get; set; } = null!;

        public virtual ICollection<Post> Posts { get; set; }
    }
}
