using System;
using System.Collections.Generic;

namespace JohnyBlaze
{
    class Program
    {
        static void Main(string[] args)
        {
            //_01Ages();
            //_02Division();
            //_03Vacation();
            //_04PrintNSum();
            //_05Login();
            //_06StrongNumber();
            //_07VendingMachine();
            //_08TriangleOfNumbers();
            //_09DaForceBby();
            _10PeshoRichBoi();

        }


        private static void _01Ages()
        {

            int age;
            string result = "";

            int.TryParse(Console.ReadLine(), out age);

            if (age >= 0 && age <= 2)
            {
                result = "baby";
            }
            else if (age <= 13)
            {
                result = "child";
            }
            else if (age <= 19)
            {
                result = "teenager";
            }
            else if (age <= 65)
            {
                result = "adult";
            }
            else if (age >= 66)
            {
                result = "elder";
            }
            else
            {

                //use this case to handle anything else

            }

            Console.WriteLine(result);

        }
        private static void _02Division()
        {

            int num;

            int.TryParse(Console.ReadLine(), out num);

            string result = "The number is divisible by ";

            if(num % 10 == 0)
            {

                result += "10";

            }
            else if(num % 7 == 0)
            {
                result += "7";
            }
            else if(num % 3 == 0)
            {
                if(num % 2 == 0)
                {
                    result += "6";
                }
                else
                {
                    result += "3";
                }
                
            }
            else if(num % 2 == 0)
            {

                result += "2";

            }
            else
            {
                result = "Not divisible";
            }

            Console.WriteLine(result);
        }


        private static void _03Vacation()
        {

            //inputs
            int groupSize;
            string typeOfGroup, dayOfTheWeek;


            int.TryParse(Console.ReadLine(), out groupSize);
            typeOfGroup = Console.ReadLine().ToLower();
            dayOfTheWeek = Console.ReadLine().ToLower();

            //outputs
            string result = "Total price: ";
            decimal totalPrice = 0M;

            //create dictionaries
            Dictionary<string, decimal> businessPrices = new Dictionary<string, decimal>();
            Dictionary<string, decimal> studentPrices = new Dictionary<string, decimal>();
            Dictionary<string, decimal> regularPrices = new Dictionary<string, decimal>();

            //Populate student prices
            studentPrices.Add("friday", 8.45M);
            studentPrices.Add("saturday", 9.80M);
            studentPrices.Add("sunday", 10.46M);

            //populate business prices
            businessPrices.Add("friday", 10.9M);
            businessPrices.Add("saturday", 15.6M);
            businessPrices.Add("sunday", 16M);


            //populate regular prices
            regularPrices.Add("friday", 15M);
            regularPrices.Add("saturday", 20M);
            regularPrices.Add("sunday", 22.5M);

            decimal priceToUse;


            switch (typeOfGroup)
            {
                case "students":
                    priceToUse = studentPrices[dayOfTheWeek];

                    if (groupSize >= 30) priceToUse -= priceToUse * 0.15M;

                    break;

                case "business":
                    priceToUse = businessPrices[dayOfTheWeek];

                    if (groupSize >= 100) groupSize -= 10;

                    break;
                
                default:
                    priceToUse = regularPrices[dayOfTheWeek];

                    if (groupSize >= 10 && groupSize <= 20) priceToUse -= priceToUse * 0.05M;

                    break;
            }

            totalPrice = priceToUse * groupSize;

            result += $"{totalPrice:f2}";

            Console.WriteLine(result);
        }

        private static void _04PrintNSum()
        {

            int a, b, sum = 0;

            int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);

            string numbersList = String.Empty;

            do
            {
                numbersList += $"{a} ";

                sum += a;
                a++;

            } while (a <= b);

            Console.WriteLine(numbersList);
            Console.WriteLine($"Sum: {sum}");
        }

        private static void _05Login()
        {

            string userName = Console.ReadLine();
            char[] emaNresu = userName.ToCharArray();
            string superSecretPasswordMufucka;

            Array.Reverse(emaNresu);

            string guess = new string(emaNresu);

            byte tries = 3;
            for (byte i = 0; i <= tries; i++)
            {

                superSecretPasswordMufucka = Console.ReadLine();

                if (superSecretPasswordMufucka == guess)
                {
                    Console.WriteLine($"User {userName} logged in.");
                    break;
                }
                else if (tries == i)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    break;
                }

                Console.WriteLine("Incorrect password. Try again.");
            }

        }


        private static void _06StrongNumber()
        {

            string input = Console.ReadLine();
            char[] number = input.ToCharArray();

            int sum = 0;

            for(int i = 0; i < number.Length; i++)
            {
                int useCaseNumber;
                int factorial = 1;
                int.TryParse(number[i].ToString(), out useCaseNumber);

                for(int x = 1; x <= useCaseNumber; x++)
                {
                    factorial *= x;
                }

                sum += factorial;
            }

            Console.WriteLine((sum == int.Parse(input)) ? "yes" : "no");

        }

        private static void _07VendingMachine()
        {
            string cmd = "";
            decimal sumInserted = 0;

            while (cmd != "start")
            {
                cmd = Console.ReadLine().Trim().ToLower();

                if (cmd != "start")
                {
                    decimal coinInserted;

                    decimal.TryParse(cmd, out coinInserted);

                    if (coinInserted != 0.1M && coinInserted != 0.2M && coinInserted != 0.5M && coinInserted != 1M && coinInserted != 2M)
                    {
                        Console.WriteLine($"Can not accept {coinInserted}");
                    }
                    else
                    {
                        sumInserted += coinInserted;
                    }
                }

            }

            while (cmd != "end")
            {

                
                cmd = Console.ReadLine().ToLower().Trim();

                switch (cmd)
                {
                    case "nuts":
                        if (sumInserted >= 2)
                        {
                            Console.WriteLine($"Purchased {cmd}");
                            sumInserted -= 2;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;


                    case "water":
                        if (sumInserted >= 0.7M)
                        {
                            Console.WriteLine($"Purchased {cmd}");
                            sumInserted -= 0.7M;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;


                    case "crisps":
                        if (sumInserted >= 1.5M)
                        {
                            Console.WriteLine($"Purchased {cmd}");
                            sumInserted -= 1.5M;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;


                    case "soda":
                        if (sumInserted >= 0.8M)
                        {
                            Console.WriteLine($"Purchased {cmd}");
                            sumInserted -= 0.8M;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;


                    case "coke":
                        if (sumInserted >= 1)
                        {
                            Console.WriteLine($"Purchased {cmd}");
                            sumInserted -= 1;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;

                    case "end":
                        break;

                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }



            }

            Console.WriteLine($"Change: {sumInserted:f2}");

        }

        private static void _08TriangleOfNumbers()
        {

            int num;

            int.TryParse(Console.ReadLine(), out num);

            for(int i = 1; i<=num; i++)
            {
                for(int x = 1; x<=i; x++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }

        }

        private static void _09DaForceBby()
        {

            decimal sumAvailable, lightsaberUnitCost, robesUnitCost, beltsUnitCost;
            int numberOfStudents, freeBelts = 0;

            decimal.TryParse(Console.ReadLine(), out sumAvailable);
            int.TryParse(Console.ReadLine(), out numberOfStudents);
            decimal.TryParse(Console.ReadLine(), out lightsaberUnitCost);
            decimal.TryParse(Console.ReadLine(), out robesUnitCost);
            decimal.TryParse(Console.ReadLine(), out beltsUnitCost);


            if(numberOfStudents >= 6)
            {

                freeBelts = numberOfStudents / 6;

            }

            decimal lightSaberCost = (decimal) (numberOfStudents + Math.Ceiling(numberOfStudents * 0.1)) * lightsaberUnitCost;
            decimal robesCost = robesUnitCost * numberOfStudents;
            decimal beltsCost = beltsUnitCost * (numberOfStudents - freeBelts);
            decimal totalCost = lightSaberCost + robesCost + beltsCost;

            if(sumAvailable >= totalCost)
            {
                Console.WriteLine($"The money is enough - it would cost {totalCost:f2}lv.");
            }
            else
            {
                //WHO DA FUCK IS FUCKIN' JOHN ?!?!?!?
                Console.WriteLine($"John will need {totalCost - sumAvailable:f2}lv more.");
            }
        }


        private static void _10PeshoRichBoi()
        {
            //inputs
            int lostGames;
            decimal headsetUnitPrice, mouseUnitPrice, keybouardUnitPrice, displayUnitPrice;

            int.TryParse(Console.ReadLine(), out lostGames);
            decimal.TryParse(Console.ReadLine(), out headsetUnitPrice);
            decimal.TryParse(Console.ReadLine(), out mouseUnitPrice);
            decimal.TryParse(Console.ReadLine(), out keybouardUnitPrice);
            decimal.TryParse(Console.ReadLine(), out displayUnitPrice);

            //helpers
            decimal totalExpenses = 0;

            totalExpenses += headsetUnitPrice * (lostGames / 2) + mouseUnitPrice * (lostGames / 3) + keybouardUnitPrice * (lostGames / 6) + displayUnitPrice * (lostGames / 12);

            Console.WriteLine($"Rage expenses: {totalExpenses:f2} lv.");
        }

    }
}
