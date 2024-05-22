using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IgolfBackend.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public List<Course> FavoriteCourses { get; set; } = new List<Course>();
    }
}