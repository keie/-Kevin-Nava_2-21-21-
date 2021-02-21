using System;
using Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiProject.Controllers
{
    [Route("api/users")]
    public class UsersController:Controller
    {
        private IUsersLogic _logic;
        public UsersController(IUsersLogic logic)
        {
            _logic = logic;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            try
            {
                return Ok(_logic.GetLsit());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        
    }
}