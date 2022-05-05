using System;
using RestaurantDl;
using RestaurantModel;

namespace RestaurantBl
{
	public class AddReviewLogic
	{
		public AddReviewLogic()
		{
		}
        public static void AddReviewMethod(ReviewModelClass reviewModel)
        {
            ReviewRepository review = new ReviewRepository();
            var result = review.AddItemToDB(reviewModel);

            if (result == "Review Added!!!")
            {
                //Log.Information("Review successfully added");
                Console.WriteLine("\nReview Added!!!\n");
            }
            else if (result.Contains("Violation of UNIQUE KEY constrain"))
            {
                Console.WriteLine("\nYou have already rated this restaurant!!\n");
            }
            else
            {
                //Log.Information(" faild : ", result.ToString());
                Console.WriteLine("\nSomething went wrong, please try again!!:\n");
            }
        }
    }
}

