using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Workforce.Models.SchoolViewModels; // Це для моделей Student, Course тощо

namespace Workforce.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; } = default!;
        public DbSet<Course> Courses { get; set; } = default!;
        public DbSet<Enrollments> Enrollments { get; set; } = default!;
    }
}
