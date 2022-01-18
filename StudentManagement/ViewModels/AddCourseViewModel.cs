
   
    

using StudentManagement.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentManagement.ViewModels
{
    public class AddCourseViewModel
    {
        [Required(ErrorMessage = "CourseId is required.")]
        [StringLength(5, MinimumLength = 3, ErrorMessage = "CourseId must be between 3 and 5 character.")]

        public string CourseId { get; set; }

        
        public string CourseTitle { get; set; }
        [Required(ErrorMessage = "CourseTitle is required.")]

        
        public string Description { get; set; }



        
        public AddCourseViewModel() { }



    }
}
