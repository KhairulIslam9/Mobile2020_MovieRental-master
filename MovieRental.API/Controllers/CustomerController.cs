using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieRental.DAL.Models;
using MovieRental.DAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRental.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private CustomerService _service;
        
        public CustomerController()
        {
            _service = new CustomerService();
        }

        [HttpGet]

        public IActionResult GetCheck(string email, string passwd)
        {
            try
            {
                return Ok(_service.Login(email, passwd));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult Register(Customer customer)
        {
            try
            {
                _service.Insert(customer);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

            return Ok("Insertion effectué");
        }
        
        
    }
}
