namespace RestaurantModel
{
    public class RestaurantModelClass
    {
        public RestaurantModelClass()
        {
            RestaurantId = 0;
            RestaurantName = "xyz";
            Address = "Nj,Usa";
            ZipCode = "07950";
            CostType = "$$";
            Website = "www.xyz.com";
            //Reviews = new List<ReviewModelClass>();

        }
        public int RestaurantId { get; set; }
        private string restaurantName; 
        public string RestaurantName
        {
            get => restaurantName;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    restaurantName = value;
                }
                else
                {
                    throw new Exception("Restaurant Name can not be empty");
                }
            }

        }
        public string Address { get; set; }
        private string zipCode;
        public string ZipCode
        {
            get => zipCode;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    zipCode = value;
                }
                else
                {
                    throw new Exception("Zip code can not be empty");
                }
            }

        }
        public string CostType { get; set; }
        //public List<ReviewModelClass> Reviews { get;}
        public string Website { get; set; }

    }
}