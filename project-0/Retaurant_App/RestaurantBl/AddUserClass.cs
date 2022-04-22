using System;
using RestaurantModel;

namespace RestaurantBl
{
    public class AddUserClass
    {
        public AddUserClass()
        {
        }
        public static string AddUser()
        {
            UserModelClass userModel = new UserModelClass();
            int userNo = userModel.UserId;
            userNo += 1;
            userModel.UserId = userNo;

            Console.Write("Please Enter First Name: ");
            userModel.FirstName = Console.ReadLine();
            
            Console.Write("Please Enter Last Name: ");
            userModel.LastName = Console.ReadLine();
            Globals.userName = userModel.FirstName + " " + userModel.LastName;
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
                userModel.ContactNo = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter valid contact number!!");
                goto contactSection;
            }

            //Console.WriteLine(userModel.FirstName);
            return "User Added!!!";
        }
       
    }
}

