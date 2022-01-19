
using StydentManagementSystem1.Models;
using System.Collections.Generic;

namespace StydentManagementSystem1.Data
{
    public class CourseData
    {
        static private Dictionary<int, Course> Course = new Dictionary<int, Course>();

        // GetAll
        public static IEnumerable<Course> GetAll()
        {
            return Course.Values;
        }

        // Add
        public static void Add(Course newCourse)
        {
            Course.Add(newCourse.CourseId, newCourse);
        }

        // Remove
        public static void Remove(int courseId)
        {
            Course.Remove(courseId);
        }

        // GetById
        public static Course GetById(int courseId)
        {
            return Course[courseId];
        }
    }
}
