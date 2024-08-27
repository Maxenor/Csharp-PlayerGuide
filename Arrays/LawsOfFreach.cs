namespace The_Basics.Arrays
{
    public static class LawsOfFreach
    {
        public static void Run()
        {
            var array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            var currentSmallest = int.MaxValue; // Start higher than anything in the array.
            foreach (var i in array) {
                if (i < currentSmallest) {
                    currentSmallest = i;
                }
            }
            Console.WriteLine($"The smallest number was : {currentSmallest}");
            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();
        }
    }
}