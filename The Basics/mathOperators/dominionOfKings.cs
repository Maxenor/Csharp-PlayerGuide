using static The_Basics.Tools.Tools;
namespace The_Basics.MathOperators
{
    public static class DominionOfKings
    {
        public static void Run()
        {
            Console.WriteLine("What is the name of the king?");
            var kingName = Console.ReadLine();
            const int estatePoint = 1;
            const int duchyPoint = 3;
            const int provincePoint = 6;

            var estate = GetValidInput("How many estates do you have?");
            var duchy = GetValidInput("How many duchies do you have?");
            var province = GetValidInput("How many provinces do you have?");
            
            var totalPoints = (estate * estatePoint) + (duchy * duchyPoint) + (province * provincePoint);
            Console.WriteLine($"The total points for {kingName} is {totalPoints}.");

            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();
        }
    }
}