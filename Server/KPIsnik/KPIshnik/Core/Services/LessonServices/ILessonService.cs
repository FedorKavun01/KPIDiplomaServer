using System.Collections.Generic;
using KPIsnik.Infrastructure.DTO;

namespace KPIsnik.Core.Services.LessonServices
{
    public interface ILessonService
    {
        public LessonDTO GetLesson(string id);
        public LessonDTO GetCurrentLesson(string groupId);
        public List<ScheduleDayDTO> GetLessons(string groupId);
    }
}