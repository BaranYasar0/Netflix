using Netflix.Api.Application.Exceptions;
using Netflix.Api.Application.Features.Rules.Common;
using Netflix.Api.Application.Services.Repositories;
using Netflix.Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Netflix.Api.Application.Features.Rules
{
    public class MovieBusinessRules:BaseBusinessRule
    {
        private readonly IMovieRepository _movieRepository;

        public MovieBusinessRules(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task IsMovieNameExists(params string[] names)
        {
            foreach (var name in names)
            {
                Movie tempMovie = await _movieRepository.GetAsync(x => x.Name == name,disaableTracking:true);
                if (tempMovie != null)
                    throw new BusinessException("Aynı isme sahip bir Film var!");
            }
        }

        public async Task AreMoviesNull(params Movie[] movies)
        {
            foreach (var movie in movies)
            {
                if (movie.Name == null || movie.Duration==null) throw new BusinessException("Film boş!");
            }
        }
    }
}
