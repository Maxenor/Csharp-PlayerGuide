namespace The_Basics.MathOperators
{
    public static class FourSisters
    {
        public static void Run()
        {
            Console.WriteLine("How many eggs made today ?");
            int eggs = Convert.ToInt32(Console.ReadLine());
            int sisters = eggs / 4;
            int duckbear = eggs % 4;
            Console.WriteLine($"Each sister gets {sisters} eggs and the duckbear gets {duckbear} eggs.");
            if (duckbear > sisters) {
                Console.WriteLine("The duckbear gets more eggs than each sister.");
            }
            
            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();
        }
        
    }
}