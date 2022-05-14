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

        [Route("getAllRestaurant")]
        // GET: api/values
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<List<ReviewModelClass>> Get()
        {

            try
            {
                var restaurants = logic.GetAllRestaurant();
                if (restaurants == null)
                {
                    return NotFound("There is no restaurant in Database");
                }
                else
                {
                    return Ok(restaurants);
                }

            }
            catch (Exception ex)
            {
                return BadRequest("Server is down,please try again");
            }
        }

        [Route("getSearchRestaurant")]
        // GET: api/values
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<List<ReviewModelClass>> Get(string searchRestaurant)
        {

            try
            {
                var restaurants = seach.SearchRestaurantBL(searchRestaurant);
                if (restaurants == null)
                {
                    return NotFound("There is no restaurant in Database");
                }
                else
                {
                    return Ok(restaurants);
                }

            }
            catch (Exception ex)
            {
                return BadRequest("Server is down,please try again");
            }
        }
    }
}


