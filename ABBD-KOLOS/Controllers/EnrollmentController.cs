using ABBD_KOLOS.Services;
using Microsoft.AspNetCore.Mvc;

namespace ABBD_KOLOS.Controllers;

[ApiController]
[Route("enrollment")]
public class EnrollmentController(IDbService service) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetEnrollments()
    {
        var enrollments = await service.GetEnrollments();
        return Ok(enrollments);
    }
}