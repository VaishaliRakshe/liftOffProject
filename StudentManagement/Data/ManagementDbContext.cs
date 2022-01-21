using Microsoft.EntityFrameworkCore;
using StudentManagement.Models;
using StydentManagementSystem1.Models;

namespace StudentManagement.Data
{
    public class ManagementDbContext :DbContext
    {
        public DbSet<Course> Course { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Teacher> Teacher { get; set; }


        public ManagementDbContext(DbContextOptions<ManagementDbContext> options)
              : base(options)
        {
        }
    }
}
