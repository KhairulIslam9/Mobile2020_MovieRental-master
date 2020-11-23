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
    public class ActorController : ControllerBase
    {
        private ActorService _service;

        public ActorController()
        {
            _service = new ActorService();

        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_service.GetAll());
            }catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{Id:int}")]
        public IActionResult GetById(int Id)
        {
            try
            {
                return Ok(_service.GetById(Id));
            }catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("Title")]
        public IActionResult getByFilm(string Title)
        {
            try
            {
                return Ok(_service.GetByFilm(Title));
            }catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        [HttpGet]
        [Route("Initial")]
        public IActionResult GetByInital(char Initial)
        {
            try
            {
                return Ok(_service.GetByIntial(Initial));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("AllInitial")]
        public IActionResult getAllInitial()
        {
            try
            {
                return Ok(_service.getAllInitial());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
