namespace Showplan.Tests.Interceptor7.Data
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
            PostTags = new HashSet<PostTag>();
            Votes = new HashSet<Vote>();
        }

        public int Id { get; set; }
        /// <summary>
        /// Id of the accepted answer. Only present if PostTypeId = 1 (question).
        /// </summary>
        public int? AcceptedAnswerId { get; set; }
        public int? AnswerCount { get; set; }
        /// <summary>
        /// The body as rendered HTML.
        /// </summary>
        public string Body { get; set; } = null!;
        public DateTime? ClosedDate { get; set; }
        public int? CommentCount { get; set; }
        /// <summary>
        /// The date the post became community owned. Present only if post is community wiki&apos;d.
        /// </summary>
        public DateTime? CommunityOwnedDate { get; set; }
        public string ContentLicense { get; set; } = null!;
        public DateTime CreationDate { get; set; }
        public int? FavoriteCount { get; set; }
        /// <summary>
        /// The date and time of the post&apos;s most recent activity.
        /// </summary>
        public DateTime LastActivityDate { get; set; }
        /// <summary>
        /// The date and time of the most recent edit to the post.
        /// </summary>
        public DateTime? LastEditDate { get; set; }
        public string? LastEditorDisplayName { get; set; }
        public int? LastEditorUserId { get; set; }
        /// <summary>
        /// User Id of the owner. Always -1 for tag wiki entries, i.e. the community user owns them.
        /// </summary>
        public int? OwnerUserId { get; set; }
        /// <summary>
        /// The Id of the Parent. Only present if PostTypeId = 2 (answer).
        /// </summary>
        public int? ParentId { get; set; }
        public int PostTypeId { get; set; }
        public int Score { get; set; }
        public string? Tags { get; set; }
        public string? Title { get; set; }
        public int? ViewCount { get; set; }

        public virtual Post? AcceptedAnswer { get; set; }
        public virtual User? OwnerUser { get; set; }
        public virtual Post? Parent { get; set; }
        public virtual PostType PostType { get; set; } = null!;
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Post> InverseAcceptedAnswer { get; set; }
        public virtual ICollection<Post> InverseParent { get; set; }
        public virtual ICollection<PostHistory> PostHistories { get; set; }
        public virtual ICollection<PostLink> PostLinkPosts { get; set; }
        public virtual ICollection<PostLink> PostLinkRelatedPosts { get; set; }
        public virtual ICollection<PostTag> PostTags { get; set; }
        public virtual ICollection<Vote> Votes { get; set; }
    }
}
