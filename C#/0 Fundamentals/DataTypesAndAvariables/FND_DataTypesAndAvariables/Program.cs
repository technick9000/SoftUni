using System;
using System.Numerics;

namespace FND_DataTypesAndAvariables
{
    class Program
    {
        static void Main(string[] args)
        {

            //_01IntegerOperations();
            //_02SumDigits();
            //_03Elevator();
            //_04SumOfChars();
            //_05PrintASCIIRange();
            //_06TheLatinTrio();
            //_07WaterOverflow();
            //_08BeerKegs();
            //_09SpiceMustFlow();
            //_10PokeMon();
            //_11Snowballs();

        }

      

        private static void _01IntegerOperations()
        {

            int first, second, third, fourth;

            int.TryParse(Console.ReadLine(), out first);
            int.TryParse(Console.ReadLine(), out second);
            int.TryParse(Console.ReadLine(), out third);
            int.TryParse(Console.ReadLine(), out fourth);

            Console.WriteLine(((first+second)/third)*fourth);

        }

        private static void _02SumDigits()
        {

            //Stringer/Char loop
            string num = Console.ReadLine();

            int sum = 0;



            for (int i = 0; i < num.Length; i++)
            {
                int current;

                int.TryParse(num[i].ToString(), out current);
                sum += current;

            }

            Console.WriteLine(sum);


            /* Modulus Approach 

            int num = int.Parse(Console.ReadLine());

            int sum = 0;

            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }


            Console.WriteLine(sum);

            */
        }

        private static void _03Elevator()
        {
            //@param n:int - People, @param p:int - Capacity, @return x:int - tripCounter
            int n, p, x = 0;

            int.TryParse(Console.ReadLine(), out n);
            int.TryParse(Console.ReadLine(), out p);

            while(n > 0)
            {
                n -= p;
                x++;
            }

            Console.WriteLine(x);
        }

        private static void _04SumOfChars()
        {

            int inputLines = 0, sum = 0;
            int.TryParse(Console.ReadLine(), out inputLines);

            for (int i = 0; i < inputLines; i++)
            {

                char letter;
                char.TryParse(Console.ReadLine(), out letter);

                sum += (int)letter;

            }

            Console.WriteLine($"The sum equals: {sum}");

        }

        private static void _05PrintASCIIRange()
        {

            int x, y;

            int.TryParse(Console.ReadLine(), out x);
            int.TryParse(Console.ReadLine(), out y);

            for (int i = x; i <= y; i++)
            {

                Console.Write($"{(char) i} ");

            }

        }

        private static void _06TheLatinTrio()
        {

            int n;
            int.TryParse(Console.ReadLine(), out n);

            char first=' ', second=' ', third=' ';

            for (int i = 97; i < (97+n); i++)
            {
                first = (char)i;
                for (int x = 97; x < (97+n); x++)
                {
                    second = (char)x;
                    for (int y = 97; y < (97 + n); y++)
                    {
                        third = (char)y;
                        Console.WriteLine($"{first}{second}{third}");
                    }
                }
               
            }

        }

        private static void _07WaterOverflow()
        {
            int tankVolumeLitres = 255;

            int n = 0, waterQuantity = 0, litresInTank = 0;

            int.TryParse(Console.ReadLine(), out n);

            for (int i = 0; i < n; i++)
            {
                int.TryParse(Console.ReadLine(), out waterQuantity);



                if (tankVolumeLitres >= waterQuantity)
                {
                    tankVolumeLitres -= waterQuantity;
                    litresInTank += waterQuantity;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(litresInTank);
        }

        private static void _08BeerKegs()
        {
            // @param n:int - beerKergs, @requriement lines = 3
            // @requierment lines @children -> j:string = Model, k:double = radius, l:double = height
            // @ helpers biggestKegVolume:double, 
            // formula Math.Pi * math.pow(k,2) * l

            int kegs = 0;
            double k, l, cKegVolume = 0, biggestKeg = double.MinValue;
            string j, biggestKegName = "";

            int.TryParse(Console.ReadLine(), out kegs);

            for (int i = 0; i < kegs; i++)
            {

                j = Console.ReadLine();
                double.TryParse(Console.ReadLine(), out k);
                double.TryParse(Console.ReadLine(), out l);

                cKegVolume = Math.PI * Math.Pow(k, 2) * l;

                if(cKegVolume > biggestKeg)
                {
                    biggestKeg = cKegVolume;
                    biggestKegName = j;
                }

            }

            Console.WriteLine(biggestKegName);
        }

        private static void _09SpiceMustFlow()
        {
            const int exhaustiveConsumptionYield = 26, yieldDropFactor = 10, profitableYieldFactor = 100;
            
            int startingYield, dayCounter = 0, totalSpice = 0;

            int.TryParse(Console.ReadLine(), out startingYield);

            while(startingYield >= profitableYieldFactor)
            {

                dayCounter++;

                totalSpice += startingYield - exhaustiveConsumptionYield;

                startingYield -= yieldDropFactor;

            }

            if(dayCounter !=0) totalSpice -= exhaustiveConsumptionYield;

            Console.WriteLine(dayCounter);
            Console.WriteLine(totalSpice);
        }

        private static void _10PokeMon()
        {
            // @param n:int Poke Power, m:int target distance, y:int exhastion factor

            //Ask persenter about decimal division and int division as 

            int n, m, y;
            int targetsHit = 0, originalPokePower;

            int.TryParse(Console.ReadLine(), out n);
            int.TryParse(Console.ReadLine(), out m);
            int.TryParse(Console.ReadLine(), out y);

            originalPokePower = n;

            while (n >= m)
            {
                targetsHit++;
                n -= m;
                if ((decimal)n / originalPokePower == 0.5M && y > 0) n /= y;
            }

            Console.WriteLine(n);
            Console.WriteLine(targetsHit);
        }

        private static void _11Snowballs()
        {
            // @param n: int Number of snowballs, @n->children @params snowballSnow:int, snowballTime:int, snowballQuality:int , @result snowballValue:double
            // @snowball formula == (snowballSnow / snowballTime) ^ snowballQuality
            // @output format -> {snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})

            int n, snowballSnow = 0, snowballTime = 0, snowballQuality = 0;
            BigInteger snowballValue = 0;
            string result="";

            int.TryParse(Console.ReadLine(), out n);

            for (int i = 0; i < n; i++)
            {

                int.TryParse(Console.ReadLine(), out snowballSnow);
                int.TryParse(Console.ReadLine(), out snowballTime);
                int.TryParse(Console.ReadLine(), out snowballQuality);

                BigInteger cSnowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballValue < cSnowballValue)
                {
                    snowballValue = cSnowballValue;
                    result = $"{snowballSnow} : { snowballTime} = { snowballValue} ({ snowballQuality})";
                }

            }

            Console.WriteLine(result);

        }

    }
}
