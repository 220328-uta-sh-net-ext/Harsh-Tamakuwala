using System;
using RestaurantDl;
using RestaurantModel;

namespace RestaurantBl
{
	public class SearchUser
	{
		public SearchUser()
		{
		}
		/// <summary>
        /// it will ask for input to search a registered user in the database and will display the details of that user
        /// </summary>
		public static List<UserModelClass> SearchUserAsAdmin(string searchValue)
        {
            List<UserModelClass> userList = GetAllUser();
        
                var filteredUsers = from user in userList
                                    where user.FirstName.ToLower().Contains(searchValue.ToLower()) ||
                                          user.LastName.ToLower().Contains(searchValue.ToLower()) ||
                                          user.EmailId.ToLower().Contains(searchValue.ToLower())
                                          
                                    select user;
            return filteredUsers.ToList();
        }


        
        public static List<UserModelClass> GetAllUser()
        {
            Console.Clear();
            UserRepository userRepository = new();
            List<UserModelClass> userList = userRepository.GetItemFromDB();
            return userList;
        }
    }
}

