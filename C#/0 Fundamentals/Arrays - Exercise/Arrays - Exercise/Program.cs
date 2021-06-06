using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrays___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //_01Train();
            //_02CommonElements();
            //_03ZigZagArrays();
            //_04ArrayRoatation();
            //_05TopIntegers();
            //_06EqualSums();
            //_07MaxSequenceOfEqualElements();
            //_08MagicSum();
            //_09KaminoFactory();
            //_10LadyBugs();
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
        private static void _02CommonElements()
        {
            string[] arr1 = Console.ReadLine().Split(' ').Select(val => val.Trim()).ToArray();
            string[] arr2 = Console.ReadLine().Split(' ').Select(val => val.Trim()).ToArray();
            var common = arr2.Intersect(arr1);

            foreach (var item in common)
            {
                Console.Write($"{item} ");
            }

        }
        private static void _03ZigZagArrays()
        {
            int n = int.TryParse(Console.ReadLine(), out n) ? n : 1;
            string[] j = new string[n];
            string[] k = new string[n];

            for (int i = 0; i < n; i++)
            {

                string[] x = Console.ReadLine().Split(' ').ToArray();

                if (i % 2 == 0)
                {
                    j[i] = x[0];
                    k[i] = x[1];
                }
                else
                {
                    j[i] = x[1];
                    k[i] = x[0];
                }

            }

            foreach (string item in j)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            foreach (string item in k)
            {
                Console.Write($"{item} ");
            }
        }
        private static void _04ArrayRoatation()
        {
            int[] someArray = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            int n = int.TryParse(Console.ReadLine(), out n) ? n : 1;



            for (int j = 0; j < n; j++)
            {
                int first = someArray[0];
                for (int i = 0; i < someArray.Length - 1; i++)
                {
                    someArray[i] = someArray[i + 1];
                }
                someArray[someArray.Length - 1] = first;
            }

            Console.WriteLine(string.Join(' ', someArray));


        }
        private static void _05TopIntegers()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            for (int i = 0; i < numbers.Length; i++)
            {
                bool print = true;

                for (int j = i + 1; j < numbers.Length; j++)
                {

                    if (numbers[i] <= numbers[j])
                        print = false;

                }

                if (print)
                    Console.Write("{0} ", numbers[i]);
            }
        }
        private static void _06EqualSums()
        {
            int[] numbers = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

            bool found = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0, rightSum = 0, middle = i + 1;


                for (int j = i - 1; j >= 0; j--)
                {
                    leftSum += numbers[j];
                }

                for (int k = i + 1; k < numbers.Length; k++)
                {
                    rightSum += numbers[k];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    found = true;
                    break;
                }
            }

            if (found == false)
                Console.WriteLine("no");
        }
        private static void _07MaxSequenceOfEqualElements()
        {

            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int currLen = 1, maxLen = 0, currVal = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {

                if (numbers[i + 1] == numbers[i])
                {
                    currLen++;

                }
                else
                {
                    currLen = 1;
                }

                if (currLen > maxLen)
                {
                    maxLen = currLen;
                    currVal = numbers[i];
                }
            }

            for (int i = 0; i < maxLen; i++)
            {
                Console.Write("{0} ", currVal);
            }
        }
        private static void _08MagicSum()
        {
            int[] numbers = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            int n = int.TryParse(Console.ReadLine(), out n) ? n : 0;

            for (int i = 0; i < numbers.Length; i++)
            {

                for (int j = numbers.Length - 1; j > i; j--)
                {
                    if (numbers[j] + numbers[i] == n)
                    {
                        Console.WriteLine("{0} {1}", numbers[i], numbers[j]);
                    }
                }

            }
        }
        private static void _09KaminoFactory()
        {
            int n = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            int applicationMaxSequence = 0;
            int mostLeftIndex = int.MaxValue;
            int maxSumOfOnes = 0;

            int bestDna = 1;
            int currentDna = 0;

            int[] result = null;

            while (command != "Clone them!")
            {
                //1!1!0!1
                int[] numbers = command
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int sumOfOnes = 0;
                int maxSequence = 0;
                int currentSequence = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == 0)
                    {
                        currentSequence = 0;
                        continue;
                    }

                    sumOfOnes++;
                    currentSequence++;

                    if (currentSequence > maxSequence)
                    {
                        maxSequence = currentSequence;
                    }
                }

                string targetString = new string('1', maxSequence);
                int currentIndex = string.Join("", numbers).IndexOf(targetString);

                currentDna++;

                if (maxSequence >= applicationMaxSequence && currentIndex < mostLeftIndex ||
                    maxSequence == applicationMaxSequence && currentIndex == mostLeftIndex && sumOfOnes > maxSumOfOnes)
                {
                    applicationMaxSequence = maxSequence;
                    mostLeftIndex = currentIndex;
                    maxSumOfOnes = sumOfOnes;
                    bestDna = currentDna;
                    result = numbers;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestDna} with sum: {maxSumOfOnes}.");
            Console.WriteLine(string.Join(" ", result));
        }
        private static void _10LadyBugs()
        {
            int fieldSize = int.Parse(Console.ReadLine());

            int[] lBugInitialPositionIndex = Console.ReadLine()      // get initial Bug positions
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] ladyBugField = new int[fieldSize];

            for (int i = 0; i < ladyBugField.Length; i++)   //setting '1' on initial bug positions
            {
                if (lBugInitialPositionIndex.Contains(i))
                {
                    ladyBugField[i] = 1;
                }
            }

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] rules = command
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                int initialPosition = int.Parse(rules[0]);
                string direction = rules[1];
                int countOfMoves = int.Parse(rules[2]);

                int newPosition = 0;

                if (countOfMoves < 0)
                {
                    if (direction == "left")
                    {
                        direction = "right";
                        countOfMoves = Math.Abs(countOfMoves);
                    }
                    else if (direction == "right")
                    {
                        direction = "left";
                        countOfMoves = Math.Abs(countOfMoves);
                    }
                }

                if (initialPosition < 0     //check if initial position is out of array or if initial position has NO bug
                   || initialPosition > ladyBugField.Length - 1
                   || ladyBugField[initialPosition] == 0)
                {
                    command = Console.ReadLine();
                    continue;
                }

                if (countOfMoves == 0 && initialPosition >= 0 && initialPosition <= ladyBugField.Length - 1)
                {
                    if (ladyBugField[initialPosition] == 1)
                    {
                        ladyBugField[initialPosition] = 0;
                    }

                }

                switch (direction)
                {

                    case "right":

                        newPosition = initialPosition + countOfMoves; //find new position index

                        ladyBugField[initialPosition] = 0; //both cases initial index gets '0'

                        if (newPosition > ladyBugField.Length - 1) //check if new position index is out of array
                        {
                            ladyBugField[initialPosition] = 0;  //if it is out , cuurent position get '0'-LB flies out of the array
                            break;
                        }
                        else
                        {
                            for (int i = newPosition; i < ladyBugField.Length; i += countOfMoves) // array goes till LB find free index, or goes out of tje field
                            {
                                if (ladyBugField[i] == 0) //if new position has no LB, current LB land here
                                {
                                    ladyBugField[i] = 1;
                                    break;
                                }
                            }

                        }
                        break;

                    case "left":

                        newPosition = initialPosition - countOfMoves;


                        ladyBugField[initialPosition] = 0; //in both cases initial position gets '0'
                        if (newPosition < 0) //if new posiion is out of array initial index of LB gets '0'
                        {
                            ladyBugField[initialPosition] = 0;
                            break;
                        }

                        else
                        {
                            for (int i = newPosition; i >= 0; i -= countOfMoves) //find free index or LB gets out of the array
                            {
                                if (ladyBugField[i] == 0)  //if index is free LB lands here
                                {
                                    ladyBugField[i] = 1;
                                    break;
                                }
                            }

                        }
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", ladyBugField));
        }

    }
}
