using System;
namespace RestaurantModel
{
	
	public class AvgRating
	{
		public AvgRating()
		{
			Rating = "Not rated yet.";
			RestaurantId = 0;
		}
        public int RestaurantId { get; set; }
        public string Rating { get; set; }
    }
}

