using static The_Basics.Tools.Tools;
using The_Basics.Console2._0;
using The_Basics.MathOperators;
using The_Basics.DecisionMaking;
using The_Basics.Looping;
using The_Basics.SwitchStatements;

namespace The_Basics
{
        static class Program
    {
        const string ErrorMessage = "Incorrect entry, please try again. \n Press any key to go back";
        const string ChallengeSelectionMessage = "Select a challenge to view or type 'exit' or 'quit' to return to the main menu: ";
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.Clear();
                DisplayMainMenu();

                var chapter = GetValidInput("Select a chapter to view or type 'exit' to quit : ");
                Console.Clear();
                HandleChapterSelection(chapter);
            }
        }

        static void DisplayMainMenu()
        {
            Console.WriteLine("Welcome to the C# Player's guide challenge archive!");
            Console.WriteLine("This is a collection of challenges from the book 'C# Player's Guide' by RB Whitaker.");
            Console.WriteLine("You are on Part 1: The Basics.");
            Console.WriteLine("Please select a chapter to view:");
            Console.WriteLine("1. Chapter 1: Math Operators");
            Console.WriteLine("2. Chapter 2: Console 2.0");
            Console.WriteLine("3. Chapter 3: Decision Making");
            Console.WriteLine("4. Chapter 4: Switch Statements");
            Console.WriteLine("5. Chapter 5: Looping");
            Console.WriteLine("6. Chapter 6: Arrays");
            Console.WriteLine("7. Chapter 7: Methods");
            Console.WriteLine("8. Chapter 8: Memory management");
        }

        static void HandleChapterSelection(int chapter)
        {
            Action response = chapter switch
            {
                0 => () => { Environment.Exit(0); },
                1 => HandleMathOperators,
                2 => HandleConsole2_0,
                3 => HandleDecisionMaking,
                4 => HandleSwitchStatements,
                5 => HandleLooping,
                6 => HandleArrays,
                7 => HandleMethods,
                8 => HandleMemoryManagement,
                _ => () => { Console.Clear(); Console.Write(ErrorMessage); Console.ReadKey();
                }
            };
            response();
        }

        static void HandleMathOperators()
        {
            Console.WriteLine("Chapter 1: Math Operators");
            Console.WriteLine("1. The triangle farmer");
            Console.WriteLine("2. The four sisters and the duckbear");
            Console.WriteLine("3. The dominion of kings");

            var challengeToView = GetValidInput(ChallengeSelectionMessage);
            
            Action response = challengeToView switch
            {
                0 => () => {Environment.Exit(0);},
                1 => TriangleFarmer.Run,
                2 => FourSisters.Run,
                3 => DominionOfKings.Run,
                _ => () => { Console.Clear(); Console.Write(ErrorMessage); Console.ReadKey(); }
            };
            response();
        }

        static void HandleConsole2_0()
        {
            Console.WriteLine("Chapter 2: Console 2.0");
            Console.WriteLine("1. The defense of Consolas");
            var challengeToView = GetValidInput(ChallengeSelectionMessage);
                
            Action response = challengeToView switch
            {
                0 => () => { Environment.Exit(0); },
                1 => DefenseOfConsolas.Run,
                _ => () => { Console.Clear(); Console.Write(ErrorMessage); Console.ReadKey(); }
            };
            response();
            
        }
        
        static void HandleDecisionMaking()
        {
            Console.WriteLine("Chapter 3: Decision Making");
            Console.WriteLine("1. Repair the clock tower");
            Console.WriteLine("2. Watchtower");
            var challengeToView = GetValidInput(ChallengeSelectionMessage);
            
            Action response = challengeToView switch
            {
                0 => () => { Environment.Exit(0); },
                1 => ClocktowerRepair.Run,
                2 => Watchtower.Run,
                _ => () => { Console.Clear(); Console.Write(ErrorMessage); Console.ReadKey(); }
            };
            response();
        }
        
        static void HandleSwitchStatements()
        {
            Console.WriteLine("Chapter 4: Switch Statements");
            Console.WriteLine("1. Buying Inventory");
            var challengeToView = GetValidInput(ChallengeSelectionMessage);
            Action response = challengeToView switch
            {
                0 => () => { Environment.Exit(0); },
                1 => BuyingInventory.Run,
                _ => () => { Console.Clear(); Console.Write(ErrorMessage); Console.ReadKey(); }
            };
            response(); 
        }
        
        static void HandleLooping()
        {
            Console.WriteLine("Chapter 5: Looping");
            Console.WriteLine("1. The prototype");
            Console.WriteLine("2. The magic cannon");
            var challengeToView = GetValidInput(ChallengeSelectionMessage);
            Action response = challengeToView switch
            {
                0 => () => { Environment.Exit(0); },
                1 => Prototype.Run,
                _ => () => { Console.Clear(); Console.Write(ErrorMessage); Console.ReadKey(); }
            };
            response();
            
        }
        
        static void HandleArrays()
        {
            // todo
        }
        static void HandleMethods()
        {
            // todo
        }
        static void HandleMemoryManagement()
        {
            // todo
        }
    }
}
