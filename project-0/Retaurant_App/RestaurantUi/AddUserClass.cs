using System;
using RestaurantBl;
using RestaurantDl;
using RestaurantModel;

namespace RestaurantUi
{
    public class AddUserClass
    {
        public AddUserClass()
        {
        }
        /// <summary>
        /// this method will add users in database by getting the input from the admin 
        /// </summary>
        Authentication authentication = new Authentication();
        public string SignupUser(string choice)
        {
            Console.WriteLine("\n----------Register Now----------\n");
            var result = AddUser();
            Console.WriteLine(result);
            // userChoice = "Registered user";
            if (result == "User Added!!!")
            {
                var loginResult = authentication.AskInput(choice);

                return loginResult;
            }
            else
            {
               // Console.WriteLine(result);
                return result;
            }

        }
        public static string AddUser()
        {
            UserModelClass userModel = new UserModelClass();
            

            Console.Write("Please Enter First Name: ");
            userModel.FirstName = Console.ReadLine();
            
            Console.Write("Please Enter Last Name: ");
            userModel.LastName = Console.ReadLine();
            //Globals.userName = userModel.FirstName + " " + userModel.LastName;
            Console.Write("Please Enter EmailId: ");
        emailSection:
            try
            {
                userModel.EmailId = Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter valid email address!!");
                goto emailSection;
            }


            Console.Write("Please enter Password: ");
        passwordSection:

            try
            {
                userModel.Password = Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Minimum 6 character requried!!");
                goto passwordSection;
            }
            Console.Write("Condfirm Password: ");
        ConfirmpasswordSection:
            try
            {
                string? confirmPassword = Console.ReadLine();
                if (confirmPassword == userModel.Password)
                {
                    userModel.ConfirmPassword = confirmPassword;
                }
                else
                {
                    Console.WriteLine("Password does not match!!");
                    Console.WriteLine("Enter password again!!");
                    goto ConfirmpasswordSection;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Minimum 6 character requried!!");
                goto ConfirmpasswordSection;
            }
            Console.Write("Please Enter Contact No. ");
        contactSection:
            try
            {
                userModel.ContactNo = Convert.ToDecimal(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter valid contact number!!");
                goto contactSection;
            }
            UserRepository user = new UserRepository();
            var result = user.AddItemToDB(userModel);
           
            if(result == "User Added!!!")
            {
                Log.Information("User successfully added");
                return "User Added!!!";
            }
            else
            {
                Log.Information(" faild : ", result.ToString());
                return result.ToString();
            }

            //Console.WriteLine(userModel.FirstName);
           
        }
       
    }
}

