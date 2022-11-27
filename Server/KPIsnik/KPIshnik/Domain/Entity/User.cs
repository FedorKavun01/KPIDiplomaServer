using System;

namespace KPIsnik.Domain.Entity
{
    public class User
    {
        public Guid id { get; set; }
        public Guid groupid { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string login { get; set; }
        public string password { get; set; }
    }
}