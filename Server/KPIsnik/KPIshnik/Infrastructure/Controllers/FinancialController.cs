using System.Threading.Tasks;
using KPIsnik.Core.Services.FinancialServices;
using KPIsnik.Infrastructure.DTO;
using Microsoft.AspNetCore.Mvc;

namespace KPIsnik.Infrastructure.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FinancialController
    {
        private readonly IFinancialService _financialService;

        public FinancialController(IFinancialService financialService)
        {
            _financialService = financialService;
        }
        
        [HttpGet("GetFinancialData")]
        public async Task<FinancialDataDTO> GetFinancialData(string studentId) => _financialService.GetFinancialData(studentId);
    }
}