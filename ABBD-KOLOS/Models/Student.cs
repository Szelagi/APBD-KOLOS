using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ABBD_KOLOS.Models;

[Table("Student")]
public class Student
{
    [Key] public int IdStudent { get; set; }
    [MaxLength(50)] public string FirstName { get; set; } = null!;
    [MaxLength(100)] public string LastName { get; set; } = null!;
    [MaxLength(150)] public string? Email { get; set; }
    
    public ICollection<Enrollment> Enrollments { get; set; } = [];
}