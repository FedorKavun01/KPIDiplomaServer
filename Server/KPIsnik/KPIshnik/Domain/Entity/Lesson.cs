using System;

namespace KPIsnik.Domain.Entity
{
    public class Lesson
    {
        public Guid ID { get; set; }
        public Guid GroupID { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Teacher { get; set; }
        public string? Link { get; set; }
        public string Theme { get; set; }
        public string? Homework { get; set; }
    }
}