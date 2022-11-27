using System;

namespace KPIsnik.Infrastructure.DTO
{
    public class FinancialDataDTO
    {
        public Guid ID { get; set; }
        public Guid StudentId { get; set; }
        public bool IsContract { get; set; }
        public int? DebtAmount { get; set; }
    }
}