using RestaurantDl;
using RestaurantModel;

namespace RestaurantBl
{
    public static class Globals
    {

        public static string choice = "NoChoice";
        public static string userChoice = "Registered";
        public static string userName = "Admin";
    }
    public class Authentication
    {
        LoginModelClass loginModel = new LoginModelClass();
        public Authentication()
        {
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
                //email.Substring(0);
                if (emailId == email && password == pass)
                {
                    Console.Clear();
                    Console.WriteLine("\n----------Login Successful!!----------\n");
                    return "Login Successful";
                }
            }
            else if (choice == "User")
            {
                UserRepository userRepository = new UserRepository();
               var allUders= userRepository.GetAllUsers();
               
                foreach (var user in allUders)
                {
                    Console.WriteLine(user.EmailId);
                    Console.WriteLine(user.Password);
                    if (user.EmailId == emailId && user.Password == password)
                    {
                        Console.Clear();
                        Globals.userName = user.FirstName + " " + user.LastName;
                        return "Login Successful";
                    }
                    
                }
                return "Login Failed";
                Console.Clear();
                
                
            }
            return "Login Failed";
        }


        public string AskInput(string choice)
        {
            Console.Clear();
            Console.WriteLine("Please enter email id and password\n");
        emailSection:
            Console.Write("Email id: ");
            loginModel.EmailId = Console.ReadLine();
            if (string.IsNullOrEmpty(loginModel.EmailId))
            {
                Console.Write("Email should not be empty!\n");
                goto emailSection;
            }
        passSection:
            Console.Write("Password: ");
            loginModel.Password = Console.ReadLine();
            if (string.IsNullOrEmpty(loginModel.Password))
            {
                Console.Write("Password should not be empty!\n");
                goto passSection;
            }
            var result = Login(choice, loginModel.EmailId, loginModel.Password);
            return result;

        }
    }
}

