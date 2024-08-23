namespace MathOperators
{
    public static class TriangleFarmer
    {
        public static void Run()
        {
            Console.WriteLine("Enter base :");
            int triangleBase = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter height :");
            int height = Convert.ToInt32(Console.ReadLine());
            int area = (triangleBase * height) / 2;
            Console.WriteLine("Area of triangle is : " + area);
            
            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();
        }
    }
}