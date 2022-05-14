namespace RestaurantModel
{
    public class RestaurantModelClass
    {
        public RestaurantModelClass()
        {
           

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
               
            }

        }
        public string CostType { get; set; }
       public List<ReviewModelClass> Reviews { get; set; }
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
               

            }
        }
        public double? rating { get; set; }

    }
}