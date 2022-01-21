using System.ComponentModel.DataAnnotations;

namespace StudentManagement.ViewModels
{
    public class AddStudentViewModel
    {
        [Required]
        public string StudentName { get; set; }
        [Required]
        public string Address { get; set; }
    }
}
