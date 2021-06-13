using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods___Exercise
{
    class _05AddAndSubtract
    {

        public static int Reslove()
        {

            int a, b, c;

            a = int.TryParse(Console.ReadLine(), out a) ? a : 0;
            b = int.TryParse(Console.ReadLine(), out b) ? b : 0;
            c = int.TryParse(Console.ReadLine(), out c) ? c : 0;

            int result = Sum(a, b) - c;

            return result;
        }

        private static int Sum(int a = 0, int b = 0)
        {
            return a + b;
        }
    }
}
