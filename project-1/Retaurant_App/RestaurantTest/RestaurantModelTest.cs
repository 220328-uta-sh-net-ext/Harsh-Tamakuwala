using System;
using RestaurantModel;
using Xunit;

namespace RestaurantTest
{
	public class RestaurantModelTest
	{
		public RestaurantModelTest()
		{
		}
        [Fact]
        public void NonEmptyRestaurantName()
        {
            //Arrange
            RestaurantModelClass restaurantModel = new RestaurantModelClass();
            restaurantModel.RestaurantName = "abc";
           
            //Assert
            Assert.NotNull(restaurantModel.RestaurantName);
            
        }

        [Fact]
        public void NonEmptyZipCode()
        {
            //Arrange
            RestaurantModelClass restaurantModel = new RestaurantModelClass();
           
            restaurantModel.ZipCode = "07950";
           
            
            //Assert
            Assert.NotNull(restaurantModel.ZipCode);
            
        }
    }
}

