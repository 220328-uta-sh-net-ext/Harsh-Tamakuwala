using System;
using RestaurantModel;
using Microsoft.Data.SqlClient;

namespace RestaurantDl
{
    public class ReviewRepository : IItemRepository<ReviewModelClass>
    {
        //private const string connectionStringFilePath = "../RestaurantDl/Db-Connection-string-File.txt";
        private readonly string connectionString;
        //public ReviewRepository()
        //{
        //    connectionString = File.ReadAllText(connectionStringFilePath);
        //}
        public ReviewRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<ReviewModelClass> GetItemFromDB()
        {
            string commandString = "SELECT r.*,u.firstname + ' ' + LastName ,rs.RestaurantName from Reviews as r INNER join Users as u on r.RatedBy = u.userID INNER join Restaurants as rs on r.RestaurantId = rs.RestaurantId Order by r.Reviewtime desc ";
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
                    UserID = reader.GetInt32(2),
                    Rating = reader.GetDouble(3),
                    Comments = reader.GetString(4),
                    ReviewTime = reader.GetDateTime(5),
                    UserName = reader.GetString(6),
                    RestaurantName = reader.GetString(7),
                });


            }
           
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
                command.Parameters.AddWithValue("@RateedBy", item.UserID);
                command.Parameters.AddWithValue("@Ratetime", item.ReviewTime);

               command.ExecuteNonQuery();
               
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

        
    }
}

