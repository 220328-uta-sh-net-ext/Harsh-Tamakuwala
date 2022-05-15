using System;
using RestaurantModel;
using Xunit;

namespace RestaurantTest
{
	public class ReviewModelTest
	{
        [Fact]
        public void CommentlessthanFiftyChar()
        {
            //Arrange
            ReviewModelClass reviewModel = new ReviewModelClass();

            reviewModel.Comments = "nice restaurant";
          
            //Assert,act
            Assert.NotNull(reviewModel.Comments);
            
        }
     
        [Fact]
        public void NonEmptyRestaurantName()
        {
            //Arrange
            ReviewModelClass reviewModel = new ReviewModelClass();
            reviewModel.RestaurantId = 1;

           
            //Assert,Act
            Assert.NotNull(reviewModel.RestaurantId.ToString());
            
        }

    }
}

