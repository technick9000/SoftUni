using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods___Exercise
{
    class _06MiddleCharacters
    {

        public static string getMiddleString(string i = "")
        {
            int charCount = i.Length, index = 0;
            int charsToGet = 0;

            if (charCount % 2 == 1)
            {
                index = charCount / 2;
                charsToGet = 1;
            }
            else
            {
                index = (charCount / 2) - 1;
                charsToGet = 2;
            }

            return i.Substring(index, charsToGet);
        }

    }
}
