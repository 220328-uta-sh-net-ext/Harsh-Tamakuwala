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
		public static void SearchUserAsAdmin()
		{
			Console.Clear();
			UserRepository userRepository = new UserRepository();
			List<UserModelClass> userList = userRepository.GetAllUsers();
			search:
			Console.Write("Search Users : ");
			string? searchValue= Console.ReadLine();
			if (searchValue == "")
			{
				Console.WriteLine("\nInvalid Input!!\n");
				goto search;
			}
			else
			{

				var filteredUsers =from user in userList
									where user.FirstName.ToLower().Contains(searchValue.ToLower()) ||
										  user.LastName.ToLower().Contains(searchValue.ToLower()) ||
										  user.EmailId.ToLower().Contains(searchValue.ToLower()) ||
										  user.ContactNo.ToString().Contains(searchValue)
									select user;

				foreach (var user in filteredUsers.Select((value, index) => new { value, index }))
				{
					Console.WriteLine("\n---------------------------\n");
					Console.WriteLine("User: " + (user.index + 1));
					Console.WriteLine("First Name: " + user.value.FirstName);
					Console.WriteLine("Last Name: " + user.value.LastName);
					Console.WriteLine("EmailId: " + user.value.EmailId);
					Console.WriteLine("Contact NO: " + user.value.ContactNo);
					if ((user.index + 1) == filteredUsers.Count())
					{
						Console.WriteLine("\n---------------------------\n");
					}

				}
			}
        }
	}
}

