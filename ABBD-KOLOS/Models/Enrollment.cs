using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ABBD_KOLOS.Models;

[Table("Enrollment")]
[PrimaryKey(nameof(StudentId), nameof(CourseId))]
public class Enrollment
{
    public int StudentId { get; set; }
    
    [ForeignKey(nameof(StudentId))]
    public Student Student { get; set; } = null!;
    
    public int CourseId { get; set; }
    [ForeignKey(nameof(CourseId))]
    public Course Course { get; set; } = null!;
    
    public DateTimeOffset EnrollmentDate { get; set; }
}