using CRUDClient.MoviesService;
using CRUDClient.ReviewsService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDClient
{
    class CrudClient
    {
        static void Main(string[] args)
        {
            MovieSystemManager manager = new MovieSystemManager(new MoviesServiceClient(), new ReviewsServiceClient());

            manager.InitUser();

            while (true)
            {
                manager.ShowMenu();
                manager.HandleUserInput();
            }
           
        }
    }
}
