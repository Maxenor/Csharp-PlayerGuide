namespace OOP.CatacombsOfClass
{
    public static class Hangman
    {
        public static void Run()
        {
            Console.WriteLine("Press any key to return to the main menu...");
            Console.ReadKey();
        }
    }
}

/*
 
 CRC CARDS
 
Class game
   
   Resp:
   
   Managing the flow of the game
    Determine the game state
    Checks if guess is correct with Hangman
   
   Collab:
   
   Player
   Hangman
   Hangman Generator
   
   Class Hangman
   
   Resp:
   
   Knows letters already found
   Checks if user input is correct
   Add letter to found if correct
   Determine when solved
   Tracks guess count
   
   Collab:
   
   none
   
   Class Player
   
   Resp:
   
   Get user input
   Tell player has won
   Display game state
   Tell user guess count
   
   Collab:
   
   Hangman
   Console
   
   Class Hangman Generator
   
   Resp:
   
   Generate random word
   
   Collab:
   
   Hangman
*/