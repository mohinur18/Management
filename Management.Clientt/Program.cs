
using Management.Application;
using Management.Domain.Models;

namespace Management.Clientt
{
    internal class Program
    {
        private const string PASSWORD = "12345";

        static StudentService studentService = new StudentService();

        static void Main(string[] args)
        {
            Console.WriteLine("Salom!!!");

            bool isPasswordCorrect = false;
            int count = 0;
            while(count < 3 && !isPasswordCorrect)
            {
                Console.WriteLine("Parolni kiriting: ");
                string password = Console.ReadLine();
                if (password == PASSWORD)
                {
                    isPasswordCorrect = true;
                }
                else
                {
                    count++;
                    if(count < 3)
                    {
                        Console.WriteLine($"Noto'g'ri parol. Qolgan urinishlar soni: {3 - count}");
                    }
                    else
                    {
                        Console.WriteLine("Urinishlar soni tugadi. The end...");
                        return;
                    }
                }
            }
            if(isPasswordCorrect)
            {
                ShowStudentMenu();
            }
        }

        public static void ShowStudentMenu()
        {
            while (true)
            {
                Console.WriteLine("Menulardan birini tanlang:\n" +
                    "1.Student qo'shish\n" +
                    "2.studentlarni ko'rish\n" +
                    "3.Qabul soni\n" +
                    "4. Chiqish");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        PrintAllStudent();
                        break;
                    case 3:
                        PrintStudentCapacity();
                        break;
                    case 4:
                        Console.WriteLine("Chiqilmoqda... ");
                        return;
                    default:
                        Console.WriteLine("Error!!!");
                        break;
                }
            }

        }
        private static void AddStudent()
        {
            int boshjoy = studentService.GetAvailableCapacity();
            if(boshjoy<=0)
            {
                Console.WriteLine("Afsuski, qabulda bo'sh joy qolmagan!");
                return;
            }
            Console.Write("Ismingizni kiring:");
            string fristName = Console.ReadLine();

            Console.Write("Familyangini kiring:");
            string lastName = Console.ReadLine();

            studentService.AddStudent(fristName, lastName);
            Console.WriteLine("Zo'r, kiritildi!");
        }

        private static void PrintAllStudent()
        {
            Student[] students = studentService.GetStudents();
            foreach (Student student in students)
            {
                if (student == null)
                {
                    continue;
                }
                Console.WriteLine($"Student Id: {student.Id} Name: {student.FirstName} {student.LastName}");
            }
        }

        private static void PrintStudentCapacity()
        {
            Console.WriteLine($"Bizda {studentService.GetAvailableCapacity()} qabul bor.");
        }
    }
}
