namespace MaoriQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName;

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();
            if ((firstName.Length < 2) || (firstName.Length > 16))
            {
                while ((firstName.Length < 2) || (firstName.Length > 16))
                {
                    Console.WriteLine("Invalid, your name must be between 2 and 16 characters long!");
                }
            }
            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine($"Hello {firstName} {lastName}, welcome to the MaoriQuiz!");
            Console.WriteLine("--------------------------------------------------------");
        }
    }
}
