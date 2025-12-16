using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Management.Domain.Models;
using Management.Infrastructure.Data;

namespace Management.Application
{
    public class StudentService
    {
        private int index = 0;
        public DbContext DbContext { get; set; }
        public StudentService()
        {
            this .DbContext = new DbContext();
        }
        public void AddStudent(string firstName, string lastName)
        {
            if (index >= DbContext.Students.Length)
                return;

            Student newStudent = new Student
            {
                Id = new Random().Next(1, 1000).ToString(),
                FirstName = firstName,
                LastName = lastName
            };

            this.DbContext.Students[index] = newStudent;
            index++;
        }

        public Student[] GetStudents()
        {
            return DbContext.Students;
        }

    }
}
