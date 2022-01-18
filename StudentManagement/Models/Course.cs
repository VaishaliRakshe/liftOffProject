
    
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace StudentManagement.Models
{
    public class Course
    {
        [Key]
        
        public string CourseID { get; set; }
        public string CourseTitle { get; set; }
        public string Description { get; set; }
        public Course(string courseId, string courseTitle, string description)
        {
            CourseID = courseId;
            CourseTitle = courseTitle;
            Description = description;


        }

    }
}