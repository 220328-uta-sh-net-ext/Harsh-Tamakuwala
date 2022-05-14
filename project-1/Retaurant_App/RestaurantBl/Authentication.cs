using RestaurantDl;
using RestaurantModel;

namespace RestaurantBl
{
    public static class Globals
    {

        public static string choice = "NoChoice";
        public static string userChoice = "Registered";
        public static string userName = "Admin";
        public static int userId = 0;
    }
    public class Authentication
    {

        readonly IItemRepository<UserModelClass> repo;
        public Authentication(IItemRepository<UserModelClass> repo)
        {
            this.repo = repo;
        }
        /// <summary>
        /// if choice = admin
        /// then emailId = "admin@gmail.com"
        /// and password = admin123@
        /// </summary>
        /// <param name="choice">it checks wether person is admin or user</param>
        /// <param name="userChoice"> it will check wether user is new or already registered</param>
        /// <returns>returns the string wether login is successful or not </returns>
        public string Login(string choice, string emailId, string password)
        {


            if (choice == "Admin")
            {
                var email = "admin@gmail.com";
                var pass = "admin123@";
               
                if (emailId == email && password == pass)
                {
                    Console.Clear();
                    Console.WriteLine("\n----------Login Successful!!----------\n");
                    return "Login Successful";
                }
            }
            else if (choice == "User")
            {
                
               var allUders= repo.GetItemFromDB();
               
                foreach (var user in allUders)
                {
                    Console.WriteLine(user.EmailId);
                    Console.WriteLine(user.Password);
                    if (user.EmailId == emailId && user.Password == password)
                    {
                        Console.Clear();
                        Globals.userName = user.FirstName + " " + user.LastName;
                        Globals.userId = user.UserId;
                        return "Login Successful";
                    }
                    
                }
                return "Login Failed";
                Console.Clear();
                
                
            }
            return "Login Failed";
        }



        
    }
}

