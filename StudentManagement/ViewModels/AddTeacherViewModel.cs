﻿using System.ComponentModel.DataAnnotations;

namespace StudentManagement.ViewModels
{
    public class AddTeacherViewModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }

    }
}
