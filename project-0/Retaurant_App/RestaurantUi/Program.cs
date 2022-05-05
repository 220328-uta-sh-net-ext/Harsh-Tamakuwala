global using Serilog;

using RestaurantUi;
using RestaurantBl;
using RestaurantDl;


Log.Logger = new LoggerConfiguration().WriteTo.File("./Logs/user.txt").MinimumLevel.Debug().MinimumLevel.Information()
    .CreateLogger();

bool repeat = true;
InitialRestaurantClass initialRestaurantClass = new InitialRestaurantClass();
AdminUserMenu menu = new AdminUserMenu();

var result = initialRestaurantClass.getinitiated();

if (result == "Login Successful")
{

    Log.Information(Globals.userName + " Login Successful");
    while (repeat)
    {
        menu.Display();
        string ans = menu.UserChoice();

        switch (ans)
        {
            case "ChooseRestaurant":
                Console.Clear();
                RestaurantOperation.ChooseRestaurant();
                Log.Information("Choosed next restaurant");
                break;

            case "AddNewRestaurant":
                Console.Clear();
                AddRestaurant addRestaurant = new AddRestaurant();
                addRestaurant.AddNewRestaurant();
                Log.Information("Restaurant Added successfully");
                break;

            case "SearchRestaurant":
                Console.Clear();
                RestaurantOperation.SearchRestaurant();
                Log.Information("Searched Restaurant.");
                break;

            //case "CalculateAllRestaurantAvgRating":
            //    Console.Clear();
            //    RestaurantOperation.AvgRatingOfRestaurants();
            //    Log.Information("Calculated avg rating.");
            //    break;

            case "ViewRestaurantReview":
                Console.Clear();
                RestaurantOperation.ViewReviews();
                Log.Information("Viewed Restaurant review.");  
                break;

            case "ViewRestaurantDetails":
                Console.Clear();
                RestaurantOperation.ViewRestaurantDetails();
                Log.Information("Viewed Restaurant Detail.");  
                break;

            case "AddRestaurantReview":
                Console.Clear();
                RestaurantOperation.AddReview();
                Log.Information("review added successfully.");
                break;

            //case "DisplayRestaurantDetail":
            //    Console.Clear();
            //    RestaurantOperation.DisplayRestaurantDetail();
            //    Log.Information("Displayed Restaurant Detail.");
            //    break;

            case "SearchUserAsAdmin":
                Console.Clear();
                Log.Information("searched user.");
                SearchUser.SearchUserAsAdmin();
                break;

            case "MainMenu":
                Console.Clear();
                Log.Information("Main menu.");
                menu = new AdminUserMenu();
                break;

            case "Exit":
                Log.Information("exit.");
                Console.Clear();
                repeat = false;
                break;

            default:
                Console.WriteLine("View does not exist");
                Console.WriteLine("Please press <enter> to continue");
                Console.ReadLine();
                break;
        }
    }
}

else if(result.Contains("Violation of UNIQUE KEY constraint"))
{
    Log.Information(result);
    Console.WriteLine("Email ID is already registered!!");
    Console.WriteLine("User is not added!!");
   
}
else
{
    Console.Clear();
    Log.Information("Login failed");
    Console.WriteLine("Invalid credential.");
    Console.WriteLine("\n----------Login Failed!!----------\n");
    Environment.Exit(0);
}
