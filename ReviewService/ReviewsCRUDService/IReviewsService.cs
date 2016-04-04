using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ReviewsCRUDService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAuthorsService" in both code and config file together.
    [ServiceContract]
    public interface IReviewsService
    {
        [OperationContract]
        List<Person> GetAllAuthors();

        [OperationContract]
        int AddAuthor(Person author);

        [OperationContract]
        Person GetAuthor(int id);

        [OperationContract]
        Person UpdateAuthor(Person author);

        [OperationContract]
        bool DeleteAuthor(int id);



        [OperationContract]
        List<Review> GetAllReviews();

        [OperationContract]
        int AddReview(Review review);

        [OperationContract]
        Review GetReview(int id);

        [OperationContract]
        Review UpdateReview(Review review);

        [OperationContract]
        bool DeleteReview(int id);
    }
}
