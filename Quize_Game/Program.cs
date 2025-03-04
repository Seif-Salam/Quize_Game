namespace Quize_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] questions = new string[]
            {
                "1. What Is The Capital Of England ?",
                "2. What Is The Red Planet ?",
                "3. What Is The Biggest Animal"
            };

            string[] answers = new string[]
            {
                "london",
                "mars",
                "blue whale"

            };
            Console.WriteLine("Welcome To My Game");
            Console.WriteLine("-------------------");
            Console.WriteLine("Please Answer The Following Question :\n");
            int score = 0;
            int index = 0;
            for(int i =0;i<questions.Length;i++)
            {
                Console.WriteLine($"{questions[i]}\n");
                string userAnswer = Convert.ToString(Console.ReadLine().ToLower());
                try
                {
                    bool result = CheckAnswer(userAnswer, answers[i]);
                    if (result == true)
                    {
                        Console.WriteLine("\nCorrect Answer✔️.\n");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"\nSorry‼️, Incorrect Answer, The Correct Answer IS: {answers[i]}.\n");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                index = i+1;
            }
            if (index - score == 0)
            {
                Console.WriteLine($"\nYour Score IS: {score}🥇🏆, Congratulations.\n");
            }
            else if (index - score == 1)
            {
                Console.WriteLine($"\nYour Score IS: {score}🥈.\n");

            }

            else if (index - score == 2)
            {
                Console.WriteLine($"\nYour Score IS: {score}🥉.\n");

            }
            else
            {
                Console.WriteLine($"\nYour Score IS: {score}😔, Good Luke In The Next Game.\n");

            }
            Console.ReadKey();

        }
        private static bool CheckAnswer(string userInput, string correctAnswer)
        {
            if (string.IsNullOrEmpty(userInput))
            {
                throw new Exception("Answer Can't Be Empty!.\n");
            };
            if (userInput == correctAnswer)
            {
                return true;

            }
            else
            {
                return false;

            }

        }
    }
}
