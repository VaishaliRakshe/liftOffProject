using System.ComponentModel.DataAnnotations;

namespace StudentManagement.ViewModels
{
    public class AddCourseViewModel
    {
        [Required]
        public string CourseName { get; set; }
        [Required]
        public string Description { get; set; }
    }
   
}
