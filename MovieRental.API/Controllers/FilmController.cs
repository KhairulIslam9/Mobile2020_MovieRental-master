using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieRental.DAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRental.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private FilmService _service;

        public FilmController()
        {
            _service = new FilmService();

        }
        [HttpGet]
        public IActionResult getAll()
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
        [HttpGet]
        [Route("Actor")]
        public IActionResult GetByActor(string Actor)
        {
            try
            {
                return Ok(_service.GetByActor(Actor));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("Category")]
        public IActionResult GetByCategory(string Category)
        {
            try
            {
                return Ok(_service.GetByCategory(Category));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("KeyWord")]
        public IActionResult GetByKeyWord(string KeyWord)
        {
            try
            {
                return Ok(_service.GetByKeyWord(KeyWord));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("Language")]
        public IActionResult GetByLanguage(string Language)
        {
            try
            {
                return Ok(_service.GetByLanguage(Language));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("Title")]
        public IActionResult GetByTitle(string Title)
        {
            try
            {
                return Ok(_service.GetByTitle(Title));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
