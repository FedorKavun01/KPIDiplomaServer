using System;
using System.Collections.Generic;

namespace KPIsnik.Infrastructure.DTO
{
    public class ScheduleDayDTO
    {
        public Guid ID { get; set; }
        public DateTime Date { get; set; }
        public List<LessonDTO> Lessons { get; set; }
    }
}