namespace The_Basics.Looping
{
    public static class Prototype
    {
        public static void Run()
        {
            var number = GetUser1Number();
            Console.Clear();
            GetUser2Guess(number);
        }

        private static int GetUser1Number()
        {
            while (true)
            {
                Console.Write("User 1, enter a number between 0 and 100: ");
                var input = Console.ReadLine();
                if (int.TryParse(input, out var number) && number is >= 0 and <= 100) return number;
                Console.Clear();
                Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
            }
        }

        private static void GetUser2Guess(int number)
        {
            while (true)
            {
                Console.Write("User 2, guess the number: ");
                var input = Console.ReadLine();
                if (int.TryParse(input, out var guess))
                {
                    if (guess == number)
                    {
                        Console.Write("You guessed the correct number!\nPress any key to return to the main menu.");
                        Console.ReadKey();
                        break;
                    }
                    Console.WriteLine(guess < number ? $"{guess} is too low." : $"{guess} is too high.");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
                }
            }
        }
    }
}