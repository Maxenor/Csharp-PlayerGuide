namespace OOP.Tools
{
    public static class Tools
    {
        /// <summary>
        /// Get valid input from the user based on the type
        /// </summary>
        /// <param name="prompt"> The text to display</param>
        /// <param name="type"> The type to check</param>
        /// <returns></returns>
        public static object GetValidInput(string prompt, Type type)
        {
            while (true) {
                Console.Write(prompt);
                var input = Console.ReadLine();

                if (type == typeof(string)) return input;
                if (input is "exit" or "quit") return 0;
                if (type == typeof(int) && int.TryParse(input, out var value)) return value;
                
                Console.Clear();
                Console.WriteLine("Invalid input. Please enter a valid input.");
            }
        }
    }
}