using DBInterfaces;
using Model;
using MoviesDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MovieCRUDService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class MoviesService : IMoviesService
    {
        private readonly IMoviesRepository _moviesRepository;

        public MoviesService()
        {
            _moviesRepository = new MoviesRepository();
        }

        public int Add(Movie movie)
        {
            return _moviesRepository.Add(movie);
        }

        public bool Delete(int id)
        {
            return _moviesRepository.Delete(id);
        }

        public Movie Get(int id)
        {
            return _moviesRepository.Get(id);
        }

        public List<Movie> GetAll()
        {
            return _moviesRepository.GetAll();
        }

        public Movie Update(Movie Movie)
        {
            return _moviesRepository.Update(Movie);
        }
    }
}
