using System;
using RestaurantDl;
using RestaurantModel;

namespace RestaurantBl
{
    public class RestaurantLogic
    {
        public RestaurantLogic()
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

        /// <summary>
        /// This method is used to get all the restaurant details
        /// </summary>
        /// <returns>list of restaurant</returns>
        public static List<RestaurantModelClass> GetAllRestaurant()
        {
            Console.Clear();
            RestaurantRepository restaurantRepository = new RestaurantRepository();
            var restaurants = restaurantRepository.GetItemFromDB();
            return restaurants;
        }

        /// <summary>
        /// This method is used to get all the avgrage rating ofrestaurant details
        /// </summary>
        /// <returns>list of avarage rating of restaurant</returns>
        public static List<AvgRating> GetAvgRating()
        {
            Console.Clear();

            ReviewRepository reviewRepository = new();
            var avgRating = reviewRepository.getAvgReview();
            return avgRating;
        }
    }
}

