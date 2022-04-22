using System;
using RestaurantBl;

namespace RestaurantUi
{
    //public static class Globals
    //{

    //    public static string choice = "NoChoice";
    //    public static string userChoice = "Registered";
    //    public static string userName = "admin";
    //}
    public class InitialRestaurantClass : IInitiateMenu
    {
		public InitialRestaurantClass()
		{
		}
        

        public string getinitiated()
        {
            Authentication authentication = new Authentication();
            RegisteredNewUserSelectionMenu registeredNewUserSelectionMenu = new RegisteredNewUserSelectionMenu();

      
            

                Console.WriteLine("Welcome to Restaurant");

                AdminUserSelectionMenu adminUser = new AdminUserSelectionMenu();

            mainSection:
                Console.WriteLine("Are you a admin or a user?");

                adminUser.Display();
                Globals.choice = adminUser.UserChoice();

                if (Globals.choice == "mainMenu")
                {
                    goto mainSection;
                }
                else if (Globals.choice == "User")
                {
                    userSection:
                    registeredNewUserSelectionMenu.Display();
                    Globals.userChoice = registeredNewUserSelectionMenu.UserChoice();
                    if (Globals.userChoice == "Registered user"){
                        var result = authentication.login(Globals.choice, Globals.userChoice);
                        return result;
                    }else if(Globals.userChoice == "New user")
                    {
                        var result = authentication.RegisterUser(Globals.choice, Globals.userChoice);
                        Globals.userChoice = "Registered user";
                        return result;
                    }else
                    {
                        Console.Clear();
                        Console.WriteLine("Please select proper option!!");
                        goto userSection;
                    }

                }
                else if (Globals.choice == "Admin")
                {
                    var result = authentication.login(Globals.choice, Globals.userChoice);
                    return result;
                }


            //}
            //else
            //{
            //    Console.WriteLine("Please select proper option!!");
            //    Globals.choice = "NoChoice";
                
            //}
            //if (Globals.choice == "user" || Globals.choice == "User")
            //{

            //    Console.WriteLine("\nAre you a New user or a Registered user?");
            //userSection:
            //    Console.WriteLine("Press <2> New User");
            //    Console.WriteLine("Press <1> Registered user");
            //    Console.WriteLine("Press <0> Exit");
            //    int userC = Convert.ToInt32(Console.ReadLine());


            //    if (userC == 1)
            //    {
            //        Globals.userChoice = "Registered user";
            //        var result = authentication.login(Globals.choice, Globals.userChoice);
            //        return result;
            //    }
            //    else if (userC == 2)
            //    {
            //        Globals.userChoice = "New user";
            //        var result = authentication.RegisterUser(Globals.choice, Globals.userChoice);
            //        Globals.userChoice = "Registered user";
            //        return result;
            //    }
            //    else if (userC == 0)
            //    {
            //        Environment.Exit(0);
            //    }
            //    else
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Please select proper option!!");
            //        goto userSection;
            //    }

            //}



            return "Failed";

        }
    }
}

