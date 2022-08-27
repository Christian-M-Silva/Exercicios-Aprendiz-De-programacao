using Microsoft.AspNetCore.Mvc;
using MyFirstApiDomain.Entities;
using MyFirstApiDomain.Interfaces.Service.InterfaceUser;
using System.Threading.Tasks;
using System;
using System.Net;

namespace MyFirstApi.Controllers {
    [Route("api/[controller]")]
    [ApiController]

    public class LoginController : ControllerBase {
        [HttpPost]

        public async Task<object> Login([FromBody] User users, [FromServices] IloginUser loginUser) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }
            if (users == null) { 
                return BadRequest();
            }
            try {
                var result = await loginUser.FindByLogin(users);
                if (result == null) { 
                    return NotFound();
                }
                else {
                    return Ok(result);
                }
            }
            catch (ArgumentException err) {

                return StatusCode((int) HttpStatusCode.InternalServerError, err.Message);
            }
        }
    }
}
