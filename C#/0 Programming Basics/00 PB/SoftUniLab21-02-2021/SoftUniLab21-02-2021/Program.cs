using System;
using System.Collections.Generic;

namespace SoftUniLab21_02_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cinema();
            //SummerOutfit();
            //NewHouse();
            //FishingBoat();
            //Journey();
            //OperationsBetweenNumbers();
            //HotelRoom();
            //OnTimeForExam();
            //Volleyball();

            
        }

        private static void Volleyball()
        {
            // Първият ред съдържа думата &quot; leap & quot; (високосна година) или & quot; normal & quot; (невисокосна).
            string yearType = Console.ReadLine().ToLower().Trim();
            // Вторият ред съдържа цялото число p – брой празници в годината(които не са събота и неделя).
            int p = int.Parse(Console.ReadLine());
            // Третият ред съдържа цялото число h – брой уикенди, в които Влади си пътува до родния град.
            int h = int.Parse(Console.ReadLine());

            int playableWeekends = 48;
            double leapYearBonus = (yearType == "leap") ? 0.15 : 0;

            double sofiaFactorial = (double) 3 / 4;
            double holidayFactorial = (double) 2 / 3;
            double gamesInSofia = (playableWeekends - h) * sofiaFactorial;
            double gamesOnHolidays = p * holidayFactorial;


            double gamesAbleToPlay = gamesInSofia + gamesOnHolidays + h;

            if (leapYearBonus > 0) gamesAbleToPlay += gamesAbleToPlay * leapYearBonus;

            Console.WriteLine(Math.Floor(gamesAbleToPlay));
            //Volleyball();
        }

        private static void OnTimeForExam()
        {
            //Първият ред съдържа час на изпита – цяло число от 0 до 23.
            int examH = int.Parse(Console.ReadLine());
            // Вторият ред съдържа минута на изпита – цяло число от 0 до 59.
            int examM = int.Parse(Console.ReadLine());
            // Третият ред съдържа час на пристигане – цяло число от 0 до 23.
            int arrivalH = int.Parse(Console.ReadLine());
            //Четвъртият ред съдържа минута на пристигане – цяло число от 0 до 59.
            int arrivalM = int.Parse(Console.ReadLine());

            int timeStart = 0, timeArrived = 0, timeDifference = 0, outputH = 0, outputM = 0;
            string status = "", output = "";

            /*
              На първият ред отпечатайте:
                 “Late”, ако студентът пристига по-късно от часа на изпита.
                 “On time”, ако студентът пристига точно в часа на изпита или до 30 минути по-рано.
                 “Early”, ако студентът пристига повече от 30 минути преди часа на изпита.
                Ако студентът пристига с поне минута разлика от часа на изпита, отпечатайте на следващия ред:
            
                “mm minutes after the start” за закъснение под час.
                 “hh: mm hours after the start” за закъснение от 1 час или повече.Минутите винаги печатайте с 2 цифри,
                например “1:03”.
            */

            timeStart = examH * 60 + examM;
            timeArrived = arrivalH * 60 + arrivalM;

            timeDifference = timeStart - timeArrived;

            if (timeDifference > 30)
            {

                status = "Early";

                if (timeDifference >= 60)
                {
                    outputH = timeDifference / 60;
                    outputM = timeDifference % 60;
                    output = $"{outputH}:{outputM:d2} hours before the start";
                }
                else
                {
                    output = $"{timeDifference} minutes before the start";
                }

            }
            else if (timeDifference < 0)
            {

                status = "Late";
                timeDifference = Math.Abs(timeDifference);


                if (timeDifference >= 60)
                {
                    outputH = timeDifference / 60;
                    outputM = timeDifference % 60;
                    output = $"{outputH}:{outputM:d2} hours after the start";
                }
                else
                {
                    output = $"{timeDifference} minutes after the start";
                }

            }
            else
            {
                status = "On time";
                if (timeDifference > 0)
                {
                    output = $"{timeDifference} minutes before the start";
                }
            }

            //Console.WriteLine(timeDifference);
            Console.WriteLine(status);
            Console.WriteLine(output);
            //OnTimeForExam();
        }

        private static void HotelRoom()
        {
            // За студио, при повече от 7 нощувки през май и октомври: 5 % намаление.
            // За студио, при повече от 14 нощувки през май и октомври: 30 % намаление.
            // За студио, при повече от 14 нощувки през юни и септември: 20 % намаление.
            // За апартамент, при повече от 14 нощувки, без значение от месеца : 10 % намаление.

            //Console.Write("Enter month here (format e.g. June, May etc.): "); //Ooohlalala Fancy Schmansy labeling! Judge --> Piss off you schmuck
            string month = Console.ReadLine();
            string monthComparison = month.ToLower().Trim();

            //Console.Write("Enter how many nights you'd like to stay: ");
            int stayNights = int.Parse(Console.ReadLine());
            double studioDiscount = 0, apartmentDiscount = 0, studioPrice = 0, apartmentPrice = 0, totalCostStudio, totalCostApartment;

            if (stayNights > 14) apartmentDiscount = 0.1;

            if (monthComparison == "may" || monthComparison == "october")
            {
                studioPrice = 50;
                apartmentPrice = 65;

                if (stayNights > 7 && stayNights <= 14)
                {
                    studioDiscount = 0.05;
                }
                else if (stayNights > 14)
                {
                    studioDiscount = 0.3;
                }

            }
            else if (monthComparison == "june" || monthComparison == "september")
            {
                studioPrice = 75.2;
                apartmentPrice = 68.7;

                if (stayNights > 14)
                {
                    studioDiscount = 0.2;
                }
            }
            else if (monthComparison == "july" || monthComparison == "august")
            {
                studioPrice = 76;
                apartmentPrice = 77;
            }

            if (studioDiscount > 0) studioPrice -= studioPrice * studioDiscount;
            if (apartmentDiscount > 0) apartmentPrice -= apartmentPrice * apartmentDiscount;

            totalCostApartment = stayNights * apartmentPrice;
            totalCostStudio = stayNights * studioPrice;

            Console.WriteLine($"Apartment: {totalCostApartment:f2} lv.");
            Console.WriteLine($"Studio: {totalCostStudio:f2} lv.");

        }

        private static void OperationsBetweenNumbers()
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            // char operand = Console.ReadKey().KeyChar; <- Mоже и така
            char operand = Convert.ToChar(Console.ReadLine()); //Tова ще позволи нулеви инпути и затова си правим проверката долy



            char[] validOperands = { '+', '-', '*', '/', '%' };
            double result = 0;
            string appenderEvenOdd = "even", output = "";

            bool validOperand = (Array.IndexOf(validOperands, operand) >= 0) ? true : false;

            if (!validOperand)
            {
                Console.WriteLine($"Invalid Operand Selection - {operand}! Please try again\n");
                OperationsBetweenNumbers();
                return;
            }

            if (num2 == 0 && (operand == '%' || operand == '/'))
            {
                Console.WriteLine($"Cannot divide {num1} by zero");
                return;
            }

            
            switch (operand)
            {

                case '+':
                    result = num1 + num2;
                    if (result % 2 != 0) appenderEvenOdd = "odd";
                    output = $"{num1} {operand} {num2} = {result} - {appenderEvenOdd}";
                    break;

                case '-':
                    result = num1 - num2;
                    if (result % 2 != 0) appenderEvenOdd = "odd";
                    output = $"{num1} {operand} {num2} = {result} - {appenderEvenOdd}";
                    break;

                case '*':
                    result = num1 * num2;
                    if (result % 2 != 0) appenderEvenOdd = "odd";
                    output = $"{num1} {operand} {num2} = {result} - {appenderEvenOdd}";
                    break;
                case '/':
                    result = num1 / num2;
                    output = $"{num1} {operand} {num2} = {result:f2}";
                    break;
                case '%':
                    result = num1 % num2;
                    output = $"{num1} {operand} {num2} = {result}";
                    break;
                default:
                    break;
            }

            Console.WriteLine(output);
        }
        
        private static void Journey()
        {

            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower().Trim();

            string destination = "";
            string accommodation = "";
            string result = "";

            if (budget <= 100)
            {
                destination = "Bulgaria";
            }
            else if (budget >= 100 && budget <= 1000)
            {
                destination = "Balkans";
            }
            else if (budget > 1000)
            {
                destination = "Europe";
            }

            accommodation = (season == "summer" && destination != "Europe") ? "Camp" : "Hotel";

            switch (destination)
            {
                case "Bulgaria":
                    budget *= (season == "summer") ? 0.3 : 0.7;
                    break;
                case "Balkans":
                    budget *= (season == "summer") ? 0.4 : 0.8;
                    break;
                case "Europe":
                    budget *= 0.9;
                    break;
                default:
                    break;
            }

            //result = $"Somewhere in {destination}{System.Environment.NewLine}{accommodation} - {budget:f2}"; // Тук си играх с един стринг и нова линия инструкции
            //result = $"Somewhere in {destination}\n{accommodation} - {budget:f2}"; BTW judge го пуска да мине и в двата случая


            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{accommodation} - {budget:f2}");
        }

        private static void FishingBoat()
        {
            double groupBudget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower().Trim();
            int fishers = int.Parse(Console.ReadLine());

            double seasonalPrice = 0;
            string result = "";

            bool areFishermenEven = (fishers % 2 == 0) ? true : false;

            /*
             * Горният ред е така наречения шорт хенд иф
             * 
             * Същото е все едно да напишете иф но се събира в един ред, за мързеливците като мен
             * Същото като ето това:
             * 
             * bool areFishermenEven;
             * 
             * if(fishers % 2 ==0)
             * {
             *      areFishermenEven = true;
             * }
             * else
             * {
             *      areFishermenEven = false;
             * }
             * 
             *  Синтаксисът върви както следва:
             *  
             *      (условие) ? ако е вярно : ако не е вярно;
             *      
             *      Пояснения:
             *      ? <-- задаваме въпрос логически -> Това така ли е ? тоест true ---> ако е така значи това ще е стане
             *      ако ли не --> продължаваме
             *      : <-- двете точки са else, тоест ако условието не отговаря или не е вярно, а.к.а false значи ще изпълним след след двтете точки
             *      
             *      !!!! МНОГО ВАЖНО !!!!
             *      В този синтаксис НЯМА else if структуре
             *      имаме само вярно или невярно, a.k.a if/else only
             *      
             *      RealLife examples 
             *      Да задаваме стойност на променливи или ако имаме функция която връща нещо a.k.a return 
             *      e.g. 
             *      public CheckPassword(string inputPassword)
             *      {
             *          string Password = "TheSecretestSecretKappa";
             *          
             *          
             *          return (Password == inputPassword) ? true : false;
             *      }
             * 
             * */

            switch (season)
            {
                case "spring":
                    seasonalPrice = 3000;
                    break;

                case "summer":
                    seasonalPrice = 4200;
                    break;

                case "autumn":
                    seasonalPrice = 4200;
                    break;

                case "winter":
                    seasonalPrice = 2600;
                    break;

                default:
                    break;
            }

            if (fishers <= 6)
            {
                seasonalPrice -= seasonalPrice * 0.1;
            }
            else if (fishers >= 7 && fishers <= 11)
            {
                seasonalPrice -= seasonalPrice * 0.15;
            }
            else if (fishers >= 12)
            {
                seasonalPrice -= seasonalPrice * 0.25;
            }

            if (areFishermenEven && season != "autumn")
            {
                seasonalPrice -= seasonalPrice * 0.05;
            }


            if (groupBudget >= seasonalPrice)
            {
                result = $"Yes! You have {(groupBudget - seasonalPrice):f2} leva left.";

            }
            else
            {
                result = $"Not enough money! You need {(seasonalPrice - groupBudget):f2} leva.";
            }

            Console.WriteLine(result);
        }

        private static void NewHouse()
        {
            string flowerType = Console.ReadLine();
            string flowerTypeComparison = flowerType.ToLower().Trim();
            int flowerQuantity = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            string[] validFlowerList = { "roses", "dahlias", "tulips", "narcissus", "gladiolus" };
            Dictionary<string, double> priceList = new Dictionary<string, double>();

            bool isValidFlowerSelection = (Array.IndexOf(validFlowerList, flowerTypeComparison) >= 0) ? true : false;

            double totalCost = 0, price = 0;
            string result = "";

            priceList.Add("roses", 5);
            priceList.Add("dahlias", 3.8);
            priceList.Add("tulips", 2.8);
            priceList.Add("narcissus", 3);
            priceList.Add("gladiolus", 2.5);

            if (isValidFlowerSelection)
            {

                switch (flowerTypeComparison)
                {
                    case "roses":
                        price = (flowerQuantity > 80) ? priceList[flowerTypeComparison] - (priceList[flowerTypeComparison] * 0.10) : priceList[flowerTypeComparison];
                        break;

                    case "dahlias":
                        price = (flowerQuantity > 90) ? priceList[flowerTypeComparison] - (priceList[flowerTypeComparison] * 0.15) : priceList[flowerTypeComparison];
                        break;

                    case "tulips":
                        price = (flowerQuantity > 80) ? priceList[flowerTypeComparison] - (priceList[flowerTypeComparison] * 0.15) : priceList[flowerTypeComparison];
                        break;

                    case "narcissus":
                        price = (flowerQuantity < 120) ? priceList[flowerTypeComparison] + (priceList[flowerTypeComparison] * 0.15) : priceList[flowerTypeComparison];
                        break;

                    case "gladiolus":
                        price = (flowerQuantity < 80) ? priceList[flowerTypeComparison] + (priceList[flowerTypeComparison] * 0.2) : priceList[flowerTypeComparison];
                        break;

                }

                totalCost = flowerQuantity * price;

                if (budget >= totalCost)
                {
                    result = $"Hey, you have a great garden with {flowerQuantity} {flowerType} and {(budget - totalCost):f2} leva left.";

                }
                else
                {
                    result = $"Not enough money, you need {Math.Abs(budget - totalCost):f2} leva more.";
                }

            }
            else
            {
                result = "Invalid Selection";
            }

            Console.WriteLine(result);
        }

        private static void SummerOutfit()
        {
            double temp = double.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine().ToLower().Trim();

            string Outfit = "", Shoes = "";

            switch (timeOfDay)
            {
                case "morning":
                    if (temp >= 10 && temp <= 18)
                    {
                        Outfit = "Sweatshirt";
                        Shoes = "Sneakers";
                    }
                    else if (temp > 18 && temp <= 24)
                    {
                        Outfit = "Shirt";
                        Shoes = "Moccasins";

                    }
                    else if (temp >= 25)
                    {
                        Outfit = "T-Shirt";
                        Shoes = "Sandals";
                    }
                    break;

                case "afternoon":
                    if (temp >= 10 && temp <= 18)
                    {
                        Outfit = "Shirt";
                        Shoes = "Moccasins";
                    }
                    else if (temp > 18 && temp <= 24)
                    {
                        Outfit = "T-Shirt";
                        Shoes = "Sandals";

                    }
                    else if (temp >= 25)
                    {
                        Outfit = "Swim Suit";
                        Shoes = "Barefoot";
                    }
                    break;

                case "evening":
                    if (temp >= 10)
                    {
                        Outfit = "Shirt";
                        Shoes = "Moccasins";
                    }

                    break;
            }

            Console.WriteLine($"It's {temp} degrees, get your {Outfit} and {Shoes}.");
        }

        private static void Cinema()
        {
            string ticketType = Console.ReadLine().ToLower().Trim();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            double income = 0;

            switch (ticketType)
            {
                case "premiere":
                    income = rows * cols * 12;
                    break;
                case "normal":
                    income = rows * cols * 7.50;
                    break;
                case "discount":
                    income = rows * cols * 5;
                    break;
            }
            Console.WriteLine($"{income:f2} leva");

        }
    }
}
