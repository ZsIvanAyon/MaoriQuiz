namespace MaoriQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName;
            char difficultyChoice, choiceConfirmation, replayChoice;

            // Questions and the Answers for it
            String[] easyQuestions = { "Q1) What is the correct Maori greeting? \n A) Kia Ore B) Kia Ora C) Bula Vinaka D) Kamusta", "Q2) What does 'Whanau' mean in english? \n A) Family B) Food C) Respect D) Name", "Q3) What does 'Kai' mean in english? \n A) Ocean B) Person C) Food D) House", "Q4) What is does 'Aotearoa' mean in english? \n A) North Island B) New Zealand C) South Island D) Country", "Q5) What does 'Love' mean in Maori? \n A) Matariki B) Moana C) Marae D) Aroha" };
            char[] easyAnswers = { 'B', 'A', 'C', 'B', 'D' };
            String[] mediumQuestions = { "Q1) What does 'Iwi' mean in english? \n A) Tribe B) Children C) Ocean D) Forest", "Q2) What is a Waka? \n A) Canoe B) Money C) Belonging D) Tree", "Q3) What is a Haka? \n A) Traditional Song B) Traditional Weapon C) Cultural Jade D) Traditional Dance" };
            char[] mediumAnswers = { 'A', 'A', 'D' };

            Console.WriteLine("--------------------------------------------------------");
            firstName = DisplayAskName("first");
            lastName = DisplayAskName("last");
            Console.WriteLine("--------------------------------------------------------");
            // Displays the welcome message which shows their first name and last name.
            Console.WriteLine($"Hello {firstName} {lastName}, welcome to the MaoriQuiz!");
            Console.WriteLine("--------------------------------------------------------");
            // Displays the difficulty choosing and returns it back if they say no to the confirmation part.
            do
            {
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
                        {
                            DisplayQuestions(easyQuestions, easyAnswers);
                        }
                        break;
                    case 'M':
                        {
                            DisplayQuestions(mediumQuestions, mediumAnswers);
                        }
                        break;
                }
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("Congrats on finishing the test! Do you want to play again? ([Y] for Yes [N] for No)");
                replayChoice = Console.ReadLine().ToUpper()[0];
                Console.WriteLine("--------------------------------------------------------");
            } while (replayChoice == 'Y');
            
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
        static string DisplayAskName(String nameType)
        {
            string name;

            Console.WriteLine($"What is your {nameType} name? ");
            name = Console.ReadLine();
            while ((name.Length < 3) || (name.Length > 10) || (!name.All(char.IsLetter)))
            {
                Console.WriteLine("Invalid, your name must be between 3 and 10 characters long!");
                Console.WriteLine("What is your first name?");
                name = Console.ReadLine();
            }
            return name;
        }
    }
}
