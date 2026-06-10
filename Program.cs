namespace MaoriQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName;
            char difficultyChoice, choiceConfirmation;

            // Questions and the Answers for it
            String[] easyQuestions = {
                $"Q1) What is the correct Maori greeting? \n A) Kia Ore B) Kia Ora C) Bula Vinaka D) Kamusta", "Q2) What does 'Whanau' mean in english? \n A) Family B) Food C) Respect D) Name", "Q3) What does 'Kai' mean in english? \n A) Ocean B) Person C) Food D) House" };
            char[] easyAnswers = { 'B', 'A', 'C' };
            String[] mediumQuestions = { };
            char[] mediumAnswers = { };

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("What is your first name?");

            firstName = Console.ReadLine();
            // This checks the length and if its shorter than 3 characters or longer than 15 characters then it displays a invalid message and repeats the question.
            while ((firstName.Length < 3) || (firstName.Length > 10) || (!firstName.All(char.IsLetter)))
            {
                Console.WriteLine("Invalid, your name must be between 3 and 10 characters long!");
                Console.WriteLine("What is your first name?");
                firstName = Console.ReadLine();
            }

            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();
            // This checks the length and if its shorter than 3 characters or longer than 15 characters then it displays a invalid message and repeats the question.
            while ((lastName.Length < 3) || (lastName.Length > 10) || (!lastName.All(char.IsLetter)))
            {
                Console.WriteLine("Invalid, your name must be between 3 and 10 characters long!");
                Console.WriteLine("What is your last name?");
                lastName = Console.ReadLine();
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
            switch (difficultyChoice)
            {
                case 'E':
                    DisplayQuestions(easyQuestions, easyAnswers);
                    break;
                case 'M':
                    DisplayQuestions(mediumQuestions, mediumAnswers);
                    break;
            }
        }
        // This is a method that displays the difficulty choice 
        static char DisplayDifficultyChoice()
        {
            char difficultyChoice;

            Console.WriteLine("([E] for Easy, [M] for Medium, [H] for Hard) Which difficulty would you like to take the quiz in? ");
            difficultyChoice = Console.ReadLine().ToUpper()[0];
            return difficultyChoice;
        }

        static int DisplayQuestions(String[] quizQuestions, char[] quizAnswers)
        {
            int totalScore = 0;
            char answer;

            for (int i = 0; i < quizQuestions.Length; i++)
            {
                Console.WriteLine(quizQuestions[i]);
                answer = Console.ReadLine().ToUpper()[0];
                if (answer == quizAnswers[i])
                {
                    totalScore++;
                    Console.WriteLine("Correct Answer!");
                }
                else
                {
                    Console.WriteLine($"Incorrect answer! The correct answer was {quizAnswers[i]}");
                }
            }
            Console.WriteLine($"Your total score is: {totalScore} out of 5");
            return totalScore;
        }
    }
}
