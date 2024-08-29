namespace OOP.Tuples
{
    public static class SimulaSoup
    {
        private enum SoupType
        {
            Soup,
            Stew,
            Gumbo
        }

        private enum Ingredients
        {
            Mushrooms,
            Chicken,
            Carrots,
            Potatoes,
        }
        
        private enum Seasonings
        {
            Spicy,
            Salty,
            Sweet
        }
        
        public static void Run()
        {
            (SoupType soupType, Ingredients ingredient, Seasonings seasoning) soup;
            while (true) 
            {
                Console.Write("What type of soup do you want to make?" +
                              "\nPossible choices are: Soup, Stew, Gumbo : ");
                var soupType = Console.ReadLine();
                if (!Enum.TryParse(soupType, out SoupType _))
                {
                    Console.WriteLine("Invalid choice");
                    continue;
                }
                Console.Write("What ingredients do you want to use?" +
                              "\nPossible choices are: Mushrooms, Chicken, Carrots, Potatoes : ");
                var ingredients = Console.ReadLine();
                if (!Enum.TryParse(ingredients, out Ingredients _))
                {
                    Console.WriteLine("Invalid choice");
                    continue;
                }
                Console.Write("What seasonings do you want to use?" +
                              "\nPossible choices are: Spicy, Salty, Sweet : ");
                var seasonings = Console.ReadLine();
                if (!Enum.TryParse(seasonings, out Seasonings _))
                {
                    Console.WriteLine("Invalid choice");
                    continue;
                }
                soup = (Enum.Parse<SoupType>(soupType), Enum.Parse<Ingredients>(ingredients), Enum.Parse<Seasonings>(seasonings));
                Console.WriteLine($"{soup.seasoning} {soup.ingredient} {soup.soupType}");
                Console.WriteLine("Press any key to return to the main menu...");
                Console.ReadKey();
                break;
            }
        }
    }
}