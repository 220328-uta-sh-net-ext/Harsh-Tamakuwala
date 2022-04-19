using System;
using System.Text.RegularExpressions;

namespace RestaurantModel
{
    public class UserModelClass
    {


        public UserModelClass()
        {
            //UserId = 0;
            FirstName = "john";
            LastName = "Pierson";
           // Age = 18;
            ContactNo = 1234567890;
            EmailId = "abc@gamil.com";
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
                else
                {
                    throw new Exception("First Name can not be empty");
                }
            }

        }

        //public int Age
        //{
        //    get
        //    {
        //        return Age;
        //    }
        //    set
        //    {
        //        if (value > 16)
        //        {
        //            Age = value;
        //        }
        //        else
        //        {
        //            throw new Exception("Age Must be greater than 16");
        //        }
        //    }

        //}
        private long contactNo;
        public long ContactNo
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
                else
                {
                    throw new Exception("Enter valid Contact No.");
                }

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
                    throw new Exception("Please enter valid email address!!");
                }
            }
        }

        //public List<ReviewModelClass> UserReview { get; set; }
        // public int UserId { get; set; }
    }
}

