using KPIsnik.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace KPIsnik.Infrastructure
{
    public class KPIshnikDBContext : DbContext
    {
        public KPIshnikDBContext(DbContextOptions options) : base(options)
        {
        }
        
        public DbSet<Group> Groups { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<FinancialData> FinancialData { get; set; }
    }
}