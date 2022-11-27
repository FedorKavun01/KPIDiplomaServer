using System.Collections.Generic;
using KPIsnik.Infrastructure.DTO;

namespace KPIsnik.Core.Services.MarkServices
{
    public interface IMarkService
    {
        public List<MarkDTO> GetMarks(string studentId);
    }
}