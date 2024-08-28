using static The_Basics.Tools.Tools;
namespace The_Basics.MathOperators
{
    public static class TriangleFarmer
    {
        public static void Run()
        {
            var triangleBase = GetValidInput("Enter base : ");
            var height = GetValidInput("Enter height : ");
            var area = (triangleBase * height) / 2;
            Console.WriteLine($"Area of triangle is : {area}");
            
            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();
        }
    }
}