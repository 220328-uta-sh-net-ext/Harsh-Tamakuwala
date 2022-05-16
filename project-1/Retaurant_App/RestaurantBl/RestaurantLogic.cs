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
               
                return "Restaurant Added!";
            }
            else if (result.Contains("Violation of UNIQUE KEY constrain"))
            {
               
                return "You have already added this restaurant!!";
            }
            else
            {
               
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


        public string DeleteRestaurant(int id)
        {
            //UserRepository user = new UserRepository();
            var result = repo.DeleteItemToDB(id);

            if (result == "restaurant deleted")
            {

                return "restaurant deleted!";
            }
            else
            {

                return "Failed to delete restaurant";
            }
        }
    }
}

