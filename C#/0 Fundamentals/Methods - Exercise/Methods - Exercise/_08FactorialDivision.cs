using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods___Exercise
{
    class _08FactorialDivision
    {

        public static double getFactorialDivision(int v1, int v2)
        {
            return (double)getFactorial(v1) / getFactorial(v2);
        }

        private static long getFactorial(int number)
        {

            if (number == 0)
                return 1;

            return getFactorial(number - 1) * number;
        }

    }
}
