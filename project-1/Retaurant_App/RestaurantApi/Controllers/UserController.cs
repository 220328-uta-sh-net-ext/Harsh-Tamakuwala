using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RestaurantBl;
using RestaurantDl;
using RestaurantModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestaurantApi.Controllers
{
    [Route("api/[controller]")]

    public class UserController : Controller
    {
        // GET: api/values
       
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<UserModelClass>> Get()
        {
           
            try
            {
                var users = SearchUser.GetAllUser();
                if(users == null)
                {
                    return NotFound("There is no users in Database");
                }
                else
                {
                    return Ok(users);
                }
               
            }catch(Exception ex)
            {
                return BadRequest("Server is down,please try again");
            }
        }

        
    }
}

