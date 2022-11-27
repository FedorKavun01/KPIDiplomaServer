using System;

namespace KPIsnik.Domain.Entity
{
    public class Mark
    {
        public Guid id { get; set; }
        public Guid studentid { get; set; }
        public string name { get; set; }
        public int mark { get; set; }
        public string teacher { get; set; }
    }
}