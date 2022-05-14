using System;
using RestaurantBl;
using RestaurantModel;

namespace RestaurantUi
{
	public class UserOperationUi
	{
        readonly SearchUser logic;
        public UserOperationUi(SearchUser logic)
		{
            this.logic = logic;
		}
		
        public void SearchUserUiMethod()
        {
        search:
            Console.Write("Search Users : ");
            string? searchValue = Console.ReadLine();
            if (searchValue == "")
            {
                Console.WriteLine("\nInvalid Input!!\n");
                goto search;
            }
            var filteredUsers = logic.SearchUserAsAdmin(searchValue);
            if (filteredUsers.Count() > 0)
            {
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
            else
            {
                Console.WriteLine("\n---------------------------\n");
                Console.WriteLine("User not Found!!");
                Console.WriteLine("\n---------------------------\n");
            }
        }
    }
}

