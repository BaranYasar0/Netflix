using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Netflix.Api.Domain.Entities
{
    public class Movie:BaseEntity
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public TimeSpan Duration { get; set; }
        //public int UserId { get; set; }
        public ICollection<Category> Categories { get; set; }
        public ICollection<MovieComment> MovieComments { get; set; }
        //public User User { get; set; }
        public ICollection<MovieFavourite> MovieFavourites { get; set; }
        public ICollection<MovieVote> MovieVotes { get; set; }

    }
}
