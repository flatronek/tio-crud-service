using DBInterfaces;
using LiteDB;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewsDB
{

    public class ReviewsRepository : IReviewsRepository
    {
        private readonly string _reviewsConnection = DatabaseConnections.ReviewsConnection;

        public int Add(Review review)
        {
            using (var db = new LiteDatabase(_reviewsConnection))
            {
                var repository = db.GetCollection<Review>("reviews");

                if (repository.FindById(review.Id) != null)
                    repository.Update(review);
                else
                    repository.Insert(review);

                return review.Id;
            }
        }

        public bool Delete(int id)
        {
            using (var db = new LiteDatabase(_reviewsConnection))
            {
                var repository = db.GetCollection<Person>("reviews");

                return repository.Delete(id);
            }
        }

        public Review Get(int id)
        {
            using (var db = new LiteDatabase(_reviewsConnection))
            {
                var repository = db.GetCollection<Review>("reviews");

                return repository.FindById(id);
            }
        }

        public List<Review> GetAll()
        {
            using (var db = new LiteDatabase(_reviewsConnection))
            {
                return db.GetCollection<Review>("reviews").FindAll().ToList();
            }
        }

        public Review Update(Review review)
        {
            using (var db = new LiteDatabase(_reviewsConnection))
            {
                var repository = db.GetCollection<Review>("reviews");

                if (repository.Update(review))
                    return review;
                else
                    return null;
            }
        }
    }
}
