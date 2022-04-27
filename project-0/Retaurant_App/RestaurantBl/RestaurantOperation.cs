using System;
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
            throw new NotImplementedException();
        }

        public static void AvgRatingOfRestaurants()
        {
            throw new NotImplementedException();
        }

        public static void ViewReviews()
        {
            throw new NotImplementedException();
        }

        public static void ViewRestaurantDetails()
        {
            throw new NotImplementedException();
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
            Console.WriteLine("Please Enter restaurant Name from the list:");
            reviewModel.RestaurantName = Console.ReadLine();

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
            throw new NotImplementedException();
        }

        public static void SearchUserAsAdmin()
        {
            throw new NotImplementedException();
        }
    }
}

