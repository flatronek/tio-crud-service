using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Model;
using DBInterfaces;
using ReviewsDB;

namespace ReviewsCRUDService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ReviewsService : IReviewsService
    {
        private readonly IAuthorsRepository _authorsRepository;
        private readonly IReviewsRepository _reviewsRepository;

        public ReviewsService()
        {
            _authorsRepository = new AuthorsRepository();
            _reviewsRepository = new ReviewsRepository();
        }

        public int AddAuthor(Person author)
        {
            return _authorsRepository.Add(author);
        }

        public int AddReview(Review review)
        {
            return _reviewsRepository.Add(review);
        }

        public bool DeleteAuthor(int id)
        {
            return _authorsRepository.Delete(id);
        }

        public bool DeleteReview(int id)
        {
            return _reviewsRepository.Delete(id);
        }

        public List<Person> GetAllAuthors()
        {
            return _authorsRepository.GetAll();
        }

        public List<Review> GetAllReviews()
        {
            return _reviewsRepository.GetAll();
        }

        public Person GetAuthor(int id)
        {
            return _authorsRepository.Get(id);
        }

        public Review GetReview(int id)
        {
            return _reviewsRepository.Get(id);
        }

        public Person UpdateAuthor(Person author)
        {
            return _authorsRepository.Update(author);
        }

        public Review UpdateReview(Review review)
        {
            return _reviewsRepository.Update(review);
        }
    }
}
