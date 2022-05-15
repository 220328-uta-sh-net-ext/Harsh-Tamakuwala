using System;
using RestaurantDl;
using RestaurantModel;

namespace RestaurantBl
{
    public class RestaurantLogic
    {
        readonly  IItemRepository<RestaurantModelClass> repo;
       
        public RestaurantLogic(IItemRepository<RestaurantModelClass> repo)
        {
            this.repo = repo;
        }

        /// <summary>
        /// this is logic for adding restaurant in the databse
        /// </summary>
        /// <param name="restaurantModelClass"></param>
        /// <returns></returns>
        public string AddRestaurantMethod(RestaurantModelClass restaurantModelClass)
        {

           // RestaurantRepository restaurantRepository = new RestaurantRepository();
            var result = repo.AddItemToDB(restaurantModelClass);
            if (result == "Restaurant Added!!!")
            {
                Console.WriteLine("\nRestaurant Added!!!\n");
                return "Restaurant Added!";
            }
            else if (result.Contains("Violation of UNIQUE KEY constrain"))
            {
                Console.WriteLine("\nYou have already Added this restaurant!!\n");
                return "You have already added this restaurant!!";
            }
            else
            {
                Console.WriteLine("\nSometing went wrong. please try again!!\n");
                return "Someting went wrong. please try again!";
            }
        }

        /// <summary>
        /// This method is used to get all the restaurant details
        /// </summary>
        /// <returns>list of restaurant</returns>
        public List<RestaurantModelClass> GetAllRestaurant()
        {
            var restaurants = repo.GetItemFromDB();
            return restaurants;
        }

    }
}

