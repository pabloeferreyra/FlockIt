using FlockIt.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FlockIt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        // POST api/<LoginController>
        [HttpPost]
        public IResult Post([FromBody] User? user)
        {
            try
            {
                return Results.Ok(user);
            }
            catch (Exception ex)
            {
                return Results.BadRequest(new { ErrorMessage = "haha, no" });
            }
        }
    }
}
