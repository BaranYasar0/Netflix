using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix.Api.Domain.Entities
{
    public class Movie:BaseEntity
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public TimeSpan Duration { get; set; }
        public ICollection<Category> Categories { get; set; }
        public ICollection<MovieComment> MovieComments { get; set; }

    }
}
