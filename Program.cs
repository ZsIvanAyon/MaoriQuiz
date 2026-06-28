namespace MaoriQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName;
            char difficultyChoice, choiceConfirmation, replayChoice;

            // Arrays for all the questions and answers such as easy question and answer
            String[] easyQuestions = { "Q1) What is the correct Maori greeting? \n A) Kia Ore B) Kia Ora C) Bula Vinaka D) Kamusta", "Q2) What does 'Whanau' mean in english? \n A) Family B) Food C) Respect D) Name", "Q3) What does 'Kai' mean in english? \n A) Ocean B) Person C) Food D) House", "Q4) What is does 'Aotearoa' mean in english? \n A) North Island B) New Zealand C) South Island D) Country", "Q5) What does 'Love' mean in Maori? \n A) Matariki B) Moana C) Marae D) Aroha" };
            char[] easyAnswers = { 'B', 'A', 'C', 'B', 'D' };
            String[] mediumQuestions = { "Q1) What does 'Iwi' mean in english? \n A) Tribe B) Children C) Ocean D) Forest", "Q2) What is a Waka? \n A) Canoe B) Money C) Belonging D) Tree", "Q3) What is a Haka? \n A) Traditional Song B) Traditional Weapon C) Cultural Jade D) Traditional Dance", "Q4) What is the most liked food in New Zealand? \n A) Sushi B) Pizza C) Pies D) Steak", "Q5) What does 'Ka Pai' mean? \n A) Good one B) Good job C) Nice job D) Nice one" };
            char[] mediumAnswers = { 'A', 'A', 'D', 'C', 'B' };
            String[] hardQuestions = { "Q1) When was the treaty of Waitangi signed? \n A) Feb 6 1840 B) Feb 6 1940 C) Feb 7 1840 D) Feb 7 1940", "Q2) What does the red poppy symbolise? \n A) Love B) War C) Tribe D) Dinner", "Q3) When was Aotearoa discovered? \n A) Between 1250 and 1300 CE, B) Between 1300 and 1450 CE C) 1200 D) 1150", "Q4) How much people are living in NZ in 2026? \n A) 3 million B) Approximately 5.36M C) 4 million D) Approximately 7.23M", "Q5) What number is used to call for emergencies? \n A) 911 B) 711 C) 514 D) 111" };
            char[] hardAnswers = { 'A', 'B', 'A', 'B', 'D' };

            Console.WriteLine("--------------------------------------------------------");
            firstName = DisplayAskName("first");
            lastName = DisplayAskName("last");
            Console.WriteLine("--------------------------------------------------------");
            // Displays the welcome message which shows their first name and last name.
            Console.WriteLine($"Hello {firstName} {lastName}, welcome to the MaoriQuiz!");
            Console.WriteLine("--------------------------------------------------------");
            // Displays the difficulty choosing and returns it back if they say no to the confirmation part
            do
            {
                do
                {
                    difficultyChoice = DisplayDifficultyChoice();
                    while (difficultyChoice != 'E' && difficultyChoice != 'M' && difficultyChoice != 'H')
                    {
                        Console.WriteLine("Invalid character, you must pick between the three difficulty choices!");
                        difficultyChoice = DisplayDifficultyChoice();
                    }
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
                            {
                            }
                            break;
                    }
                    Console.WriteLine("[Y] for Yes [N] for No");
                    choiceConfirmation = Console.ReadLine().ToUpper()[0];
                    while (choiceConfirmation != 'Y' && choiceConfirmation != 'N')
                    {
                        Console.WriteLine("Invalid character, you must pick between Y or N!");
                        Console.WriteLine("[Y] for Yes [N] for No");
                        choiceConfirmation = Console.ReadLine().ToUpper()[0];
                    }
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
                    case 'H':
                        {
                            DisplayQuestions(hardQuestions, hardAnswers);
                        }
                        break;
                }

                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("Congrats on finishing the test! Do you want to play again? ([Y] for Yes [N] for No)");
                replayChoice = Console.ReadLine().ToUpper()[0];
                while (replayChoice != 'Y' && replayChoice != 'N')
                {
                    Console.WriteLine("Invalid character, you must pick between Y or N!");
                    Console.WriteLine("Do you want to play again? ([Y] for Yes [N] for No)");
                    replayChoice = Console.ReadLine().ToUpper()[0];
                }
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
        // This method displays the quesions and how it works is that each time a question is answered the integer i adds up by 1.
        static int DisplayQuestions(String[] quizQuestions, char[] quizAnswers)
        {
            int totalScore = 0;
            char answer;

            for (int i = 0; i < quizQuestions.Length; i++)
            {
                Console.WriteLine(quizQuestions[i]);
                answer = Console.ReadLine().ToUpper()[0];
                while (answer != 'A' && answer != 'B' && answer != 'C' && answer != 'D')
                {
                    Console.WriteLine("Invalid character, you must pick between A, B, C, or D");
                    Console.WriteLine(quizQuestions[i]);
                    answer = Console.ReadLine().ToUpper()[0];
                }
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
        // This method asks the user for their name and if I didnt use a method then I wouldve had to copy and paste the code twice which is messy and unorganised. It also checks if the name is below than 3 and above 10 and if it doesn't meet any of those then they have to retry.
        static string DisplayAskName(String nameType)
        {
            string name;

            Console.WriteLine($"What is your {nameType} name? ");
            name = Console.ReadLine();
            while ((name.Length < 3) || (name.Length > 10) || (!name.All(char.IsLetter)))
            {
                Console.WriteLine("Invalid, your name must be between 3 and 10 characters long and not have special characters like $.");
                Console.WriteLine($"What is your {nameType} name?");
                name = Console.ReadLine();
            }
            return name;
        }
    }
}