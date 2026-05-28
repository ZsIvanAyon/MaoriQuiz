namespace MaoriQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName;
            char difficultyChoice, choiceConfirmation;

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
            // Displays the difficulty choosing and returns it back if they say no to the confirmation part.
            do
            {
                difficultyChoice = DisplayDifficultyChoice();
                switch (difficultyChoice)
                {
                    case 'E':
                        {
                            Console.WriteLine("Are you sure you want to pick Easy?");
                        }
                        break;
                    case 'M':
                        {
                            Console.WriteLine("Are you sure you want to pick Medium?");
                        }
                        break;
                    case 'H':
                        {
                            Console.WriteLine("Are you sure you want to pick Hard?");
                        }
                        break;
                    default:

                        break;
                }
                Console.WriteLine("[Y] for Yes [N] for No");
                choiceConfirmation = Console.ReadLine().ToUpper()[0];
            } while (choiceConfirmation == 'N');
        static char DisplayDifficultyChoice()
        {
            char difficultyChoice;

            Console.WriteLine("([E] for Easy, [M] for Medium, [H] for Hard) Which difficulty would you like to take the quiz in? ");
            difficultyChoice = Console.ReadLine().ToUpper()[0];
            return difficultyChoice;
        }
    }
}
