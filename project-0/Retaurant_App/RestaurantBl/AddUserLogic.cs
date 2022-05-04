using System;
using RestaurantDl;
using RestaurantModel;

namespace RestaurantBl
{
	public class AddUserLogic
	{
		public AddUserLogic()
		{
		}
        public static string addUserMethod(UserModelClass userModel)
        {
            UserRepository user = new UserRepository();
            var result = user.AddItemToDB(userModel);

            if (result == "User Added!!!")
            {
                //Log.Information("User successfully added");
                return "User Added!!!";
            }
            else
            {
              //  Log.Information(" faild : ", result.ToString());
                return "Failed to add user \n";
            }
        }
    }
}

