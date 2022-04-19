using System;
namespace RestaurantUi
{
	public class MainMenu : IMenu
	{
		public MainMenu()
		{
		}

        public void Display()
        {
            Console.WriteLine("Welcome to Restaurant");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Press <8> search restaurant");
            Console.WriteLine("Press <7> calculate reviews’ average rating for each restaurant");
            Console.WriteLine("Press <6> view reviews of restaurants as a user");
            Console.WriteLine("Press <5> view details of restaurants as a user");
            Console.WriteLine("Press <4> add reviews to a restaurant as a user");
            Console.WriteLine("Press <3> display details of a restaurant for user");
            Console.WriteLine("Press <2> ability to search user as admin");
            Console.WriteLine("Press <1> add a new user");
            Console.WriteLine("Press <0> EXIT");
        }

        public string UserChoice()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    return "Exit";
                case "1":
                    return "AddUser";
                case "2":
                    return "SearchUserAsAdmin";
                case "3":
                    return "DisplayRestaurantDetail";
                case "4":
                    return "AddUserReview";
                case "5":
                    return "ViewRestaurantDetails";
                case "6":
                    return "ViewRestaurantReview";
                case "7":
                    return "CalculateAllRestaurantAvgRating";
                case "8":
                    return "SearchRestaurant";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press <enter> to continue");
                    Console.ReadLine();
                    return "MainMenu";
            }
        }
    }
}

