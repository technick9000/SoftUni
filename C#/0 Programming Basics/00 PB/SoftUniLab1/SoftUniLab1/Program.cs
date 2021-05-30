using System;

namespace SoftUniLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Execute

            //Comment out Each function/method below if you want to run individual or certain Tasks
            //Be carefull if you want to run all, its time, memory consuming and might get confusing

            //USD2BGN();
            //Rad2Deg();
            //InterestCalc();
            //booksList();
            //Birthday();
            //CharityCampaign();
            //FruitMarket();
            FishTank();
        }


        public static void USD2BGN()
        {   

            //Inputs
            //Console.WriteLine("Enter USD amount:");
            double usdAmount = double.Parse(Console.ReadLine());
            double exchangeRate = 1.79549;

            //Calculation
            double result = usdAmount * exchangeRate;


            //Output
            Console.WriteLine(result);


        }

        public static void Rad2Deg ()
        {
            //Inputs
            //Console.WriteLine("Enter Radian value:");
            double rads = double.Parse(Console.ReadLine());
            double adjuster = 180;

            //Calculations
            double result = rads * adjuster / Math.PI;

            result = Math.Round(result);

            Console.WriteLine(result);

        }

        public static void InterestCalc()

        {
            //Inputs
            double depositAmount = double.Parse(Console.ReadLine());
            int depositPeriod = int.Parse(Console.ReadLine());
            double interestPercent = double.Parse(Console.ReadLine());

            interestPercent /= 100;

            //Calculations
            double interestOnSumPerMonth = (depositAmount * interestPercent) / 12;

            double amountafter = depositAmount + depositPeriod * interestOnSumPerMonth;
            
            //Output
            Console.WriteLine(amountafter);
        }

        public static void booksList()
        {
            //Inputs
            int pagesInBook = int.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            int numOfDays = int.Parse(Console.ReadLine());

            //Calculations
            double totalTimeForBook = pagesInBook / pagesPerHour;
            double daysToRead = totalTimeForBook / numOfDays;
           
            //Output
            Console.WriteLine(daysToRead);

        }

        public static void Birthday()
        {   
            //Inputs
            double rentSuite = double.Parse(Console.ReadLine());
            double cakeCharge;
            double drinksCharge;
            double entertainerCharge;

            //Calculations
            cakeCharge = 0.20 * rentSuite;
            drinksCharge = 0.55 * cakeCharge;
            //drinksCharge = cakeCharge - 0.45 * cakeCharge;
            entertainerCharge = rentSuite / 3;

            double result = rentSuite + cakeCharge + drinksCharge + entertainerCharge;

            //Output
            Console.WriteLine(result);
        }

        public static void CharityCampaign()
        {   
            //Inputs
            int campaingDays = int.Parse(Console.ReadLine());
            int numberOfChefs = int.Parse(Console.ReadLine());
            int numberOfCakes = int.Parse(Console.ReadLine());
            int numberOfWaffles = int.Parse(Console.ReadLine());
            int numberOfPancakes = int.Parse(Console.ReadLine());

            //Pricelist
            double pricePerCake = 45;
            double pricePerWaffle = 5.80;
            double pricePerPancake = 3.20;

            //Calculations
            double cakeTotalPerDay = numberOfCakes * pricePerCake;
            double waffleTotalPerDay = numberOfWaffles * pricePerWaffle;
            double pancakeTotalPerDay = numberOfPancakes * pricePerPancake;

            double totalSumPerDay = (cakeTotalPerDay + waffleTotalPerDay + pancakeTotalPerDay) * numberOfChefs;
            double totalSumCampaign_BeforeExpenses = totalSumPerDay * campaingDays;

            double totalSumCampaign_AfterExpenses = 0.875 * totalSumCampaign_BeforeExpenses;

            Console.WriteLine(totalSumCampaign_AfterExpenses);


        }

        private static void FruitMarket()
        {
            //Inputs
            Double strawberriesPricePerKg = Double.Parse(Console.ReadLine());
            Double bannasWeightKg = Double.Parse(Console.ReadLine());
            Double orangesWeightKg = Double.Parse(Console.ReadLine());
            Double raspberriesWeightKg = Double.Parse(Console.ReadLine());
            Double strawberriesWeightKg = Double.Parse(Console.ReadLine());

            //Calculations
            double raspberriesPricePerKg = 0.5 * strawberriesPricePerKg;
            double orangesPricePerKg = 0.6 * raspberriesPricePerKg;
            double bannanasPricePerKg = 0.2 * raspberriesPricePerKg;

            double totalBananasPrice = bannanasPricePerKg * bannasWeightKg;
            double totalOrangesPrice = orangesPricePerKg * orangesWeightKg;
            double totalRaspberriesPrice = raspberriesPricePerKg * raspberriesWeightKg;
            double totalStrawberriesPrice = strawberriesPricePerKg * strawberriesWeightKg;

            double totalSum = totalBananasPrice + totalOrangesPrice + totalRaspberriesPrice + totalStrawberriesPrice;
            totalSum = Math.Round(totalSum, 2);
            //Output
            Console.WriteLine(totalSum);

        }

        private static void FishTank()
        {
            //Inputs
            int parallelepipedLength = int.Parse(Console.ReadLine());
            int parallelepipedWidth = int.Parse(Console.ReadLine());
            int parallelepipedHeight = int.Parse(Console.ReadLine());
            double occupiedPercent = double.Parse(Console.ReadLine());

            double aquariumVolumeTotalLiters = (parallelepipedLength * parallelepipedWidth * parallelepipedHeight) * 0.001;
            double aquariumVolumeOccupiedPercent = occupiedPercent * 0.01;
            double aquariumVolumeUnoccupiedPercent = 1 - aquariumVolumeOccupiedPercent;

            double aquariumVolumeRequiredLitres = aquariumVolumeTotalLiters * aquariumVolumeUnoccupiedPercent;

            //Output
            Console.WriteLine(aquariumVolumeRequiredLitres);
        }

    }
}
