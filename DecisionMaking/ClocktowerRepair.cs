namespace The_Basics.DecisionMaking
{
    public static class ClocktowerRepair
    {
        public static void Run()
        {
            Console.Write("Enter a number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number % 2 == 0 ? "Tick." : "Tock.");
            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();
        }
    }
}