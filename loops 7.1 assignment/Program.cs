namespace topic_7._1_loop_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PartOne();
            PartTwo();
        }
        public static void PartOne()
        {
            Random generator = new Random();
            int randomNumber = generator.Next(1, 101);
            int userGuess = 0;
            int attempts = 0;
            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("I have selected a random number between 1 and 100. Try to guess it!");
            while (userGuess != randomNumber)
            {
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out userGuess))
                {
                    attempts++;
                    if (userGuess < randomNumber)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }
                    else if (userGuess > randomNumber)
                    {
                        Console.WriteLine("Too high! Try again.");
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations! You've guessed the number {randomNumber} in {attempts} attempts.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
                if (attempts == 7)
                {
                    Console.WriteLine($"Sorry, you've reached the maximum number of attempts. The correct number was {randomNumber}.");
                    break;
                }
            }
        }
        public static void PartTwo()
        {
            int number1;
            int number2;
            int number3;
            int number4;
            int average;
            Console.WriteLine("Enter the first number:");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number:");
            number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the fourth number:");
            number4 = Convert.ToInt32(Console.ReadLine());
            average = (number1 + number2 + number3 + number4) / 4;
            Console.WriteLine($"The average of the four numbers is: {average}");
        }

    }
}