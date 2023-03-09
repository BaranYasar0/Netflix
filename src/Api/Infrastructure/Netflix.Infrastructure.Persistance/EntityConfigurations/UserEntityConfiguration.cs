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
    public class UserEntityConfiguration:BaseEntityConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.Email)
                .HasColumnName("E-mail");

            builder.Property(x => x.FirstName)
                .HasColumnName("FirstName");

            builder.Property(x => x.LastName)
                .HasColumnName("LastName");

            builder.Property(x => x.ContactNumber)
                .HasColumnName("ContactNumber");

            builder.HasMany(x => x.UserOperationClaims);

        }
    }
}
