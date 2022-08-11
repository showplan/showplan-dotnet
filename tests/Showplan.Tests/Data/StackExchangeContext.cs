using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Showplan.Tests.Data
{
    public partial class StackExchangeContext : DbContext
    {
        public StackExchangeContext()
        {
        }

        public StackExchangeContext(DbContextOptions<StackExchangeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Badge> Badges { get; set; } = null!;
        public virtual DbSet<Comment> Comments { get; set; } = null!;
        public virtual DbSet<LinkType> LinkTypes { get; set; } = null!;
        public virtual DbSet<Post> Posts { get; set; } = null!;
        public virtual DbSet<PostHistory> PostHistories { get; set; } = null!;
        public virtual DbSet<PostHistoryType> PostHistoryTypes { get; set; } = null!;
        public virtual DbSet<PostLink> PostLinks { get; set; } = null!;
        public virtual DbSet<PostTag> PostTags { get; set; } = null!;
        public virtual DbSet<PostType> PostTypes { get; set; } = null!;
        public virtual DbSet<Tag> Tags { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<Vote> Votes { get; set; } = null!;
        public virtual DbSet<VoteType> VoteTypes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=sports.stackexchange.com;integrated security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Badge>(entity =>
            {
                entity.Property(e => e.Class).HasComment("The class of the badge. 1 = Gold, 2 = Silver, 3 = Bronze.");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(40);

                entity.Property(e => e.TagBased).HasComment("True if badge is for a tag, otherwise it is a named badge.");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.Property(e => e.ContentLicense).HasMaxLength(250);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Text).HasMaxLength(700);

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comments_PostId__Posts_Id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Comments_UserId__Users_Id");
            });

            modelBuilder.Entity<LinkType>(entity =>
            {
                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.HasIndex(e => new { e.Id, e.AcceptedAnswerId }, "IX_Posts_Id_AcceptedAnswerId")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.OwnerUserId }, "IX_Posts_Id_OwnerUserId")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.ParentId }, "IX_Posts_Id_ParentId")
                    .IsUnique();

                entity.Property(e => e.AcceptedAnswerId).HasComment("Id of the accepted anser. Only present if PostTypeId = 1 (question).");

                entity.Property(e => e.Body).HasComment("The body as rendered HTML.");

                entity.Property(e => e.ClosedDate).HasColumnType("datetime");

                entity.Property(e => e.CommunityOwnedDate)
                    .HasColumnType("datetime")
                    .HasComment("The date the post became community owned. Present only if post is community wiki'd.");

                entity.Property(e => e.ContentLicense).HasMaxLength(250);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.LastActivityDate)
                    .HasColumnType("datetime")
                    .HasComment("The date and time of the post's most recent activity.");

                entity.Property(e => e.LastEditDate)
                    .HasColumnType("datetime")
                    .HasComment("The date and time of the most recent edit to the post.");

                entity.Property(e => e.LastEditorDisplayName).HasMaxLength(40);

                entity.Property(e => e.OwnerUserId).HasComment("User Id of the owner. Always -1 for tag wiki entries, i.e. the community user owns them.");

                entity.Property(e => e.ParentId).HasComment("The Id of the Parent. Only present if PostTypeId = 2 (answer).");

                entity.Property(e => e.Tags).HasMaxLength(150);

                entity.Property(e => e.Title).HasMaxLength(250);

                entity.HasOne(d => d.AcceptedAnswer)
                    .WithMany(p => p.InverseAcceptedAnswer)
                    .HasForeignKey(d => d.AcceptedAnswerId)
                    .HasConstraintName("FK_Posts_AcceptedAnswerId__Posts_Id");

                entity.HasOne(d => d.OwnerUser)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.OwnerUserId)
                    .HasConstraintName("FK_Posts_OwnerUserId__Users_Id");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Posts_ParentId__Posts_Id");

                entity.HasOne(d => d.PostType)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.PostTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Posts_PostTypeId__PostTypes_Id");
            });

            modelBuilder.Entity<PostHistory>(entity =>
            {
                entity.ToTable("PostHistory");

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.ContentLicense).HasMaxLength(250);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.RevisionGuid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("RevisionGUID")
                    .IsFixedLength()
                    .HasComment("At times more than one type of history record can be recorded by a single action. All of these will be grouped using the same RevisionGUID.");

                entity.Property(e => e.Text)
                    .HasColumnType("ntext")
                    .HasComment("A raw version of the new value for a given revision. \r\n\r\nIf PostHistoryTypeId in (10,11,12,13,14,15,19,20,35) this column will contain a JSON encoded string with all users who have voted for the PostHistoryTypeId\r\n\r\nIf it is a duplicate close vote, the JSON string will contain an array of original questions as OriginalQuestionIds\r\n\r\nIf PostHistoryTypeId = 17 this column will contain migration details of either from <url> or to <url>");

                entity.Property(e => e.UserDisplayName).HasMaxLength(40);

                entity.HasOne(d => d.PostHistoryType)
                    .WithMany(p => p.PostHistories)
                    .HasForeignKey(d => d.PostHistoryTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostHistory_PostHistoryTypeId__PostHistoryTypes_Id");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.PostHistories)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostHistory_PostId__Posts_Id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PostHistories)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_PostHistory_UserId__Users_Id");
            });

            modelBuilder.Entity<PostHistoryType>(entity =>
            {
                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<PostLink>(entity =>
            {
                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.HasOne(d => d.LinkType)
                    .WithMany(p => p.PostLinks)
                    .HasForeignKey(d => d.LinkTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostLinks_LinkTypeId__LinkTypes_Id");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.PostLinkPosts)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostLinks_PostId__Posts_Id");

                entity.HasOne(d => d.RelatedPost)
                    .WithMany(p => p.PostLinkRelatedPosts)
                    .HasForeignKey(d => d.RelatedPostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostLinks_RelatedPostId__Posts_Id");
            });

            modelBuilder.Entity<PostTag>(entity =>
            {
                entity.HasKey(e => new { e.PostId, e.Tag })
                    .HasName("PK_PostTags__PostId_Tag");

                entity.Property(e => e.Tag).HasMaxLength(50);

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.PostTags)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostTags_PostId__Posts_Id");
            });

            modelBuilder.Entity<PostType>(entity =>
            {
                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.Property(e => e.TagName).HasMaxLength(150);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.AboutMe).HasComment("The user's profile as rendered HTML.");

                entity.Property(e => e.AccountId).HasComment("The user's stack exchange network profile id.");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DisplayName).HasMaxLength(40);

                entity.Property(e => e.DownVotes).HasComment("The number of downvotes a user has cast.");

                entity.Property(e => e.EmailHash)
                    .HasMaxLength(40)
                    .HasComment("Always blank.");

                entity.Property(e => e.LastAccessDate).HasColumnType("datetime");

                entity.Property(e => e.Location).HasMaxLength(100);

                entity.Property(e => e.UpVotes).HasComment("The number of upvotes a user has cast.");

                entity.Property(e => e.Views).HasComment("The number of times the profile has been viewed.");

                entity.Property(e => e.WebsiteUrl).HasMaxLength(200);
            });

            modelBuilder.Entity<Vote>(entity =>
            {
                entity.Property(e => e.Id).HasComment("The bounty amount. Present only if VoteTypeId in (8, 9)");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasComment("The user Id of the voter. Present only if VoteTypeId in (5,8).");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.Votes)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Votes_PostId__Posts_Id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Votes)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Votes_UserId__Users_Id");

                entity.HasOne(d => d.VoteType)
                    .WithMany(p => p.Votes)
                    .HasForeignKey(d => d.VoteTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Votes_UserId__VoteTypes_Id");
            });

            modelBuilder.Entity<VoteType>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
