namespace The_Basics.Tools
{
    public static class Tools
    {
        public static int GetValidInput(string prompt)
        {
            while (true) {
                Console.Write(prompt);
                var input = Console.ReadLine();
                
                if (input is "exit" or "quit") return 0;
                if (int.TryParse(input, out var value)) return value;
                Console.Clear();
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}