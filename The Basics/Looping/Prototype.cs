using static The_Basics.Tools.Tools;
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
            while (true) {
                var input = GetValidInput("User 1, enter a number between 0 and 100: ");
                if (input is >= 0 and <= 100) return input;
                Console.Clear();
                Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
            }
        }

        private static void GetUser2Guess(int number)
        {
            while (true)
            {
                var input = GetValidInput("User 2, guess the number: ");
            
                if (input == number)
                {
                    Console.Write("You guessed the correct number!\n Press any key to return to the main menu.");
                    Console.ReadKey();
                    break;
                }
                Console.WriteLine(input < number ? $"{input} is too low." : $"{input} is too high.");
            }
        }
    }
}