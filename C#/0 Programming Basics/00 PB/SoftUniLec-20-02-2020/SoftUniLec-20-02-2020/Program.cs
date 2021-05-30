using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniLec_20_02_2020
{
    class MainClass
    {
        static void Main(string[] args)
        {
            /*
                The difference between using arrays or dictionaries is mainly simplicity, less code and ease of refactoring if needed.
                Also in some cases execution time is reduced significantly, e.g.
                    In the FruitOrVeg example the switch solution executes in Time: 0.093 s, and that is due to having to go through each switch case.
                    But the FruitOrVeg using arrays solution execution time is Time: 0.040 s. 
                    Of course that is relative with each solution, as for example in the later Fruit Shop excercise the execution time is the same Time: 0.093 s,
                        although code reusability is greatly improved in the dictionary/arrays solution as we can dynamically add more items or change data and readability is far better with less lines of code
            */


            //DayOfTheWeek();
            //WeekendOrWorkday();
            //AnimalType();
            //PersonalTitles();
            //SmallShop();
            //SmallShopWithDictionaries();
            //NumberInRange();
            //WorkingHours();
            //CinemaTicket();
            //FruitOrVegetableWithArrays();
            //FruitOrVegetable();
            //InvalidNumber();
            //FruitShopWithDictionariesArrays();
            //FruitShop();
            //TradeCommissions(); // също може да се направи с речници просто ме домързя, иначе ще стане по-лесно с кратко
            //SkiTrip();



        }

       
        private static void SkiTrip()
        {
            int daysOfStay = int.Parse(Console.ReadLine());
            string typeOfAccomodation = Console.ReadLine().ToLower().Trim();
            string review = Console.ReadLine().ToLower().Trim();

            double totalForStay = 0;
            double discountForLongerStay = 0;
            double price = 0;

            //daysOfStay = (daysOfStay <= 1) ? 1 : daysOfStay - 1; 
            //Използвам същия вар да не си играя с различн Judge не хареса това но in real life дори и да не пренощуваш мисля че пак ще се заплати една нощувка наем
            //but for thes sakes of Judge
            daysOfStay -= 1;

            switch (typeOfAccomodation)
            {

                case "room for one person":

                    price = 18;

                    break;

                case "apartment":


                    if (daysOfStay < 10)
                    {

                        discountForLongerStay = 0.3;


                    }
                    else if (daysOfStay <= 15)
                    {


                        discountForLongerStay = 0.35;


                    }
                    else if (daysOfStay > 15)
                    {

                        discountForLongerStay = 0.5;

                    }

                    price = 25 - (25 * discountForLongerStay);


                    break;


                case "president apartment":

                    if (daysOfStay < 10)
                    {

                        discountForLongerStay = 0.1;


                    }
                    else if (daysOfStay <= 15)
                    {


                        discountForLongerStay = 0.15;


                    }
                    else if (daysOfStay > 15)
                    {

                        discountForLongerStay = 0.2;

                    }

                    price = 35 - (35 * discountForLongerStay);



                    break;

                default:
                    break;
            }




            if (review == "positive")
            {


                price = price + (price * 0.25);


            }
            else if (review == "negative")
            {

                price = price - (price * 0.1);

            }
            else
            {
                // за всеки случай или еррор хандлинг, иначе може само с иф/елсе структура
            }

            totalForStay = daysOfStay * price;
            Console.WriteLine($"{totalForStay:f2}");
        }

        private static void TradeCommissions()
        {
            string city = Console.ReadLine().ToLower().Trim();
            double sales = double.Parse(Console.ReadLine());
            double result;

            //Console.WriteLine(result) e на всеки ред за да не плаче джъджа

            switch (city)
            {
                case "sofia":
                    if (sales > 0 && sales <= 500)
                    {

                        result = sales * 0.05;
                        Console.WriteLine($"{result:f2}");

                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        result = sales * 0.07;
                        Console.WriteLine($"{result:f2}");
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        result = sales * 0.08;
                        Console.WriteLine($"{result:f2}");
                    }
                    else if (sales > 10000)
                    {
                        result = sales * 0.12;
                        Console.WriteLine($"{result:f2}");
                    }
                    else
                    {
                        Console.WriteLine("error");

                    }
                    break;

                case "varna":
                    if (sales > 0 && sales <= 500)
                    {

                        result = sales * 0.045;
                        Console.WriteLine($"{result:f2}");

                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        result = sales * 0.075;
                        Console.WriteLine($"{result:f2}");
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        result = sales * 0.1;
                        Console.WriteLine($"{result:f2}");
                    }
                    else if (sales > 10000)
                    {
                        result = sales * 0.13;
                        Console.WriteLine($"{result:f2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;

                case "plovdiv":
                    if (sales > 0 && sales <= 500)
                    {

                        result = sales * 0.055;
                        Console.WriteLine($"{result:f2}");

                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        result = sales * 0.08;
                        Console.WriteLine($"{result:f2}");
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        result = sales * 0.12;
                        Console.WriteLine($"{result:f2}");
                    }
                    else if (sales > 10000)
                    {
                        result = sales * 0.145;
                        Console.WriteLine($"{result:f2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }

        }

        private static void FruitShop()
        {
            string fruit = Console.ReadLine().ToLower().Trim();
            string day = Console.ReadLine().ToLower().Trim();
            double quantity = double.Parse(Console.ReadLine());
            double result;

            switch (day)
            {

                case "monday":
                case "tuesday":
                case "wednesday":
                case "thursday":
                case "friday":

                    if (fruit == "banana")
                    {
                        result = quantity * 2.5;
                        Console.WriteLine($"{result:f2}");
                    }
                    else if (fruit == "apple")
                    {
                        result = quantity * 1.2;
                        Console.WriteLine($"{result:f2}");
                    }
                    else if (fruit == "orange")
                    {
                        result = quantity * 0.85;
                        Console.WriteLine($"{result:f2}");
                    }
                    else if (fruit == "grapefruit")
                    {
                        result = quantity * 1.45;
                        Console.WriteLine($"{result:f2}");
                    }
                    else if (fruit == "kiwi")
                    {
                        result = quantity * 2.7;
                        Console.WriteLine($"{result:f2}");
                    }
                    else if (fruit == "pineapple")
                    {
                        result = quantity * 5.5;
                        Console.WriteLine($"{result:f2}");
                    }
                    else if (fruit == "grapes")
                    {
                        result = quantity * 3.85;
                        Console.WriteLine($"{result:f2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }



                    break;
                case "saturday":
                case "sunday":
                    if (fruit == "banana")
                    {
                        result = quantity * 2.7;
                        Console.WriteLine($"{result:f2}");
                    }
                    else if (fruit == "apple")
                    {
                        result = quantity * 1.25;
                        Console.WriteLine($"{result:f2}");
                    }
                    else if (fruit == "orange")
                    {
                        result = quantity * 0.9;
                        Console.WriteLine($"{result:f2}");
                    }
                    else if (fruit == "grapefruit")
                    {
                        result = quantity * 1.6;
                        Console.WriteLine($"{result:f2}");
                    }
                    else if (fruit == "kiwi")
                    {
                        result = quantity * 3;
                        Console.WriteLine($"{result:f2}");
                    }
                    else if (fruit == "pineapple")
                    {
                        result = quantity * 5.6;
                        Console.WriteLine($"{result:f2}");
                    }
                    else if (fruit == "grapes")
                    {
                        result = quantity * 4.20; //Blaze it
                        Console.WriteLine($"{result:f2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                    break;
                default:
                    Console.WriteLine("error");
                    break;

            }


        }

        private static void FruitShopWithDictionariesArrays()
        {

            string fruit = Console.ReadLine().ToLower().Trim();
            string day = Console.ReadLine().ToLower().Trim();
            double quantity = double.Parse(Console.ReadLine());

            string[] validDays = { "monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday" };
            string[] validFruits = { "banana", "apple", "orange", "grapefruit", "kiwi", "pineapple", "grapes" };


            bool isValidDay = Array.IndexOf(validDays, day) >= 0 ? true : false;
            bool isValidFruit = Array.IndexOf(validFruits, fruit) >= 0 ? true : false;


            Dictionary<string, double> priceListWeekday = new Dictionary<string, double>();
            Dictionary<string, double> priceListWeekend = new Dictionary<string, double>();

            priceListWeekday.Add("banana", 2.5);
            priceListWeekday.Add("apple", 1.2);
            priceListWeekday.Add("orange", 0.85);
            priceListWeekday.Add("grapefruit", 1.45);
            priceListWeekday.Add("kiwi", 2.7);
            priceListWeekday.Add("pineapple", 5.5);
            priceListWeekday.Add("grapes", 3.85);

            priceListWeekend.Add("banana", 2.7);
            priceListWeekend.Add("apple", 1.25);
            priceListWeekend.Add("orange", 0.9);
            priceListWeekend.Add("grapefruit", 1.6);
            priceListWeekend.Add("kiwi", 3);
            priceListWeekend.Add("pineapple", 5.6);
            priceListWeekend.Add("grapes", 4.20); //Blaze it



            if (isValidDay && isValidFruit)
            {

                double result = 0;
                Dictionary<string, double> priceList = (day == "saturday" || day == "sunday") ? priceListWeekend : priceListWeekday;

                result = quantity * priceList[fruit];

                Console.WriteLine($"{result:f2}");

            }
            else
            {
                Console.WriteLine("error");
            }

        }

        private static void InvalidNumber()
        {
            int num = int.Parse(Console.ReadLine());
            string result = ((num >= 100 && num <= 200) || num == 0) ? "" : "invalid";


            // Горния ред е същото като да направим това ---> if ((num >= 100 && num <= 200) || num == 0) result = "";
            // Прост е синтаксис на така наречения short-hand if или както аз му казвам lazy-if
            // Принципно не е за предпочитане особено в големи проекти, само заради четливост на кода иначе си важи

            Console.WriteLine(result);
        }

        private static void FruitOrVegetable()
        {
            string produce = Console.ReadLine().ToLower().Trim();
            string result = "unknown";

            switch (produce)
            {

                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    result = "fruit";
                    break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    result = "vegetable";
                    break;

            }

            Console.WriteLine(result);
        }

        private static void FruitOrVegetableWithArrays()
        {

            string produce = Console.ReadLine().ToLower().Trim();
            string[] fruits = { "banana", "apple", "kiwi", "cherry", "lemon", "grapes" };
            string[] veggies = { "tomato", "cucumber", "pepper", "carrot" };

            string result = "unknown";

            if (Array.IndexOf(fruits, produce) >= 0) result = "fruit";
            if (Array.IndexOf(veggies, produce) >= 0) result = "vegetable";

            Console.WriteLine(result);

        }

        private static void CinemaTicket()
        {
            string d = Console.ReadLine().ToLower().Trim();
            int result = 0;

            switch (d)
            {
                case "monday":
                case "tuesday":
                case "friday":
                    result = 12;
                    break;
                case "wednesday":
                case "thursday":
                    result = 14;
                    break;
                case "saturday":
                case "sunday":
                    result = 16;
                    break;
            }
            Console.WriteLine(result);
        }

        private static void WorkingHours()
        {
            int h = int.Parse(Console.ReadLine());
            string d = Console.ReadLine().ToLower().Trim();
            string result = "closed";

            switch (d)
            {
                case "monday":
                case "tuesday":
                case "wednesday":
                case "thursday":
                case "friday":
                case "saturday":
                    if (h >= 10 && h <= 18)
                    { result = "open"; }
                    break;
                case "sunday":
                    break;
            }
            Console.WriteLine(result);
        }

        private static void NumberInRange()
        {
            int input = int.Parse(Console.ReadLine());

            if (input >= -100 && input <= 100 && input != 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        private static void SmallShop()
        {
            string product = Console.ReadLine().ToLower().Trim();
            string city = Console.ReadLine().ToLower().Trim();
            double quantity = double.Parse(Console.ReadLine());
            double result = 0;

            switch (product)
            {

                case "coffee":

                    if (city == "sofia")
                    {

                        result = quantity * 0.5;

                    }
                    else if (city == "plovdiv")
                    {
                        result = quantity * 0.4;
                    }
                    else if (city == "varna")
                    {
                        result = quantity * 0.45;
                    }

                    break;

                case "water":
                    if (city == "sofia")
                    {

                        result = quantity * 0.8;

                    }
                    else if (city == "plovdiv")
                    {
                        result = quantity * 0.7;
                    }
                    else if (city == "varna")
                    {
                        result = quantity * 0.7;
                    }

                    break;
                case "beer":
                    if (city == "sofia")
                    {

                        result = quantity * 1.2;

                    }
                    else if (city == "plovdiv")
                    {
                        result = quantity * 1.15;
                    }
                    else if (city == "varna")
                    {
                        result = quantity * 1.1;
                    }

                    break;
                case "sweets":
                    if (city == "sofia")
                    {

                        result = quantity * 1.45;

                    }
                    else if (city == "plovdiv")
                    {
                        result = quantity * 1.30;
                    }
                    else if (city == "varna")
                    {
                        result = quantity * 1.35;
                    }

                    break;
                case "peanuts":
                    if (city == "sofia")
                    {

                        result = quantity * 1.6;

                    }
                    else if (city == "plovdiv")
                    {
                        result = quantity * 1.5;
                    }
                    else if (city == "varna")
                    {
                        result = quantity * 1.55;
                    }

                    break;

            }

            Console.WriteLine(result);
        }

        private static void SmallShopWithDictionaries()
        {
            string product = Console.ReadLine().ToLower().Trim();
            string city = Console.ReadLine().ToLower().Trim();
            double quantity = double.Parse(Console.ReadLine());
            Dictionary<string, double> priceListSofia = new Dictionary<string, double>();
            Dictionary<string, double> priceListPlovdiv = new Dictionary<string, double>();
            Dictionary<string, double> priceListVarna = new Dictionary<string, double>();
            double result = 0;


          

            priceListSofia.Add("coffee", 0.50);
            priceListSofia.Add("water", 0.80);
            priceListSofia.Add("beer", 1.20);
            priceListSofia.Add("sweets", 1.45);
            priceListSofia.Add("peanuts", 1.60);

            priceListPlovdiv.Add("coffee", 0.40);
            priceListPlovdiv.Add("water", 0.70);
            priceListPlovdiv.Add("beer", 1.15);
            priceListPlovdiv.Add("sweets", 1.30);
            priceListPlovdiv.Add("peanuts", 1.50);

            

            priceListVarna.Add("coffee", 0.45);
            priceListVarna.Add("water", 0.70);
            priceListVarna.Add("beer", 1.10);
            priceListVarna.Add("sweets", 1.35);
            priceListVarna.Add("peanuts", 1.55);

            switch (city)
            {

                case "sofia":

                    if (priceListSofia.ContainsKey(product))
                    {

                        result = quantity * priceListSofia[product];

                    }

                    break;

                case "plovdiv":

                    if (priceListVarna.ContainsKey(product))
                    {

                        result = quantity * priceListPlovdiv[product];

                    }

                    break;
                case "varna":

                    if (priceListVarna.ContainsKey(product))
                    {

                        result = quantity * priceListVarna[product];

                    }

                    break;

            }

            Console.WriteLine(result);
        }

        private static void PersonalTitles()
        {
            double age = double.Parse(Console.ReadLine());
            string sex = Console.ReadLine().ToLower().Trim();
            string result = "";

            switch (sex)
            {
                case "m":
                    if (age >= 16)
                    {
                        result = "Mr.";
                    }
                    else
                    {

                        result = "Master";

                    }
                    break;

                case "f":
                    if (age >= 16)
                    {

                        result = "Ms.";

                    }
                    else
                    {


                        result = "Miss";

                    }

                    break;
                default:
                    break;
            }

            Console.WriteLine(result);
        }

        private static void AnimalType()
        {
            string animal = Console.ReadLine().ToLower().Trim();
            string result = "";

            switch (animal)
            {
                case "dog":
                    result = "mammal";
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    result = "reptile";
                    break;
                default:
                    result = "unknown";
                    break;

            }

            Console.WriteLine(result);
        }

        private static void WeekendOrWorkday()
        {
            string day = Console.ReadLine().ToLower().Trim();
            string result = "";

            switch (day)
            {

                case "monday":
                case "tuesday":
                case "wednesday":
                case "thursday":
                case "friday":
                    result = "Working day";
                    break;
                case "saturday":
                case "sunday":
                    result = "Weekend";
                    break;
                default:
                    result = "Error";
                    break;

            }

            Console.WriteLine(result);
        }

        private static void DayOfTheWeek()
        {
            int day = int.Parse(Console.ReadLine());

            string result = "";

            switch (day)
            {
                case 1:
                    result = "Monday";
                    break;
                case 2:
                    result = "Tuesday";
                    break;
                case 3:
                    result = "Wednesday";
                    break;
                case 4:
                    result = "Thursday";
                    break;
                case 5:
                    result = "Friday";
                    break;
                case 6:
                    result = "Saturday";
                    break;
                case 7:
                    result = "Sunday";
                    break;
                default:
                    result = "Error";
                    break;

            }
            Console.WriteLine(result);
        }
    }
}
