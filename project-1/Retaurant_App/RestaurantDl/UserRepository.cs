using Microsoft.Data.SqlClient;
using RestaurantModel;
using System.IO;

namespace RestaurantDl
{
    public class UserRepository : IItemRepository<UserModelClass>
    {
        private const string connectionStringFilePath = "../RestaurantDl/Db-Connection-string-File.txt";
        private readonly string connectionString;

        public UserRepository()
        {
            
            connectionString = File.ReadAllText(connectionStringFilePath);
        }
        public List<UserModelClass> GetItemFromDB()
        {
            string commandString = "SELECT * FROM Users";

            using SqlConnection connection = new(connectionString);
            var users = new List<UserModelClass>();
            try
            {
                connection.Open();
                using SqlCommand command = new(commandString, connection);

                using SqlDataReader reader = command.ExecuteReader();

               
                while (reader.Read())
                {
                    users.Add(new UserModelClass
                    {
                        UserId = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        EmailId = reader.GetString(3),
                        Password = reader.GetString(4),
                        ContactNo = reader.GetDecimal(5),
                    });
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            //foreach (var user in users)
            //{
            //    Console.WriteLine(user.FirstName);
            //}
            
            return users;
        }

        public string AddItemToDB(UserModelClass item)
        {
            
            string result = "error";
            string commandString = "INSERT INTO Users(FirstName,LastName,EmailId,UserPassword,ContactNo)VALUES(@fname, @lname, @email, @pass, @contact)";

            using SqlConnection connection = new(connectionString);
            try
            {
                
                connection.Open();
                using SqlCommand command = new(commandString, connection);
                command.Parameters.AddWithValue("@fname", item.FirstName);
                command.Parameters.AddWithValue("@lname", item.LastName);
                command.Parameters.AddWithValue("@email", item.EmailId);
                command.Parameters.AddWithValue("@pass", item.Password);
                command.Parameters.AddWithValue("@contact", item.ContactNo);
               
               var success= command.ExecuteNonQuery();
                Console.WriteLine(success);
                result = "User Added!!!";
                return result;
            }
            catch (Exception ex)
            {
                result = ex.Message;

                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
               
                
        }

        public void deleteUser(int id)
        {
            string commandString = "Delete from Users where userID=" + id;
            using SqlConnection connection = new(connectionString);
            try
            {
                connection.Open();
                using SqlCommand command = new(commandString, connection);
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        public void updateUser(int id,UserModelClass user)
        {
            string commandString = "Update Users set FirstName = '"+user.FirstName+"' ,LastName = '"+user.LastName+"' ,EmailId = '"+user.EmailId+ "' ,ContactNo = '" + user.ContactNo+"' ,UserPassword = '"+user.Password+"' where userID=" + id;
            using SqlConnection connection = new(connectionString);
            try
            {
                connection.Open();
                using SqlCommand command = new(commandString, connection);
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }


    }
}