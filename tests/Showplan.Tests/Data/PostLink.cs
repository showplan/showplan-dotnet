using System;

#nullable disable

namespace Showplan.Tests.Data
{
    public partial class PostLink
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public int PostId { get; set; }
        public int RelatedPostId { get; set; }
        public int LinkTypeId { get; set; }

        public virtual LinkType LinkType { get; set; }
        public virtual Post Post { get; set; }
        public virtual Post RelatedPost { get; set; }
    }
}
