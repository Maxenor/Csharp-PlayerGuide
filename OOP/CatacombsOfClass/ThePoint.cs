namespace OOP.CatacombsOfClass
{
    public static class ThePoint
    {
        public static void Run()
        {
            var point = new Point();
            Console.WriteLine($"Point: ({point.GetX()}, {point.GetY()})");
            
            var point2 = new Point(3, 4);
            Console.WriteLine($"Point: ({point2.GetX()}, {point2.GetY()})");
            
            Console.WriteLine("Press any key to return to the main menu...");
            Console.ReadKey();
        }

        private class Point(int x, int y)
        {
            public Point() : this(0, 0){}
           
           public int GetX() => x;
           public int GetY() => y;
           
        }
    }
}