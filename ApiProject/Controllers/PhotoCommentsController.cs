using System;
using Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiProject.Controllers
{
    [Route("api/comments")]
    public class PhotoCommentsController:Controller
    {
        private IPhotoCommentsLogic _logic;
        
        public PhotoCommentsController(IPhotoCommentsLogic logic)
        {
            _logic = logic;
        }
        
        
        [HttpGet]
        public IActionResult GetList()
        {
            try
            {
                return Ok(_logic.GetList());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}