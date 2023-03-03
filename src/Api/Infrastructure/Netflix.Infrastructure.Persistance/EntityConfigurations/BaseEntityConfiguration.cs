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
    public class BaseEntityConfiguration<T> : IEntityTypeConfiguration<T>where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id");

            builder.Property(x => x.CreatedDate)
                .ValueGeneratedOnAdd()
                .HasColumnName("Created_Date");

            builder.Property(x => x.UpdatedDate)
                .ValueGeneratedOnAdd()
                .HasColumnName("Updated_Date");
        }
    }
}
