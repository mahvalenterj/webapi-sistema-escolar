using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.OpenApi.Models;
using System.Reflection;

namespace SchoolSystem.Api.Controllers
{
    [ApiController]
    [Route("api/alunos")]
    public class StudentsController : ControllerBase
    {
              

        [HttpGet(Name = "GetStudents")]
        public ActionResult GetStudents() {

            return new OkObjectResult("Afonso, Lana, Roberto");
        
        }
        
    }
}