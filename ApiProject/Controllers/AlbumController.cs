using System;
using Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiProject.Controllers
{
    [Route("api/albums")]
    public class AlbumController:Controller
    {
        private IAlbumLogic _logic;

        public AlbumController(IAlbumLogic logic)
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