using System;
namespace RestaurantUi
{

	public class AdminUserSelectionMenu : IMenu
	{
		public AdminUserSelectionMenu()
		{
		}

        /// <summary>
        /// This will display the menu for chosing user or admin
        /// </summary>
        public void Display()
        {
           
            Console.WriteLine("Press <2> User");
            Console.WriteLine("Press <1> Admin");
            Console.WriteLine("Press <0> Exit");
        }

        public string UserChoice()
        {
            
            string? mainChoice = Console.ReadLine();
            int choice;
            if (!(int.TryParse(mainChoice, out choice)))
            {
                Console.Clear();
                return "mainMenu";
            }
           
            switch(choice)
            {
                case 0:
                    Environment.Exit(0);
                    return "";
                   
                case 1:
                     return "Admin";
                   
                case 2:
                    return "User";
                   
                default:
                    Console.WriteLine("Please select proper option!!");
                    Console.Clear();
                    return "mainMenu";
                    
            }
            
        }
    }
}

