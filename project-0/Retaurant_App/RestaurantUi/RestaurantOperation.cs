using System;
using RestaurantDl;
using RestaurantModel;

namespace RestaurantBl
{
    public class RestaurantOperation
    {

        public RestaurantOperation()
        {
        }

        public static void SearchRestaurant()
        {
            Console.WriteLine("Search restaurant by name, address, phoneNo and cost type\n");
        search:
            Console.Write("Search Restaurant : ");
            string? searchValue = Console.ReadLine();
            if (searchValue == "")
            {
                Console.WriteLine("\nInvalid Input!!\n");
                goto search;
            }
            else
            {

                SearchRestaurantBl.SearchRestaurantBL(searchValue);
            }
        }

        public static void AvgRatingOfRestaurants()
        {
            throw new NotImplementedException();
        }

        public static void ViewReviews()
        {
            ReviewRepository reviewRepository = new ReviewRepository();
            var reviews = reviewRepository.GetItemFromDB();
            foreach (var review in reviews.Select((value, index) => new { value, index }))
            {
                Console.WriteLine("\n---------------------------\n");
                Console.WriteLine("            Review: " + (review.index + 1));
                Console.WriteLine("");
                Console.WriteLine("Restaurant Name: " + review.value.RestaurantName);
                Console.WriteLine("Review By:       " + review.value.UserName);
                Console.WriteLine("Rating:          " + review.value.Rating);
                Console.WriteLine("Note:            " + review.value.Comments);
                Console.WriteLine("Reviewed at:     " + review.value.ReviewTime);

                if ((review.index + 1) == reviews.Count())
                {
                    Console.WriteLine("\n---------------------------\n");
                }

            }
        }

        public static void ViewRestaurantDetails()
        {
            RestaurantRepository restaurantRepository = new RestaurantRepository();
            var restaurants = restaurantRepository.GetItemFromDB();

            foreach (var restaurant in restaurants.Select((value, index) => new { value, index }))
            {
                Console.WriteLine("\n---------------------------\n");
                Console.WriteLine("          Restaurant: " + (restaurant.index + 1));
                Console.WriteLine("");
                Console.WriteLine("Restaurant Name:      " + restaurant.value.RestaurantName);
                Console.WriteLine("Restaurant Address:   " + restaurant.value.Address1 + ", " + restaurant.value.city + ", " + restaurant.value.state);
                Console.WriteLine("Restaurant Zipcode:   " + restaurant.value.ZipCode);
                Console.WriteLine("Restaurant Cost Type: " + restaurant.value.CostType);
                Console.WriteLine("Restaurant Website:   " + restaurant.value.Website);
                Console.WriteLine("Restaurant PhoneNo:   " + restaurant.value.ContactNo);
                if ((restaurant.index + 1) == restaurants.Count())
                {
                    Console.WriteLine("\n---------------------------\n");
                }

            }
        }

        public static void AddReview()
        {
            ReviewModelClass reviewModel = new ReviewModelClass();
            int reviewNo = reviewModel.ReviewId;
            reviewNo += 1;
            reviewModel.ReviewId = reviewNo;
            //get the list of resaturant name and display it to select the restaurant to review
            Console.WriteLine("Please Enter your Name:");
            reviewModel.UserName = Console.ReadLine();
            Console.WriteLine("Please Enter restaurant Code from the list:");
            reviewModel.RestaurantId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please give a rating between 1 to 5:");
        ratingSection:

            try
            {
                reviewModel.Rating = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a rating between 1 to 5 only!!");
                goto ratingSection;
            }

            Console.WriteLine("Please enter comment:");
        commentSection:
            try
            {
                reviewModel.Comments = Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("50 characters only!!");
                goto commentSection;
            }
            reviewModel.ReviewTime = DateTime.Now;

        }



        public static void DisplayRestaurantDetail()
        {
            RestaurantRepository restaurantRepository = new RestaurantRepository();
            var restaurants = restaurantRepository.GetItemFromDB();

            foreach (var restaurant in restaurants.Select((value, index) => new { value, index }))
            {
                Console.WriteLine("\n---------------------------\n");
                Console.WriteLine("          Restaurant: " + (restaurant.index + 1));
                Console.WriteLine("");
                Console.WriteLine("Restaurant Name:      " + restaurant.value.RestaurantName);
                Console.WriteLine("Restaurant Address:   " + restaurant.value.Address1 + ", " + restaurant.value.city + ", " + restaurant.value.state);
                Console.WriteLine("Restaurant Zipcode:   " + restaurant.value.ZipCode);
                Console.WriteLine("Restaurant Cost Type: " + restaurant.value.CostType);
                Console.WriteLine("Restaurant Website:   " + restaurant.value.Website);
                Console.WriteLine("Restaurant PhoneNo:   " + restaurant.value.ContactNo);
                if ((restaurant.index + 1) == restaurants.Count())
                {
                    Console.WriteLine("\n---------------------------\n");
                }

            }
        }

        public static void SearchUserAsAdmin()
        {
            throw new NotImplementedException();
        }
    }
}

