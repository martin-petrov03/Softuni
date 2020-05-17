namespace StudentSystem.Data
{
    using Microsoft.EntityFrameworkCore;
    using StudentSystem.Data.Models;

    public class StudentSystemContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DbSet<StudentCourse> StudentCourses { get; set; }

        public DbSet<Resource> Resources { get; set; }

        public DbSet<Homework> Homeworks { get; set; }

        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
            {
                builder
                    .UseSqlServer("Server=.;Database=MyCarDB; Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Student>(student =>
            {
                student
                    .Property(s => s.Name)
                    .IsUnicode(true);

                student
                    .Property(s => s.PhoneNumber)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            builder.Entity<Course>(course =>
            {
                course
                    .Property(c => c.Name)
                    .IsUnicode(true);

                course
                    .Property(c => c.Description)
                    .IsUnicode(true);
            });

            builder.Entity<Resource>(resource =>
            {
                resource
                    .Property(r => r.Name)
                    .IsUnicode(true);
            });
        }
    }
}
