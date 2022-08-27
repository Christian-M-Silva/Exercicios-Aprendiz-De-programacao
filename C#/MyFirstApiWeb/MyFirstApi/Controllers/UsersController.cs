using Microsoft.AspNetCore.Mvc;
using MyFirstApiDomain.Entities;
using MyFirstApiDomain.Interfaces.Service.InterfaceUser;
using System;
using System.Net;
using System.Threading.Tasks;

namespace MyFirstApi.Controllers {
    [Route("api/[controller]")]
    [ApiController]

    public class UsersController : ControllerBase {
        private IUserService _userService;

        public UsersController(IUserService userService) {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll() {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            try {
                return Ok(await _userService.GetAll());
            }
            catch (ArgumentException err) {

                return StatusCode((int) HttpStatusCode.InternalServerError, err.Message);
            }
        }

        [HttpGet]
        [Route ("{id}", Name = "routeWhitId")]
        public async Task<ActionResult> Get (Guid id) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            try {
                return Ok(await _userService.Get(id));
            }
            catch (ArgumentException err) {

                return StatusCode((int) HttpStatusCode.InternalServerError, err.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] User user) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            try {
                var result = await _userService.Post(user);
                if (result != null) {
                    return Created(new Uri(Url.Link("routeWhitId", new {id = result.Id})), result);
                }
                else {
                    return BadRequest();
                }
            }
            catch (ArgumentException err) {

                return StatusCode((int)HttpStatusCode.InternalServerError, err.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] User user) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }
            try {
                var result = await _userService.Put(user);
                if (result != null) {
                    return Ok (result);
                }
                else {
                    return BadRequest();
                }
            }
            catch (ArgumentException err) {
                return StatusCode((int)HttpStatusCode.InternalServerError, err.Message);
            }
        }

        [HttpDelete ("{id}")]
        public async Task<ActionResult> Delete(Guid id) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            try {
                return Ok(await _userService.Delete(id));
            }
            catch (ArgumentException err) {

                return StatusCode((int)HttpStatusCode.InternalServerError, err.Message);
            }
        }
    }
}
