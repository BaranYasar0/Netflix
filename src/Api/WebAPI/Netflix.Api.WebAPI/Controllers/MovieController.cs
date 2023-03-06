using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Netflix.Api.Application.Features.Commands.Movies.CreateMovie;
using Netflix.Api.Application.Services.Repositories;
using Netflix.Api.Domain.Entities;

namespace Netflix.Api.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : BaseController
    {
        private readonly IMovieRepository _movieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public MovieController(IMovieRepository movieRepository, ICategoryRepository categoryRepository)
        {
            _movieRepository = movieRepository;
            _categoryRepository = categoryRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateMovieCommand createMovieCommand) {

            return Ok(await Mediator.Send(createMovieCommand));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _movieRepository.GetListAsync());
        }
    }
}
