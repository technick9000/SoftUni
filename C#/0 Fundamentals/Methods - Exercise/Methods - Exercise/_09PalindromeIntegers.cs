using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods___Exercise
{
    class _09PalindromeIntegers
    {

        public static void init()
        {
            string command = Console.ReadLine();

            while (command != "END")
            {
                Console.WriteLine(isPalindrome(command));

                command = Console.ReadLine();

            }
        }

        private static bool isPalindrome(string command)
        {
            char[] reversed = command.ToCharArray();
            Array.Reverse(reversed);
            string rCommand = string.Join("", reversed);

            return command == rCommand;
        }

    }
}
