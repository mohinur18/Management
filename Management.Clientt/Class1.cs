using Management.Application;
using Management.Domain.Models;

namespace Management.Clientt
{
    internal class Program
    {
       static void Main(string[] args)
        {
            var studentService = new StudentService();
            studentService.AddStudent("Mohinur", "Muhammadjonova");
            Student[] students = studentService.GetStudents();
            foreach(Student student in students)
            {
                if(student == null)
                {
                    break;
                }
                Console.WriteLine($"Student Id: {student.Id}. Name: {student.FirstName} {student.LastName} ");
            }
        }
    }
}
