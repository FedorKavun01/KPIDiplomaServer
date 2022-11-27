using System;

namespace KPIsnik.Domain.Entity
{
    public class Mark
    {
        public Guid ID { get; set; }
        public Guid StudentID { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }
        public string Teacher { get; set; }
    }
}