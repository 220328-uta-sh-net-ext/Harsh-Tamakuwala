using System;
namespace RestaurantModel
{
    public class ReviewModelClass
    {
        public ReviewModelClass()
        {
            ReviewId = 0;
            RestaurantName = "abc";
            Comments = "";
            UserName = "john Pierson";
            rating = 5;
            ReviewTime = DateTime.Now;

        }
        public int ReviewId { get; set; }
        public DateTime ReviewTime { get; set; }
       
        public string UserName { get; set; }

        private string comment;
        public string Comments { get => comment;

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
                if(value>1 && value < 5)
                {
                    rating = value;
                }
                else
                {
                    throw new Exception("Please enter valid rating!");
                }
            }
        }
        
        private string restaurantName;
        public string RestaurantName {
            get => restaurantName;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    restaurantName = value;
                }
                else
                {
                    throw new Exception("Restaurant name cannot be empty!");
                }
            }
        }


    }
}

