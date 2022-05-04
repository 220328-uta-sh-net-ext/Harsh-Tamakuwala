﻿using System;
using RestaurantModel;
using System.IO;
using Microsoft.Data.SqlClient;

namespace RestaurantDl
{
    public class RestaurantRepository : IItemRepository<RestaurantModelClass>
    {
        private const string connectionStringFilePath = "../RestaurantDl/Db-Connection-string-File.txt";
        private readonly string connectionString;
        public RestaurantRepository()
        {
            connectionString = File.ReadAllText(connectionStringFilePath);
        }
        public List<RestaurantModelClass> GetItemFromDB()
        {
            string result = "error";
            using SqlConnection connection = new(connectionString);
            var restaurants = new List<RestaurantModelClass>();
            try
            {
                string commandString = "SELECT * FROM Restaurants";
              
               

                connection.Open();
                using SqlCommand command = new(commandString, connection);

                using SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
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

                    });

                }
                //foreach (var restaurant in restaurants)
                //{
                //    Console.WriteLine(restaurant.RestaurantName);
                //}

                return restaurants;
            }
            catch(Exception ex)
            {
                result = ex.Message;
            }
            finally
            {
                connection.Close();
            }
            return restaurants;
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
                var success = command.ExecuteNonQuery();

                result = "Restaurant Added!!!";
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

