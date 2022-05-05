using System;
using RestaurantModel;
using Microsoft.Data.SqlClient;

namespace RestaurantDl
{
    public class ReviewRepository : IItemRepository<ReviewModelClass>, IAvgReviewRepository
    {
        private const string connectionStringFilePath = "../RestaurantDl/Db-Connection-string-File.txt";
        private readonly string connectionString;
        public ReviewRepository()
        {
            connectionString = File.ReadAllText(connectionStringFilePath);
        }

        public List<ReviewModelClass> GetItemFromDB()
        {
            string commandString = "SELECT r.* , rs.RestaurantName from Reviews as r JOIN Restaurants as rs on r.RestaurantId = rs.RestaurantId Order by r.Reviewtime desc";
            using SqlConnection connection = new(connectionString);
            var reviews = new List<ReviewModelClass>();

            connection.Open();
            using SqlCommand command = new(commandString, connection);

            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                reviews.Add(new ReviewModelClass
                {
                    ReviewId = reader.GetInt32(0),
                    RestaurantId = reader.GetInt32(1),
                    Rating = reader.GetDouble(2),
                    Comments = reader.GetString(3),
                    UserName = reader.GetString(4),
                    ReviewTime = reader.GetDateTime(5),
                    RestaurantName = reader.GetString(6),
                });


            }
            //foreach (var review in reviews)
            //{
            //    Console.WriteLine(review.RestaurantName);
            //}

            return reviews;
        }

        public string AddItemToDB(ReviewModelClass item)
        {
            string result = "error";
            string commandString = "INSERT INTO Reviews(RestaurantId,Ratings,Note,RatedBy,Reviewtime)VALUES(@Rid, @Rating, @Note, @RateedBy,@Ratetime)";

            using SqlConnection connection = new(connectionString);
            try
            {

                connection.Open();
                using SqlCommand command = new(commandString, connection);
                command.Parameters.AddWithValue("@Rid", item.RestaurantId);
                command.Parameters.AddWithValue("@Rating", item.Rating);
                command.Parameters.AddWithValue("@Note", item.Comments);
                command.Parameters.AddWithValue("@RateedBy", item.UserName);
                command.Parameters.AddWithValue("@Ratetime", item.ReviewTime);

                var success = command.ExecuteNonQuery();
                Console.WriteLine(success);
                result = "Review Added!!!";
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            finally
            {
                connection.Close();
            }

            return result;
        }

        public List<AvgRating> getAvgReview()
        {
            Console.Clear();
            string commandString = "Select AVG(r.ratings) as rating ,rs.RestaurantId from Reviews as r Right JOIN Restaurants as rs on r.RestaurantId = rs.RestaurantId GROUP BY rs.RestaurantId Order by rating desc";
            using SqlConnection connection = new(connectionString);

            connection.Open();
            using SqlCommand command = new(commandString, connection);
            using SqlDataReader reader = command.ExecuteReader();


           var avgRatingRest = new List<AvgRating>();

            while (reader.Read())
            {
                avgRatingRest.Add(new AvgRating
                {
                    Rating = reader.IsDBNull(0) ? "0" : reader.GetDouble(0).ToString(),
                    RestaurantId = reader.GetInt32(1),
                });
            }

            //foreach (var avgReview in avgRatingRest)
            //{

            //        Console.WriteLine(avgReview.rating+ " " + avgReview.RestaurantId);

            //}
            return avgRatingRest;

        }
    }
}

