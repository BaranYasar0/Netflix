using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Netflix.Api.Domain.Entities
{
    public class MovieComment:BaseEntity
    {
        public string Content { get; set; }
        public int MovieId { get; set; }
        public int UserId { get; set; }
        public Movie Movie { get; set; }
        public User User { get; set; }
        public ICollection<MovieCommentVote>? MovieCommentVotes { get; set; }


    }
}
