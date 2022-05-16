//global using Serilog;

using System;
using RestaurantModel;


//Log.Logger = new LoggerConfiguration().WriteTo.File("./Logs/user.txt").MinimumLevel.Debug().MinimumLevel.Information()
//    .CreateLogger();

namespace RestaurantDl
{
    public interface IItemRepository<T> 
    {
        /// <summary>
        /// Add a new item to the database
        /// </summary>
        /// <param name="item"></param>
        /// <returns>The item added</returns>
        string AddItemToDB(T item);
        /// <summary>
        /// This method returns all the item from the database
        /// </summary>
        /// <returns>Returns a collection of item as Generic List</returns>
        List<T> GetItemFromDB();
        /// <summary>
        /// delete a new item to the database
        /// </summary>
        /// <param name="item"></param>
        /// <returns>The item deleted</returns>
        string DeleteItemToDB(int id);

    }
    public interface IAvgReviewRepository{
        /// <summary>
        /// it will get avg rating for all the restaurant;
        /// </summary>
        List<AvgRating> getAvgReview(); 
}

    
}

