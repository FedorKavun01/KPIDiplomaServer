using System.Collections.Generic;
using System.Threading.Tasks;
using KPIsnik.Core.Services.MarkServices;
using KPIsnik.Infrastructure.DTO;
using Microsoft.AspNetCore.Mvc;

namespace KPIsnik.Infrastructure.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MarkController
    {
        private readonly IMarkService _markService;

        public MarkController(IMarkService markService)
        {
            _markService = markService;
        }

        [HttpGet("GetMarks")]
        public async Task<List<MarkDTO>> GetMarks(string studentId) => _markService.GetMarks(studentId);
    }
}