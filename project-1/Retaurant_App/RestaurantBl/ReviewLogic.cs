using System;
using RestaurantDl;
using RestaurantModel;

namespace RestaurantBl
{
    public class ReviewLogic
    {
        public ReviewLogic()
        {
        }
        public static string AddReviewMethod(ReviewModelClass reviewModel)
        {
            ReviewRepository review = new ReviewRepository();
            var result = review.AddItemToDB(reviewModel);

            if (result == "Review Added!!!")
            {
                //Log.Information("Review successfully added");
                Console.WriteLine("\nReview Added!!!\n");
                return "Review Added!!!";
            }
            else if (result.Contains("Violation of UNIQUE KEY constrain"))
            {
                Console.WriteLine("\nYou have already rated this restaurant!!\n");
                return "You have already rated this restaurant!!";
            }
            else
            {
                //Log.Information(" faild : ", result.ToString());
                Console.WriteLine("\nSomething went wrong, please try again!!\n");
                return "Something went wrong, please try again!!";
            }
        }

        /// <summary>
        /// This method is used to get all the reviews
        /// </summary>
        /// <returns>list of reviews</returns>
        public static List<ReviewModelClass> GetAllReview()
        {
            Console.Clear();
            ReviewRepository reviewRepository = new();
            List<ReviewModelClass> reviewList = reviewRepository.GetItemFromDB();
            return reviewList;
        }

    }
}

