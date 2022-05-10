using System;
using System.Text.RegularExpressions;

namespace RestaurantModel
{
    public class UserModelClass
    {


        public UserModelClass()
        {

            //UserId = 0;
            //firstName = "john";
            //LastName = "Pierson";
            //password = "abc123";
            //confirmPassword = "abc123";
            //contactNo = 1234567890;
            //emailId = "abc@gamil.com";
            // UserReview = new List<ReviewModelClass>();

        }

        public string LastName { get; set; }
        
        private string firstName;   
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    firstName = value;
                }
                //else
                //{
                //    throw new Exception("First Name can not be empty");
                //}
            }

        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                if (!(value.Length < 6))
                {
                    password = value;
                }
                //else
                //{
                //    throw new Exception("Minimum 6 character requried!!");
                //}
            }


        }

        private string confirmPassword;
        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set
            {
                if (!(value.Length < 6))
                {
                    confirmPassword = value;
                }
                else
                {
                    throw new Exception("Minimum 6 character requried!!");
                }
            }


        }

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
                //else
                //{
                //    throw new Exception("Enter valid Contact No.");
                //}

            }
        }

        private string emailId;
        public string EmailId
        {
            get
            {
                return emailId;
            }
            set
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match m = regex.Match(value);
                if (m.Success)
                {
                    emailId = value;

                }
                else
                {
                    emailId = "";
                }
            }
        }
        
        //public List<ReviewModelClass> UserReview { get; set; }
        public int UserId { get; set; }
    }
}

