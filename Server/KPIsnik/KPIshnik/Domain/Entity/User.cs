using System;

namespace KPIsnik.Domain.Entity
{
    public class User
    {
        public Guid ID { get; set; }
        public Guid GroupID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}