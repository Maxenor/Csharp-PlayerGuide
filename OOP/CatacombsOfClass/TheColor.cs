namespace OOP.CatacombsOfClass
{
    public static class TheColor
    {
        public static void Run()
        {
            var customColor = new Color(100, 100, 100);
            Console.WriteLine($"Custom color: {customColor.GetRed()}, {customColor.GetGreen()}, {customColor.GetBlue()}");
            Console.WriteLine($"Orange: {Color.Orange.GetRed()}, {Color.Orange.GetGreen()}, {Color.Orange.GetBlue()}");
            Console.WriteLine("Press any key to return to the main menu...");
            Console.ReadKey();
        }
        
        private class Color(int red, int blue, int green)
        {
            public Color() : this(255, 255, 255){}
            
            public int GetRed() => red;
            public int GetBlue() => blue;
            public int GetGreen() => green;
            
            public static Color White => new Color(255,255,255);
            public static Color Black => new Color(0,0,0);
            public static Color Red => new Color(255,0,0);
            public static Color Green => new Color(0,255,0);
            public static Color Blue => new Color(0,0,255);
            public static Color Yellow => new Color(255,255,0);
            public static Color Orange => new Color(255,165,0);
            public static Color Purple => new Color(128,0,128);
        }
    }
}