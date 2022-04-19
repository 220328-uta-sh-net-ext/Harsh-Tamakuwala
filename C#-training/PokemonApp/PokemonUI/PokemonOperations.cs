using System.Text.Json;
using PokemonDL;
using PokemonModels;

namespace PokemonUI
{
    internal class PokemonOperations
    {
        static Repository repository = new Repository();

        public static void GetAllPokemons()
        {
            var pokemons = repository.GetAllPokemons();
            var pokemonString = JsonSerializer.Serialize<List<Pokemon>>(pokemons);
            //foreach (var pokemon in pokemons)
            //{
            // Console.WriteLine(pokemons[0].Abilities[0].   );
            // pokemons.ForEach(i => Console.Write("{0}\t", i.Abilities.ForEach()));
            //}
            for (int i = 0; i < pokemonString.ToList().Count; i++)
            {
                Console.Write(pokemonString.ToList()[i]);
            }
        }
        public static void AddDummyPokemon()
        {
            // AddPokemonMenu menu = new AddPokemonMenu();
            //Pokemon pokemon1 = new Pokemon()
            //{
            //    Name = "Pikachu",
            //    Level = 4,
            //    Attack = 40,
            //    Defense = 45,
            //    Health = 50,
            //    Abilities = new List<Ability>() {
            //        new Ability()
            //        {
            //            Name = "ThunderBolt",
            //            Accuracy = 100,
            //            Power = 90,
            //            PP = 15
            //        }
            //    }
            //};

            //menu.Display();
            //string ans = menu.UserChoice();


            //switch (ans)
            //{
            //    case "SearchPokemon":
            //        //call SearchPokemon method
            //        Console.WriteLine("SearchPokemon() Method implementation is in progress....");
            //        break;
            //    case "AddPokemon":
            //        //call AddPokemon method
            //        Console.WriteLine("AddPokemon() Method implementaion is in progress....");
            //        break;
            //    case "MainMenu":
            //        menu = new MainMenu();
            //        break;
            //    case "Exit":
            //        repeat = false;
            //        break;
            //    default:
            //        Console.WriteLine("View does not exist");
            //        Console.WriteLine("Please press <enter> to continue");
            //        Console.ReadLine();
            //        break;
            //}
            // repository.AddPokemon(pokemon1);

            Pokemon pokemon1 = new Pokemon();
            //{
            //    Name = "Raichu",
            //    Level = 4,
            //    Attack = 40,
            //    Defense = 45,
            //    Health = 50,
            //    Abilities = new List<Ability>() {
            //        new Ability()
            //        {
            //            Name = "ThunderBolt",
            //            Accuracy = 100,
            //            Power = 90,
            //            PP = 15
            //        }
            //    }
            //};
            Console.WriteLine("Enter the Pokemon Name");
            pokemon1.Name = Console.ReadLine();
            pokemon1.Level = 4;
            pokemon1.Attack = 40;
            pokemon1.Defense = 45;
            pokemon1.Health = 50;
            //    pokemon1.Abilities = new List<Ability>() {
            //            new Ability()
            //            {
            //                Name = "ThunderBolt",
            //                Accuracy = 100,
            //                Power = 90,
            //                PP = 15
            //            }
            //};
            // Console.WriteLine(pokemon1.ToString());
            repository.AddPokemon(pokemon1);
        }
    }
}