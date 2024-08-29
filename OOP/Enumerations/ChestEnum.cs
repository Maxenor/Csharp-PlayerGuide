namespace OOP.Enumerations
{
    public class ChestEnum
    {
        private enum ChestState
        {
            Closed,
            Opened,
            Locked,
            Unlocked
        }

        public static void Run()
        {
            var chestState = ChestState.Closed;

            while (true)
            {
                Console.Write($"The chest is {chestState}, what do you want to do?" +
                              $"\nPossible choices are: Open, Close, Lock, Unlock : ");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "Open" when chestState is ChestState.Closed or ChestState.Unlocked:
                        chestState = ChestState.Opened;
                        Console.WriteLine("You opened the chest");
                        break;
                    case "Close" when chestState is ChestState.Opened:
                        chestState = ChestState.Closed;
                        Console.WriteLine("You closed the chest");
                        break;
                    case "Lock" when chestState is ChestState.Closed:
                        chestState = ChestState.Locked;
                        Console.WriteLine("You locked the chest");
                        break;
                    case "Unlock" when chestState is ChestState.Locked:
                        chestState = ChestState.Unlocked;
                        Console.WriteLine("You unlocked the chest");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}