using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods___Exercise
{
    class _04PasswordValidator
    {

        public static void PasswordIsValid(string password = "")
        {

            bool isLongEnough = CheckPasswordLength(password),
                 hasLettersAndDigitsOnly = CheckPasswordContainsLettersAndDigits(password),
                 hasMinDigits = CheckPasswordContainsMinDigits(password, 2);


            if (!isLongEnough)
                Console.WriteLine("Password must be between 6 and 10 characters");

            if (!hasLettersAndDigitsOnly)
                Console.WriteLine("Password must consist only of letters and digits");

            if (!hasMinDigits)
                Console.WriteLine("Password must have at least 2 digits");

            if (isLongEnough && hasLettersAndDigitsOnly && hasMinDigits)
                Console.WriteLine("Password is valid");

        }


        private static bool CheckPasswordContainsMinDigits(string password, int numberOfDigits)
        {
            return password.Count(char.IsDigit) >= numberOfDigits;
        }

        private static bool CheckPasswordContainsLettersAndDigits(string password)
        {
            return password.All(char.IsLetterOrDigit);
        }

        private static bool CheckPasswordLength(string password = "")
        {
            return password.Length >= 6 && password.Length <= 10;
        }

    }
}
