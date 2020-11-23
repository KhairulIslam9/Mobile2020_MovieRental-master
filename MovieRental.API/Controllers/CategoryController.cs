using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using MovieRental.DAL.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRental.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private CategoryService _service;

        public CategoryController()
        {
            _service = new CategoryService();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_service.GetAll());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
