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
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
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

        // GET api/values/5
        [HttpGet("Search")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<UserModelClass> Get(string searchuser)
        {
            if (searchuser == null || int.TryParse(searchuser, out int result) == true)
                return BadRequest("Invalid input, please try again with valid input");
            var user = SearchUser.SearchUserAsAdmin(searchuser);
            if (user.Count <= 0)
                return NotFound("User not found");
            return Ok(user);
        }

        // POST api/values
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Post([FromBody] UserModelClass user)
        {
            if (user == null)
            {
                return BadRequest("Invalid User, please try again with valid values.");
            }

            if (user.FirstName == null || user.FirstName == "")
            {
                return BadRequest("Invalid First Name,please enter valid First Name.");
            }
            if (user.Password.Length < 6)
            {
                return BadRequest("Password must be more than 6 character.");
            }
            if (user.ContactNo.ToString().Length != 10)
            {
                return BadRequest("Invalid Contact Number,please enter valid contact number.");
            }
            if (user.EmailId == "")
            {
                return BadRequest("Invalid Email address,Please enter valid email address!!");

            }
            try
            {
                AddUserLogic.addUserMethod(user);
                return CreatedAtAction("Get", user);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put(int id, [FromBody] UserModelClass user)
        {
            if (user == null)
            {
                return BadRequest("Invalid User, please try again with valid values.");
            }

            if (user.FirstName == null || user.FirstName == "")
            {
                return BadRequest("Invalid First Name,please enter valid First Name.");
            }
            if (user.Password.Length < 6)
            {
                return BadRequest("Password must be more than 6 character.");
            }
            if (user.ContactNo.ToString().Length != 10)
            {
                return BadRequest("Invalid Contact Number,please enter valid contact number.");
            }


            if (user.EmailId == "")
            {
                return BadRequest("Invalid Email address,Please enter valid email address!!");

            }
            try
            {
                UserRepository userRepository = new();
                userRepository.updateUser(id, user);
                return Created("Get", user);
            }
            catch (Exception ex)
            {
                return BadRequest("Something went wrong!!");
            }
        }

        // DELETE api/values/5
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult Delete(int id)
        {

            UserRepository userRepository = new();
            userRepository.deleteUser(id);
            return Ok();
        }

    }
}

