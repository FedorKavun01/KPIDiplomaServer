using KPIsnik.Infrastructure.DTO;

namespace KPIsnik.Core.Services.FinancialServices
{
    public interface IFinancialService
    {
        public FinancialDataDTO GetFinancialData(string studentId);
    }
}