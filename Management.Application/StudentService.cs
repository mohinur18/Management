using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Management.Domain.Models;
using Management.Infrastructure.Data;

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
            Student newStudent = new Student
            {
                Id = new Random().Next(1, 1000).ToString(),
                FirstName = firstName,
                LastName = lastName
            };

            this.DbContext.Students[0] = newStudent;
        }

    }
}
