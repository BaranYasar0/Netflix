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
    public class MovieEntityConfiguration:BaseEntityConfiguration<Movie>
    {
    public override void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.Property(x => x.Name)
                .HasColumnName("MovieName");

            builder.Property(x => x.Description)
                .HasColumnName("Description");

            builder.Property(x => x.Duration)
                .HasColumnName("MovieLength");
        }
    }
}
