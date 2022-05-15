using System;
using RestaurantModel;
using System.IO;
using Microsoft.Data.SqlClient;

namespace RestaurantDl
{
    public class RestaurantRepository : IItemRepository<RestaurantModelClass>,IAvgReviewRepository
    {
       
        private readonly string connectionString;
       
        public RestaurantRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public List<RestaurantModelClass> GetItemFromDB()
        {
            string result = "error";
            using SqlConnection connection = new(connectionString);
            var restaurants = new List<RestaurantModelClass>();
           
            try
            {
                string commandString = "SELECT * FROM Restaurants";

                var avgList = getAvgReview();

                connection.Open();
                using SqlCommand command = new(commandString, connection);

                using SqlDataReader reader = command.ExecuteReader();
               
                var reviewList= getReview();
                foreach (var item in avgList)
                {
                    while (reader.Read())
                    {
                        List<ReviewModelClass> restReviewList=new List<ReviewModelClass>();
                        foreach (var reItem in reviewList)
                        {
                            if (reader.GetInt32(0) == reItem.RestaurantId)
                            {
                                restReviewList.Add(reItem);

                            }
                        }
                       
                        restaurants.Add(new RestaurantModelClass
                        {
                            RestaurantId = reader.GetInt32(0),
                            RestaurantName = reader.GetString(1),
                            Address1 = reader.GetString(2),
                            city = reader.GetString(3),
                            state = reader.GetString(4),
                            ZipCode = reader.GetString(5),
                            CostType = reader.GetString(6),
                            Website = reader.GetString(7),
                            ContactNo = reader.GetDecimal(8),
                            rating = double.Parse(item.Rating),
                            Reviews = restReviewList

                        });
                        break;
                    }
                }

                return restaurants;
            }
            catch (Exception ex)
            {
                //Log.Information(ex.Message);
                result = ex.Message;
            }
            finally
            {
                connection.Close();
            }
            return restaurants;
        }

        private List<ReviewModelClass> getReview()
        {
            var reviewList = new List<ReviewModelClass>();
            using SqlConnection connection = new(connectionString);
            try
            {
                string commandString = "select r.*,(u.firstname + ' ' + u.LastName) as 'UserName' from Reviews as r INNER join Users as u on r.RatedBy = u.userID order by RestaurantId; ";
                connection.Open();
                SqlCommand reviewCommand = new(commandString, connection);
                SqlDataReader reviewReader = reviewCommand.ExecuteReader();

            while (reviewReader.Read())
            {
                reviewList.Add(new ReviewModelClass
                {
                    ReviewId = reviewReader.GetInt32(0),
                    RestaurantId = reviewReader.GetInt32(1),
                    UserID = reviewReader.GetInt32(2),
                    Rating = reviewReader.GetDouble(3),
                    Comments = reviewReader.GetString(4),
                    ReviewTime = reviewReader.GetDateTime(5),
                    UserName = reviewReader.GetString(6)
                });
            }
         }
            
             catch (Exception ex)
            {
               // Log.Information(ex.Message);
               
            }
            finally
            {
                connection.Close();
            }
            return reviewList;
        }

        public string AddItemToDB(RestaurantModelClass item)
        {
            string result = "error";
            string commandString = "INSERT INTO Restaurants(RestaurantName,RestaurantAddress1,RestaurantCity,RestaurantState,RestaurantZipCode,Costtype,Website,Phoneno)VALUES(@RName,@RAddress1,@RCity,@RState,@RZipCode,@RCosttype,@RWebsite,@RPhoneno)";

            using SqlConnection connection = new(connectionString);
            try
            {

                connection.Open();
                using SqlCommand command = new(commandString, connection);
                command.Parameters.AddWithValue("@RName", item.RestaurantName);
                command.Parameters.AddWithValue("@RAddress1", item.Address1);
                command.Parameters.AddWithValue("@RCity", item.city);
                command.Parameters.AddWithValue("@RState", item.state);
                command.Parameters.AddWithValue("@RZipCode", item.ZipCode);
                command.Parameters.AddWithValue("@RCosttype", item.CostType);
                command.Parameters.AddWithValue("@RWebsite", item.Website);
                command.Parameters.AddWithValue("@RPhoneno", item.ContactNo);
                command.ExecuteNonQuery();

                result = "Restaurant Added!!!";
            }
            catch (Exception ex)
            {
                //Log.Information(ex.Message);
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
            
            string commandString = "Select AVG(r.ratings) as rating ,rs.RestaurantId from Reviews as r Right JOIN Restaurants as rs on r.RestaurantId = rs.RestaurantId GROUP BY rs.RestaurantId";
            using SqlConnection connection = new(connectionString);
            var avgRatingRest = new List<AvgRating>();
            try
            {

            
            connection.Open();
            using SqlCommand command = new(commandString, connection);
            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                avgRatingRest.Add(new AvgRating
                {
                    Rating = reader.IsDBNull(0) ? "0" : reader.GetDouble(0).ToString("#.#"),
                    RestaurantId = reader.GetInt32(1),
                });
            }
            }
            catch (Exception ex)
            {
                //Log.Information(ex.Message);
                
            }
            finally
            {
                connection.Close();
            }

            return avgRatingRest;

        }

    }
}

