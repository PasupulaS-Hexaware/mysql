using System.Collections.Generic;
using dotnetmysl.Business.Interfaces;
using dotnetmysl.Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace dotnetmysl.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        IStudentService _StudentService;
        public StudentController(IStudentService StudentService)
        {
            _StudentService = StudentService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Student>> Get()
        {
            return Ok(_StudentService.GetAll());
        }

        [HttpPost]
        public ActionResult<Student> Save(Student Student)
        {
            return Ok(_StudentService.Save(Student));

        }

        [HttpPut]
        public ActionResult<Student> Update( Student Student)
        {
            return Ok(_StudentService.Update(Student));

        }

        [HttpDelete]
        public ActionResult<bool> Delete(int id)
        {
            return Ok(_StudentService.Delete(id));

        }
        [HttpGet("{id:int}")]
        public ActionResult<Student> GetById(int id)
        {
            return Ok(_StudentService.GetById(id));
        }

    }
}
