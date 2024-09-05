using OOP.Classes;
using OOP.Enumerations;
using OOP.Tuples;
using static OOP.Tools.Tools;
namespace OOP
{
        static class Program
    {
        const string ErrorMessage = "Incorrect entry, please try again. \n Press any key to go back";
        const string ChallengeSelectionMessage = "Select a challenge to view or type 'exit' or 'quit' to quit: ";
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                DisplayMainMenu();

                var chapter = GetValidInput("Select a chapter to view or type 'exit' to quit : ", typeof(int));
                Console.Clear();
                HandleChapterSelection(chapter);
            }
        }

        static void DisplayMainMenu()
        {
            Console.WriteLine("Welcome to the C# Player's guide challenge archive!");
            Console.WriteLine("This is a collection of challenges from the book 'C# Player's Guide' by RB Whitaker.");
            Console.WriteLine("You are on Part 2: Object Oriented Programming.");
            Console.WriteLine("Please select a chapter to view:");
            Console.WriteLine("1. Chapter 1: Enumerations");
            Console.WriteLine("2. Chapter 2: Tuples");
            Console.WriteLine("3. Chapter 3: Classes");
            Console.WriteLine("4. Chapter 4: Information Hiding");
            Console.WriteLine("5. Chapter 5: Properties");
            Console.WriteLine("6. Chapter 6: Static");
            Console.WriteLine("7. Chapter 7: Exercises");
            Console.WriteLine("8. Chapter 8: Inheritance");
            Console.WriteLine("9. Chapter 9: Polymorphism");
            Console.WriteLine("10. Chapter 10: Interfaces");
            Console.WriteLine("11. Chapter 11: Structs");
            Console.WriteLine("12. Chapter 12: Records");
            Console.WriteLine("13. Chapter 13: Generics");
            Console.WriteLine("14. Chapter 14: The Fountain of Objects");
            Console.WriteLine("15. Chapter 15: Some Useful Types");
        }

        static void HandleChapterSelection(object chapter)
        {
            Action response = chapter switch
            {
                0 => () => { Environment.Exit(0); },
                1 => HandleEnumerations,
                2 => HandleTuples,
                3 => HandleClasses,
                4 => HandleInfoHiding,
                5 => HandleProperties,
                6 => HandleStatic,
                7 => HandleExercises,
                8 => HandleInheritance,
                9 => HandlePolymorphism,
                10 => HandleInterfaces,
                11 => HandleStructs,
                12 => HandleRecords,
                13 => HandleGenerics,
                14 => HandleFountain,
                15 => HandleUsefulTypes,
                _ => () => { Console.Clear(); Console.Write(ErrorMessage); Console.ReadKey();
                }
            };
            response();
        }

        static void HandleEnumerations()
        {
            Console.WriteLine("Chapter 1: Enumerations");
            Console.WriteLine("1. Simula's Test");

            var challengeToView = GetValidInput(ChallengeSelectionMessage, typeof(int));
            
            Action response = challengeToView switch
            {
                0 => () => {Environment.Exit(0);},
                1 => ChestEnum.Run,
                _ => () => { Console.Clear(); Console.Write(ErrorMessage); Console.ReadKey(); }
            };
            response();
        }

        static void HandleTuples()
        {
            Console.WriteLine("Chapter 2: Tuples");
            Console.WriteLine("1. Simula's Soup");
            var challengeToView = GetValidInput(ChallengeSelectionMessage, typeof(int));
                
            Action response = challengeToView switch
            {
                0 => () => { Environment.Exit(0); },
                1 => SimulaSoup.Run,
                _ => () => { Console.Clear(); Console.Write(ErrorMessage); Console.ReadKey(); }
            };
            response();
            
        }
        
        static void HandleClasses()
        {
            Console.WriteLine("Chapter 3: Decision Making");
            Console.WriteLine("1. Vin Fletcher's Arrows");
            var challengeToView = GetValidInput(ChallengeSelectionMessage, typeof(int));
            
            Action response = challengeToView switch
            {
                0 => () => { Environment.Exit(0); },
                1 => VinFletcherArrows.Run,
                _ => () => { Console.Clear(); Console.Write(ErrorMessage); Console.ReadKey(); }
            };
            response();
        }
        
        static void HandleInfoHiding()
        {
            Console.WriteLine("Chapter 4: Information Hiding");
            Console.WriteLine("1. Buying Inventory");
            var challengeToView = GetValidInput(ChallengeSelectionMessage, typeof(int));
            Action response = challengeToView switch
            {
                0 => () => { Environment.Exit(0); },
                _ => () => { Console.Clear(); Console.Write(ErrorMessage); Console.ReadKey(); }
            };
            response(); 
        }
        
        static void HandleProperties()
        {
            Console.WriteLine("Chapter 5: Properties");
            Console.WriteLine("1. The Properties of Arrows");
            var challengeToView = GetValidInput(ChallengeSelectionMessage, typeof(int));
            Action response = challengeToView switch
            {
                0 => () => { Environment.Exit(0); },
                _ => () => { Console.Clear(); Console.Write(ErrorMessage); Console.ReadKey(); }
            };
            response();
            
        }
        
        static void HandleStatic()
        {
            Console.WriteLine("Chapter 6: Static");
            Console.WriteLine("1. Arrow Factories");
            Console.WriteLine("2. The Laws of Freach");
            var challengeToView = GetValidInput(ChallengeSelectionMessage, typeof(int));
            Action response = challengeToView switch
            {
                0 => () => { Environment.Exit(0); },
                _ => () => { Console.Clear(); Console.Write(ErrorMessage); Console.ReadKey(); }
            };
            response();
        }
        static void HandleExercises()
        {
            Console.WriteLine("Chapter 7: The Catacombs of Class");
            Console.WriteLine("1. The Point");
            Console.WriteLine("2. The Color");
            Console.WriteLine("3. The Locked Door");
            Console.WriteLine("4. Rock Paper Scissors");
            Console.WriteLine("5. 15 Puzzle");
            Console.WriteLine("6. Hangman");
            Console.WriteLine("7. Tic Tac Toe");
            var challengeToView = GetValidInput(ChallengeSelectionMessage, typeof(int));
            Action response = challengeToView switch
            {
                0 => () => { Environment.Exit(0); },
                _ => () => { Console.Clear(); Console.Write(ErrorMessage); Console.ReadKey(); }
            };
            response();
        }
        static void HandleInheritance()
        {
            Console.WriteLine("Chapter 8: Inheritance");
            Console.WriteLine("1. Packing Inventory");
            var challengeToView = GetValidInput(ChallengeSelectionMessage, typeof(int));
            Action response = challengeToView switch
            {
                0 => () => { Environment.Exit(0); },
                _ => () => { Console.Clear(); Console.Write(ErrorMessage); Console.ReadKey(); }
            };
            response();
        }
        static void HandlePolymorphism()
        {
            Console.WriteLine("Chapter 9: Polymorphism");
            Console.WriteLine("1. Labeling Inventory");
            Console.WriteLine("2. The Old Robot");
            var challengeToView = GetValidInput(ChallengeSelectionMessage, typeof(int));
            Action response = challengeToView switch
            {
                0 => () => { Environment.Exit(0); },
                _ => () => { Console.Clear(); Console.Write(ErrorMessage); Console.ReadKey(); }
            };
            response();
        }
        static void HandleInterfaces()
        {
            Console.WriteLine("Chapter 10: Interfaces");
            Console.WriteLine("1. Robotic Interface");
            var challengeToView = GetValidInput(ChallengeSelectionMessage, typeof(int));
            Action response = challengeToView switch
            {
                0 => () => { Environment.Exit(0); },
                _ => () => { Console.Clear(); Console.Write(ErrorMessage); Console.ReadKey(); }
            };
            response();
        }
        static void HandleStructs()
        {
            Console.WriteLine("Chapter 11: Structs");
            Console.WriteLine("1. Room Coordinates");
            var challengeToView = GetValidInput(ChallengeSelectionMessage, typeof(int));
            Action response = challengeToView switch
            {
                0 => () => { Environment.Exit(0); },
                _ => () => { Console.Clear(); Console.Write(ErrorMessage); Console.ReadKey(); }
            };
            response();
        }
        static void HandleRecords()
        {
            Console.WriteLine("Chapter 12: Records");
            Console.WriteLine("1. War Preparations");
            var challengeToView = GetValidInput(ChallengeSelectionMessage, typeof(int));
            Action response = challengeToView switch
            {
                0 => () => { Environment.Exit(0); },
                _ => () => { Console.Clear(); Console.Write(ErrorMessage); Console.ReadKey(); }
            };
            response();
        }
        static void HandleGenerics()
        {
            Console.WriteLine("Chapter 13: Generics");
            Console.WriteLine("1. Colored Items");
            var challengeToView = GetValidInput(ChallengeSelectionMessage, typeof(int));
            Action response = challengeToView switch
            {
                0 => () => { Environment.Exit(0); },
                _ => () => { Console.Clear(); Console.Write(ErrorMessage); Console.ReadKey(); }
            };
            response();
        }
        static void HandleFountain()
        {
            Console.WriteLine("Chapter 14: The Fountain of Objects");
            Console.WriteLine("1. The Fountain of Objects");
            Console.WriteLine("2. Small, Medium, Large");
            Console.WriteLine("3. Pits");
            Console.WriteLine("4. Maelstroms");
            Console.WriteLine("5. Amaroks");
            Console.WriteLine("6. Getting Armed");
            Console.WriteLine("7. Getting Help");
            var challengeToView = GetValidInput(ChallengeSelectionMessage, typeof(int));
            Action response = challengeToView switch
            {
                0 => () => { Environment.Exit(0); },
                _ => () => { Console.Clear(); Console.Write(ErrorMessage); Console.ReadKey(); }
            };
            response();
        }
        static void HandleUsefulTypes()
        {
            Console.WriteLine("Chapter 15: Some Useful Types");
            Console.WriteLine("1. The Robot Pilot");
            Console.WriteLine("2. Time in the cavern");
            Console.WriteLine("3. Lists of Commands");
            var challengeToView = GetValidInput(ChallengeSelectionMessage, typeof(int));
            Action response = challengeToView switch
            {
                0 => () => { Environment.Exit(0); },
                _ => () => { Console.Clear(); Console.Write(ErrorMessage); Console.ReadKey(); }
            };
            response();
        }
    }
}