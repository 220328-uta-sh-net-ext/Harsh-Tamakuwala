using System;
using RestaurantDl;
using RestaurantModel;

namespace RestaurantBl
{
	public class AddUserLogic
	{
		
        readonly IItemRepository<UserModelClass> repo;
        public AddUserLogic(IItemRepository<UserModelClass> repo)
        {
            this.repo = repo;
        }

        /// <summary>
        /// this is logic for adding user in the databse
        /// </summary>
        /// <param name="userModel"></param>
        /// <returns></returns>
        public string addUserMethod(UserModelClass userModel)
        {
            //UserRepository user = new UserRepository();
            var result = repo.AddItemToDB(userModel);

            if (result == "User Added!!!")
            {
              
                return "User Added!!!";
            }
            else if (result.Contains("Violation of UNIQUE KEY constrain"))
            {
               
                return "Violation of UNIQUE KEY constraint";
            }
            else
            {
             
                return "Failed to add user \n";
            }
        }

        public string DeleteUser(int id)
        {
            //UserRepository user = new UserRepository();
            var result = repo.DeleteItemToDB(id);

            if (result == "User deleted")
            {

                return "User deleted!";
            }
            else
            {

                return "Failed to delete user";
            }
        }

    }
}

