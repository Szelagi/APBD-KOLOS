using ABBD_KOLOS.Models;
using Microsoft.EntityFrameworkCore;

namespace ABBD_KOLOS.Data;

public class MyDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }
    public DbSet<Course> Courses { get; set; }
    
    public MyDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    
        var students = new List<Student>
        {
            new Student { IdStudent = 1, FirstName = "James", LastName = "Bond" },
        };
    
        var courses = new List<Course>
        {
            new Course { IdCourse = 1, Title = "C# 8", Credits = "example", Teacher = "Random Person" },
        };
    
        var enrollments = new List<Enrollment>
        {
            new Enrollment
            {
                StudentId = 1,
                CourseId = 1,
                EnrollmentDate = new DateTimeOffset(2025, 5, 28, 14, 30, 0, TimeSpan.Zero),
            }
        };
        
        modelBuilder.Entity<Student>().HasData(students);
        modelBuilder.Entity<Course>().HasData(courses);
        modelBuilder.Entity<Enrollment>().HasData(enrollments);
    }
    
}