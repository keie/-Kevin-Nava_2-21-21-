using System;
using Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiProject.Controllers
{
    [Route("api/photos")]
    public class PhotoAlbumController:Controller
    {
        private IPhotoAlbumLogic _logic;

        public PhotoAlbumController(IPhotoAlbumLogic logic)
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