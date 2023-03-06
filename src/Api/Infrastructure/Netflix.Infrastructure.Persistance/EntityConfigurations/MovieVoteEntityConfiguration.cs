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
    public class MovieVoteEntityConfiguration:BaseEntityConfiguration<MovieVote>
    {
        public override void Configure(EntityTypeBuilder<MovieVote> builder)
        {
            builder.Property(x => x.VoteType)
                .HasColumnName("VoteType");

            builder.Property(x => x.MovieId)
                .HasColumnName("MovieId");

            builder.Property(x => x.UserId)
               .HasColumnName("User_Id");

            builder.HasOne(x => x.Movie)
                .WithMany(x => x.MovieVotes)
                .HasForeignKey(x => x.MovieId);

            builder.HasOne(x => x.User)
               .WithMany(x => x.MovieVotes)
               .HasForeignKey(x => x.UserId)
               .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
