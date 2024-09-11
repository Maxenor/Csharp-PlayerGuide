namespace OOP.CatacombsOfClass
{
    public static class ThePasswordValidator
    {
        public static void Run()
        {
            while (true) 
            {
                Console.Write("Please enter a password to validate: ");
                var password = Console.ReadLine();
                if (password != null) {
                    var validator = new PasswordValidator(password);
                    var isValid = validator.Validate(password);
                    Console.WriteLine(isValid ? "Password is valid!" : "Password is invalid!");
                    break;
                }
                Console.WriteLine("Please enter a valid password.");

            }
            
            Console.WriteLine("Press any key to return to the main menu...");
            Console.ReadKey();
        }
        
        private class PasswordValidator(string password)
        {
            public static bool Validate(string password)
            {
                if (password.Length is < 7 or > 13)
                {
                    return false;
                }
                
                var hasUpper = false;
                var hasLower = false;
                var hasDigit = false;
                var hasTorAmpersand = false;

                foreach (var c in password)
                {
                    if (char.IsUpper(c)) hasUpper = true;
                    if (char.IsLower(c)) hasLower = true;
                    if (char.IsDigit(c)) hasDigit = true;
                    if (c is 'T' or '&') hasTorAmpersand = true;

                    // If all conditions are met, no need to continue checking
                    if (hasUpper && hasLower && hasDigit && !hasTorAmpersand) { return true; }
                    
                }

                return hasUpper && hasLower && hasDigit && !hasTorAmpersand;
            }
        }
    }
}