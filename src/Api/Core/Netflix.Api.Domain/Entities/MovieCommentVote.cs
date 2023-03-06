using Netflix.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix.Api.Domain.Entities
{
    public class MovieCommentVote:BaseEntity
    {
        public VoteType VoteType { get; set; }

        public int UserId { get; set; }
        public int MovieCommentId { get; set; }
        public User User { get; set; }
        public MovieComment MovieComment { get; set; }

        public MovieCommentVote()
        {
            MovieComment = new();
        }
    }
}
