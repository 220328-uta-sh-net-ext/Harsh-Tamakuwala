using System;
namespace RestaurantModel
{
   
    public class ReviewModelClass
    {
        public ReviewModelClass()
        {
            
            ReviewTime = DateTime.Now;
            

        }
        public int ReviewId { get; set; }
        public DateTime ReviewTime { get; set; }
        public string UserName { get; set; }
        public int UserID { get; set; }

        private string? comment;
        public string? Comments { get => comment;

            set {
                if (value.Length < 50)
                {
                    comment = value;
                }
                
            }
        }

        private double rating;
        public double Rating {
            get { return rating; }
            set {
                if(value>0 && value <= 5)
                {
                    rating = value;
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
               
            }
        }

       

        public string? RestaurantName { get; set; }


    }
}

