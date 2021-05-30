using System;

namespace PB_NestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            NumbersPyrmaid();
            //EqualSumEvenOddPosition();
            //SumPrimeNonPrime();
            //TrainTheTrainers();
            //PasswordGenerator();
            //SpecialNumbers();
        }



        private static void NumbersPyrmaid()
        {
            int n, i, j, counter = 1;

            bool isBigger = false;

            int.TryParse(Console.ReadLine(), out n);


            for (i = 1; i <= n; i++)
            {

                for (j = 1; j <= i; j++)
                {

                    if (counter > n)
                    {

                        isBigger = true;
                        break;
                    }

                    Console.Write($"{counter} ");
                    counter++;
                }


                Console.WriteLine();

                if (isBigger)
                {
                    break;
                }

            }

        }


        private static void EqualSumEvenOddPosition()
        {

            int x, y, evenSum = 0, oddSum = 0, letterCounter = 0;

            int.TryParse(Console.ReadLine(), out x);
            int.TryParse(Console.ReadLine(), out y);

            while (x <= y)
            {

                foreach (char letter in Convert.ToString(x))
                {


                    if (letterCounter % 2 == 0)
                    {
                        evenSum += (int)letter;
                    }
                    else
                    {
                        oddSum += (int)letter;
                    }

                    letterCounter++;
                }


                if (evenSum == oddSum) Console.Write($"{x} ");

                letterCounter = 0;
                evenSum = 0;
                oddSum = 0;
                x++;

            }

        }

        private static void SumPrimeNonPrime()
        {

            /*If a number n is not a prime, it can be factored into two factors a and b:

                n = a * b
                Now a and b can't be both greater than the square root of n, since then the product a * b would be greater than sqrt(n) * sqrt(n) = n.
                 So in any factorization of n, at least one of the factors must be smaller than the square root of n, 
                 and if we can't find any factors less than or equal to the square root, n must be a prime.
            */
            int num, min = int.MinValue, max = int.MaxValue, sumPrime = 0, sumNonPrime = 0;

            string n = "";

            bool isPrime = true;

            while (n != "stop")
            {

                n = Console.ReadLine();

                int.TryParse(n, out num);


                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }

                for (int i = 2; i <= Math.Sqrt(num); i++)
                {

                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }

                if (isPrime)
                {
                    sumPrime += num;
                }
                else
                {
                    sumNonPrime += num;
                }

                isPrime = true;
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");



        }

        private static void TrainTheTrainers()
        {

            string presentationName = "";

            double score, presenataionScoreAverage = 0, finalScoreAvarage = 0, totalScoreCounter = 0;

            int n, i, counter = 0;

            int.TryParse(Console.ReadLine(), out n);

            while (presentationName != "Finish")
            {

                presentationName = Console.ReadLine();

                if (n <= 0 || presentationName == "Finish") break;

                for (i = 1; i <= n; i++)
                {

                    double.TryParse(Console.ReadLine(), out score);

                    presenataionScoreAverage += score;
                    totalScoreCounter += score;
                    counter++;
                }

                Console.WriteLine($"{presentationName} - {presenataionScoreAverage / n:f2}.");
                presenataionScoreAverage = 0;
            }

            Console.WriteLine($"Student's final assessment is {totalScoreCounter / counter:f2}.");

        }

        private static void PasswordGenerator()
        {

            int n, l, i, j, k, o, p;



            int.TryParse(Console.ReadLine(), out n);
            int.TryParse(Console.ReadLine(), out l);


            for (i = 1; i <= n; i++)
            {

                for (j = 1; j <= n; j++)
                {

                    for (k = 97; k < (97 + l); k++)
                    {

                        for (o = 97; o < (97 + l); o++)
                        {


                            for (p = 1; p <= n; p++)
                            {

                                if (p > i && p > j) Console.Write($"{i}{j}{(char)k}{(char)o}{p} ");

                            }

                        }

                    }

                }

            }

        }

        private static void SpecialNumbers()
        {

            string k;
            int n, i, j, l;

            bool print = true;

            int.TryParse(Console.ReadLine(), out n);

            for (i = 1111; i <= 9999; i++)
            {


                k = i.ToString();

                for (j = 0; j < k.Length; j++)
                {
                    if (n % Char.GetNumericValue(k[j]) != 0)
                    {
                        print = false;
                    }

                }

                if (print)
                {
                    Console.Write($"{i} ");
                }
                else
                {
                    print = true;
                }

            }

        }
    }
}
