using Microsoft.EntityFrameworkCore;
using StudentCourseProject;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<StudentCourse> StudentCourses { get; set; }
    public DbSet<TeacherCourse> TeacherCourses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<StudentCourse>()
            .HasKey(sc => new { sc.StudentId, sc.CourseId });

        
        modelBuilder.Entity<TeacherCourse>()
            .HasKey(tc => new { tc.TeacherId, tc.CourseId });

        
        modelBuilder.Entity<Course>()
            .Property(c => c.Price)
            .HasPrecision(18, 2);

        modelBuilder.Entity<Teacher>()
            .Property(t => t.PricePerHour)
            .HasPrecision(18, 2);
    }
}
