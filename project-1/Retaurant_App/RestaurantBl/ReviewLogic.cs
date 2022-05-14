using System;
using RestaurantDl;
using RestaurantModel;

namespace RestaurantBl
{
    public class ReviewLogic
    {
        readonly IItemRepository<ReviewModelClass> repo;
       
        public ReviewLogic(IItemRepository<ReviewModelClass> repo)
        {
            this.repo = repo;
        }
        public  string AddReviewMethod(ReviewModelClass reviewModel)
        {
           
            var result = repo.AddItemToDB(reviewModel);

            if (result == "Review Added!!!")
            {
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
                Console.WriteLine("\nSomething went wrong, please try again!!\n");
                return "Something went wrong, please try again!!";
            }
        }

        /// <summary>
        /// This method is used to get all the reviews
        /// </summary>
        /// <returns>list of reviews</returns>
        public  List<ReviewModelClass> GetAllReview()
        {
            Console.Clear();
           
            List<ReviewModelClass> reviewList = repo.GetItemFromDB();
            return reviewList;
        }

    }
}

