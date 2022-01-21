
    
using System;

namespace StydentManagementSystem1.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        private static int nextId = 1;

        public Course()
        {
            CourseId = nextId;
            nextId++;
        }
        public Course(string name, string description)

        {
            CourseName = name;
            Description = description;

        }

        public override string ToString()
        {
            return CourseName;
        }

        public override bool Equals(object obj)
        {
            return obj is Course course &&
                   CourseId == course.CourseId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(CourseId);
        }
    }
}
