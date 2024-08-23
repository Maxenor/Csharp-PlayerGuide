namespace MathOperators
{
    public static class DominionOfKings
    {
        public static void Run()
        {
            Console.WriteLine("What is the name of the king?");
            string kingName = Console.ReadLine();
            int estatePoint = 1;
            int duchyPoint = 3;
            int provincePoint = 6;
            
            Console.WriteLine("How many estates do you have?");
            int estates = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many duchies do you have?");
            int duchies = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many provinces do you have?");
            int provinces = Convert.ToInt32(Console.ReadLine());
            
            int totalPoints = (estates * estatePoint) + (duchies * duchyPoint) + (provinces * provincePoint);
            Console.WriteLine($"The total points for {kingName} is {totalPoints}.");
            
            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();
        }
    }
}