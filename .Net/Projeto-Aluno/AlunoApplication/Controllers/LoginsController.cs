using Domain.Interface.Director.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace AlunoApplication.Controllers {
    [Route("api/[controller]")]
    [ApiController]

    public class LoginsController: ControllerBase {
        private ILoginService _logingservice;

        public LoginsController(ILoginService logingservice) {
            _logingservice = logingservice;
        }

        [HttpGet] //Esse metodo o professor fez como post, mas para mim não fez sentindo então ir seguindo como get qualquer coisa eu mudo para post
        [Route("{email}", Name = "GetEmail")]

        public async Task<ActionResult> FindByEmail(string email) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            try {
                return Ok(await _logingservice.FindByLoginService(email));
            }
            catch (ArgumentException erro) {

                return StatusCode((int)HttpStatusCode.InternalServerError, erro.Message);
            }
        }
    }
}
