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
            string validName = "abc";
            //Act
            restaurantModel.RestaurantName = validName;
            //Assert
            Assert.NotNull(restaurantModel.RestaurantName);
            
        }

        [Fact]
        public void NonEmptyZipCode()
        {
            //Arrange
            RestaurantModelClass restaurantModel = new RestaurantModelClass();
            string validName = "07950";
            //Act
            restaurantModel.ZipCode = validName;
            //Assert
            Assert.NotNull(restaurantModel.ZipCode);
            
        }
    }
}

