using static The_Basics.Tools.Tools;
namespace The_Basics.Memory
{
    public static class ManticoreHunt
    {
        public static void Run()
        {
            const int manticoreAttack = 1;
            var rounds = 0;
            var cityHealth = 10;
            var manticoreHealth = 10;
            var manticorePosition = GetValidInput("Player 1, enter the manticore's position: ");
            Console.Clear();
            
            do {
                var cannonDamage = MagicCannon();
                Console.Write($"-------------------------------------------------------- \n" +
                              $"STATUS : Round : {rounds} | City Health: {cityHealth} | Manticore Health: {manticoreHealth}\n" +
                              $"The cannon is expected to do {cannonDamage} damage\n" );
                var cannonRange = GetValidInput("Player 2 , enter the desired cannon range : ");
                if (cannonRange == manticorePosition) {
                    Console.WriteLine("Direct hit on the manticore!");
                    manticoreHealth -= cannonDamage;
                } else if (cannonRange < manticorePosition) {
                    cityHealth -= manticoreAttack;
                    Console.WriteLine("That round fell short the manticore");
                } else {
                    cityHealth -= manticoreAttack;
                    Console.WriteLine("That round went over the manticore");
                }
                Console.WriteLine("--------------------------------------------------------");
                rounds++;
            } while (cityHealth > 0 && manticoreHealth > 0);

            Console.WriteLine(cityHealth <= 0
                ? "The manticore has destroyed the city... Game Over"
                : "The manticore has been defeated, the city of Consolas is saved !");
            Console.WriteLine("Press any key to return to continue or exit to quit");
            Console.ReadKey();
        }

        /// <summary>
        /// Modified function to return the damage of the magic cannon
        /// Takes a random number between 1 and 100 
        /// </summary>
        /// <returns>Returns the damage based on the number</returns>
        private static int MagicCannon()
        {
            const int normalBlast = 1;
            const int fireBlast = 3;
            const int electricShock = 5;
            const int combinedBlast = 10;
            
            var randomNumber = new Random();
            var randomNumberInRange = randomNumber.Next(1, 101);

            return (randomNumberInRange % 3) switch
            {
                0 when randomNumberInRange % 5 == 0 => combinedBlast,
                0 => fireBlast,
                _ => randomNumberInRange % 5 == 0 ? electricShock : normalBlast
            };
        }
    }
}