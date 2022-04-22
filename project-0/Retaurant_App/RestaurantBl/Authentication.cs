using System;
using RestaurantModel;

namespace RestaurantBl
{
    public static class Globals
    {

        public static string choice = "NoChoice";
        public static string userChoice = "Registered";
        public static string userName = "admin";
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
        public string login(string choice, string userChoice)
        {

            Console.Clear();
            Console.WriteLine("Please enter email id and password\n");
            if (choice == "Admin")
            {
                var email = "admin@gmail.com";
                var pass = "admin123@";
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
                if (loginModel.EmailId == email && loginModel.Password == pass)
                {
                    Console.Clear();
                    Console.WriteLine("\n----------Login Successful!!----------\n");
                    return "Login Successful";
                }
            }
            else if (choice == "User")
            {
                return "Login Successful";
            }
            return "Login Failed";
        }

        public string RegisterUser(string choice, string userChoice)
        {
            Console.WriteLine("\n----------Register Now----------\n");
            var result = AddUserClass.AddUser();
            Console.WriteLine(result);
            userChoice = "Registered user";
            var loginResult = login(choice, userChoice);
            return loginResult;
        }
    }
}

