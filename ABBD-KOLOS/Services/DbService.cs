using ABBD_KOLOS.Data;
using ABBD_KOLOS.DTOs;
using ABBD_KOLOS.Models;
using Microsoft.EntityFrameworkCore;

namespace ABBD_KOLOS.Services;

public interface IDbService
{
    public Task<ICollection<GetEnrollmentDTO>> GetEnrollments();
}

public class DbService(MyDbContext data) : IDbService
{
    public async Task<ICollection<GetEnrollmentDTO>> GetEnrollments()
    {
        var enrollments = await data.Enrollments
            .Include(p => p.Student)
            .Include(p => p.Course)
            .ToListAsync();

        return enrollments.Select(e => new GetEnrollmentDTO
        {
            Student = new GetEnrollmentStudentDTO
            {
                Id = e.Student.IdStudent,
                FirstName = e.Student.FirstName,
                LastName = e.Student.LastName,
            },
            Course = new GetEnrollmentCourseDTO
            {
                Id = e.Course.IdCourse,
                Title = e.Course.Title,
                Teacher = e.Course.Teacher
            },
            EnrollmentDate = e.EnrollmentDate.ToString("yyyy-MM-ddTHH:mm:ss"),
        }).ToList();
        
    }
}