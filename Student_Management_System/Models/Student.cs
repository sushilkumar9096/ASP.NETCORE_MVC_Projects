using System.ComponentModel.DataAnnotations;

namespace Student_Management_System.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Course { get; set; } = string.Empty;

        [Required]
        public string Mobile { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;
    }
}
