using System;
namespace RestaurantUi
{
	public class RegisteredNewUserSelectionMenu : IMenu
	{
		public RegisteredNewUserSelectionMenu()
		{
		}
        /// <summary>
        /// this will display menu for new user or registered User
        /// </summary>
        public void Display()
        {
            Console.WriteLine("\nAre you a New user or a Registered user?");
            Console.WriteLine("Press <2> New User");
            Console.WriteLine("Press <1> Registered user");
            Console.WriteLine("Press <0> Exit");
        }

        public string UserChoice()
        {
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    Environment.Exit(0);
                    return "";

                case 1:
                    return "Registered user";

                case 2:
                    return "New user";

                default:
                    Console.WriteLine("Please select proper option!!");
                    Console.Clear();
                    return "mainMenu";

            }
        }
    }
}

