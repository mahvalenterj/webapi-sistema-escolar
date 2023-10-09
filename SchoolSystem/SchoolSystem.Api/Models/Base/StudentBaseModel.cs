using SchoolSystem.Api.Domain.Entities;

namespace SchoolSystem.Api.Domain.Models.Base
{
    public class StudentBaseModel
    {
        public string? StudentName { get; set; } // Mudança: Nome deve ser não nulo
        public string? StudentAddress { get; set; }
        public string? Phone { get; set; } // Mudança: Renomear para Telefone
        public PaymentStatus PaymentOnDay { get; set; } // Mudança: Usar um enum para PagamentoEmDia

        public enum PaymentStatus
        {
            OnDay,
            Late
        }
    }
}

