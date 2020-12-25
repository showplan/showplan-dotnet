using System.Collections.Generic;

#nullable disable

namespace Showplan.Tests.Data
{
    public partial class PostType
    {
        public PostType()
        {
            Posts = new HashSet<Post>();
        }

        public int Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
