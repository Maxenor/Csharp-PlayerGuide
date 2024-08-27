using static The_Basics.Tools.Tools;
namespace The_Basics.DecisionMaking
{
    public static class Watchtower
    {
        public static void Run()
        {
            var x = GetValidInput("Enter x value : ");
            var y = GetValidInput("Enter y value : ");

            switch (x) {
                case > 0 when y > 0:
                    Console.WriteLine("The enemy is to the North East.");
                    break;
                case < 0 when y > 0:
                    Console.WriteLine("The enemy is to the North West.");
                    break;
                case > 0 when y < 0:
                    Console.WriteLine("The enemy is to the South East.");
                    break;
                case < 0 when y < 0:
                    Console.WriteLine("The enemy is to the South West.");
                    break;
                case 0 when y > 0:
                    Console.WriteLine("The enemy is to the North.");
                    break;
                case 0 when y < 0:
                    Console.WriteLine("The enemy is to the South.");
                    break;
                case > 0 when y == 0:
                    Console.WriteLine("The enemy is to the East.");
                    break;
                case < 0 when y == 0:
                    Console.WriteLine("The enemy is to the West.");
                    break;
                default:
                    Console.WriteLine("The enemy is here!");
                    break;
            }
            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();
        }
    }
}