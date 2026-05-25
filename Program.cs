namespace MaoriQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName;

            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();
            Console.WriteLine("What is your first name?");
            lastName = Console.ReadLine();

            Console.WriteLine($"Hello {firstName} {lastName}, welcome to the MaoriQuiz!");
        }
    }
}
