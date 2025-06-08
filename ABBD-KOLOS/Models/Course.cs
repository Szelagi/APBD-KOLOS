using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ABBD_KOLOS.Models;

[Table("Course")]
public class Course
{
    [Key] public int IdCourse { get; set; }
    [MaxLength(150)] public string Title { get; set; } = null!;
    [MaxLength(300)] public string? Credits { get; set; }
    [MaxLength(150)] public string Teacher { get; set; } = null!;

    public ICollection<Enrollment> Enrollments { get; set; } = [];
}