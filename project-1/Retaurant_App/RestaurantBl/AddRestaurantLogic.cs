using System;
using RestaurantDl;
using RestaurantModel;

namespace RestaurantBl
{
	public class AddRestaurantLogic
	{
		public AddRestaurantLogic()
		{
		}
        public static void AddRestaurantMethod(RestaurantModelClass restaurantModelClass)
        {
            RestaurantRepository restaurantRepository = new RestaurantRepository();
            var result = restaurantRepository.AddItemToDB(restaurantModelClass);
            if (result == "Restaurant Added!!!")
            {
               // Log.Information("Restaurant successfully added");
                Console.WriteLine("\nRestaurant Added!!!\n");
            }
            else
            {
                //Log.Information(" faild : ", result.ToString());
                Console.WriteLine("\nSometing went wrong. please try again!!\n");
            }
        }
    }
}

