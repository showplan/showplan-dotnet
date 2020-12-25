using System;
using System.Collections.Generic;

#nullable disable

namespace Showplan.Tests.Data
{
    public partial class Post
    {
        public Post()
        {
            Comments = new HashSet<Comment>();
            InverseAcceptedAnswer = new HashSet<Post>();
            InverseParent = new HashSet<Post>();
            PostHistories = new HashSet<PostHistory>();
            PostLinkPosts = new HashSet<PostLink>();
            PostLinkRelatedPosts = new HashSet<PostLink>();
            Votes = new HashSet<Vote>();
        }

        public int Id { get; set; }
        public int? AcceptedAnswerId { get; set; }
        public int? AnswerCount { get; set; }
        public string Body { get; set; }
        public DateTime? ClosedDate { get; set; }
        public int? CommentCount { get; set; }
        public DateTime? CommunityOwnedDate { get; set; }
        public DateTime CreationDate { get; set; }
        public int? FavoriteCount { get; set; }
        public DateTime LastActivityDate { get; set; }
        public DateTime? LastEditDate { get; set; }
        public string LastEditorDisplayName { get; set; }
        public int? LastEditorUserId { get; set; }
        public int? OwnerUserId { get; set; }
        public int? ParentId { get; set; }
        public int PostTypeId { get; set; }
        public int Score { get; set; }
        public string Tags { get; set; }
        public string Title { get; set; }
        public int ViewCount { get; set; }

        public virtual Post AcceptedAnswer { get; set; }
        public virtual User OwnerUser { get; set; }
        public virtual Post Parent { get; set; }
        public virtual PostType PostType { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Post> InverseAcceptedAnswer { get; set; }
        public virtual ICollection<Post> InverseParent { get; set; }
        public virtual ICollection<PostHistory> PostHistories { get; set; }
        public virtual ICollection<PostLink> PostLinkPosts { get; set; }
        public virtual ICollection<PostLink> PostLinkRelatedPosts { get; set; }
        public virtual ICollection<Vote> Votes { get; set; }
    }
}
