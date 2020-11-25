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
    public class RentalDetailController : ControllerBase
    {
        private RentalDetailService _service;

        public RentalDetailController()
        {
            _service = new RentalDetailService();
        }

        [HttpGet]
        public IActionResult GetByCustomer(int customerId)
        {
            return Ok(_service.GetByCustomer(customerId));
        }
    }
}
