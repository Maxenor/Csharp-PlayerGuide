namespace The_Basics.DecisionMaking
{
    public static class Watchtower
    {
        public static void Run()
        {
            Console.Write("Enter x value : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y value : ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("The enemy is to the North East.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("The enemy is to the North West.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("The enemy is to the South East.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("The enemy is to the South West.");
            }
            else if (x == 0 && y > 0)
            {
                Console.WriteLine("The enemy is to the North.");
            }
            else if (x == 0 && y < 0)
            {
                Console.WriteLine("The enemy is to the South.");
            }
            else if (x > 0 && y == 0)
            {
                Console.WriteLine("The enemy is to the East.");
            }
            else if (x < 0 && y == 0)
            {
                Console.WriteLine("The enemy is to the West.");
            }
            else
            {
                Console.WriteLine("The enemy is here!");
            }
            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();
        }
    }
}