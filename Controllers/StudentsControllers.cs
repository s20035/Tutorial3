using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APBDTUT3.DAL;
using APBDTUT3.Models;

namespace APBDTUT3.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IDbServices _dbServices;

        public StudentsController(IDbServices dbServices) {
            _dbServices = dbServices;
        }
        [HttpGet]
        public IActionResult GetStudent(String orderby) {
            return Ok(_dbServices.GetStudents());
        }

        [HttpGet("{id}")]
        public IActionResult GetStudent(int id) {
            if (id == 1)
            {
                return Ok("Simphiwe");
            }
            else if (id == 2)
            {
                return Ok("Vuyo");
            }
            else if (id == 3)
            {
                return Ok("Ntokozo");
            }
            else {
                return NotFound("No student found here");
            }
        }

        [HttpPost]

        public IActionResult CreateStudent(Student student) {

            student.IndexNumber = $"s{new Random().Next(1, 20000)}";
            return Ok(student);
        }

        [HttpPut("{id}")]

        public IActionResult UpdateStudent(int id) {
            return Ok("Update Complete");
            
        }

        [HttpDelete("{id}")]

        public IActionResult DeleteStudent(int id) {
            return Ok("Delete Complete");
        }

    }
}