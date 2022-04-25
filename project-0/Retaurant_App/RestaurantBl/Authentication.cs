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
        public string login(string choice, string emailId,string password)
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
                Console.Clear();
                return "Login Successful";
            }
            return "Login Failed";
        }



        public string signupUser(string choice)
        {
            Console.WriteLine("\n----------Register Now----------\n");
            var result = AddUserClass.AddUser();
            Console.WriteLine(result);
           // userChoice = "Registered user";
           if(result == "User Added!!!")
            {
              var loginResult=  askInput(choice);
                return loginResult;
            }
            else
            {
               
                return "Login Failed";
            }
            
        }



        public string askInput(string choice)
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
            var result = login(choice, loginModel.EmailId, loginModel.Password);
            return result;

        }
    }
}

