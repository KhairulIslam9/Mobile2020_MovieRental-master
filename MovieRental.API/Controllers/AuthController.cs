using Microsoft.AspNetCore.Mvc;
using MovieRental.API.Models.Forms;
using MovieRental.API.Models.Services;
using MovieRental.API.Security;
using MovieRental.DAL.Models;


namespace MovieRental.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;
        private readonly TokenService _tokenService;
       
        public AuthController()
        {
            _authService = new AuthService();
            _tokenService = new TokenService();
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult GetCheck([FromBody] LoginForm form)
        {
            if (ModelState.IsValid)
            {
                Customer customer = _authService.Login(form.Email, form.Passwd);

                if (customer is null)
                {
                    return NotFound();
                }

                customer.Token = _tokenService.GenerateToken(customer);

                return Ok(customer);
            }

            return BadRequest();
        }

        [HttpPost]
        [Route("Register")]
        public IActionResult Register([FromBody] RegisterForm form)
        {
            if (ModelState.IsValid)
            {
                Customer customer = new Customer()
                {
                    LastName = form.LastName,
                    FirstName = form.FirstName,
                    Email = form.Email,
                    Passwd = form.Passwd
                };
                _authService.Register(customer);
                return Ok();
            }

            return BadRequest();

        }
        
        
    }
}
