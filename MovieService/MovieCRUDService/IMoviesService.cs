using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MovieCRUDService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IMoviesService
    {
        [OperationContract]
        List<Movie> GetAll();

        [OperationContract]
        int Add(Movie movie);

        [OperationContract]
        Movie Get(int id);

        [OperationContract]
        Movie Update(Movie Movie);

        [OperationContract]
        bool Delete(int id);
    }
}
