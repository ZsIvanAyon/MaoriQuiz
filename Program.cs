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
            // This checks the length and if its shorter than 3 characters or longer than 15 characters then it displays a invalid message and repeats the question.
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
            // This checks the length and if its shorter than 3 characters or longer than 15 characters then it displays a invalid message and repeats the question.
            if ((firstName.Length < 3) || (firstName.Length > 15))
            {
                while ((firstName.Length < 3) || (firstName.Length > 15))
                {
                    Console.WriteLine("Invalid, your name must be between 3 and 15 characters long!");
                    Console.WriteLine("What is your first name?");
                    firstName = Console.ReadLine();
                }
            }
            Console.WriteLine("--------------------------------------------------------");
            // Displays the welcome message which shows their first name and last name.
            Console.WriteLine($"Hello {firstName} {lastName}, welcome to the MaoriQuiz!");
            Console.WriteLine("--------------------------------------------------------");
        }
    }
}
