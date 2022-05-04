using System;
using RestaurantBl;

namespace RestaurantUi
{
  
    public class InitialRestaurantClass : IInitiateMenu
    {
		public InitialRestaurantClass()
		{
		}
        /// <summary>
        /// From this method program get started and will invoke the method to register or login
        /// </summary>
        /// <returns>will return wether login is successful or failed </returns>

        public string getinitiated()
        {
            
            LoginClass login = new();
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
                        var result = login.AskInput(Globals.choice);
                        return result;
                    }else if(Globals.userChoice == "New user")
                    {
                    AddUserClass addUserClass = new AddUserClass();
                    var result = addUserClass.SignupUser(Globals.choice);
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
                    var result = login.AskInput(Globals.choice);
                    return result;
                }
            return "Failed";

        }
    }
}

