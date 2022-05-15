global using Serilog;

using RestaurantUi;
using RestaurantBl;
using RestaurantDl;
using RestaurantModel;

Log.Logger = new LoggerConfiguration().WriteTo.File("./Logs/user.txt").MinimumLevel.Debug().MinimumLevel.Information()
    .CreateLogger();

bool repeat = true;

AdminUserMenu menu = new AdminUserMenu();


string connectionStringFilePath = "../RestaurantDl/Db-Connection-string-File.txt";
string connectionString = File.ReadAllText(connectionStringFilePath);

IItemRepository<RestaurantModelClass> repo = new RestaurantRepository(connectionString);
RestaurantLogic logic = new RestaurantLogic(repo);
IItemRepository<ReviewModelClass> reviewRepo = new ReviewRepository(connectionString);
ReviewLogic reviewLogic = new ReviewLogic(reviewRepo);
IAvgReviewRepository avgReviewRepo = new RestaurantRepository(connectionString);
avgClass avgReviewLogic = new avgClass(avgReviewRepo);
RestaurantOperation restaurantOperation = new RestaurantOperation(logic, reviewLogic, avgReviewLogic);

IItemRepository<UserModelClass> userRepo = new UserRepository(connectionString);
AddUserLogic addUserLogic = new AddUserLogic(userRepo);
Authentication authentication = new Authentication(userRepo);
InitialRestaurantClass initialRestaurantClass = new InitialRestaurantClass(addUserLogic, authentication);
var result = initialRestaurantClass.getinitiated();


SearchUser searchUser = new SearchUser(userRepo);
UserOperationUi userOperationUi = new UserOperationUi(searchUser);
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
                restaurantOperation.ChooseRestaurant();
                Log.Information("Choosed next restaurant");
                break;

            case "AddNewRestaurant":
                Console.Clear();
                AddRestaurant addRestaurant = new AddRestaurant(logic);
                addRestaurant.AddNewRestaurant();
                Log.Information("Restaurant Added successfully");
                break;

            case "SearchRestaurant":
                Console.Clear();
                restaurantOperation.SearchRestaurant();
                Log.Information("Searched Restaurant.");
                break;

            //case "CalculateAllRestaurantAvgRating":
            //    Console.Clear();
            //    RestaurantOperation.AvgRatingOfRestaurants();
            //    Log.Information("Calculated avg rating.");
            //    break;

            case "ViewRestaurantReview":
                Console.Clear();
                restaurantOperation.ViewReviews();
                Log.Information("Viewed Restaurant review.");
                break;

            case "ViewRestaurantDetails":
                Console.Clear();
                restaurantOperation.ViewRestaurantDetails();
                Log.Information("Viewed Restaurant Detail.");
                break;

            case "AddRestaurantReview":
                Console.Clear();
                restaurantOperation.AddReview();
                Log.Information("review added successfully.");
                break;

            case "SearchUserAsAdmin":
                Console.Clear();
                Log.Information("searched user.");
                userOperationUi.SearchUserUiMethod();
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

else if (result.Contains("Violation of UNIQUE KEY constraint"))
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