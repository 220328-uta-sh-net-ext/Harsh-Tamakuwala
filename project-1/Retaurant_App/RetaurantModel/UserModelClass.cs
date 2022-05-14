using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace RestaurantModel
{
    public class UserModelClass
    {


        public UserModelClass()
        {

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
                
            }


        }
        
        private string confirmPassword;
        [JsonIgnore]
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
      
        public int UserId { get; set; }
    }
}

