using System;
using System.Collections.Generic;
using System.Linq;

namespace Methods___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            init();
            // !TO-DO Handle bottom comments

        }

        private static void init()
        {
            const string INVALIDCOUNTMSG = "Invalid Count", INVALIDINDEXMSG = "Invalid index";


            int[] numbers = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            

            string command = "", arg1 = "", arg2 = "";


            while (command != "end")
            {
                command = Console.ReadLine();

                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);


                command = cmdArgs[0];
                arg1 = cmdArgs[1];




                if (command == "exchange")
                {
                    int index = int.TryParse(arg1, out index) ? index : 0;
                    if (index > numbers.Length)
                    {
                        Console.WriteLine(INVALIDINDEXMSG);
                        continue;
                    }

                    numbers = ArrayExchange(numbers, index);
                }

                if (command == "max")
                {

                    if (arg1 == "even")
                    {
                        Console.WriteLine(getMaxEvenIndex(numbers));
                    }
                    else
                    {
                        Console.WriteLine(getMaxOddIndex(numbers));
                    }

                }

                if (command == "min")
                {

                    if (arg1 == "even")
                    {
                        Console.WriteLine(getMinEvenIndex(numbers));
                    }
                    else
                    {
                        Console.WriteLine(getMinOddIndex(numbers));
                    }

                }

                if (command == "first")
                {

                    
                    arg2 = cmdArgs[2];

                    if(int.Parse(arg1) > numbers.Length)
                    {
                        Console.WriteLine(INVALIDCOUNTMSG);
                        continue;
                    }

                    if (arg2 == "even")
                    {

                        getFirstEvenElements(numbers, int.Parse(arg1));

                    }
                    else
                    {
                        getFirstOddElements(numbers, int.Parse(arg1));
                    }

                }

                if (command == "last")
                {


                    arg2 = cmdArgs[2];

                    if (int.Parse(arg1) > numbers.Length)
                    {
                        Console.WriteLine(INVALIDCOUNTMSG);
                        continue;
                    }

                    if (arg2 == "even")
                    {

                        getLastEvenElements(numbers, int.Parse(arg1));

                    }
                    else
                    {
                        getLastOddElements(numbers, int.Parse(arg1));
                    }

                }

            }

            Console.WriteLine("[{0}]", string.Join(", ", numbers));

        }

        private static void getLastOddElements(int[] numbers, int v)
        {
            int[] temp = numbers.Where(x => x % 2 == 1).ToArray();
            temp = temp.ToList().GetRange(temp.Length - v, v).ToArray();

            //probably good to handle use case where there are less even numbers in the array than requested
            Console.WriteLine("[{0}]", string.Join(", ", temp));
        }

        private static void getLastEvenElements(int[] numbers, int v)
        {
            int[] temp = numbers.Where(x => x % 2 == 0).ToArray();
            temp = temp.ToList().GetRange(temp.Length - v, v).ToArray();

            //probably good to handle use case where there are less even numbers in the array than requested
            Console.WriteLine("[{0}]", string.Join(", ", temp));
        }

        private static void getFirstOddElements(int[] numbers, int v)
        {
            int[] temp = numbers.Where(x => x % 2 == 1).ToList().GetRange(0, v).ToArray();
            //probably good to handle use case where there are less even numbers in the array than requested
            Console.WriteLine("[{0}]", string.Join(", ", temp));
        }

        private static void getFirstEvenElements(int[] numbers, int v)
        {
            int[] temp = numbers.Where(x => x % 2 == 0).ToList().GetRange(0,v).ToArray();
            //probably good to handle use case where there are less even numbers in the array than requested
            Console.WriteLine("[{0}]",string.Join(", ", temp));
        }

        private static int getMinEvenIndex(int[] numbers)
        {
            int maxVal = numbers.Where(number => number % 2 == 0).Min();

            return numbers.ToList().IndexOf(maxVal);
        }

        private static int getMinOddIndex(int[] numbers)
        {
            int maxVal = numbers.Where(number => number % 2 == 1).Min();

            return numbers.ToList().IndexOf(maxVal);
        }

        private static int getMaxOddIndex(int[] numbers)
        {
            int maxVal = numbers.Where(number => number % 2 == 1).Max();

            return numbers.ToList().IndexOf(maxVal);
        }

        private static int getMaxEvenIndex(int[] numbers)
        {
            int maxVal = numbers.Where(number => number % 2 == 0).Max();

            return numbers.ToList().IndexOf(maxVal);
        }

        private static int[] ArrayExchange(int[] numbers, int index)
        {

            int[] left = numbers.ToList().GetRange(0, index).ToArray();
            int[] right = numbers.ToList().GetRange(index, numbers.Length - index).ToArray();

            List<int> temp = new List<int>();

            temp.AddRange(right);
            temp.AddRange(left);

            int[] newArray = temp.ToArray();

            //return $"[{string.Join(", ", newArray)}]";
            return newArray;
        }
    }
}
