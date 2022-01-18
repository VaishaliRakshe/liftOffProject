
using System;
using StudentManagement.Models;


namespace StudentManagement.Data
{
    public class DbContext : DbContext
    {
        public DbSet<Course> Course { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbContext(DbContextOptions<DbContext> options)
              : base(options)
        {
        }
    }
}