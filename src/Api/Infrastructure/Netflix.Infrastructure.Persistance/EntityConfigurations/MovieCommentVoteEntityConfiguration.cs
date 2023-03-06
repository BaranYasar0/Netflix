using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Netflix.Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix.Infrastructure.Persistance.EntityConfigurations
{
    public class MovieCommentVoteEntityConfiguration:BaseEntityConfiguration<MovieCommentVote>
    {
    public override void Configure(EntityTypeBuilder<MovieCommentVote> builder)
        {
            builder.Property(x => x.VoteType)
                .HasColumnName("VoteType");

            builder.Property(x => x.UserId)
                .HasColumnName("User_Id");

            builder.Property(x => x.MovieCommentId)
                .HasColumnName("MovieCommentId");

            builder.HasOne(x => x.User)
                .WithMany(x => x.MovieCommentVotes)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.MovieComment)
                .WithMany(x => x.MovieCommentVotes)
                .HasForeignKey(x => x.MovieCommentId);
        }
    }
}
