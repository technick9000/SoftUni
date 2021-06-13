using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods___Exercise
{
    class _10TopNumber
    {

        public static void init()
        {
            int number = int.TryParse(Console.ReadLine(), out number) ? number : 1;

            for (int i = 0; i < number; i++)
            {

                if (isTopNumber(i))
                    Console.WriteLine(i);

            }
        }

        public static bool isTopNumber(int i = 1)
        {
            return IsDivisibleBy8(i) && ContainsOddDigit(i);
        }

        private static bool IsDivisibleBy8(int i)
        {
            int sum = 0;

            do
            {
                sum += i % 10;
                i /= 10;
            } while (i > 0);

            return sum % 8 == 0;
        }

        private static bool ContainsOddDigit(int i)
        {
            do
            {

                if ((i % 10) % 2 == 1)
                    return true;

                i /= 10;

            } while (i > 0);



            return false;
        }

    }
}
