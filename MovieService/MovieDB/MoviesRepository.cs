using DBInterfaces;
using LiteDB;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesDB
{
    public class MoviesRepository : IMoviesRepository
    {
    
        public int Add(Movie movie)
        {
            using (var db = new LiteDatabase(DatabaseConnections.MoviesConnection))
            {
                var repository = db.GetCollection<Movie>("movies");

                if (repository.FindById(movie.Id) != null)
                    repository.Update(movie);
                else
                    repository.Insert(movie);

                return movie.Id;
            }
        }

        public bool Delete(int id)
        {
            using (var db = new LiteDatabase(DatabaseConnections.MoviesConnection))
            {
                var repository = db.GetCollection<Movie>("movies");

                return repository.Delete(id);
            }
        }

        public Movie Get(int id)
        {
            using (var db = new LiteDatabase(DatabaseConnections.MoviesConnection))
            {
                var repository = db.GetCollection<Movie>("movies");

                return repository.FindById(id);
            }
        }

        public List<Movie> GetAll()
        {
            using (var db = new LiteDatabase(DatabaseConnections.MoviesConnection))
            {
                return db.GetCollection<Movie>("movies").FindAll().ToList();
            }
        }

        public Movie Update(Movie Movie)
        {
            using (var db = new LiteDatabase(DatabaseConnections.MoviesConnection))
            {
                var repository = db.GetCollection<Movie>("movies");

                if (repository.Update(Movie))
                    return Movie;
                else
                    return null;
            }
        }
    }
}
