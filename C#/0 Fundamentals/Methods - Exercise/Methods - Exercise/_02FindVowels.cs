using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods___Exercise
{
    class _02FindVowels
    {
        public static int FindVowelsCount(string words)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            char[] input = words.Trim().ToLower().ToCharArray();

            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                for (int y = 0; y < vowels.Length; y++)
                {

                    if (vowels[y] == input[i])
                        count++;

                }
            }

            return count;
        }
    }
}
