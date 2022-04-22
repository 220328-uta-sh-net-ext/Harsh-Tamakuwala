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

            Pokemon pokemon1 = new Pokemon();
         
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