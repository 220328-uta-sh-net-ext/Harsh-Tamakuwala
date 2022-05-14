using System;
using RestaurantDl;
using RestaurantModel;

namespace RestaurantBl
{
    public class RestaurantOperation
    {
        readonly RestaurantLogic logic;
        readonly ReviewLogic reLogic;
        readonly avgClass avgReLogic;
        public RestaurantOperation(RestaurantLogic logic,ReviewLogic reviewLogic1, avgClass avgReLogic)
        {
            this.avgReLogic = avgReLogic;
            this.logic=logic;
            this.reLogic = reviewLogic1;
        }
        /// <summary>
        /// this will ask for input for searching the restaurant 
        /// </summary>
        public void SearchRestaurant()
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
                SearchRestaurantBl searchRestaurantBl = new SearchRestaurantBl(logic);
                var filteredRestaurants = searchRestaurantBl.SearchRestaurantBL(searchValue);
                var avgRating = avgReLogic.GetAvgRating();
                if (filteredRestaurants.Count() > 0)
                {

                    foreach (var rate in avgRating)
                    {

                        foreach (var restaurant in filteredRestaurants.Select((value, index) => new { value, index }))
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
       


        //}
        /// <summary>
        /// it will show haighest rating restaurant to choose
        /// </summary>
        internal void ChooseRestaurant()
        {
            var avgRating = avgReLogic.GetAvgRating();
           
            var restaurants = logic.GetAllRestaurant();
            foreach (var rate in avgRating.Select((value, index) => new { value, index }))
            {
                Console.WriteLine("\n---------------------------\n");
                Console.WriteLine("You should try this restaurant next time as it has highest rating!!\n");
                foreach (var restaurant in restaurants)
                {

                    if (rate.value.RestaurantId == restaurant.RestaurantId)
                    {

                        Console.WriteLine("Restaurant Name:      " + restaurant.RestaurantName);
                        Console.WriteLine("Restaurant Address:   " + restaurant.Address1 + ", " + restaurant.city + ", " + restaurant.state);
                        Console.WriteLine("Restaurant Zipcode:   " + restaurant.ZipCode);
                        if (rate.value.Rating != "0")
                        {
                            Console.WriteLine("Average Rating:       " + rate.value.Rating);
                        }
                        else
                        {
                            Console.WriteLine("Average Rating:       " + "Not Rated yet");
                        }
                        Console.WriteLine("Restaurant Cost Type: " + restaurant.CostType);
                        Console.WriteLine("Restaurant Website:   " + restaurant.Website);
                        Console.WriteLine("Restaurant PhoneNo:   " + restaurant.ContactNo);
                    }
                }

                Console.WriteLine("\n---------------------------\n");

                break;
            }

        }
        /// <summary>
        /// this methos will display reviews of every restaurant
        /// </summary>
        public void ViewReviews()
        {


            List<ReviewModelClass> reviews = reLogic.GetAllReview();

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
        /// <summary>
        /// this methos will display details of every restaurant
        /// </summary>
        public void ViewRestaurantDetails()
        {


            var avgRating = avgReLogic.GetAvgRating();
       

            var restaurants = logic.GetAllRestaurant();
            foreach (var rate in avgRating.Select((value, index) => new { value, index }))
            {
                Console.WriteLine("\n---------------------------\n");
                Console.WriteLine("          Restaurant: " + (rate.index + 1));
                Console.WriteLine("");
                foreach (var restaurant in restaurants)
                {

                    if (rate.value.RestaurantId == restaurant.RestaurantId)
                    {

                        Console.WriteLine("Restaurant Name:      " + restaurant.RestaurantName);
                        Console.WriteLine("Restaurant Address:   " + restaurant.Address1 + ", " + restaurant.city + ", " + restaurant.state);
                        Console.WriteLine("Restaurant Zipcode:   " + restaurant.ZipCode);
                        if (rate.value.Rating != "0")
                        {
                            Console.WriteLine("Average Rating:       " + rate.value.Rating);
                        }
                        else
                        {
                            Console.WriteLine("Average Rating:       " + "Not Rated yet");
                        }
                        Console.WriteLine("Restaurant Cost Type: " + restaurant.CostType);
                        Console.WriteLine("Restaurant Website:   " + restaurant.Website);
                        Console.WriteLine("Restaurant PhoneNo:   " + restaurant.ContactNo);
                    }
                }
                if ((rate.index + 1) == restaurants.Count())
                {
                    Console.WriteLine("\n---------------------------\n");
                }
            }
        }

        /// <summary>
        /// this method will ask for input for adding the review
        /// </summary>
        public void AddReview()
        {
           

            var restaurants = logic.GetAllRestaurant();
            Console.WriteLine("\n---------------------------\n");
            Console.WriteLine("Restaurant Reference No.  Restaurant Name");
            foreach (var restaurant in restaurants.Select((value, index) => new { value, index }))
            {

                Console.WriteLine(restaurant.value.RestaurantId + "                         " + restaurant.value.RestaurantName);

            }
            Console.WriteLine("");
            ReviewModelClass reviewModel = new ReviewModelClass();
            try
            {
                Console.WriteLine("Please Enter restaurant Reference No. from the list:");
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

                reviewModel.UserID = Globals.userId;
                reviewModel.ReviewTime = DateTime.Now;
            }
            catch (Exception e)
            {

                Console.WriteLine("Something went wrong, please try again!!");

            }

            reLogic.AddReviewMethod(reviewModel);

        }
    }
}

