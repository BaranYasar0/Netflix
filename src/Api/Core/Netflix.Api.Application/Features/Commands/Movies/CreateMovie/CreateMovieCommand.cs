using AutoMapper;
using FluentValidation;
using FluentValidation.AspNetCore;
using FluentValidation.Results;
using MediatR;
using Netflix.Api.Application.Features.Dtos.Movie;
using Netflix.Api.Application.Features.Rules;
using Netflix.Api.Application.Features.Rules.Common;
using Netflix.Api.Application.Services.Repositories;
using Netflix.Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Netflix.Api.Application.Features.Commands.Movies.CreateMovie
{
    public class CreateMovieCommand:IRequest<CreatedMovieDto>
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public string Duration { get; set; }

        public class CreateMovieCommandHandler : IRequestHandler<CreateMovieCommand, CreatedMovieDto>
        {
            private readonly IMapper _mapper;
            private readonly IMovieRepository _movieRepository;
            private readonly MovieBusinessRules _businessRules;
            private readonly IValidator<CreateMovieCommand> _validator;

            public CreateMovieCommandHandler(IMapper mapper, IMovieRepository movieRepository, MovieBusinessRules businessRules, IValidator<CreateMovieCommand> validator)
            {
                _mapper = mapper;
                _movieRepository = movieRepository;
                _businessRules = businessRules;
                _validator = validator;
            }

            public async Task<CreatedMovieDto> Handle(CreateMovieCommand request, CancellationToken cancellationToken)
            {
                await _businessRules.IsMovieNameExists(request.Name);

                Movie mappedMovie = _mapper.Map<Movie>(request);

                await _businessRules.AreMoviesNull(mappedMovie);

                Movie createdMovie = await _movieRepository.AddAsync(mappedMovie);
                CreatedMovieDto createdMovieDto = _mapper.Map<CreatedMovieDto>(createdMovie);
                return createdMovieDto;

            }
        }
    }
}
