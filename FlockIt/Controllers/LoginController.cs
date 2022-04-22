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

        public LoginController()
        {
        }

        // POST api/<LoginController>
        [HttpPost]
        public IResult Post([FromBody] User? user)
        {
            if(user != null)
                return Results.Ok(user);
            else
                return Results.BadRequest(new { ErrorMessage = "haha, no" });
        }
    }
}
