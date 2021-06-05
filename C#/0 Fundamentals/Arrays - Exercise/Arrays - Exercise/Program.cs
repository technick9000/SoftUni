using System;
using System.Linq;

namespace Arrays___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            _01Train();
        }

        private static void _01Train()
        {
            int n = int.TryParse(Console.ReadLine(), out n) ? n : 1;
            int[] wagons = { };

            for (int i = 0; i < n; i++)
            {
                int passangers = int.TryParse(Console.ReadLine(), out passangers) ? passangers : 0;
                Array.Resize(ref wagons, wagons.Length + 1);
                wagons[wagons.GetUpperBound(0)] = passangers;
            }

            Console.WriteLine(String.Join(' ', wagons));
            Console.WriteLine(wagons.Sum());
        }
    }
}
