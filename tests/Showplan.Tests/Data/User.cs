using System;
using System.Collections.Generic;

#nullable disable

namespace Showplan.Tests.Data
{
    public partial class User
    {
        public User()
        {
            Comments = new HashSet<Comment>();
            PostHistories = new HashSet<PostHistory>();
            Posts = new HashSet<Post>();
            Votes = new HashSet<Vote>();
        }

        public int Id { get; set; }
        public string AboutMe { get; set; }
        public int? Age { get; set; }
        public DateTime CreationDate { get; set; }
        public string DisplayName { get; set; }
        public int DownVotes { get; set; }
        public string EmailHash { get; set; }
        public DateTime LastAccessDate { get; set; }
        public string Location { get; set; }
        public int Reputation { get; set; }
        public int UpVotes { get; set; }
        public int Views { get; set; }
        public string WebsiteUrl { get; set; }
        public int? AccountId { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<PostHistory> PostHistories { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Vote> Votes { get; set; }
    }
}
