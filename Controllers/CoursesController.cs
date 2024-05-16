using Microsoft.AspNetCore.Mvc;
using IgolfBackend.Data;
using IgolfBackend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;



namespace IgolfBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly GolfContext _context;

        public CoursesController(GolfContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Course>>> GetCourses([FromQuery] string state)
        {
            if (string.IsNullOrEmpty(state))
            {
                return await _context.Courses.ToListAsync();
            }
            else
            {
                return await _context.Courses.Where(c => c.State == state).ToListAsync();
            }
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<Course>> PostCourse(Course course)
        {
            _context.Courses.Add(course);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetCourses), new { id = course.Id }, course);
        }
    }
}
