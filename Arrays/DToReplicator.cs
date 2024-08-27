using static The_Basics.Tools.Tools;
namespace The_Basics.Arrays
{
    public static class DToReplicator
    {
        public static void Run()
        {
            var firstArray = new int[5];
            for (var i = 0; i < 5; i++) {
                var number = GetValidInput("Enter a number: ");
                firstArray[i] = number;
            }
            var secondArray = new int[5];
            for (var i = 0; i < 5; i++) {
                secondArray[i] = firstArray[i];
            }

            for (var i = 0; i < 5; i++) {
                Console.WriteLine($"First array: {firstArray[i]}");
                Console.WriteLine($"Second array: {secondArray[i]}");
            }
            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();
        }
    }
}