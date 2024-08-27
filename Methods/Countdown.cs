namespace The_Basics.Methods
{
    public static class Countdown
    {
        public static void Run()
        {
            static int Countdown(int number)
            {
                if (number == 1) {Console.WriteLine(1); return 1;}
                Console.WriteLine(number);
                return Countdown(number - 1);
            }

            Countdown(10);
            Console.WriteLine("Press any key to return to continue or exit to quit");
            Console.ReadKey();
        }
    }
}