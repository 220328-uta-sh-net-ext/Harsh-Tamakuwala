namespace RestaurantModel
{
    public class RestaurantModelClass
    {
        public RestaurantModelClass()
        {
            RestaurantId = 0;
            RestaurantName = "xyz";
            Address1 = "123 main street";
            city = "Morris plains";
            state = "NJ";
            ZipCode = "07950";
            CostType = "$$";
            Website = "www.xyz.com";
            ContactNo = 1234567890;
            rating =0;
            //Reviews = new List<ReviewModelClass>();

        }
        public int RestaurantId { get; set; }
       
        private string? restaurantName;
        public string? RestaurantName
        {
            get { return restaurantName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    restaurantName = value;
                }
                else
                {
                    throw new Exception("First Name can not be empty");
                }
            }

        }
        public string city { get; set; }
        public string state { get; set; }
        public string Address1 { get; set; }
        private string? zipCode;
        public string? ZipCode
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
       
        private decimal contactNo;
        public decimal ContactNo
        {
            get
            {
                return contactNo;
            }
            set
            {
                if (value.ToString().Length == 10)
                {
                    contactNo = value;
                }
                else
                {
                    throw new Exception("Enter valid Contact No.");
                }

            }
        }
        public int? rating { get; set; }

    }
}