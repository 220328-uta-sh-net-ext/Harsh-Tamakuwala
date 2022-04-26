using RestaurantModel;
using System.Data.SqlClient;
using System.IO;

namespace RestaurantDl
{
    public class UserRepository : IUserRepository
    {
        private const string connectionStringFilePath = "../RestaurantDl/Db-Connection-string-File.txt";
        private readonly string connectionString;

        public UserRepository()
        {
            
            connectionString = File.ReadAllText(connectionStringFilePath);
        }
        public List<UserModelClass> GetAllUsers()
        {
            string commandString = "SELECT * FROM Users";

            using SqlConnection connection = new(connectionString);
            connection.Open();
            using SqlCommand command = new(commandString, connection);
           
            using SqlDataReader reader = command.ExecuteReader();

            var users = new List<UserModelClass>();
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
            //foreach (var user in users)
            //{
            //    Console.WriteLine(user.FirstName);
            //}
            return users;
        }

        public string AddUserToDB(UserModelClass user)
        {
            
            string result = "error";
            string commandString = "INSERT INTO Users(FirstName,LastName,EmailId,UserPassword,ContactNo)VALUES(@fname, @lname, @email, @pass, @contact)";

            using SqlConnection connection = new(connectionString);
            try
            {
                
                connection.Open();
                using SqlCommand command = new(commandString, connection);
                command.Parameters.AddWithValue("@fname", user.FirstName);
                command.Parameters.AddWithValue("@lname", user.LastName);
                command.Parameters.AddWithValue("@email", user.EmailId);
                command.Parameters.AddWithValue("@pass", user.Password);
                command.Parameters.AddWithValue("@contact", user.ContactNo);
               
               var success= command.ExecuteNonQuery();
                Console.WriteLine(success);
                result = "User Added!!!";
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