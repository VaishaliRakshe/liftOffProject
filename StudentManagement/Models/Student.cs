using System;

namespace StydentManagementSystem1.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Address { get; set; }
        private static int nextId = 1;

        public Student()
        {
            StudentId = nextId;
            nextId++;
        }
        public Student(string studentName, string address)
        {
            StudentName = studentName;
            Address = address;
        }

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   StudentId == student.StudentId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(StudentId);
        }
    }
}
