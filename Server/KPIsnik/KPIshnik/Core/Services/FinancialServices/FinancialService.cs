using System;
using System.Linq;
using KPIsnik.Infrastructure;
using KPIsnik.Infrastructure.DTO;
using Microsoft.AspNetCore.Http;

namespace KPIsnik.Core.Services.FinancialServices
{
    public class FinancialService : IFinancialService
    {
        private readonly KPIshnikDBContext _context;

        public FinancialService(KPIshnikDBContext context)
        {
            _context = context;
        }

        public FinancialDataDTO GetFinancialData(string studentId)
        {
            var financialData = _context.FinancialData.ToList().Find(financialData => financialData.studentid == Guid.Parse(studentId));

            if (financialData == null)
            {
                throw new BadHttpRequestException("No financial data");
            }

            var financialDataDTO = new FinancialDataDTO
            {
                ID = financialData.id,
                StudentId = financialData.studentid,
                IsContract = financialData.iscontract,
                DebtAmount = financialData.debtamount
            };

            return financialDataDTO;
        }
    }
}