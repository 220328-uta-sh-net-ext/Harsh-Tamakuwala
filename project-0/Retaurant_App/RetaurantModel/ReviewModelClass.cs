using System;
namespace RestaurantModel
{
	public class ReviewModelClass
	{
		public ReviewModelClass()
		{
            Comments = "";
            UserName = "john Pierson";
            Rating = 5;
            ReviewTime = DateTime.Now;

        }
        public int ReviewId { get; set; }
        public string Comments { get; set; }
        public string UserName { get; set; }
        public int Rating { get; set; }
        public DateTime ReviewTime { get; set; }

    }
}

