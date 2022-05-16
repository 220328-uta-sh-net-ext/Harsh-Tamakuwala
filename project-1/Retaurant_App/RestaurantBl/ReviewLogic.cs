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

        /// <summary>
        /// this is logic for adding review in the databse
        /// </summary>
        /// <param name="reviewModel"></param>
        /// <returns></returns>
        public string AddReviewMethod(ReviewModelClass reviewModel)
        {
           
            var result = repo.AddItemToDB(reviewModel);

            if (result == "Review Added!!!")
            {
                
                return "Review Added!!!";
            }
            else if (result.Contains("Violation of UNIQUE KEY constrain"))
            {
                
                return "You have already rated this restaurant!!";
            }
            else
            {
               
                return "Something went wrong, please try again!!";
            }
        }

        /// <summary>
        /// This method is used to get all the reviews
        /// </summary>
        /// <returns>list of reviews</returns>
        public  List<ReviewModelClass> GetAllReview()
        {   
            List<ReviewModelClass> reviewList = repo.GetItemFromDB();
            return reviewList;
        }


        public string DeleteReview(int id)
        {
            //UserRepository user = new UserRepository();
            var result = repo.DeleteItemToDB(id);

            if (result == "review deleted")
            {

                return "review deleted!";
            }
            else
            {

                return "Failed to delete review";
            }
        }

    }
}

