using System;

namespace SoftUniLec2_08_08_2020
{
    class Program
    {
        static void Main(string[] args)
        {

            //ExcellentResult();
            //GreaterNumber();
            //EvenOrOdd();
            //numFunnel();
            //PasswordGuess();
            AreaOfFigures();
            //ToyStore();

        }

        private static void AreaOfFigures()
        {
            //switch is better here but wtvs
            string figType = Console.ReadLine();
            double result = 0;

            if(figType=="square")
            {

                double sideSize = double.Parse(Console.ReadLine());
                result = sideSize * sideSize;

            }else if(figType == "rectangle")
            {

                double wSize = double.Parse(Console.ReadLine());
                double hSize = double.Parse(Console.ReadLine());

                result = wSize * hSize;

            }
            else if(figType == "circle")
            {

                double rad = double.Parse(Console.ReadLine());
                result = Math.PI * Math.Pow(rad, 2);

            }else if(figType == "triangle")
            {

                double size1 = double.Parse(Console.ReadLine());
                double size2 = double.Parse(Console.ReadLine());

                result = size1 * size2 / 2;


            }

            Console.WriteLine(Math.Round(result,3));
        }

        private static void PasswordGuess()
        {
            string input = Console.ReadLine();

            string pass = "s3cr3t!P@ssw0rd";

            if (input == pass)
            {

                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }

        }

        private static void numFunnel()
        {
            int num = int.Parse(Console.ReadLine());

            if (num < 100)
            {

                Console.WriteLine("Less than 100");
            }
            else if (num <= 200)
            {
                Console.WriteLine("Between 100 and 200");

            }
            else // here another else if is better just to say above 200, so no negative values result the same but im too lazu
            {
                Console.WriteLine("Greater than 200");
            }
        }

        private static void EvenOrOdd()
        {
            int num = int.Parse(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }

        private static void GreaterNumber()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if(num1 > num2)
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine(num2);
            }
        }

        public static void ExcellentResult()
        {

            double grade = double.Parse(Console.ReadLine());

            if(grade >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }

        }

        //Toy Shop
        public static void ToyStore()
        {

            double tripPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int teddies = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double totalPuzzles = puzzles * 2.60;
            double totalDolls = dolls * 3;
            double totalTeddies = teddies * 4.10;
            double totalMinions = minions * 8.20;
            double totalTrucks = trucks * 2;

            double totalToysOrdered = puzzles + dolls + teddies + minions + trucks;

            double totalSum = totalPuzzles + totalDolls + totalTeddies + totalMinions + totalTrucks;



            if (totalToysOrdered >= 50)
            {

                totalSum *= 0.75;
            }

            totalSum *= 0.90;

            

            if (totalSum > tripPrice)
            {
                double remainingSum = totalSum - tripPrice;
                
                Console.WriteLine($"Yes! {remainingSum:F2} lv left.");
            }
            else
            {
                double neededMoney = tripPrice - totalSum;
                
                Console.WriteLine($"Not enough money! {neededMoney:F2} lv needed.");

            }

        }
    }
}
