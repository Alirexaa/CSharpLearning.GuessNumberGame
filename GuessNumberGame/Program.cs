namespace GuessNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 100;
            bool isEqual = false;
            int guess;
            do
            {
                guess = GetGuess(min, max);
                Console.WriteLine("is correct " + guess);
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "0":
                        isEqual = true;
                        break;
                    case "+":
                        min = guess;
                        break;
                    case "-":
                        max = guess;
                        break;
                    default:
                        Console.WriteLine("wrong answer");
                        break;
                }

            } while (!isEqual);

            Console.WriteLine("correct number is " + guess);
        }

        static int GetGuess(int min, int max)
        {
            Random random = new Random();
            int number = random.Next(min, max);
            return number;
        }
    }
}