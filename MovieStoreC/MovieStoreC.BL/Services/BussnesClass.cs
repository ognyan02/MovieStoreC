using MovieStoreC.BL.Interfaces;
using MovieStoreC.DL.Interfaces;
using MovieStoreC.Models.DTO;
using MovieStoreC.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreC.BL.Services
{
    internal class BussnesClass : IBussnesClass
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IActorRepository _actorRepository;

        public BussnesClass(
            IMovieRepository  movieRepository, 
            IActorRepository actorRepository)
        {
            _movieRepository= movieRepository;
            _actorRepository= actorRepository;
        }

        public List<MovieFullDetails> GetMovies()
        {
            var result = new List<MovieFullDetails>();
            var movies = _movieRepository.GetAll();

            

            return result;
        }
    }
}
