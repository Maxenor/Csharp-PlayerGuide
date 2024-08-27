using static The_Basics.Tools.Tools;
namespace The_Basics.SwitchStatements
{
    public static class BuyingInventory
    {
        public static void Run()
        {
            while (true) {
                
                float rope = 10;
                float torches = 15;
                float climbingGear = 25;
                float cleanWater = 1;
                float machete = 20;
                float canoe = 200;
                float foodSupplies = 1;
                var discountedClient = "Max";
                
                Console.Clear();
                Console.Write("The following items are available : " +
                              "\n 1- Rope" +
                              "\n 2- Torches" +
                              "\n 3- Climbing Gear" +
                              "\n 4- Clean water" +
                              "\n 5- Machete" +
                              "\n 6- Canoe" +
                              "\n 7- Food supplies");

                var input = Console.ReadLine();
                if (input?.ToLower() == "exit")
                {
                    return;
                }
                var itemNumber = GetValidInput("What number do you want to see the price of? ");
                Console.Write("What is your name ? ");
                var name = Console.ReadLine();
                if (string.Equals(name, discountedClient, StringComparison.CurrentCultureIgnoreCase))
                {
                    // apply a 50% discount
                    rope *= 0.5f;
                    torches *= 0.5f;
                    climbingGear *= 0.5f;
                    cleanWater *= 0.5f;
                    machete *= 0.5f;
                    canoe *= 0.5f;
                    foodSupplies *= 0.5f;
                }
                var item = itemNumber switch
                {
                    1 => $"The Rope is { rope } gold.",
                    2 => $"Torches are {torches} gold.",
                    3 => $"Climbing Gear is {climbingGear} gold.",
                    4 => $"Clean water is {cleanWater} gold.",
                    5 => $"Machete is {machete} gold.",
                    6 => $"Canoe is {canoe} gold.",
                    7 => $"Food supplies are {foodSupplies} gold.",
                    _ => "Invalid item number."
                };
                Console.WriteLine(item);
                Console.WriteLine("Press any key to return to continue or exit to quit");
                Console.ReadKey();
            }
        }
    }
}