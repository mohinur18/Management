using Management.Domain.Models;
using Management.Infrastructure.Data;
using System;

namespace Management.Application
{
    public class StudentService
    {
        public DbContext DbContext { get; set; }
        public StudentService()
        {
            this .DbContext = new DbContext();
        }
        public void AddStudent(string firstName, string lastName)
        {
            if (DbContext.StudentCount >= DbContext.Students.Length)
                return;

            Student newStudent = new Student
            {
                Id = new Random().Next(1, 1000).ToString(),
                FirstName = firstName,
                LastName = lastName
            };

            this.DbContext.Students[DbContext.StudentCount] = newStudent;
            DbContext.StudentCount++;
        }

        public Student[] GetStudents()
        {
            return DbContext.Students;
        }

        public int GetAvailableCapacity()
        {
            return DbContext.Students.Length - DbContext.StudentCount;
        }
    }
}
