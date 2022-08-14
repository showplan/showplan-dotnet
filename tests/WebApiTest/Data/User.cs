using System;
using System.Collections.Generic;

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
        /// <summary>
        /// The user&apos;s profile as rendered HTML.
        /// </summary>
        public string? AboutMe { get; set; }
        public int? Age { get; set; }
        public DateTime CreationDate { get; set; }
        public string DisplayName { get; set; } = null!;
        /// <summary>
        /// The number of downvotes a user has cast.
        /// </summary>
        public int DownVotes { get; set; }
        /// <summary>
        /// Always blank.
        /// </summary>
        public string? EmailHash { get; set; }
        public DateTime LastAccessDate { get; set; }
        public string? Location { get; set; }
        public int Reputation { get; set; }
        /// <summary>
        /// The number of upvotes a user has cast.
        /// </summary>
        public int UpVotes { get; set; }
        /// <summary>
        /// The number of times the profile has been viewed.
        /// </summary>
        public int Views { get; set; }
        public string? WebsiteUrl { get; set; }
        /// <summary>
        /// The user&apos;s stack exchange network profile id.
        /// </summary>
        public int? AccountId { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<PostHistory> PostHistories { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Vote> Votes { get; set; }
    }
}
