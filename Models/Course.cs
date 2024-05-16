using System.ComponentModel.DataAnnotations;

namespace IgolfBackend.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string Location { get; set; }
        public int Holes { get; set; }
        public int Par { get; set; }
        public string Designer { get; set; }
        public double Rating { get; set; }
    }
}
