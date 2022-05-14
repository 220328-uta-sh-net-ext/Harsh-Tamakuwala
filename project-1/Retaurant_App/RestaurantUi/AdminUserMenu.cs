using System;


namespace RestaurantUi
{
    
    public class AdminUserMenu : IMenu
    {

       /// <summary>
       /// This will display the menu as per user or admin choice
       /// </summary>

        public void Display()
        {
           

            if (RestaurantBl.Globals.choice == "Admin")
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Press <3> search user");
                Console.WriteLine("Press <2> View all restaurant");
                Console.WriteLine("Press <1> Add a new restaurant");
                Console.WriteLine("Press <0> EXIT");
            }
            else if (RestaurantBl.Globals.userChoice == "Registered user" && RestaurantBl.Globals.choice == "User")
            {
                Console.WriteLine("What would you like to do?");
               // Console.WriteLine("Press <1> Display details of a restaurant for user");
                Console.WriteLine("Press <5> Choose restaurant to eat");
                Console.WriteLine("Press <4> Search restaurant");
                //Console.WriteLine("Press <4> Calculate reviews’ average rating for each restaurant");
                Console.WriteLine("Press <3> View reviews of restaurants as a user");
                Console.WriteLine("Press <2> View details of restaurants as a user");
                Console.WriteLine("Press <1> Add reviews to a restaurant as a user");
                Console.WriteLine("Press <0> EXIT");
            }

        }
        /// <summary>
        /// this will allow user the to select as per menu
        /// </summary>
        /// <returns>it will return the string as per selection</returns>
        public string UserChoice()
        {
            string? userInput = Console.ReadLine();

            
            
            if (RestaurantBl.Globals.choice == "admin" || RestaurantBl.Globals.choice == "Admin")
            {
                switch (userInput)
                {
                    case "0":
                        return "Exit";
                    case "1":
                        return "AddNewRestaurant";
                    case "2":
                        return "ViewRestaurantDetails";
                    case "3":
                        return "SearchUserAsAdmin";
                    default:
                        Console.WriteLine("Please input a valid response");
                        Console.WriteLine("Please press <enter> to continue");
                        Console.ReadLine();
                        return "MainMenu";
                }
            }
            else
            {
                switch (userInput)
                {
                    case "0":
                        return "Exit";
                    case "1":
                        return "AddRestaurantReview";
                    case "2":
                        return "ViewRestaurantDetails";
                    case "3":
                        return "ViewRestaurantReview";
                    case "4":
                        return "SearchRestaurant";
                    case "5":
                        return "ChooseRestaurant";
                    default:
                        Console.WriteLine("Please input a valid response");
                        Console.WriteLine("Please press <enter> to continue");
                        Console.ReadLine();
                        return "MainMenu";
                }
            }
        }
    }
}

