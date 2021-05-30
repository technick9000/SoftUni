using System;

namespace SoftUniLab14_02_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //SumSeconds();
            //BonusScore();
            //SpeedInfo();
            //MetricConverter();
            //TimeAdd15Min();
            //GodzillaVsKong();
            //WorldSwimmingRecord();
            Scholarship();
            

        }

        private static void Scholarship()
        {
            double householdIncome = double.Parse(Console.ReadLine());
            double GPA = double.Parse(Console.ReadLine());
            double minIncome = double.Parse(Console.ReadLine());

            double socialScholarship = 0;
            double gpaScholarship = 0;
            bool eligbleForBoth = false;
            string result = "";

            if (GPA >= 5.5 && minIncome < householdIncome)
            {

                gpaScholarship = GPA * 25;

            }
            else if (GPA >= 5.5 && (householdIncome <= minIncome && GPA >= 4.5))
            {

                socialScholarship = minIncome * 0.35;
                gpaScholarship = GPA * 25;
                eligbleForBoth = true;

            }
            else if (GPA < 5.5 && (householdIncome < minIncome && GPA > 4.5))
            {

                socialScholarship = minIncome * 0.35;


            }


            gpaScholarship = Math.Floor(gpaScholarship);
            socialScholarship = Math.Floor(socialScholarship);


            if (eligbleForBoth)
            {

                if (gpaScholarship >= socialScholarship && gpaScholarship > 0)
                {
                    result = $"You get a scholarship for excellent results {gpaScholarship} BGN";

                }
                else
                {

                    result = $"You get a Social scholarship {socialScholarship} BGN";

                }

            }
            else
            {

                if (gpaScholarship > 0)
                {

                    result = $"You get a scholarship for excellent results {gpaScholarship} BGN";
                }
                else if (socialScholarship > 0)
                {

                    result = $"You get a Social scholarship {socialScholarship} BGN";

                }
                else
                {

                    result = "You cannot get a scholarship!";

                }
            }



            Console.WriteLine(result);
        }

        private static void WorldSwimmingRecord()
        {
            double recordTimeSeconds = double.Parse(Console.ReadLine());
            double distanceMetres = double.Parse(Console.ReadLine());
            double timePerMetreSwum = double.Parse(Console.ReadLine());
            double totalTime;

            double distance = distanceMetres * timePerMetreSwum;
            double resistanceFactor = Math.Floor(distanceMetres / 15) * 12.5;

            totalTime = distance + resistanceFactor;

            if (recordTimeSeconds <= totalTime)
            {
                double timeNeededToBeatRecord = totalTime - recordTimeSeconds;
                Console.WriteLine($"No, he failed! He was {timeNeededToBeatRecord:F2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }
        }

        private static void GodzillaVsKong()
        {

            double budget = double.Parse(Console.ReadLine());
            int staffMembers = int.Parse(Console.ReadLine());
            double singleClothingPrice = double.Parse(Console.ReadLine());

            double decorCost = budget * 0.1;
            double clothingCost = staffMembers * singleClothingPrice;
            double totalCost = 0.00;

            if(staffMembers > 150)
            {
                clothingCost *= 0.90;
            }

            totalCost = decorCost + clothingCost;

            if(totalCost > budget)
            {

                double moneyNeeded = totalCost - budget;

                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyNeeded:F2} leva more.");

            }
            else
            {

                double extraBudget = budget - totalCost;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {extraBudget:F2} leva left.");
            }



        }

        private static void TimeAdd15Min()
        {
            int HH = int.Parse(Console.ReadLine()); //Въвеждане на часовете
            int mm = int.Parse(Console.ReadLine()); //Въвеждане на минутите
            int addMinutes = 15; // допълнителното време което трябва да се добави
            string result = ""; //аз избирам да декларирам празен стринг който да ползвам за изход вместо всеки път да пиша Console.writeLine го пиша само накрая

            if((HH >= 0 || HH <= 23 ) && (mm >=0 || mm <= 59))
            {
                mm += addMinutes;
                if(mm >= 60)
                {

                    HH += 1;
                    mm -= 60;
                    
                    if(HH > 23)
                    {
                        HH -= 24;
                    }
                }
                result = $"{HH}:{mm:D2}";

            }
            else
            {
                result = "Invalid inputs detected! See format -> Hours 0 to 23 && minutes 0 to 59";
            }

            Console.WriteLine(result);
        }

        private static void MetricConverter()
        {

            double entryUnitValue = double.Parse(Console.ReadLine());
            string entryUnitType = Console.ReadLine();
            string outputUnitType = Console.ReadLine();
            double convertedUnitValue = 0.00;

            if(entryUnitValue > 0)
            {

                if(outputUnitType =="mm")
                {

                    if(entryUnitType == "m")
                    {

                        convertedUnitValue = entryUnitValue * 1000;

                    }else if(entryUnitType == "cm")
                    {
                        convertedUnitValue = entryUnitValue * 10;

                    }else if(entryUnitType == "mm")
                    {

                        convertedUnitValue = entryUnitValue;

                    }
                    else
                    {
                        Console.WriteLine("Unsupported Unit type");
                    }

                }
                else if (outputUnitType == "cm")
                {

                    if (entryUnitType == "m")
                    {

                        convertedUnitValue = entryUnitValue * 100;

                    }
                    else if (entryUnitType == "cm")
                    {
                        convertedUnitValue = entryUnitValue;
                    }
                    else if (entryUnitType == "mm")
                    {
                        convertedUnitValue = entryUnitValue / 10;

                    }
                    else
                    {
                        Console.WriteLine("Unsupported Unit type");
                    }

                }
                else if(outputUnitType =="m")
                {
                    if (entryUnitType == "m")
                    {

                        convertedUnitValue = entryUnitValue;

                    }
                    else if (entryUnitType == "cm")
                    {
                        convertedUnitValue = entryUnitValue / 100; 
                    }
                    else if (entryUnitType == "mm")
                    {
                        convertedUnitValue = entryUnitValue / 1000;

                    }
                    else
                    {
                        Console.WriteLine("Unsupported Unit type");
                    }

                }
                else
                {

                    Console.WriteLine("Invalid Output Unit Selection");
                }

            }
            else
            {


                Console.WriteLine("Unit Value must be a number bigger than 0");

            }


            Console.WriteLine($"{convertedUnitValue:F3}");
        }

        private static void SpeedInfo()
        {
            double speed = double.Parse(Console.ReadLine());

            if(speed <= 10)
            {
                Console.WriteLine("slow");
            }
            else if(speed > 10 && speed <= 50)
            {

                Console.WriteLine("average");
            }
            else if(speed > 50 && speed <= 150)
            {
                Console.WriteLine("fast");
            }else if(speed > 150 && speed <= 1000)
            {
                Console.WriteLine("ultra fast");
            }else if(speed > 1000)
            {
                Console.WriteLine("extremely fast");
            }
            else
            {
                Console.WriteLine("invalid speed value");
            }
        }

        private static void BonusScore()
        {
            int number = int.Parse(Console.ReadLine());

            double bonus = 0.0;

            if(number <=100)
            {

                bonus = 5.00;
            }
            else if(number >= 100 && number < 1000)
            {
                bonus = number * 0.20;
            }
            else if(number >=1000)
            {
                bonus = number * 0.10;                
            }

            if(number % 2 == 0)
            {

                bonus += 1;
            }
            else if (number % 10 == 5)
            {
                bonus += 2;
            }

            Console.WriteLine(bonus);
            Console.WriteLine(number + bonus);

        }

        private static void SumSeconds()
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            int totalTime = firstTime + secondTime + thirdTime;

            int minutes = totalTime / 60;
            int seconds = totalTime % 60;

            if(seconds<10)
            {

                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}
