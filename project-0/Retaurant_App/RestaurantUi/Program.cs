using RestaurantUi;

bool repeat = true;
MainMenu menu = new MainMenu();

while (repeat)
{
    menu.Display();
    string ans = menu.UserChoice();

    switch (ans)
    {
        case "SearchRestaurant":
            //call SearchPokemon method
            Console.WriteLine("SearchRestaurant() Method implementation is in progress....");
            break;
        case "CalculateAllRestaurantAvgRating":
            //call SearchPokemon method
            Console.WriteLine("CalculateAllRestaurantAvgRating() Method implementation is in progress....");
            break;
        case "ViewRestaurantReview":
            //call SearchPokemon method
            Console.WriteLine("DisplayRestaurantDetail() Method implementation is in progress....");
            break;
        case "ViewRestaurantDetails":
            //call SearchPokemon method
            Console.WriteLine("ViewRestaurantDetails() Method implementation is in progress....");
            break;
        case "AddUserReview":
            //call SearchPokemon method
            Console.WriteLine("AddUserReview() Method implementation is in progress....");
            break;
        case "DisplayRestaurantDetail":
            //call SearchPokemon method
            Console.WriteLine("DisplayRestaurantDetail() Method implementation is in progress....");
            break;
        case "SearchUserAsAdmin":
            //call SearchPokemon method
            Console.WriteLine("SearchUserAsAdmin() Method implementation is in progress....");
            break;
        case "AddUser":
            RestaurantOperations.AddUser();
            Console.WriteLine("AddUser() Method implementaion is in progress....");
            break;
        case "MainMenu":
            menu = new MainMenu();
            break;
        case "Exit":
            repeat = false;
            break;
        default:
            Console.WriteLine("View does not exist");
            Console.WriteLine("Please press <enter> to continue");
            Console.ReadLine();
            break;
    }
}
