using Microsoft.AspNetCore.Mvc;
using IgolfBackend.Data;
using IgolfBackend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace IgolfBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoritesController : ControllerBase
    {
        private readonly GolfContext _context;

        public FavoritesController(GolfContext context)
        {
            _context = context;
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<IEnumerable<Course>>> GetFavoriteCourses(int userId)
        {
            var user = await _context.Users.Include(u => u.FavoriteCourses).FirstOrDefaultAsync(u => u.Id == userId);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user.FavoriteCourses);
        }

        [Authorize]
        [HttpPost("{userId}/{courseId}")]
        public async Task<IActionResult> AddFavoriteCourse(int userId, int courseId)
        {
            var user = await _context.Users.Include(u => u.FavoriteCourses).FirstOrDefaultAsync(u => u.Id == userId);
            var course = await _context.Courses.FindAsync(courseId);

            if (user == null || course == null)
            {
                return NotFound();
            }

            user.FavoriteCourses.Add(course);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [Authorize]
        [HttpDelete("{userId}/{courseId}")]
        public async Task<IActionResult> RemoveFavoriteCourse(int userId, int courseId)
        {
            var user = await _context.Users.Include(u => u.FavoriteCourses).FirstOrDefaultAsync(u => u.Id == userId);
            var course = await _context.Courses.FindAsync(courseId);

            if (user == null || course == null)
            {
                return NotFound();
            }

            user.FavoriteCourses.Remove(course);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}