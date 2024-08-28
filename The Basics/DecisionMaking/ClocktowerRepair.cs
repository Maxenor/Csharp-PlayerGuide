using static The_Basics.Tools.Tools;
namespace The_Basics.DecisionMaking
{
    public static class ClocktowerRepair
    {
        public static void Run()
        {
            var number = GetValidInput("Enter a number: ");
            Console.WriteLine(number % 2 == 0 ? "Tick." : "Tock.");
            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();
        }
    }
}