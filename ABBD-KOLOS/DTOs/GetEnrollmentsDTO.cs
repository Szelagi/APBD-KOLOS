using ABBD_KOLOS.Models;

namespace ABBD_KOLOS.DTOs;

public class GetEnrollmentDTO
{
    public GetEnrollmentStudentDTO Student { get; set; } = null!;
    public GetEnrollmentCourseDTO Course { get; set; } = null!;
    public string EnrollmentDate { get; set; } = null!;
}

public class GetEnrollmentStudentDTO
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string? Email { get; set; }
}

public class GetEnrollmentCourseDTO
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Teacher { get; set; } = null!;
}