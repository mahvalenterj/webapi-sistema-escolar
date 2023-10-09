using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.OpenApi.Models;
using System.Reflection;
using SchoolSystem.Api.Domain.Entities;
using SchoolSystem.Api.Domain.Models.Base;
using SchoolSystem.Api.Domain.Models.Requests.Student;
using SchoolSystem.Api.Domain.Models.Responses;
using SchoolSystem.Api.Domain.Models.Responses.Student;
using System.Net.Mime;
using Microsoft.Extensions.Logging;

namespace SchoolSystem.Api.Controllers
{
    [ApiController]
    [Route("api/alunos")]
    [Consumes(MediaTypeNames.Application.Json)]
    public class StudentsController : ControllerBase
    {

        /// <summary>
        /// Retorna todos os Clientes cadastrados.
        /// </summary>
        /// <response code="200">Retorna uma colecao de todos os Clientes. Retorna colecao vazia caso não tenha clientes cadastrados.</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Produces(MediaTypeNames.Application.Json)]
        public IActionResult Get()
        {
            try
            {
                var students = new List<StudentBaseModel>();

                // Simule a obtenção dos alunos de alguma fonte, como uma lista em memória
                var studentsFromSource = new List<StudentBaseModel>
                {
                    new StudentBaseModel { StudentName = "João", StudentAddress = "Rua A, 123", Phone = "123-456-7890", PaymentOnDay = StudentBaseModel.PaymentStatus.OnDay },
                    new StudentBaseModel { StudentName = "Maria", StudentAddress = "Rua B, 456", Phone = "987-654-3210", PaymentOnDay = StudentBaseModel.PaymentStatus.Late },
                    new StudentBaseModel { StudentName = "Carlos", StudentAddress = "Rua C, 789", Phone = "555-123-4567", PaymentOnDay = StudentBaseModel.PaymentStatus.OnDay },
                    // Adicione mais alunos aqui
                };

                students = studentsFromSource.ToList();

                return Ok(students);
            }
            catch (Exception ex)
            {
                // Lide com exceções aqui
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro interno." + ex.Message);
            }
        }
    }
}