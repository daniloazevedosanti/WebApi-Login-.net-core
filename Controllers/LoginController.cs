using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        // GET: api/<LoginController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // POST api/<LoginController>
        [HttpPost]
        public ActionResult Post([FromBody] Models.Login login)
        {
            if (login == null)
            {
                return NoContent();
            }
            else
            {
                if (login.Usuario == "admin" && login.Senha == "1234")
                    return Ok();
                else
                    return BadRequest();
            }
        }
       
    }
}
