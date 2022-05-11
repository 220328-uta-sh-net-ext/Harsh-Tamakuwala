using System;
using RestaurantDl;
using RestaurantModel;

namespace RestaurantBl
{
    public class SearchRestaurantBl
    {
        public SearchRestaurantBl()
        {
        }
        /// <summary>
        /// this method will search for the restaurant from the given value in name from the database and will display the result
        /// </summary>
        /// <param name="name"></param>
        public static List<RestaurantModelClass> SearchRestaurantBL(string name)
        {



            var retsaurantList = RestaurantLogic.GetAllRestaurant();

            var filteredRestaurants = from restaurant in retsaurantList
                                      where restaurant.RestaurantName.ToLower().Contains(name.ToLower()) ||
                                            restaurant.ZipCode.ToLower().Contains(name.ToLower()) ||
                                            restaurant.ContactNo.ToString().Contains(name.ToLower()) ||
                                            restaurant.city.ToLower().Contains(name.ToLower()) ||
                                            restaurant.state.ToLower().Contains(name.ToLower()) ||
                                            restaurant.CostType.ToLower().Contains(name.ToLower())
                                      select restaurant;
            return filteredRestaurants.ToList();

        }
    }
}

