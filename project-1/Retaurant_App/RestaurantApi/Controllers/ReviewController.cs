using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestaurantBl;
using RestaurantDl;
using RestaurantModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestaurantApi.Controllers
{
    [Route("api/[controller]")]
    public class ReviewController : Controller
    {
        private ReviewLogic logic;
        public ReviewController(ReviewLogic logic)
        {

            this.logic = logic;
        }

        /// <summary>
        /// it will get all the reviews from database
        /// </summary>
        /// <returns>return all the reviews</returns>
      
        // GET: api/values
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<List<ReviewModelClass>> Get()
        {

            try
            {
                var reviews = logic.GetAllReview();
                if (reviews == null)
                {
                    return Ok("There is no review in Database");
                }
                else
                {
                    return Ok(reviews);
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// it will add the reviews to the database
        /// </summary>
        /// <param name="review"></param>
        /// <returns>return message whether review is added or not</returns>
       
        // POST api/values
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult PostReview([FromBody] ReviewModelClass review)
        {
            if (review == null)
            {
                return BadRequest("Invalid review, please try again with valid values.");
            }

            if (review.Rating == 0 || review.Rating.ToString() == null)
            {
                return BadRequest("Rating should be between 1 to 5.");
            }
            if (review.RestaurantId == 0 || review.RestaurantId.ToString() == null)
            {
                return BadRequest("RestaurantId can not be empty.");
            }
            if (review.Comments?.Length > 50)
            {
                return BadRequest("Comment can not be more than 50 char");
            }
            try
            {
                var result = logic.AddReviewMethod(review);
                if (result == "Review Added!!!")
                {
                    return CreatedAtAction("Get", review);
                }
                else if(result == "You have already rated this restaurant!!")
                {
                    return Ok("You have already rated this restaurant!");
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

        [HttpDelete("id")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult Delete(int id)
        {
            var result = logic.DeleteReview(id);
            return Ok(result);
        }   

    }
}

