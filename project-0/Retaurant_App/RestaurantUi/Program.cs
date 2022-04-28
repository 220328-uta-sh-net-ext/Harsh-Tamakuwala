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
            case "AddNewRestaurant":
                //call SearchPokemon method
                Console.Clear();
                AddRestaurant addRestaurant = new AddRestaurant();
                addRestaurant.AddNewRestaurant();
                Log.Information("Restaurant Added successfully");
                Console.WriteLine("AddNewRestaurant() Method implementation is in progress....");

                break;
            case "SearchRestaurant":
                //call SearchPokemon method
                Console.Clear();
                RestaurantOperation.SearchRestaurant();
                Log.Information("Searched Restaurant.");
                Console.WriteLine("SearchRestaurant() Method implementation is in progress....");

                break;
            case "CalculateAllRestaurantAvgRating":
                //call SearchPokemon method
                Console.Clear();
                RestaurantOperation.AvgRatingOfRestaurants();
                Log.Information("Calculated avg rating.");
                Console.WriteLine("CalculateAllRestaurantAvgRating() Method implementation is in progress....");
                break;
            case "ViewRestaurantReview":
                //call SearchPokemon method
                Console.Clear();
                RestaurantOperation.ViewReviews();
                Log.Information("Viewed Restaurant review.");
                Console.WriteLine("DisplayRestaurantDetail() Method implementation is in progress....");
                break;
            case "ViewRestaurantDetails":
                //call SearchPokemon method
                Console.Clear();
                RestaurantOperation.ViewRestaurantDetails();
                Log.Information("Viewed Restaurant Detail.");
                Console.WriteLine("ViewRestaurantDetails() Method implementation is in progress....");
                break;
            case "AddUserReview":
                //call SearchPokemon method
                Console.Clear();

                RestaurantOperation.AddReview();
                Log.Information("review added successfully.");
                Console.WriteLine("AddUserReview() Method implementation is in progress....");
                break;
            case "DisplayRestaurantDetail":
                //call SearchPokemon method
                Console.Clear();
                
                RestaurantOperation.DisplayRestaurantDetail();
                Log.Information("Displayed Restaurant Detail.");
                Console.WriteLine("DisplayRestaurantDetail() Method implementation is in progress....");
                break;
            case "SearchUserAsAdmin":
                //call SearchPokemon method
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
