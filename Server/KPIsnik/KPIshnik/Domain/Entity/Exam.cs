using System;

namespace KPIsnik.Domain.Entity
{
    public class Exam
    {
        public Guid id { get; set; }
        public Guid groupid { get; set; }
        public string name { get; set; }
        public DateTime starttime { get; set; }
        public DateTime endtime { get; set; }
        public string teacher { get; set; }
        public string? link { get; set; }
    }
}