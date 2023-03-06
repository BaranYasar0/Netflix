using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix.Api.Application.Features.Dtos.Movie
{
    public class CreatedMovieDto
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public string Duration { get; set; }

        public CreatedMovieDto(string name, string? description, string duration)
        {
            Name = name;
            Description = description;
            Duration = duration;
        }
    }
}
