using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix.Api.Domain.Entities
{
    public class User:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string? ContactNumber { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool Status { get; set; } = true;

        public ICollection<UserOperationClaim> UserOperationClaims { get; set; }

        public ICollection<MovieFavourite> MovieFavourites { get; set; }
        public ICollection<MovieVote> MovieVotes { get; set; }

        public ICollection<MovieComment> MovieComments { get; set; }
        public ICollection<MovieCommentVote> MovieCommentVotes { get; set; }

    }
}
