using SchoolSystem.Api.Domain.Models.Base;

namespace SchoolSystem.Api.Domain.Models.Responses.Student
{
    public class GetStudentResponse
    {
        public IEnumerable<StudentBaseModel> Students { get; set; }
    }
}
