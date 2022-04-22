using System;
namespace RestaurantModel
{
	public class LoginModelClass
	{
        public LoginModelClass()
        {
            EmailId = "";
            Password = "";
        }
        public string EmailId { get; set; }
        public string Password { get; set; }
    }
}

