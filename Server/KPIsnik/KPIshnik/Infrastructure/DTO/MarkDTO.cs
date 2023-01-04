using System;

namespace KPIsnik.Infrastructure.DTO
{
    public class MarkDTO
    {
        public Guid ID { get; set; }
        public Guid StudentId { get; set; }
        public string Name { get; set; }
        public int Mark { get; set; }
        public string Teacher { get; set; }
    }
}