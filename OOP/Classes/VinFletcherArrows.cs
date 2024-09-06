namespace OOP.Classes
{
    public class VinFletcherArrows
    {
        public static void Run()
        {
            while (true)
            {
                try
                {
                    var arrowhead = GetArrowheadType();
                    var shaft = GetShaftLength();
                    var fletching = GetFletchingType();

                    var arrow = new Arrow(arrowhead, shaft, fletching);
                    Console.WriteLine($"The cost of the arrow made of a { arrowhead } arrowhead," +
                                      $" a { fletching } fletching and a shaft of {shaft} centimeters is {arrow.GetCost()} gold.");

                    Console.WriteLine("Press any key to return to the main menu...");
                    Console.ReadKey();
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        private static Arrowhead GetArrowheadType()
        {
            while (true)
            {
                Console.Write("Enter arrowhead type (Steel, Wood, Obsidian): ");
                if (Enum.TryParse<Arrowhead>(Console.ReadLine(), true, out var arrowheadType))
                {
                    return arrowheadType;
                }
                Console.WriteLine("Invalid arrowhead type. Please enter a valid input.");
            }
        }

        private static float GetShaftLength()
        {
            while (true)
            {
                Console.Write("Enter shaft length: ");
                if (float.TryParse(Console.ReadLine(), out var shaft))
                {
                    return shaft;
                }
                Console.WriteLine("Invalid shaft length. Please enter a valid input.");
            }
        }

        private static Fletching GetFletchingType()
        {
            while (true)
            {
                Console.Write("Enter fletching type (TurkeyFeather, GooseFeather, Plastic): ");
                if (Enum.TryParse<Fletching>(Console.ReadLine(), true, out var fletchingType))
                {
                    return fletchingType;
                }
                Console.WriteLine("Invalid fletching type. Please enter a valid input.");
            }
        }
    }

    public enum Arrowhead
    {
        Steel = 10,
        Wood = 3,
        Obsidian = 5
    }

    public enum Fletching
    {
        TurkeyFeather = 5,
        GooseFeather = 3,
        Plastic = 10
    }

    public class Arrow
    {
        private Arrowhead _arrowhead { get; }
        private float _shaft { get; }
        private Fletching _fletching { get; }

        public Arrow(Arrowhead arrowhead, float shaft, Fletching fletching)
        {
            _arrowhead = arrowhead;
            _shaft = shaft;
            _fletching = fletching;
        }

        public float GetCost()
        {
            float cost = 0;
            cost += (float)_arrowhead;
            cost += (_shaft * 0.05f);
            cost += (float)_fletching;
            return cost;
        }
    }
}