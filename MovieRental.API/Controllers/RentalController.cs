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
    public class RentalController : ControllerBase
    {
        private RentalService _service;

        public RentalController()
        {
            _service = new RentalService();
        }

        [HttpPost]
        [Route("Basket")]
        public IActionResult insert(int customerId, params Film[] film)
        {
            return Ok(_service.Basket(customerId, film));
        }
    }
}
