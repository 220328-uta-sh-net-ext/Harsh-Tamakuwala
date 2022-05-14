using System;
using RestaurantDl;
using RestaurantModel;

namespace RestaurantBl
{
	public class SearchUser
	{
		
        readonly IItemRepository<UserModelClass> repo;
        public SearchUser(IItemRepository<UserModelClass> repo)
        {
            this.repo = repo;
        }
        /// <summary>
        /// it will ask for input to search a registered user in the database and will display the details of that user
        /// </summary>
        public List<UserModelClass> SearchUserAsAdmin(string searchValue)
        {
            List<UserModelClass> userList = GetAllUser();
        
                var filteredUsers = from user in userList
                                    where user.FirstName.ToLower().Contains(searchValue.ToLower()) ||
                                          user.LastName.ToLower().Contains(searchValue.ToLower()) ||
                                          user.EmailId.ToLower().Contains(searchValue.ToLower())
                                          
                                    select user;
            return filteredUsers.ToList();
        }


        
        public  List<UserModelClass> GetAllUser()
        {
            Console.Clear();
            //UserRepository userRepository =new userRepository();
            List<UserModelClass> userList = repo.GetItemFromDB();
            return userList;
        }
    }
}

