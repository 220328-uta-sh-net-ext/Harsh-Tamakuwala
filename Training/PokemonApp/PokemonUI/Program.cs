global using Serilog;

using PokemonUI;
Log.Logger = new LoggerConfiguration().WriteTo.File("./Logs/user.txt").MinimumLevel.Debug().MinimumLevel.Information()
    .CreateLogger();
bool repeat = true;
IMenu menu = new MainMenu();

while (repeat)
{
    menu.Display();
    string ans = menu.UserChoice();

    switch (ans)
    {
        case "SearchPokemon":
            //call SearchPokemon method
            Log.Debug("Displaying search pokemon menu to the user");
            Console.WriteLine("SearchPokemon() Method implementation is in progress....");
            break;
        case "AddPokemon":
            Log.Debug("Displaying Add pokemon menu to the user");
            menu = new AddPokemonMenu();
            Console.WriteLine("Actual AddPokemon() method implementaion is in progress.... This is just a dummy");
            break;
        case "GetAllPokemons":
            Log.Debug("Displaying all pokemon menu to the user");
            PokemonOperations.GetAllPokemons();
            break;
        case "MainMenu":
            Log.Debug("Displaying main menu to the user");
            menu = new MainMenu();
            break;
        case "Exit":
            Log.Debug("Exiting the Application ");
            Log.CloseAndFlush();
            repeat = false;
            break;
        default:
            Console.WriteLine("View does not exist");
            Console.WriteLine("Please press <enter> to continue");
            Console.ReadLine();
            break;
    }
}