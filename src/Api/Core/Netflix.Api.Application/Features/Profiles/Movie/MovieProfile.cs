using AutoMapper;
using Netflix.Api.Application.Features.Commands.Movies.CreateMovie;
using Netflix.Api.Application.Features.Dtos.Movie;
using Netflix.Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Netflix.Api.Application.Features.Profiles.Movie
{
    public class MovieProfile:Profile
    {
        public MovieProfile()
        {
            CreateMap<CreateMovieCommand, Netflix.Api.Domain.Entities.Movie>().ReverseMap();
            CreateMap<Domain.Entities.Movie, CreatedMovieDto>().ReverseMap();


        }
    }
}
