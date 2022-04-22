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
            //Act
            userModel.Password = validPass;
            //Assert
            Assert.NotNull(userModel.Password);
            Assert.Equal(validPass, userModel.Password);
        }
        [Theory]
        [InlineData("abc12")]
        [InlineData("abcde")]
        public void PasswordshouldnotlessthanSix(string p_invalidData)
        {
            //Arrange
            UserModelClass userModel = new UserModelClass();

            //Assert
            Assert.Throws<System.Exception>(
                () => userModel.Password = p_invalidData
                );
        }

        [Fact]
        public void ConfirmPasswordshouldnotlessthanSixChar()
        {
            //Arrange
            UserModelClass userModel = new UserModelClass();
            string validPass = "abc1234";
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

            //Assert
            Assert.Throws<System.Exception>(
                () => userModel.ConfirmPassword = p_invalidData
                );
        }

        [Theory]
        [InlineData(1234567)]
        [InlineData(123098765)]
        public void ContactshouldnotlessthanSix(int p_invalidData)
        {
            //Arrange
            UserModelClass userModel = new UserModelClass();

            //Assert
            Assert.Throws<System.Exception>(
                () => userModel.ContactNo = p_invalidData
                );
        }

        [Fact]
        public void EmailshoudMatchRegex()
        {
            //Arrange
            UserModelClass userModel = new UserModelClass();
            string validemail = "abc@gmail.com";
            //Act
            userModel.EmailId = validemail;
            //Assert
            Assert.NotNull(userModel.ConfirmPassword);
            Assert.Equal(validemail, userModel.EmailId);
        }
        }
}

