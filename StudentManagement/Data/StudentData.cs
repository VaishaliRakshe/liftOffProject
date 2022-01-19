using StydentManagementSystem1.Models;
using System.Collections.Generic;

namespace StydentManagementSystem1.Data
{
    public class StudentData
    {
        static private Dictionary<int, Student> Student = new Dictionary<int, Student>();


        // GetAll
        public static IEnumerable<Student> GetAll()
        {
            return Student.Values;
        }

        // Add
        public static void Add(Student newStudent)
        {
            Student.Add(newStudent.StudentId, newStudent);
        }

        // Remove
        public static void Remove(int studentId)
        {
            Student.Remove(studentId);
        }

        // GetById
        public static Student GetById(int studentId)
        {
            return Student[studentId];
        }
    }
}
