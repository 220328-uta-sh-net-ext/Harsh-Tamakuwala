using System;
namespace RestaurantUi
{
	public interface IMenu
	{
		/// <summary>
		/// Will display the menu and user choices in the terminal
		/// </summary>
		void Display();
		/// <summary>
		/// Will record the user's choice and change/route your menu based on that choice
		/// </summary>
		/// <returns>Return the menu that will change your screen</returns>
		string UserChoice();
		
	}

	public interface IInitiateMenu
    {
		/// <summary>
		/// Asking for chosing admin or user
		/// if user is selected then asking for registered or new user
		/// </summary>

		public string getinitiated();

	}
}

