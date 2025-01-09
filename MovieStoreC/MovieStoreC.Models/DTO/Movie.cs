namespace MovieStoreC.Models.DTO
{
    public class Movie
    {
        public string Id { get; set; }

        public string Title { get; set; } = string.Empty;
        public int Year { get; set; }

<<<<<<< HEAD
        public List<int> Actors { get; set; }
=======
        public List<int>Actor { get; set; }
        public List<Movie>Movies { get; set; }
>>>>>>> 42d0ae08e354bd7bc352e85410f40a5fdb6252a1
    }
}
