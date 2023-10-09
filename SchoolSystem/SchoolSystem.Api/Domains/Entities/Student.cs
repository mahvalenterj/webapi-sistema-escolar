namespace SchoolSystem.Api.Domain.Entities
{
    public class Student
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Address { get; set; }

        public string? Phone { get; set; }
        public PaymentStatus PaymentOnDay { get; set; } // Mudança: Usar um enum para PagamentoEmDia


        public enum PaymentStatus
        {
            OnDay,
            Late
        }
    }
}
