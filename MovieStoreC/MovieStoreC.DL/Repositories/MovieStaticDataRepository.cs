using MovieStoreC.DL.Interfaces;
using MovieStoreC.DL.StaticData;
using MovieStoreC.Models.DTO;

namespace MovieStoreC.DL.Repositories
{
<<<<<<< HEAD
    //internal class MovieStaticDataRepository : IMovieRepository
    //{
    //    //public List<Movie> GetAll()
    //    //{
    //    //    return StaticDb.Movies;
    //    //}
=======
    public class MovieStaticDataRepository : IMovieRepository
    {
        public List<Movie> GetAll()
        {
            return StaticDb.Movie;
        }
>>>>>>> 42d0ae08e354bd7bc352e85410f40a5fdb6252a1

    //    //public Movie? GetById(string id)
    //    //{
    //    //    if (string.IsNullOrEmpty(id)) return null;

<<<<<<< HEAD
    //    //    return StaticDb.Movies
    //    //        .FirstOrDefault(x => x.Id == id);
    //    //}
    //}
=======
            return StaticDb.Movie
                .FirstOrDefault(x => x.Id == id);
        }
>>>>>>> 42d0ae08e354bd7bc352e85410f40a5fdb6252a1

    }
   
}
