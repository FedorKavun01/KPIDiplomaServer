using System.Collections.Generic;
using System.Threading.Tasks;
using KPIsnik.Core.Services.ExamServices;
using KPIsnik.Infrastructure.DTO;
using Microsoft.AspNetCore.Mvc;

namespace KPIsnik.Infrastructure.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExamController
    {
        private IExamService _examService;

        public ExamController(IExamService examService)
        {
            _examService = examService;
        }

        [HttpGet("GetExams")]
        public async Task<List<ExamDTO>> GetExams(string groupId) => _examService.GetExams(groupId);
    }
}