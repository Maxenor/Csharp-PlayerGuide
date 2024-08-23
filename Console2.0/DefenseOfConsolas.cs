using System.Diagnostics;

namespace Console2._0
{
    public static class DefenseOfConsolas
    {
        public static void Run()
        {
            Console.Title = "Defense of Consolas";
            int rows = 7;
            int columns = 7;
            Console.Write("What is the target row ? ");
            int targetRow = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is the target column ? ");
            int targetColumn = Convert.ToInt32(Console.ReadLine());
            if (targetRow < 1 || targetRow >= rows || targetColumn < 1 || targetColumn >= columns)
            {
                Console.WriteLine("Target is out of bounds.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($" Deploy to ({targetRow}, {targetColumn -1})");
                Console.WriteLine($" Deploy to ({targetRow -1}, {targetColumn})");
                Console.WriteLine($" Deploy to ({targetRow}, {targetColumn +1})");
                Console.WriteLine($" Deploy to ({targetRow +1}, {targetColumn})");
                Console.ResetColor();
                Process.Start("say", "-v Whisper \"BEEP BOOP BEEP BOOP\"");
            }
            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();
        }
    }
}