using System.Collections.Generic;
using KPIsnik.Infrastructure.DTO;

namespace KPIsnik.Core.Services.ExamServices
{
    public interface IExamService
    {
        public List<ExamDTO> GetExams(string groupId);
    }
}