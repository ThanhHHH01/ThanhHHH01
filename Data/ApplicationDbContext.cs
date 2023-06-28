using BaiThucHanh2002.Models;
using Microsoft.EntityFrameworkCore;

namespace BaiThucHanh2002.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Faculty> Faculty { get; set; } = default!;
    }
}