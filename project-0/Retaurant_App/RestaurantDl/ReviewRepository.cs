using System;
using RestaurantModel;
using Microsoft.Data.SqlClient;

namespace RestaurantDl
{
	public class ReviewRepository : IItemRepository<ReviewModelClass>
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
                Rating = reader.GetInt32(2),
                Comments = reader.GetString(3),
                UserName = reader.GetString(4),
                ReviewTime = reader.GetDateTime(5),
                RestaurantName = reader.GetString(6),
            });


        }
            foreach (var review in reviews)
            {
                Console.WriteLine(review.RestaurantName);
            }

            return reviews;
    }

        public string AddItemToDB(ReviewModelClass item)
        {
            throw new NotImplementedException();
        }

        
    }
}

