﻿using System;
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
            string validComment = "nice restaurant!!";
            //Act
            reviewModel.Comments = validComment;
            //Assert
            Assert.NotNull(reviewModel.Comments);
            Assert.Equal(validComment, reviewModel.Comments);
        }
        [Theory]
        [InlineData(7)]
        [InlineData(-2)]
        public void PasswordshouldnotlessthanSix(int p_invalidData)
        {
            //Arrange
            ReviewModelClass reviewModel = new ReviewModelClass();

            //Assert
            Assert.Throws<System.Exception>(
                () => reviewModel.Rating = p_invalidData
                );
        }

        [Fact]
        public void NonEmptyRestaurantName()
        {
            //Arrange
            ReviewModelClass reviewModel = new ReviewModelClass();
            string validName = "abc";
            //Act
            reviewModel.RestaurantName = validName;
            //Assert
            Assert.NotNull(reviewModel.RestaurantName);
            //Assert.Equal(validName, reviewModel.RestaurantName);
        }

    }
}

