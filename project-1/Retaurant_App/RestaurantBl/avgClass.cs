using System;
using RestaurantDl;
using RestaurantModel;

namespace RestaurantBl
{
	public class avgClass
	{
        readonly IAvgReviewRepository repo;
      
        public avgClass(IAvgReviewRepository repo)
        {
            this.repo = repo;
        }
        /// <summary>
        /// This method is used to get all the avgrage rating ofrestaurant details
        /// </summary>
        /// <returns>list of avarage rating of restaurant</returns>
        public List<AvgRating> GetAvgRating()
        {
            
            var avgRating = repo.getAvgReview();
            return avgRating;
        }
    }
}

