using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods___Exercise
{
    class _07NxNMartix
    {
        public static void Matrice2D()
        {

            int n = int.TryParse(Console.ReadLine(), out n) ? n : 1;

            for (int i = 0; i < n; i++)
            {
                for (int x = 0; x < n; x++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
