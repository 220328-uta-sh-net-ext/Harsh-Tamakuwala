using System;
using RestaurantModel;
namespace RestaurantDl
{
	public interface IUserRepository
	{
        /// <summary>
        /// Add a new user to the database
        /// </summary>
        /// <param name="user"></param>
        /// <returns>The user added</returns>
        string AddUserToDB(UserModelClass user);
        /// <summary>
        /// This method returns all the user from the database
        /// </summary>
        /// <returns>Returns a collection of user as Generic List</returns>
        List<UserModelClass> GetAllUsers();
    }
}

