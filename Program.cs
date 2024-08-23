using The_Basics.Console2._0;
using The_Basics.MathOperators;

namespace The_Basics
{
        static class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                DisplayMainMenu();

                string input = Console.ReadLine();
                if (input.ToLower() == "exit")
                {
                    break;
                }

                if (int.TryParse(input, out int chapter))
                {
                    Console.Clear();
                    HandleChapterSelection(chapter);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Incorrect entry, please try again.");
                }
            }
        }

        static void DisplayMainMenu()
        {
            Console.WriteLine("Welcome to the C# Player's guide challenge archive!");
            Console.WriteLine("This is a collection of challenges from the book 'C# Player's Guide' by RB Whitaker.");
            Console.WriteLine("You are on Part 1: The Basics.");
            Console.WriteLine("Please select a chapter to view:");
            Console.WriteLine("1. Chapter 1: Math Operators");
            Console.WriteLine("2. Chapter 2: Console 2.0");
            Console.WriteLine("3. Chapter 3: Decision Making");
            Console.WriteLine("4. Chapter 4: Switch Statements");
            Console.WriteLine("5. Chapter 5: Looping");
            Console.WriteLine("6. Chapter 6: Arrays");
            Console.WriteLine("7. Chapter 7: Methods");
            Console.WriteLine("8. Chapter 8: Memory management");
            Console.WriteLine("Select a chapter to view or type 'exit' to quit:");
        }

        static void HandleChapterSelection(int chapter)
        {
            switch (chapter)
            {
                case 1:
                    HandleMathOperators();
                    break;
                case 2:
                    HandleConsole2_0();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Incorrect entry, please try again.");
                    break;
            }
        }

        static void HandleMathOperators()
        {
            Console.WriteLine("Chapter 1: Math Operators");
            Console.WriteLine("1. Challenge 1: The triangle farmer");
            Console.WriteLine("2. Challenge 2: The four sisters and the duckbear");
            Console.WriteLine("3. Challenge 3: The dominion of kings");
            Console.WriteLine("Select a challenge to view or type 'exit' to return to the main menu:");
            int challengeToView = Convert.ToInt32(Console.ReadLine());
            switch (challengeToView)
            {
                case 1:
                    TriangleFarmer.Run();
                    break;
                case 2:
                    FourSisters.Run();
                    break;
                case 3:
                    DominionOfKings.Run();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Incorrect entry, please try again.");
                    break;
            }
        }

        static void HandleConsole2_0()
        {
            Console.WriteLine("Chapter 2: Console 2.0");
            Console.WriteLine("1. The defense of Consolas");
            if (Convert.ToInt32(Console.ReadLine()) == 1)
            {
                DefenseOfConsolas.Run();
            }
        }
    }
}
