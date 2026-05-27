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
            if ((firstName.Length < 3) || (firstName.Length > 15))
            {
                while ((firstName.Length < 3) || (firstName.Length > 15))
                {
                    Console.WriteLine("Invalid, your name must be between 3 and 15 characters long!");
                    Console.WriteLine("What is your first name?");
                    firstName = Console.ReadLine();
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
