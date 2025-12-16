using Management.Application;

namespace Management.Clientt
{
    internal class Program
    {
       static void Main(string[] args)
        {
            var studentService = new StudentService();
            studentService.AddStudent("Mohinur", "Muhammadjonova");
        }
    }
}
