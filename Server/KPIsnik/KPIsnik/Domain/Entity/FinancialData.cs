using System;

namespace KPIsnik.Domain.Entity
{
    public class FinancialData
    {
        public Guid ID { get; set; }
        public Guid StudentID { get; set; }
        public bool IsContract { get; set; }
        public int? DebtAmount { get; set; }
    }
}