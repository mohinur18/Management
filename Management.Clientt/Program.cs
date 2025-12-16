
using Management.Application;

namespace Management.Clientt
{
    internal class Program
    {
        private const string PASSWORD = "12345";

        static StudentService studentService = new StudentService();

        static void Main(string[] args)
        {
            Console.WriteLine("Salom!!!");

            int count = 0;
            do
            {
                Console.WriteLine("Parol kiring");

                string password = Console.ReadLine();
                if (password == PASSWORD)
                {
                    ShowStudentMenu();
                }
            }
            while (count++ < 3);

        }

        public static void ShowStudentMenu()
        {
            Console.WriteLine("Menulardan birini tanlang:\n" +
                "1.Student qo'shish\n" +
                "2.studentlarni ko'rish\n" +
                "3.Qabul soni");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    AddStudent();
                    break;


            }

        }
        private static void AddStudent()
        {
            Console.Write("Ismingizni kiring:");
            string fristName = Console.ReadLine();

            Console.Write("Familyangini kiring:");
            string lastName = Console.ReadLine();

            studentService.AddStudent(fristName, lastName);
            Console.WriteLine("Zo'r, kiritildi!");
        }
    }
}
