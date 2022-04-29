using System;
namespace RestaurantModel
{
    public class ReviewModelClass
    {
        public ReviewModelClass()
        {
            ReviewId = 0;
            RestaurantId = 0;         
            Comments = "";
            UserName = "john Pierson";
            rating = 5;
            ReviewTime = DateTime.Now;
            RestaurantName = "";

        }
        public int ReviewId { get; set; }
        public DateTime ReviewTime { get; set; }
       
        public string UserName { get; set; }

        private string? comment;
        public string? Comments { get => comment;

            set {
                if (value.Length < 50)
                {
                    comment = value;
                }
                else
                {
                    throw new Exception("50 characters only");

                }
            }
        }

        private int rating;
        public int Rating {
            get { return rating; }
            set {
                if(value>0 && value <= 5)
                {
                    rating = value;
                }
                else
                {
                    throw new Exception("Please enter valid rating!");
                }
            }
        }
        
        private int restaurantId;
        public int RestaurantId {
            get => restaurantId;
            set
            {
                if (!string.IsNullOrEmpty(value.ToString()))
                {
                    restaurantId = value;
                }
                else
                {
                    throw new Exception("Restaurant Id cannot be empty!");
                }
            }
        }
        public string? RestaurantName { get; set; }


    }
}

