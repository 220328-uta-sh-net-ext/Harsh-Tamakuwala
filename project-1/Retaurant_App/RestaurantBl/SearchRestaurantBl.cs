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
        public static void SearchRestaurantBL(string name)
        {
            
            RestaurantRepository restaurantRepository = new RestaurantRepository();
            List<RestaurantModelClass> retsaurantList = restaurantRepository.GetItemFromDB();
            ReviewRepository reviewRepository = new();
            var avgRating = reviewRepository.getAvgReview();

            var filteredUsers = from restaurant in retsaurantList
                                where restaurant.RestaurantName.ToLower().Contains(name.ToLower()) ||
                                      restaurant.ZipCode.ToLower().Contains(name.ToLower()) ||
                                      restaurant.ContactNo.ToString().Contains(name.ToLower()) ||
                                      restaurant.city.ToLower().Contains(name.ToLower()) ||
                                      restaurant.state.ToLower().Contains(name.ToLower()) ||
                                      restaurant.CostType.ToLower().Contains(name.ToLower())
                                select restaurant;
            if (filteredUsers.Count() > 0)
            {
                //foreach (var restaurant in filteredUsers.Select((value, index) => new { value, index }))
                //{
                //    Console.WriteLine("\n---------------------------\n");
                //    Console.WriteLine("          Restaurant: " + (restaurant.index + 1));
                //    Console.WriteLine("");
                //    Console.WriteLine("Restaurant Name:      " + restaurant.value.RestaurantName);
                //    Console.WriteLine("Restaurant Address:   " + restaurant.value.Address1 + ", " + restaurant.value.city+ ", " + restaurant.value.state);
                //    Console.WriteLine("Restaurant Zipcode:   " + restaurant.value.ZipCode);
                //    Console.WriteLine("Restaurant Cost Type: " + restaurant.value.CostType);
                //    Console.WriteLine("Restaurant Website:   " + restaurant.value.Website);
                //    Console.WriteLine("Restaurant PhoneNo:   " + restaurant.value.ContactNo);
                //    if ((restaurant.index + 1) == filteredUsers.Count())
                //    {
                //        Console.WriteLine("\n---------------------------\n");
                //    }


                //}
                foreach (var rate in avgRating)
                {
                    
                    foreach (var restaurant in filteredUsers.Select((value, index) => new { value, index }))
                    {

                        if (rate.RestaurantId == restaurant.value.RestaurantId)
                        {
                            Console.WriteLine("\n---------------------------\n");
                            Console.WriteLine("          Restaurant: " + (restaurant.index + 1));
                            Console.WriteLine("");
                            Console.WriteLine("Restaurant Name:      " + restaurant.value.RestaurantName);
                            Console.WriteLine("Restaurant Address:   " + restaurant.value.Address1 + ", " + restaurant.value.city + ", " + restaurant.value.state);
                            Console.WriteLine("Restaurant Zipcode:   " + restaurant.value.ZipCode);
                            if (rate.Rating != "0")
                            {
                                Console.WriteLine("Average Rating:       " + rate.Rating);
                            }
                            else
                            {
                                Console.WriteLine("Average Rating:       " + "Not Rated yet");
                            }
                            Console.WriteLine("Restaurant Cost Type: " + restaurant.value.CostType);
                            Console.WriteLine("Restaurant Website:   " + restaurant.value.Website);
                            Console.WriteLine("Restaurant PhoneNo:   " + restaurant.value.ContactNo);
                            Console.WriteLine("\n---------------------------\n");
                        }
                        
                    }
                   
                        
                    
                }
            }
            else
            {
                Console.WriteLine("\n---------------------------\n");
                Console.WriteLine("Restaurant not Found!!");
                Console.WriteLine("\n---------------------------\n");
            }

        }
    }
}

