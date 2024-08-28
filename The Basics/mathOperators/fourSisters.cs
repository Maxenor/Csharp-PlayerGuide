using static The_Basics.Tools.Tools;
namespace The_Basics.MathOperators
{
    public static class FourSisters
    {
        public static void Run()
        {
            var eggs = GetValidInput("How many eggs made today ?");
            var sisters = eggs / 4;
            var duckbear = eggs % 4;
            Console.WriteLine($"Each sister gets {sisters} eggs and the duckbear gets {duckbear} eggs.");
            if (duckbear > sisters) {
                Console.WriteLine("The duckbear gets more eggs than each sister.");
            }
            
            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();
        }
        
    }
}