using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods___Exercise
{
    class _03CharatersInRange
    {

        public static void CharactersInRange(char x, char y)
        {

            if (x < y)
            {
                for (int i = x + 1; i < y; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            else
            {
                for (int i = y + 1; i < x; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
        }
    }
}
