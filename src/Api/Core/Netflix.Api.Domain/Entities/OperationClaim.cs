using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix.Api.Domain.Entities
{
    public class OperationClaim:BaseEntity
    {
        public string Name { get; set; }
        public ICollection<UserOperationClaim> UserOperationClaims { get; set; }

        public OperationClaim()
        {

        }

        public OperationClaim(string name)
        {
            Name = name;
        }
    }

}

