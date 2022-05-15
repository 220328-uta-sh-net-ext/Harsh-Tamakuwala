using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestaurantBl;
using RestaurantModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestaurantApi.Controllers
{
    [Route("api/")]
    public class RestaurantController : Controller
    {
        private RestaurantLogic logic;
        private SearchRestaurantBl seach;
        public RestaurantController(RestaurantLogic logic, SearchRestaurantBl seach)
        {
            this.seach = seach;
            this.logic = logic;
        }
        /// <summary>
        /// this will get all the rstaurant detail from database 
        /// </summary>
        /// <returns>restaurant detail</returns>
        [Route("getAllRestaurant")]
        // GET: api/values
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<List<RestaurantModelClass>> Get()
        {

            try
            {
                var restaurants = logic.GetAllRestaurant();
                if (restaurants == null)
                {
                    return Ok("There is no restaurant in Database");
                }
                else
                {
                    return Ok(restaurants);
                }

            }
            catch (Exception ex)
            {
                return BadRequest("Something went wrong,please try again");
            }
        }

        /// <summary>
        /// this will get searched the rstaurant detail from database 
        /// </summary>
        /// <param name="searchRestaurant"></param>
        /// <returns>restaurant details</returns>
        [Route("getSearchRestaurant")]
        // GET: api/values
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<List<RestaurantModelClass>> Get(string searchRestaurant)
        {

            try
            {
                var restaurants = seach.SearchRestaurantBL(searchRestaurant);
                if (restaurants.Count ==0)
                {
                    return Ok("There is no restaurant in Database");                    
                }
                else
                {
                    return Ok(restaurants);
                   
                }

            }
            catch (Exception ex)
            {
                return BadRequest("Something went wrong,please try again");
            }
        }

        /// <summary>
        /// it will add restaurant in the database
        /// </summary>
        /// <param name="restaurant"></param>
        /// <returns>return message whether restaurant is added or not</returns>
        [Route("addRestaurant")]
        // POST api/values
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult PostRestaurant([FromBody] RestaurantModelClass restaurant)
        {
            if (restaurant == null)
            {
                return BadRequest("Invalid review, please try again with valid values.");
            }
            if (restaurant.RestaurantName == "" || restaurant.RestaurantName == null)
            {
                return BadRequest("Restaurant name can not be empty.");
            }
            if (restaurant.ZipCode == "" || restaurant.ZipCode == null)
            {
                return BadRequest("Restaurant zip code can not be empty.");
            }
            if (restaurant.ContactNo.ToString().Length != 10)
            {
                return BadRequest("Invalid Contact Number.");
            }
            try
            {


                var result = logic.AddRestaurantMethod(restaurant);
                if (result == "Restaurant Added!")
                {
                    return Ok(restaurant);
                }
                else if (result == "You have already added this restaurant!!")
                {
                    return Ok("You have already added this restaurant!");
                }
                else
                {
                    return BadRequest("Something went wrong, please try again!");
                }
            }
            catch (Exception ex)
            {
                
                return BadRequest(ex.Message);
            }
        }
    }
}


