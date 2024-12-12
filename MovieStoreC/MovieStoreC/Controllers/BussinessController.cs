using Microsoft.AspNetCore.Mvc;
using MovieStoreC.BL.Interfaces;
using MovieStoreC.Models.Requests;
using System.Reflection.Metadata.Ecma335;

namespace MovieStoreC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BusinessController : ControllerBase
    {
        private readonly IBussinesService _movieService;
        private readonly ILogger<MoviesController> _logger;

        public BusinessController(IMoviesService movieService, ILogger<MoviesController> logger)
        {
            _movieService = movieService;
            _logger = logger;
        }
        [HttpGet("GetAllDetailedMovies")]
        public IActionResult GetAllDetailedMovies()
        {
            var result = _movieService.GetAllMovies();

            if (result != null && result.Count > 0)
            {
                return Ok(result);
            }
            return NotFound();
        }  
    }
}