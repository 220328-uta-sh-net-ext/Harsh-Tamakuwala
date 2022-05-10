using System;
using RestaurantBl;
using RestaurantModel;

namespace RestaurantUi
{
	public class LoginClass
	{
		public LoginClass()
		{
		}
        /// <summary>
        /// It will ask input for emailid and password to check for login as admin or user
        /// </summary>
        /// <param name="choice"></param>
        /// <returns>it will return wether login is successfull or not as a string format
        /// </returns>

        public string AskInput(string choice)
        {
            LoginModelClass loginModel = new();
            Authentication auth = new();
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
            var result = auth.Login(choice, loginModel.EmailId, loginModel.Password);
            return result;

        }
    }

}

