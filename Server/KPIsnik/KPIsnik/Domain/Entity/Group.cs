using System;

namespace KPIsnik.Domain.Entity
{
    public class Group
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string CuratorName { get; set; }
    }
}