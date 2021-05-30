using System;

namespace SoftUniProgrammingBasics_ExtraTasks
{
    class PBMore_WhileLoops
    {
        static void Main(string[] args)
        {

            
              
        }

        private static void Dishwasher()
        {
            double detergentBottlesMl = double.Parse(Console.ReadLine()) * 750;
            int counter = 1, dishes = 0, pots = 0;

            while (true)
            {

                string input = Console.ReadLine().Trim().ToLower();

                if (input != "end")
                {

                    double detergentPerWash = (counter % 3 == 0) ? 15 : 5;

                    detergentBottlesMl -= detergentPerWash * int.Parse(input);



                    if (counter % 3 == 0)
                    {
                        pots += int.Parse(input);
                    }
                    else
                    {
                        dishes += int.Parse(input);
                    }


                    if (detergentBottlesMl < 0)
                    {

                        Console.WriteLine($"Not enough detergent, {Math.Abs(detergentBottlesMl)} ml. more necessary!");
                        break;
                    }


                }
                else
                {
                    Console.WriteLine("Detergent was enough!");
                    Console.WriteLine($"{dishes} dishes and {pots} pots were washed.");
                    Console.WriteLine($"Leftover detergent {detergentBottlesMl} ml.");

                    break;
                }

                counter++;
            }
        }
    }
}
