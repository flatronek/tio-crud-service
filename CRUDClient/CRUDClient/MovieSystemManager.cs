using CRUDClient.MoviesService;
using CRUDClient.ReviewsService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDClient
{
    public class MovieSystemManager
    {
        private MoviesServiceClient moviesClient;
        private ReviewsServiceClient reviewsClient;

        private Person user;

        public MovieSystemManager(MoviesServiceClient moviesClient, ReviewsServiceClient reviewsClient)
        {
            this.moviesClient = moviesClient;
            this.reviewsClient = reviewsClient;

            if (moviesClient.GetAll().Count == 0)
            {
                initMoviesDB();
            }
        }

        public void initMoviesDB()
        {
            List<Movie> movies = new List<Movie>();
            movies.Add(new Movie() { Id = 1, Title = "Movie1", ReleaseYear = 1990 });
            movies.Add(new Movie() { Id = 2, Title = "Movie2", ReleaseYear = 1991 });
            movies.Add(new Movie() { Id = 3, Title = "Movie3", ReleaseYear = 1992 });

            movies.ForEach(movie => moviesClient.Add(movie));
        }

        public void InitUser()
        {
            Console.WriteLine("Please enter your first name: ");
            String firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name: ");
            String lastName = Console.ReadLine();

            List<Person> users = reviewsClient.GetAllAuthors();

            Person existingUser = users.Find(user => user.Name.Equals(firstName) && user.Surname.Equals(lastName));
            if (existingUser != null)
            {
                this.user = existingUser;
            }
            else
            {
                this.user = new Person() { Id = GetAuthorId(), Name = firstName, Surname = lastName };
                int userId = reviewsClient.AddAuthor(user);
            }
        }

        public void ShowMenu()
        {
            Console.WriteLine("1. Add review");
            Console.WriteLine("2. Edit review");
            Console.WriteLine("3. Remove review");
            Console.WriteLine("Press 'Esc' to exit.");
        }

        public void HandleUserInput()
        {
            ConsoleKeyInfo cki = Console.ReadKey();

            Console.Clear();
            switch (cki.Key)
            {
                case ConsoleKey.D1:
                    AddReview();
                    break;
                case ConsoleKey.D2:
                    EditReview();
                    break;
                case ConsoleKey.D3:
                    RemoveReview();
                    break;
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
            }
        }

        public void AddReview()
        {
            Console.WriteLine("Choose movie: ");

            List<Movie> movies = moviesClient.GetAll();
            movies.ForEach(movie => Console.WriteLine("{0}: {1}, {2}", movie.Id, movie.Title, movie.ReleaseYear));

            string input = Console.ReadLine();
            int movieId;

            if (int.TryParse(input, out movieId))
            {
                Console.WriteLine("Write your review: ");
                string content = Console.ReadLine();

                Console.WriteLine("Score the movie [0-100]: ");

                string scoreStr = Console.ReadLine();
                int score;

                if (int.TryParse(scoreStr, out score))
                {
                    Review review = new Review()
                    {
                        Id = GetReviewId(),
                        MovieId = movieId,
                        Content = content,
                        Author = user
                    };
                    reviewsClient.AddReview(review);

                    Console.WriteLine("Review successfully added.");
                }
            }
            else
                Console.WriteLine("Wrong input.");
        }

        public void EditReview()
        {
            Console.WriteLine("Choose review: ");

            List<Review> reviews = reviewsClient.GetAllReviews().FindAll(review => review.Author.Id == user.Id);
            reviews.ForEach(review => Console.WriteLine("{0}: {1}, {2}", review.Id, review.Content, moviesClient.Get(review.MovieId).Title));

            string input = Console.ReadLine();
            int reviewId;

            if (int.TryParse(input, out reviewId))
            {
                Review oldReview = reviews.Find(review => review.Id == reviewId);

                Console.WriteLine("Write your review: ");
                string content = Console.ReadLine();

                Console.WriteLine("Score the movie [0-100]: ");

                string scoreStr = Console.ReadLine();
                int score;

                if (int.TryParse(scoreStr, out score))
                {
                    Review review = new Review()
                    {
                        Id = oldReview.Id,
                        MovieId = oldReview.MovieId,
                        Content = content,
                        Author = oldReview.Author
                    };

                    reviewsClient.UpdateReview(review);
                    Console.WriteLine("Review successfully updated.");
                }
            }
            else
                Console.WriteLine("Wrong input.");
        }

        public void RemoveReview()
        {
            Console.WriteLine("Choose review: ");

            List<Review> reviews = reviewsClient.GetAllReviews().FindAll(review => review.Author.Id == user.Id);
            reviews.ForEach(review => Console.WriteLine("{0}: {1}, {2}", review.Id, review.Content, moviesClient.Get(review.MovieId).Title));

            string input = Console.ReadLine();
            int reviewId;

            if (int.TryParse(input, out reviewId))
            {
                reviewsClient.DeleteReview(reviewId);
                Console.WriteLine("Deleted.");
            }
            else
                Console.WriteLine("Wrong input.");
        }

        internal int GetAuthorId()
        {
            List<Person> authors = reviewsClient.GetAllAuthors();

            if (authors.Count == 0)
                return 0;

            return authors.Last().Id + 1;
        }

        internal int GetReviewId()
        {
            List<Review> reviews = reviewsClient.GetAllReviews();

            if (reviews.Count == 0)
                return 0;

            return reviews.Last().Id + 1;
        }
    }
}
