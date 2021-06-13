using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods___Exercise
{
    class _01MinNum
    {
        public static int MinNum()
        {

            int minNum = int.MaxValue;

            for (int i = 0; i <= 2; i++)
            {
                int num = int.TryParse(Console.ReadLine(), out num) ? num : minNum;
                if (num < minNum)
                    minNum = num;
            }

            return minNum;
        }
    }
}
