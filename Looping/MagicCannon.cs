namespace The_Basics.Looping
{
    public static class MagicCannon
    {
        public static void Run()
        {
            for (var i = 0; i < 100; i++) {
                switch (i % 3) {
                    case 0 when i % 5 == 0:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Combined");
                        break;
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Fire");
                        break;
                    default:
                    {
                        if (i % 5 == 0) {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Electric");
                        } else {
                            Console.ResetColor();
                            Console.WriteLine("Normal");
                        }

                        break;
                    }
                }
            }
            Console.ResetColor();
            Console.WriteLine("Press any key to return to continue or exit to quit");
            Console.ReadKey();
        }
    }
}