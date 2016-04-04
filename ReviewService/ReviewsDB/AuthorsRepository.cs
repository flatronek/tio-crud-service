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
    public class AuthorsRepository : IAuthorsRepository
    {
        private readonly string _reviewsConnection = DatabaseConnections.ReviewsConnection;
        private readonly string _collectionName = "authors";

        public int Add(Person author)
        {
            using (var db = new LiteDatabase(_reviewsConnection))
            {
                var repository = db.GetCollection<Person>(_collectionName);

                if (repository.FindById(author.Id) != null)
                    repository.Update(author);
                else
                    repository.Insert(author);

                return author.Id;
            }
        }

        public bool Delete(int id)
        {
            using (var db = new LiteDatabase(_reviewsConnection))
            {
                var repository = db.GetCollection<Person>(_collectionName);

                return repository.Delete(id);
            }
        }

        public Person Get(int id)
        {
            using (var db = new LiteDatabase(_reviewsConnection))
            {
                var repository = db.GetCollection<Person>(_collectionName);

                return repository.FindById(id);
            }
        }

        public List<Person> GetAll()
        {
            using (var db = new LiteDatabase(_reviewsConnection))
            {
                return db.GetCollection<Person>(_collectionName).FindAll().ToList();
            }
        }

        public Person Update(Person review)
        {
            using (var db = new LiteDatabase(_reviewsConnection))
            {
                var repository = db.GetCollection<Person>(_collectionName);

                if (repository.Update(review))
                    return review;
                else
                    return null;
            }
        }
    }
}
