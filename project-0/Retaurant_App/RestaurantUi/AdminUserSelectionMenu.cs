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
            int mainChoice = Convert.ToInt32(Console.ReadLine());
            
            switch(mainChoice)
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

