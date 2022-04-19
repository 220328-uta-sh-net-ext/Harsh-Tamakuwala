namespace RestaurantModel
{
    public class RestaurantModelClass
    {
        public RestaurantModelClass()
        {

            RestaurantName = "xyz";
            Address = "Nj,Usa";
            ZipCode = "07950";
            CostType = "$$";
            Reviews = new List<ReviewModelClass>();

        }
        public int RestaurantId { get; set; }
        public string RestaurantName { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string CostType { get; set; }
        public List<ReviewModelClass> Reviews { get;}

    }
}