using Domain.Entites;
using Domain.Interface.Director.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace AlunoApplication.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorsController : ControllerBase {
        private IDirectorService _directorService;

        public DirectorsController(IDirectorService directorService) {
            _directorService = directorService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll() {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }
            try {
                return Ok(await _directorService.GetAll());
            }
            catch (ArgumentException erro) {

                return StatusCode((int) HttpStatusCode.InternalServerError, erro.Message);
            }
        }

        [HttpGet]
        [Route("{id}", Name = "GetDirectorWithId")]
        public async Task<ActionResult> Get(Guid id) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            try {
                return Ok(await _directorService.Get(id));
            }
            catch (ArgumentException erro) {

                return StatusCode((int)HttpStatusCode.InternalServerError, erro.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] DirectorEntite director) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            try {
                var result = await _directorService.Post(director);
                if (result != null) {
                    return Created(new Uri(Url.Link("GetDirectorWithId", new { id = result.Id })), result);
                }
                else {
                    return BadRequest();
                }
            }
            catch (ArgumentException erro) {

                return StatusCode((int)HttpStatusCode.InternalServerError, erro.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] DirectorEntite director) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            try {
                var result = await _directorService.Put(director);
                if (result != null) {
                    return Ok(result);
                }
                else {
                    return BadRequest();
                }

            }
            catch (ArgumentException erro) {

                return StatusCode((int)HttpStatusCode.InternalServerError, erro.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            try {
                return Ok(await _directorService.Delete(id));
            }
            catch (ArgumentException erro) {

                return StatusCode((int)HttpStatusCode.InternalServerError, erro.Message);
            }
        }

    }
}
