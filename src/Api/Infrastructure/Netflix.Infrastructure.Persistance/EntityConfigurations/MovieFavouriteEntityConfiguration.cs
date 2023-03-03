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
    public class MovieFavouriteEntityConfiguration:BaseEntityConfiguration<MovieFavourite>
    {
        public override void Configure(EntityTypeBuilder<MovieFavourite> builder)
        {
            builder.Property(x => x.UserId)
                    .HasColumnName("User_Id");

            builder.Property(x => x.MovieId)
                .HasColumnName("MovieId");

            builder.HasOne(x => x.User)
                .WithMany(x => x.MovieFavourites)
                .HasForeignKey(x => x.UserId);

            builder.HasOne(x => x.Movie)
                .WithMany(x => x.MovieFavourites)
                .HasForeignKey(x => x.MovieId);
        }
    }
}
