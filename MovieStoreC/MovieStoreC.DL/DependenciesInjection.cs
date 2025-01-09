using Microsoft.Extensions.DependencyInjection;
using MovieStoreC.DL.Interfaces;
using MovieStoreC.DL.Repositories;
using MovieStoreC.DL.Repositories.MongoDb;

namespace MovieStoreC.DL
{
    public static class DependenciesInjection
    {
        public static IServiceCollection 
            RegisterRepositories(this IServiceCollection services)
        {
            return
                services
<<<<<<< HEAD
                    .AddSingleton<IMovieRepository,
                        MoviesMongoRepository>()
                    .AddSingleton<IActorRepository,
                        ActorStaticDataRepository>();
=======
                .AddSingleton<IMovieRepository,
                    MovieStaticDataRepository>()
                .AddSingleton<ActorRepository,
                    ActorStaticDataRepository>();
>>>>>>> 42d0ae08e354bd7bc352e85410f40a5fdb6252a1
        }
    }
}
