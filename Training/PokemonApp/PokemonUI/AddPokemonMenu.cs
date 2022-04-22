using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonDL;
using PokemonModels;
namespace PokemonUI
{
    internal class AddPokemonMenu : IMenu
    {
        //static non-access modifier is needed to keep this variable consistent to all objects we create out of our AddPokeMenu
        private static Pokemon newPokemon = new Pokemon();

        private IRepository _repository = new Repository(); //UpCasting
        public void Display()
        {
            Console.WriteLine("Enter Pokemon Information");
            //feel free to add more options here like for Defense, Health etc....
            Console.WriteLine("<10> Ability Accuracy - " + newPokemon.Abilities[0].Accuracy);
            Console.WriteLine("<9> Ability PP - " + newPokemon.Abilities[0].PP);
            Console.WriteLine("<8> Ability Power - " + newPokemon.Abilities[0].Power);
            Console.WriteLine("<7> Ability Name - " + newPokemon.Abilities[0].Name);
            Console.WriteLine("<6> Health - " + newPokemon.Health);
            Console.WriteLine("<5> Defense - " + newPokemon.Defense);
            Console.WriteLine("<4> Attack - " + newPokemon.Attack);
            Console.WriteLine("<3> Level - " + newPokemon.Level);
            Console.WriteLine("<2> Name - " + newPokemon.Name);
            Console.WriteLine("<1> Save");
            Console.WriteLine("<0> Go Back");
        }

        public string UserChoice()
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "0":
                    return "MainMenu";
                case "1":
                    try
                    {
                        Log.Information("Adding a pokemon - " + newPokemon.Name);
                        _repository.AddPokemon(newPokemon);
                        Log.Information("Pokemon added ");
                    }
                    catch(Exception ex)
                    {
                        Log.Error("Failed to add pokemon");
                        Console.WriteLine(ex.Message);
                    }
                    Console.WriteLine("----Pokemon Added----");
                    return "MainMenu";
                case "2":
                    Console.Write("Please enter a name! ");
                    newPokemon.Name = Console.ReadLine();
                    return "AddPokemon";
                /// Add more cases for any other attributes of pokemon
                case "3":
                    Console.Write("Please enter a level ");
                    newPokemon.Level = Convert.ToInt32(Console.ReadLine());
                    return "AddPokemon";
                case "4":
                    Console.Write("Please enter a Attack ");
                    newPokemon.Attack = Convert.ToInt32(Console.ReadLine());
                    return "AddPokemon";
                case "5":
                    Console.Write("Please enter a Defense ");
                    newPokemon.Defense = Convert.ToInt32(Console.ReadLine());
                    return "AddPokemon";
                case "6":
                    Console.Write("Please enter a Health ");
                    newPokemon.Health = Convert.ToInt32(Console.ReadLine());
                    return "AddPokemon";
                case "7":
                    
                    Console.Write("Please enter a Ability Name ");
                    newPokemon.Abilities[0].Name = Console.ReadLine();
                    return "AddPokemon";
                case "8":
                    Console.Write("Please enter a Ability Power ");
                    newPokemon.Abilities[0].Power = Convert.ToInt32(Console.ReadLine());
                    return "AddPokemon";
                case "9":
                    Console.Write("Please enter a Ability PP ");
                    newPokemon.Abilities[0].PP = Convert.ToInt32(Console.ReadLine());
                    return "AddPokemon";
                case "10":
                    Console.Write("Please enter a Ability Accuracy ");
                    newPokemon.Abilities[0].Accuracy = Convert.ToInt32(Console.ReadLine());
                    return "AddPokemon";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "AddPokemon";
            }
        }
    }
}