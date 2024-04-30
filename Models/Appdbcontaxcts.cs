using Microsoft.EntityFrameworkCore;

namespace LabPractice.Models
{
    public class Appdbcontaxcts : DbContext
    {
        public Appdbcontaxcts(DbContextOptions<Appdbcontaxcts> options)
             : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }

}
