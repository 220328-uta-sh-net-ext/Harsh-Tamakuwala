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
    [Route("api/[controller]")]
    public class ReviewController : Controller
    {
        // GET: api/values
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<List<ReviewModelClass>> Get()
        {

            try
            {
                var reviews = ReviewLogic.GetAllReview();
                if (reviews == null)
                {
                    return NotFound("There is no reviews in Database");
                }
                else
                {
                    return Ok(reviews);
                }

            }
            catch (Exception ex)
            {
                return BadRequest("Server is down,please try again");
            }
        }

       
    }
}

