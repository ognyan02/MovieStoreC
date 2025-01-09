using MovieStoreC.Models.DTO;

namespace MovieStoreC.DL.StaticData
{
    internal static class StaticDb
    {
<<<<<<< HEAD
        public static List<Actor> Actors { get; set; } = new List<Actor>()
=======
        public static List<Actor> Actor { get; set; } = new List<Actor>()
        {
            new Actor()
            {
                Id = 1,
                Title = "Actor1"
               
            },
            new Actor()
            {
                Id = 2,
                Title = "Actor2"

            },
            new Actor()
            {
                Id = 3,
                Title = "Actor3",
                
            }
        };

public static List<Movie> Movie { get; set; } = new List<Movie>()
>>>>>>> 42d0ae08e354bd7bc352e85410f40a5fdb6252a1
        {
            new Actor()
            {
                Id = 1,
<<<<<<< HEAD
                Name = "Actor1"
=======
                Title = "Movie1",
                Year = 2015

>>>>>>> 42d0ae08e354bd7bc352e85410f40a5fdb6252a1
            },
            new Actor()
            {
                Id = 2,
<<<<<<< HEAD
                Name = "Actor2"
=======
                Title = "Movie2",
                Year = 2016

>>>>>>> 42d0ae08e354bd7bc352e85410f40a5fdb6252a1
            },
            new Actor()
            {
                Id = 3,
<<<<<<< HEAD
                Name = "Actor3"
            }
        };

        //public static List<Movie> Movies { get; set; } = new List<Movie>()
        //{
        //    new Movie()
        //    {
        //        Id = 1,
        //        Title = "Test",
        //        Year = 2016,
        //        Actors = new List<int>(){1, 2}
        //    },
        //    new Movie()
        //    {
        //        Id = 2,
        //        Title = "Test2",
        //        Year = 2017,
        //        Actors = new List<int>(){2, 3}
        //    },
        //    new Movie()
        //    {
        //        Id = 3,
        //        Title = "Test3",
        //        Year = 2018,
        //        Actors = new List<int>(){1, 3}
        //    }
        //};

    }
=======
                Title = "Movie3",
                Year = 2017

            }
        };
>>>>>>> 42d0ae08e354bd7bc352e85410f40a5fdb6252a1
}
}

    

