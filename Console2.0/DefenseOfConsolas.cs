using System.Diagnostics;
using static The_Basics.Tools.Tools;
namespace The_Basics.Console2._0
{
    public static class DefenseOfConsolas
    {
        const int Rows = 7;
        const int Columns = 7;
        public static void Run()
        {
            Console.Title = "Defense of Consolas";
            
            var targetRow = GetValidInput("Enter the row of the target (1-7): ");
            var targetColumn = GetValidInput("Enter the column of the target (1-7): ");
            
            if (targetRow < 1 || targetRow >= Rows || targetColumn < 1 || targetColumn >= Columns) {
                Console.WriteLine("Target is out of bounds.");
            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($" Deploy to ({targetRow}, {targetColumn - 1})");
                Console.WriteLine($" Deploy to ({targetRow - 1}, {targetColumn})");
                Console.WriteLine($" Deploy to ({targetRow}, {targetColumn + 1})");
                Console.WriteLine($" Deploy to ({targetRow + 1}, {targetColumn})");
                Console.ResetColor();
                Process.Start("say", "-v Whisper \"BEEP BOOP BEEP BOOP\"");
            }
            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();
            
        }
    }
}