using SchoolSystem.Api.Domain.Models.Requests.Student;

namespace SchoolSystem.Api.Domain.Models.Requests.Student
{
    public class UpdateStudentRequest : CreateStudentRequest
    {
        public int Id { get; set; }
    }
}
