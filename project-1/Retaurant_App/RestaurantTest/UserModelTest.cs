using RestaurantModel;
using Xunit;

namespace RestaurantTest
{
    public class UserModelTest
    {

        [Fact]
        public void FirstNameShouldBevalidData()
        {
            //Arrange
            UserModelClass userModel = new UserModelClass();
            string validFN = "abc";
            //Act
            userModel.FirstName = validFN;
            //Assert
            Assert.NotNull(userModel.FirstName);
            Assert.Equal(validFN, userModel.FirstName);
        }

        [Fact]
        public void PasswordshouldnotlessthanSixChar()
        {
            //Arrange
            UserModelClass userModel = new UserModelClass();
            string validPass = "abc1234";
            userModel.Password = "abc1234";
            //Act
            userModel.Password = validPass;
            //Assert
            Assert.NotNull(userModel.Password);
            Assert.Equal(validPass, userModel.Password);
        }
       

        [Fact]
        public void ConfirmPasswordshouldnotlessthanSixChar()
        {
            //Arrange
            UserModelClass userModel = new UserModelClass();
            string validPass = "abc1234";
            userModel.ConfirmPassword = "abc1234";
            //Act
            userModel.ConfirmPassword = validPass;
            //Assert
            Assert.NotNull(userModel.ConfirmPassword);
            Assert.Equal(validPass, userModel.ConfirmPassword);
        }
        [Theory]
        [InlineData("abc12")]
        [InlineData("abcde")]
        public void ConfirmPasswordshouldnotlessthanSix(string p_invalidData)
        {
            //Arrange
            UserModelClass userModel = new UserModelClass();
            userModel.ConfirmPassword = "abc1234";
            //Assert
            Assert.Throws<System.Exception>(
                () => userModel.ConfirmPassword = p_invalidData
                );
        }

       

        [Fact]
        public void EmailshoudMatchRegex()
        {
            //Arrange
            UserModelClass userModel = new UserModelClass();
            string validemail = "abc@gmail.com";
            userModel.EmailId = "abc@gmail.com";
            //Act
            userModel.EmailId = validemail;
            //Assert
            Assert.NotNull(userModel.EmailId);
            Assert.Equal(validemail, userModel.EmailId);
        }
        }
}

