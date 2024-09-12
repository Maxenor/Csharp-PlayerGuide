namespace OOP.CatacombsOfClass
{
    public static class RockPaperScissors
    {
        public static void Run()
        {
            var rounds = 0;
            var player1Wins = 0;
            var player2Wins = 0;
            while (true) {
                Console.Clear();
                Console.Write("Welcome to Rock, Paper, Scissors! Enter how many rounds to play or type 'exit' to return to the main menu: ");
                try {
                    var input = Console.ReadLine();
                    if (input == "exit") {
                        break;
                    }
                    rounds = int.Parse(input);
                    if (rounds < 1) {
                        Console.WriteLine("Please enter a number greater than 0.");
                        continue;
                    }
                } catch {
                    Console.WriteLine("Please enter a valid number.");
                }
                var game = new Game(rounds);
                
                for (var i = 0; i < rounds; i++) {
                    Console.WriteLine($"Round {i + 1}");
                    var player1Choice = (Game.Choices)Enum.Parse(typeof(Game.Choices), HandlePlayerChoice("Player 1"));
                    Console.WriteLine($"Player 1 chose {player1Choice}");
                    var player2Choice = (Game.Choices)Enum.Parse(typeof(Game.Choices), HandlePlayerChoice("Player 2"));
                    Console.WriteLine($"Player 2 chose {player2Choice}");
                    if (Game.GameLogic(player1Choice,player2Choice) == Game.Results.Player1Wins) {
                        Console.WriteLine("Player 1 wins!");
                        player1Wins++;
                    } else if (Game.GameLogic(player1Choice,player2Choice) == Game.Results.Player2Wins) {
                        Console.WriteLine("Player 2 wins!");
                        player2Wins++;
                    } else {
                        Console.WriteLine("It's a tie!");
                    }
                }
                
            }
            Console.WriteLine($"Player 1 score: {player1Wins}");
            Console.WriteLine($"Player 2 score: {player2Wins}");
            Console.WriteLine("Press any key to return to the main menu...");
            Console.ReadKey();
        }

        private static string HandlePlayerChoice(string playerName)
        {
            while (true) {
                Console.Write($"{playerName}, please choose Rock, Paper, or Scissors: ");
                var playerChoice = Console.ReadLine();
                if (playerChoice != "Rock" && playerChoice != "Paper" && playerChoice != "Scissors") {
                    Console.WriteLine("Please enter a valid choice.");
                } else {
                    return playerChoice;
                }
            }
        }

        public class Game(int rounds)
        {
            
            public enum Choices
            {
                Rock,
                Paper,
                Scissors
            }
            public enum Results
            {
                Player1Wins,
                Player2Wins,
                Tie
            }
            public static Results GameLogic(Choices player1Choice, Choices player2Choice)
            {
                if (player1Choice == player2Choice)
                {
                    return Results.Tie;
                }
                else switch (player1Choice) {
                    case Choices.Rock when player2Choice == Choices.Scissors:
                    case Choices.Paper when player2Choice == Choices.Rock:
                    case Choices.Scissors when player2Choice == Choices.Paper:
                        return Results.Player1Wins;
                    default:
                        return Results.Player2Wins;
                }
            }
        }
    }
}