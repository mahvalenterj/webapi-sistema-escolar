using SchoolSystem.Api.Domain.Entities;
using SchoolSystem.Api.Domain.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace SchoolSystem.Api.Domain.Models.Requests.Student
{
    public class CreateStudentRequest : StudentBaseModel
    {
        [Required(ErrorMessage = "O campo 'Name' é obrigatório.")]
        [StringLength(50, ErrorMessage = "O campo 'Name' deve ter no máximo 50 caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo 'Address' é obrigatório.")]
        [StringLength(255, ErrorMessage = "O campo 'Address' deve ter no máximo 255 caracteres.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "O campo 'Phone' é obrigatório.")]
        [StringLength(15, ErrorMessage = "O campo 'Phone' deve ter no máximo 15 caracteres.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "O campo 'PaymentOnDay' é obrigatório.")]
        public PaymentStatus PaymentOnDay { get; set; }
    }
}
