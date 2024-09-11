namespace OOP.CatacombsOfClass
{
    public static class TheCard
    {
        public static void Run()
        {
            var colors = new Colors[] { Colors.Red, Colors.Green, Colors.Blue, Colors.Yellow };
            var ranks = new Ranks[] { Ranks.One, Ranks.Two, Ranks.Three, Ranks.Four, Ranks.Five, Ranks.Six, Ranks.Seven, Ranks.Eight, Ranks.Nine, Ranks.Ten, Ranks.Dollar, Ranks.Percent, Ranks.Caret, Ranks.Ampersand };
            
            foreach (var color in colors)
            {
                foreach (var rank in ranks)
                {
                    var card = new Card(color, rank);
                    Console.WriteLine($"The {color} {rank}");
                    Console.WriteLine($"Is the card a number or face card? {card.IsNumberOrFaceCard}");
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Press any key to return to the main menu...");
            Console.ReadKey();
        }
        
        private enum Colors
        {
            Red,
            Green,
            Blue,
            Yellow,
        }
        
        private enum Ranks
        {
            One,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Dollar,
            Percent,
            Caret,
            Ampersand
        }

        private class Card(Colors color, Ranks rank)
        {
            public bool IsNumberOrFaceCard => (int)rank >= 1 && (int)rank < 10;
        }
    }
}