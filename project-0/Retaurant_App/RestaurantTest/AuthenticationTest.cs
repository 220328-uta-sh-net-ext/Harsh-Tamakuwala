using System;
using RestaurantBl;
using RestaurantModel;
using Xunit;

namespace RestaurantTest
{
	public class AuthenticationTest
	{
		public AuthenticationTest()
		{
		}
        [Fact]
        public void checkForAdmin()
        {
            //Arrange
            Authentication authentication = new Authentication();
            LoginModelClass loginModel = new LoginModelClass();
            loginModel.EmailId = "admin@gmail.com";
            loginModel.Password = "admin123@";
            string validresult = "Login Successful";
            //Act
            string result=authentication.login("Admin", loginModel.EmailId ,
            loginModel.Password);
            //Assert
            // Assert.NotNull(restaurantModel.RestaurantName);
            Assert.Equal(result, validresult);
        }
    }
}

