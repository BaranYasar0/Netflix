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
    public class UserOperationClaimEntityConfiguration:BaseEntityConfiguration<UserOperationClaim>
    {
        public override void Configure(EntityTypeBuilder<UserOperationClaim> builder)
        {

            builder.HasOne(x => x.User)
                .WithMany(x => x.UserOperationClaims)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.OperationClaim)
                .WithMany(x=>x.UserOperationClaims)
                .HasForeignKey(x=>x.OperationClaimId)
                .OnDelete(DeleteBehavior.Restrict);

            

                
        }
    }
}
