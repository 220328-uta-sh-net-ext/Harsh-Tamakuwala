using System;


namespace RestaurantUi
{
    
    public class AdminUserMenu : IMenu
    {

       

        public void Display()
        {
            //Console.WriteLine("Welcome to Restaurant");
            //Console.WriteLine("What would you like to do?");
            //Console.WriteLine("Press <8> search restaurant");
            //Console.WriteLine("Press <7> calculate reviews’ average rating for each restaurant");
            //Console.WriteLine("Press <6> view reviews of restaurants as a user");
            //Console.WriteLine("Press <5> view details of restaurants as a user");
            //Console.WriteLine("Press <4> add reviews to a restaurant as a user");
            //Console.WriteLine("Press <3> display details of a restaurant for user");
            //Console.WriteLine("Press <2> ability to search user as admin");
            //Console.WriteLine("Press <1> add a new user");
            //Console.WriteLine("Press <0> EXIT");

            if (RestaurantBl.Globals.choice == "Admin")
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Press <2> Ability to search user as admin");
                Console.WriteLine("Press <1> Add a new restaurant");
                Console.WriteLine("Press <0> EXIT");
            }
            else if (RestaurantBl.Globals.userChoice == "Registered user" && RestaurantBl.Globals.choice == "User")
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Press <6> Search restaurant");
                Console.WriteLine("Press <5> Calculate reviews’ average rating for each restaurant");
                Console.WriteLine("Press <4> View reviews of restaurants as a user");
                Console.WriteLine("Press <3> View details of restaurants as a user");
                Console.WriteLine("Press <2> Add reviews to a restaurant as a user");
                Console.WriteLine("Press <1> Display details of a restaurant for user");
                Console.WriteLine("Press <0> EXIT");
            }

        }

        public string UserChoice()
        {
            string? userInput = Console.ReadLine();

            //switch (userInput)
            //{
            //    case "0":
            //        return "Exit";
            //    case "1":
            //        return "AddUser";
            //    case "2":
            //        return "SearchUserAsAdmin";
            //    case "3":
            //        return "DisplayRestaurantDetail";
            //    case "4":
            //        return "AddUserReview";
            //    case "5":
            //        return "ViewRestaurantDetails";
            //    case "6":
            //        return "ViewRestaurantReview";
            //    case "7":
            //        return "CalculateAllRestaurantAvgRating";
            //    case "8":
            //        return "SearchRestaurant";
            //    default:
            //        Console.WriteLine("Please input a valid response");
            //        Console.WriteLine("Please press <enter> to continue");
            //        Console.ReadLine();
            //        return "MainMenu";
            //}
            
            if (RestaurantBl.Globals.choice == "admin" || RestaurantBl.Globals.choice == "Admin")
            {
                switch (userInput)
                {
                    case "0":
                        return "Exit";
                    case "1":
                        return "AddNewRestaurant";
                    case "2":
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
                        return "DisplayRestaurantDetail";
                    case "2":
                        return "AddUserReview";
                    case "3":
                        return "ViewRestaurantDetails";
                    case "4":
                        return "ViewRestaurantReview";
                    case "5":
                        return "CalculateAllRestaurantAvgRating";
                    case "6":
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
}

