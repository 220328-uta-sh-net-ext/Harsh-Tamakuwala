using System;
using RestaurantModel;

namespace RestaurantUi
{
	public class RestaurantOperations
	{
        
		public RestaurantOperations()
		{
		}
		public static void AddUser()
        {
			UserModelClass userModel = new UserModelClass();
			Console.WriteLine("Please Enter First Name");
			//var firstName = Console.ReadLine();
			userModel.FirstName = Console.ReadLine();
            Console.WriteLine("Please Enter Last Name");
            userModel.LastName = Console.ReadLine();

            Console.WriteLine("Please Enter EmailId");
            emailSection:
            try
            {
                userModel.EmailId = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter valid email address!!");
                goto emailSection;
            }
            
            Console.WriteLine("Please Enter Contact No.");
            contactSection:
            try
            {
                userModel.ContactNo = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter valid contact number!!");
                goto contactSection;
            }
            
            Console.WriteLine(userModel.FirstName);
			//int userNo;
			//userNo = userModel.UserId;
			//Console.WriteLine(userNo);


		}

	}
}

