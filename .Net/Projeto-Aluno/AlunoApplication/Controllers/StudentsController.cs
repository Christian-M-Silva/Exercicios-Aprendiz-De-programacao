using Domain.Entites;
using Domain.Interface.Student.IService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace AlunoApplication.Controllers {
    //https:localhost:44306/api/students
    [Route("api/[controller]")]
    [ApiController]

    public class StudentsController : ControllerBase {

        private IStudentService _studentService;

        public StudentsController(IStudentService studentSevice) {
            _studentService = studentSevice;
        }

        //https:localhost:44306/api/students
        [HttpGet]
        public async Task<ActionResult> Getall() { //ActionResult devolve um status code http
            if (!ModelState.IsValid) {
                return BadRequest(ModelState); //400
            }

            try {
                return Ok(await _studentService.GetAll());//200

            }
            catch (ArgumentException erro) {

                return StatusCode((int)HttpStatusCode.InternalServerError, erro.Message);//500
            }

        }

        //https:localhost:44306/api/students/{id}
        [HttpGet]
        [Route("{id}", Name = "GetWithId")]
        public async Task<ActionResult> Get(Guid id) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            try {
                return Ok(await _studentService.Get(id));
            }
            catch (ArgumentException erro) {

                return StatusCode((int)HttpStatusCode.InternalServerError, erro.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] StudentEntite student) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            try {
                var result = await _studentService.Post(student);
                if (result != null) {
                    return Created(new Uri(Url.Link("GetWithId", new {id =result.Id})),result); //Aqui
                    //estou criando dentro dessa rota que tem o nome de GetWithId uma nova rota, faço
                    //isso com o new id que está recebendo o id criado durante o post sendo que é o
                    //que ele retorna do post e ai dentro dessa rota eu passo o resul que é o Json
                    //ou objeto com o meu post que eu fiz, ai no header ele me retorna a rota para
                    //acessar esse meu Json que criei pelo Id. Created é 201
                }
                else {
                    return BadRequest();
                }
            }
            catch (ArgumentException erro) {

                return StatusCode((int) HttpStatusCode.InternalServerError, erro.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] StudentEntite student) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            try {
                var result = await _studentService.Put(student);
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

        [HttpDelete ("{id}")]
        public async Task<ActionResult> Delete(Guid id) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            try {
                return Ok(await _studentService.Delete(id));
            }
            catch (ArgumentException erro) {

                return StatusCode((int)HttpStatusCode.InternalServerError, erro.Message);
            }
        }

    }
}
