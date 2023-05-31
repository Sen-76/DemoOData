using Microsoft.EntityFrameworkCore;

namespace DemoOData.Model
{
    public class DemoODataContext : DbContext
    {
        public DemoODataContext(DbContextOptions<DemoODataContext> options) : base(options)
        {   
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Gender> Genders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
