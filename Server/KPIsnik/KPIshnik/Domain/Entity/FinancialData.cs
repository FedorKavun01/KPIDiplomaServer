using System;

namespace KPIsnik.Domain.Entity
{
    public class FinancialData
    {
        public Guid id { get; set; }
        public Guid studentid { get; set; }
        public bool iscontract { get; set; }
        public int? debtamount { get; set; }
    }
}