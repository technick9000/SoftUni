using System;

namespace SoftUniPBPastExams_29_03_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //ChangeBureau();
            //SuppliesForSchool();
            //CatWalking();
            //MountainRun();
            //EnergyBooster();
            //FitnessCard();
            //FoodForPets();
            //TrekkingMania();
            //CareOfPupper();
            //SuitcasesLoad();
            ChrismtasTourney();
        }

        
        private static void ChangeBureau()
        {
            /*
             QUICK EXPLANATION WHY DECIMAL AND WHY THE LETTER 'M' IN THE DECLARATIONS
              NOW AS MUCH AS WE LIKE THE TERMINATOR MOVIES, TECHNOLOGY ,AND COMPUTERS ESPECIALLY, FOLLOW SPECIFIC INSTRUCTIONS TO OPERATE
              AND HAVE NOT YET ADVANCED ENOUGH, LIKE THE LIQUID COPPER THAT CAN GO THROUG PRISON BARS,
                SO THEY CANT DIFERENTIATE BETWEEN DIFFERENT DATA TYPES ON BIT LEVEL BY THEMSELVES. THATS WHY THE DATA TYPES
                HAVE BEEN ASSIGNED A DIFFERENT LETTER SO THE COMPUTER CAN DISTINGUISH THEM AND FOLLOW THE RULES FOR EACH SPECIFIC DATA TYPE
                E.G THE DOUBLE DATA TYPE HAS THE LETTER 'D' SPECIALLY RESERVED FOR IT, THE FACT THAT WE DON'T WRITE D AFTER EACH NUMBER IN A DECLARED DOUBLE VARIABLE
                IS BECAUSE ITS BEEN DEFAULTED FOR IT, AND THERES NO NEED. SOME SMART CHIMPS HAVE DONE US THE FAVOR. HOWEVER WHEN WE TRY TO ASSIGN A NUMBER WITH DIGITS 
                AFTER THE DECIMAL POINT TO A DECIMAL DATA TYPE IT CRIES, BECAUSE IN REALITY WE ARE TRYING TO ASSIGN A DOUBLE VALUE (DEFAULTED) TO A DECIMAL DATA TYPE.
                SO HERE COMES 'M' TO THE RESCUE, THIS LETTER IS RESERVED FOR THE DECIMAL DATA TYPE DECLARATION THEREFORE WE NEED TO PUT IT AFTER EACH OF OUR NUMBERS.

             IN REGARD TO WHY THE USE OF DECIMAL INSTEAD OF DOUBLE?
                ITS A MORE ACCURATE DATA TYPE, PREFFERED TO USE WHEN WORKING WITH CURRENCY/MONEY, AS IT'S NOT AS LOOSE AS DOUBLE       
             */

            //helpers
            const decimal BITCOINPRICE = 1168, CYN2USD = 0.15M, USD2BGN = 1.76M, EUR2BGN = 1.95M;
            decimal totalBGNBitcoin, totalCYN2USD, totalUSD2BGN, totalBGN2EUR;

            //inputs
            int bitcoinQty;
            decimal CYN, commissionPercentage;


            // На първия ред – броят биткойни. Цяло число в интервала[0…20]
            // На втория ред – броят китайски юана.Реално число в интервала[0.00… 50 000.00]
            // На третия ред – комисионната.Реално число в интервала[0.00... 5.00]
            int.TryParse(Console.ReadLine(), out bitcoinQty);
            decimal.TryParse(Console.ReadLine(), out CYN);
            decimal.TryParse(Console.ReadLine(), out commissionPercentage);

            //Calculate total for the bitcoins in BGN
            totalBGNBitcoin = bitcoinQty * BITCOINPRICE;

            //turn commission into percentage 
            commissionPercentage /= 100;

            //Calculate How much USD for the CYN
            totalCYN2USD = CYN * CYN2USD;

            //Calculate how much BGN for the USD from the BGN
            totalUSD2BGN = totalCYN2USD * USD2BGN;

            //add the BGN from CYN to the total of the bitcoin
            totalBGNBitcoin += totalUSD2BGN;

            //calculate how much is the total BGN in EUR
            totalBGN2EUR = totalBGNBitcoin / EUR2BGN;

            //Calculate and subtract the commission from the above total
            totalBGN2EUR -= totalBGN2EUR * commissionPercentage;

            //print the final result
            Console.WriteLine($"{totalBGN2EUR:f2}");

        }

        private static void SuppliesForSchool()
        {
            //helpers
            const decimal PACKED_PENS_SINGLE_PRICE = 5.80M, PACKED_SHARPIES_SINGLE_PRICE = 7.20M, BOARD_SOLUTION_PRICE_PER_LTR = 1.20M;
            decimal totalCostPens, totalCostSharpies, totalCostBoardSolution, totalFinalCost;


            // Първи ред -брой пакети химикали. Цяло число в интервала[0...100]
            // Втори ред -брой пакети маркери. Цяло число в интервала[0...100]
            // Трети ред -литър препарат за почистване на дъска.Реално число в интервала[0.00…50.00]
            // Четвърти ред -процентът намаление.Цяло число в интервала[0...100]
            //inputs
            int packPensQty, packSharpiesQty;
            decimal litresBoardSolution, discountPercentage;

            //Process inputs
            int.TryParse(Console.ReadLine(), out packPensQty);
            int.TryParse(Console.ReadLine(), out packSharpiesQty);
            decimal.TryParse(Console.ReadLine(), out litresBoardSolution);
            decimal.TryParse(Console.ReadLine(), out discountPercentage);

            //turn discount into percentage decimal for later calculation

            discountPercentage /= 100;

            //calculate price for pens
            totalCostPens = PACKED_PENS_SINGLE_PRICE * packPensQty;

            //calculate price for sharpies
            totalCostSharpies = PACKED_SHARPIES_SINGLE_PRICE * packSharpiesQty;

            //calculate price for total board solution
            totalCostBoardSolution = BOARD_SOLUTION_PRICE_PER_LTR * litresBoardSolution;

            //add figures to the total var
            totalFinalCost = totalCostBoardSolution + totalCostPens + totalCostSharpies;

            //subtract the discount from the final figure
            totalFinalCost -= totalFinalCost * discountPercentage;

            //print final result to 3rd decimal
            Console.WriteLine($"{totalFinalCost:f3}");

        }


        private static void CatWalking()
        {
            //Constants
            const int BURNT_CALS_PER_MIN = 5;
            const decimal MIN_BURNED_CALS = 0.5M;

            //inputs
            // На първия ред - минути разходка на ден - цяло число в интервала[1...50]
            // На втория ред - броят на разходките дневно - цяло число в интервала[1…10]
            // На третия ред - приетите от котката калории на ден – цяло число в интервала[100…4000]

            int walkMins, numWalks, intakeCalories;

            int.TryParse(Console.ReadLine(), out walkMins);
            int.TryParse(Console.ReadLine(), out numWalks);
            int.TryParse(Console.ReadLine(), out intakeCalories);

            //helpers
            int totalCalsBurned;
            decimal totalRequiredCals;

            //we multiply the minutes per walk for the regular calculated per min and then we multiply this 
            totalCalsBurned = (walkMins * BURNT_CALS_PER_MIN) * numWalks;

            //we calculate how much of intake calories have to be burnt for a succesfull walk
            totalRequiredCals = intakeCalories * MIN_BURNED_CALS;

            if (totalRequiredCals > totalCalsBurned)
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {totalCalsBurned}.");
            }
            else
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {totalCalsBurned}.");
            }
        }

        private static void MountainRun()
        {

            //helpers
            const int SLOW_FACTOR_PER_50M_IN_SEC = 30, SLOW_FACTORIAL_METRES = 50;
            decimal travelTime, adjustmentSeconds;
            //inputs
            //1.Рекордът в секунди – реално число в интервала[0.00 … 100000.00]
            //2.Разстоянието в метри – реално число в интервала[0.00 … 100000.00]
            //3.Времето в секунди, за което изкачва 1 м. – реално число в интервала[0.00 … 1000.00]

            decimal currentRecordSeconds, distanceInMetres, secondsPerMetreTravelled;

            decimal.TryParse(Console.ReadLine(), out currentRecordSeconds);
            decimal.TryParse(Console.ReadLine(), out distanceInMetres);
            decimal.TryParse(Console.ReadLine(), out secondsPerMetreTravelled);


            //Calculate time to travel before slowdown
            travelTime = distanceInMetres * secondsPerMetreTravelled;

            //Calculate aditional time after the slowdown with remark below
            //Георги ще се забави в резултат на наклона на терена, резултатът трябва да се закръгли надолу до най - близкото цяло число.
            adjustmentSeconds = Math.Floor(distanceInMetres / SLOW_FACTORIAL_METRES) * SLOW_FACTOR_PER_50M_IN_SEC;

            //add the additional time to the original calculated time
            travelTime += adjustmentSeconds;

            //compare and print

            if (travelTime < currentRecordSeconds)
            {

                Console.WriteLine($"Yes! The new record is {travelTime:f2} seconds.");

            }
            else
            {

                Console.WriteLine($"No! He was {Math.Abs(currentRecordSeconds - travelTime):f2} seconds slower.");

            }

        }

        private static void EnergyBooster()
        {

            //Диня Манго Ананас Малина
            //2 броя(small) 56 лв./ бр. 36.66 лв./ бр. 42.10 лв./ бр. 20 лв./ бр.
            //5 броя(big) 28.70 лв./ бр. 19.60 лв./ бр. 24.80 лв./ бр. 15.20 лв./ бр.

            //helpers
            //why do we multiply - because the prices given are for each in the packeage
            const decimal dualPackWatermelon = 2 * 56M, dualPackMango = 2 * 36.66M, dualPackPineapple = 2 * 42.10M, dualPackRaspberry = 2 * 20M;
            const decimal fivePackWatermelon = 5 * 28.70M, fivePackMango = 5 * 19.60M, fivePackPineapple = 5 * 24.80M, fivePackRaspberry = 5 * 15.20M;
            const decimal discountTier1 = 0.15M, discountTier1Min = 400M, discountTier1Max = 1000M, discountTier2 = 0.5M;

            //inputs
            string orderGelType, orderPackSize;
            decimal orderTotal = 0;
            int orderQty;

            //Get our inputs
            orderGelType = Console.ReadLine().Trim().ToLower();
            orderPackSize = Console.ReadLine().Trim().ToLower();

            int.TryParse(Console.ReadLine(), out orderQty);

            //Create a switch statement for the variable that has more criteria to check against, therefore the Gel Fruit Type wtv
            //we trim and lower our input so we need to right the criterias with lowercase
            switch (orderGelType)
            {


                case "watermelon":
                    //lets check the order Pack size and calculate our total based on it's price for single pack that we declared above
                    if (orderPackSize == "small") orderTotal = orderQty * dualPackWatermelon;
                    if (orderPackSize == "big") orderTotal = orderQty * fivePackWatermelon;

                    break;
                case "mango":
                    if (orderPackSize == "small") orderTotal = orderQty * dualPackMango;
                    if (orderPackSize == "big") orderTotal = orderQty * fivePackMango;

                    break;
                case "pineapple":
                    // WHO LIVES IN A PINEAPPLE UNDER THE SEA?
                    if (orderPackSize == "small") orderTotal = orderQty * dualPackPineapple;
                    if (orderPackSize == "big") orderTotal = orderQty * fivePackPineapple;

                    break;
                case "raspberry":
                    if (orderPackSize == "small") orderTotal = orderQty * dualPackRaspberry;
                    if (orderPackSize == "big") orderTotal = orderQty * fivePackRaspberry;

                    break;

                default:
                    break;
            }

            //After we have calcuylated the total lets now see and apply any discount if applicable of course

            if (orderTotal >= discountTier1Min && orderTotal <= discountTier1Max)
            {

                orderTotal -= orderTotal * discountTier1;

            }
            else if (orderTotal > discountTier1Max)
            {
                orderTotal -= orderTotal * discountTier2;
            }

            Console.WriteLine($"{orderTotal:f2} lv.");
        }

        private static void FitnessCard()
        {

            //Пол Gym Boxing Yoga Zumba Dances Pilates
            //мъж $42 $41 $45 $34 $51 $39
            //жена $35 $37 $42 $31 $53 $37

            //FUCKIN' SEXIST FITNESS CENTRE BUT WTV, LETS DO IT FOR THE FUNZIES

            //helpers
            const decimal GYM_MEMBERSHIP_M = 42M, BOXING_MEMBERSHIP_M = 41M, YOGA_MEMBERSHIP_M = 45M, ZUMBA_MEMBERSHIP_M = 34M, DANCES_MEMBERSHIP_M = 51M, PILATES_MEMBERSHIP_M = 39M;
            const decimal GYM_MEMBERSHIP_F = 35M, BOXING_MEMBERSHIP_F = 37M, YOGA_MEMBERSHIP_F = 42M, ZUMBA_MEMBERSHIP_F = 31M, DANCES_MEMBERSHIP_F = 53M, PILATES_MEMBERSHIP_F = 37M;
            const decimal STUDENT_DISCOUNT = 1 - 0.2M; //why 1-0.2 so we get the 80 percent of the real price and multiply it by this otherwise we will have to subtract, its just to ease our code below
            bool canAfford = false;

            //inputs 
            //asl pls?!?
            string sex, sport;
            decimal age, sumAvailable, currentRequiredSum = 0;

            decimal.TryParse(Console.ReadLine(), out sumAvailable);
            sex = Console.ReadLine().Trim().ToLower();
            decimal.TryParse(Console.ReadLine(), out age);
            sport = Console.ReadLine().Trim();


            //lets build our switch with the variables that we need to check against the most criterias
            switch (sport)
            {

                case "Gym":
                    //lets check the sex input and if our money are going to be enough, then set the bool value accordingly

                    //why do we have a current required sum, we have it to improve the code reusability and readability rather then checking the price in each if stmt for each case in the switch 
                    // and then printing inside of it we just get the current required price and slap it in the end where we need to do our outputs, and also to use for the discount adjustment



                    if (sex == "m")
                    {

                        currentRequiredSum = (age <= 19) ? STUDENT_DISCOUNT * GYM_MEMBERSHIP_M : GYM_MEMBERSHIP_M; //here we check against the age of the customer and if they are eligble for the discount and if so apply it directly to the final required sum
                        canAfford = currentRequiredSum < sumAvailable; // here we directly assign the boolean comparison that will either return a true or a false value based on our condition 
                        // and we repeat the same for each sport and sex below
                    }


                    if (sex == "f")
                    {
                        currentRequiredSum = (age <= 19) ? STUDENT_DISCOUNT * GYM_MEMBERSHIP_F : GYM_MEMBERSHIP_F;
                        canAfford = currentRequiredSum < sumAvailable;
                    }


                    break;
                case "Boxing":

                    if (sex == "m")
                    {
                        currentRequiredSum = (age <= 19) ? STUDENT_DISCOUNT * BOXING_MEMBERSHIP_M : BOXING_MEMBERSHIP_M;
                        canAfford = currentRequiredSum < sumAvailable;
                    }

                    if (sex == "f")
                    {
                        currentRequiredSum = (age <= 19) ? STUDENT_DISCOUNT * BOXING_MEMBERSHIP_F : BOXING_MEMBERSHIP_F;
                        canAfford = currentRequiredSum < sumAvailable;
                    }

                    break;
                case "Yoga":
                    if (sex == "m")
                    {
                        currentRequiredSum = (age <= 19) ? STUDENT_DISCOUNT * YOGA_MEMBERSHIP_M : YOGA_MEMBERSHIP_M;
                        canAfford = currentRequiredSum < sumAvailable;
                    }

                    if (sex == "f")
                    {
                        currentRequiredSum = (age <= 19) ? STUDENT_DISCOUNT * YOGA_MEMBERSHIP_F : YOGA_MEMBERSHIP_F;
                        canAfford = currentRequiredSum < sumAvailable;
                    }

                    break;
                case "Zumba":
                    if (sex == "m")
                    {
                        currentRequiredSum = (age <= 19) ? STUDENT_DISCOUNT * ZUMBA_MEMBERSHIP_M : ZUMBA_MEMBERSHIP_M;
                        canAfford = currentRequiredSum < sumAvailable;
                    }

                    if (sex == "f")
                    {
                        currentRequiredSum = (age <= 19) ? STUDENT_DISCOUNT * ZUMBA_MEMBERSHIP_F : ZUMBA_MEMBERSHIP_F;
                        canAfford = currentRequiredSum < sumAvailable;
                    }

                    break;
                case "Dances":
                    if (sex == "m")
                    {
                        currentRequiredSum = (age <= 19) ? STUDENT_DISCOUNT * DANCES_MEMBERSHIP_M : DANCES_MEMBERSHIP_M;
                        canAfford = currentRequiredSum < sumAvailable;
                    }

                    if (sex == "f")
                    {
                        currentRequiredSum = (age <= 19) ? STUDENT_DISCOUNT * DANCES_MEMBERSHIP_F : DANCES_MEMBERSHIP_F;
                        canAfford = currentRequiredSum < sumAvailable;
                    }

                    break;
                case "Pilates":
                    if (sex == "m")
                    {
                        currentRequiredSum = (age <= 19) ? STUDENT_DISCOUNT * PILATES_MEMBERSHIP_M : PILATES_MEMBERSHIP_M;
                        canAfford = currentRequiredSum < sumAvailable;
                    }

                    if (sex == "f")
                    {
                        currentRequiredSum = (age <= 19) ? STUDENT_DISCOUNT * PILATES_MEMBERSHIP_F : PILATES_MEMBERSHIP_F;
                        canAfford = currentRequiredSum < sumAvailable;
                    }

                    break;

                default:
                    break;
            }


            //and now that we have done our validations above we can use our boolean result to see if the customer can afford the membership or nah, and print the appropriate response a.k.a pay and fuck off or just fuck off
            if (canAfford)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${Math.Abs(sumAvailable - currentRequiredSum):f2} more.");
            }

        }

        private static void FoodForPets()
        {

            //Първоначално се чете един ред:
            // Брой дни – цяло число в диапазона[1…30]
            // Общо количество храна – реално число в диапазона[0.00…10000.00]
            //След това за всеки ден се чете:
            //            o Количество изядена храна от кучето – цяло число в диапазона[10…500]
            //            o Количество изядена храна от котката – цяло число в диапазона[10…500]

            //Main inputs

            int days, cDay;
            decimal foodQty = 0, dogDailyConsumption = 0, dogFoodConsumption = 0, catDailyConsumption = 0, catFoodConsumption = 0, treatConsumption = 0, totalConsumption = 0;

            int.TryParse(Console.ReadLine(), out days);
            decimal.TryParse(Console.ReadLine(), out foodQty);

            //helpers
            const decimal TREAT_FACTORIAL = 0.1M;

            //lets spin our days loop
            for (cDay = 1; cDay <= days; cDay++)
            {
                //lets get our secondary inputs for each day a.k.a our daily noms

                decimal.TryParse(Console.ReadLine(), out dogDailyConsumption);
                decimal.TryParse(Console.ReadLine(), out catDailyConsumption);

                // now its said that every 3rd day they get a treat on top of their regular consupmption so lets calculate how much that is based on the spec
                if (cDay % 3 == 0) treatConsumption += (dogDailyConsumption + catDailyConsumption) * TREAT_FACTORIAL;

                //lets add our daily consumptions to the total consumptions 
                dogFoodConsumption += dogDailyConsumption;
                catFoodConsumption += catDailyConsumption;

            }
            // lets see what is the total consumption for the whole period
            totalConsumption = dogFoodConsumption + catFoodConsumption;

            //now lets print and calculate our percentages at the same time
            Console.WriteLine($"Total eaten biscuits: {Math.Round(treatConsumption)}gr."); //its mention that the treat consumpton needs to be rounded to the nearest number, so lets just use the built in Math.Round function
            Console.WriteLine($"{totalConsumption / foodQty * 100:f2}% of the food has been eaten.");// here we calculate the total consumption against the total food qquantity
            Console.WriteLine($"{dogFoodConsumption / totalConsumption * 100:f2}% eaten from the dog."); // here we we calculate thedog consumption
            Console.WriteLine($"{catFoodConsumption / totalConsumption * 100:f2}% eaten from the cat."); // same as above but for the meow meow

        }

        private static void TrekkingMania()
        {
            //На първия ред – броя на групите от катерачи – цяло число в интервала[1...1000]
            //     За всяка една група на отделен ред – броя на хората в групата – цяло число в интервала[1...1000]

            //inputs
            int groups, cGroup, peoplePerGroup;

            int.TryParse(Console.ReadLine(), out groups);

            //helpers
            //we declare our ranges in variables for ease
            int minMusala = 1, maxMusala = 5, minMontblanc = 6, maxMontblanc = 12, minKilimanjaro = 13, maxKilimanjaro = 25, minK2 = 26, maxK2 = 40, minEverest = 41;
            decimal totalMusala = 0, totalMontblanc = 0, totalKilimanjaro = 0, totalK2 = 0, totalEverest = 0, allTotal = 0;

            //lets spin a loop to go through each one of our groups
            for (cGroup = 1; cGroup <= groups; cGroup++)
            {
                //get our secondary input i.e. the people per each current group
                int.TryParse(Console.ReadLine(), out peoplePerGroup);

                //assign the people to their respective group and mount
                if (peoplePerGroup >= minMusala && peoplePerGroup <= maxMusala)
                {
                    totalMusala += peoplePerGroup;
                }
                else if (peoplePerGroup >= minMontblanc && peoplePerGroup <= maxMontblanc)
                {
                    totalMontblanc += peoplePerGroup;
                }
                else if (peoplePerGroup >= minKilimanjaro && peoplePerGroup <= maxKilimanjaro)
                {
                    totalKilimanjaro += peoplePerGroup;
                }
                else if (peoplePerGroup >= minK2 && peoplePerGroup <= maxK2)
                {
                    totalK2 += peoplePerGroup;
                }
                else if (peoplePerGroup >= minEverest)
                {
                    totalEverest += peoplePerGroup;
                }

                //then we add the current number of people to the total so we can calculate the percentage at the end
                allTotal += peoplePerGroup;
            }


            //here we just print the calculated percentages
            Console.WriteLine($"{(totalMusala / allTotal) * 100:f2}%");
            Console.WriteLine($"{(totalMontblanc / allTotal) * 100:f2}%");
            Console.WriteLine($"{(totalKilimanjaro / allTotal) * 100:f2}%");
            Console.WriteLine($"{(totalK2 / allTotal) * 100:f2}%");
            Console.WriteLine($"{(totalEverest / allTotal) * 100:f2}%");

        }

        private static void CareOfPupper()
        {
            //Lil Cute sub-woofer
            /*
            ░░░░░░░░██████████████████████████████████████████████████░░░░░░
            ░░░░░░██                                            ████  ██░░░░
            ░░░░██                                            ██        ██░░
            ░░██                                              ██          ██
            ░░██    ██    ██    ██    ██████      ██████    ████████      ██
            ░░██    ██    ██    ██  ▒▒░░░░░░▒▒  ▒▒░░░░░░▒▒  ░░██░░░░      ██
            ░░██    ██    ██    ██  ██      ██  ██      ██    ██          ██
            ░░██    ██    ██    ██  ██      ██  ██      ██    ██          ██
            ░░░░▓▓    ████  ████      ██████      ██████      ██        ██▒▒
            ░░░░░░██                                                  ▓▓▒▒░░
            ░░░░░░░░████████████████████████████        ██████████████░░░░░░
            ░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██    ██▓▓▒▒▒▒▒▒▒▒▒▒▓▓░░░░░░
            ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██  ██▒▒░░░░░░░░░░░░░░░░░░░░
            ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██░░░░░░░░░░░░░░░░░░░░░░░░
            ░░░░░░░░░░░░░░░░░░░░░░░░░░░░██▓▓██████▓▓░░░░░░░░░░░░░░░░░░░░░░░░
            ░░░░░░░░░░░░░░░░░░████░░████▓▓▓▓▒▒▒▒▓▓▓▓██░░████░░░░░░░░░░░░░░░░
            ░░░░░░░░░░░░░░░░██▓▓▒▒██▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██▓▓▒▒██░░░░░░░░░░░░░░
            ░░░░░░░░░░░░░░██▓▓▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▒▒▒▒██░░░░░░░░░░░░
            ░░░░░░░░░░░░░░██▓▓▒▒▒▒██▒▒▒▒▒▒▒▒▒▒  ▒▒▒▒▒▒▒▒██▓▓▒▒██░░░░░░░░░░░░
            ░░░░░░░░░░██████▓▓▒▒██▓▓████▒▒▒▒      ▒▒██████▓▓▒▒██░░░░░░░░░░░░
            ░░░░░░░░░░██░░██▓▓▓▓██████  ██▒▒      ████  ████▓▓██░░░░░░░░░░░░
            ░░░░░░░░░░▒▒██▓▓████▓▓████████▒▒      ████████████▒▒░░░░░░░░░░░░
            ░░░░░░░░░░░░░░██▓▓▓▓▓▓▒▒████▒▒          ████▒▒██░░░░░░░░░░░░░░░░
            ░░░░░░░░░░░░░░██▓▓▓▓▓▓▓▓▒▒▒▒    ██▒▒▒▒    ▒▒▓▓██░░░░░░░░░░░░░░░░
            ░░░░░░░░░░░░░░▒▒██▓▓▓▓▓▓░░░░    ██████    ░░██░░░░░░░░░░░░░░░░░░
            ░░░░░░░░░░░░░░░░██▓▓▓▓▓▓░░░░██░░░░██░░░░██░░██░░░░░░░░░░░░░░░░░░
            ░░░░░░░░░░░░░░░░██░░▓▓▓▓██░░░░██████████░░██░░░░░░████░░░░████░░
            ░░░░░░░░░░░░░░░░██░░██████▒▒░░▒▒░░▒▒░░░░▒▒██░░░░██    ████    ██
            ░░░░░░░░░░░░░░░░██████░░██░░██▒▒░░▒▒████░░██░░░░██░░        ░░██
            ░░░░░░░░░░░░░░░░░░░░░░░░██████░░░░░░░░██████░░░░██  ░░████░░  ██
            ░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒░░░░░░░░▒▒▒▒▒▒░░░░▒▒██▓▓▒▒▒▒██▓▓▒▒
            */


            //inputs 
            int availableFoodKg, numericFoodConsumption;
            string foodConsumed = "";

            int.TryParse(Console.ReadLine(), out availableFoodKg);
            //lets turn our food into grams by multiplying it by 1000
            availableFoodKg *= 1000;

            //now lets make our loop to spin until our floof gets adopted
            while (foodConsumed != "Adopted")
            {
                //now we need it to be a string so we can use it aboive in the loop condition
                foodConsumed = Console.ReadLine();

                //and here we need to get the grams in another int variable, if its not a string, this is just so we have it a bit clearer
                int.TryParse(foodConsumed, out numericFoodConsumption);

                //lets just check if our command is not the Adopted, then lets subtract the food from our available quantity
                if (foodConsumed != "Adopted")
                {
                    availableFoodKg -= numericFoodConsumption;
                }
            }

            //then here we just check of our available food has dipped into the negative then we print the appropriate repsonse
            //althjough in all honest i don't know what are we feeding our pupper if it dips into the negative and keeps going but wtv LOGIC
            if (availableFoodKg < 0)
            {
                //here we use the built in func Math.Abs so we can return the positive number not the negative value that is already stored in the variable
                Console.WriteLine($"Food is not enough. You need {Math.Abs(availableFoodKg)} grams more.");

            }
            else
            {
                Console.WriteLine($"Food is enough! Leftovers: {availableFoodKg} grams.");

            }

        }

        private static void SuitcasesLoad()
        {

            //helpers
            const decimal ALLOCATION_FACTORIAL = 0.1M;
            int caseCounter = 0;

            //inputs
            decimal bootVolume = 0, currentCaseVolume = 0;
            string input = "";

            //lets get our boot volume
            decimal.TryParse(Console.ReadLine(), out bootVolume);

            //lets spin our loop to spin until the End command
            while (input != "End")
            {

                input = Console.ReadLine(); // we are getting our input as a string to listen for the command

                decimal.TryParse(input, out currentCaseVolume);//here we parse it to a deicmal whatever you are using, you can use the double and double.parse if you feel better

                if ((caseCounter + 1) % 3 == 0) currentCaseVolume *= 1 + ALLOCATION_FACTORIAL; // we check if 3 cases have been loaded then we need to adjust for the space allocation 10%, why +1 beacuse its every 3rd case loaded and our cases loaded count from 0

                //here we check if we have the space to put the case in the boot, if not then we break out loop as we've ran out of space
                if (currentCaseVolume > bootVolume)
                {

                    break;
                }


                //here we tell the counter to add a 1 except for the time when we receive the command End
                caseCounter += (input != "End") ? 1 : 0;

                //and here we subtract the current case volume from whatever space we have to work with in the boot
                bootVolume -= currentCaseVolume;

            }

            //finally here we check if we need have received an End command that means our loop didnt break due to insuficcient space and we have loaded all our cases
            if (input == "End")
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }
            else //otherwise we have broken our loop and we have ran out of space
            {
                Console.WriteLine("No more space!");
            }

            //print how many cases were actually loaded, no matter if we have ran out of space or not
            Console.WriteLine($"Statistic: {caseCounter} suitcases loaded.");
        }

        private static void ChrismtasTourney()
        {

            //NO HARDCORE GAMBLERS ALLOWED! PLEASE GAMBLE RESPONSIBLY AND PLEASE REMEMBER UR GRAMMA's KNICKERS ARE NOT A VALID BET 

            //helpers
            const decimal WON_REWARD = 20, DAILY_WIN_FACTORIAL = 0.1M, FINAL_WIN_FACTORIAL = 0.2M;
            decimal moneyGathered = 0, dailyWonSum = 0;
            int cDayGamesWon = 0, cDayGamesLost = 0, totalDaysWon = 0, totalDaysLost = 0;
            bool torneyWon = true;

            //inputs 
            int days, cDay;
            string sport = "", result = "";

            //lets read our days that the tourney will take place during
            int.TryParse(Console.ReadLine(), out days);


            //spin up our loop to count our days
            for (cDay = 1; cDay <= days; cDay++)
            {
                //in here we spin up our secondary loop to read each sport and result, i make it an infinite loop and only break it when i receive the Finish string as sport
                while (true)
                {

                    sport = Console.ReadLine(); // read our sport
                    if (sport == "Finish") break; // if our sport then break our while loop
                    result = Console.ReadLine(); // read the result of the sport

                    //now we make ourselves switch statement for if in the fututre we decide to implement more scenarios as draw, goalBasedWin, etc. plus it improves readability and is easy to write altough not always applicable
                    switch (result)
                    {

                        case "win":
                            cDayGamesWon++; //if a win then add it to the daily wins for the 10% calculations
                            totalDaysWon++; //add the win to our total torney wins for the 20% calculation and final tourney win/lose decision
                            break;

                        case "lose":
                            cDayGamesLost++; // same as above but for the lost days
                            totalDaysLost++;
                            break;

                        default:
                            break;
                    }

                }

                //here we get our daily sum and multiply the games won by our reward sum for each game won
                dailyWonSum = cDayGamesWon * WON_REWARD;

                //here we check if our daily won games are more than the lost ones so we can add our 10% adjustment
                if (cDayGamesWon > cDayGamesLost)
                {
                    dailyWonSum += dailyWonSum * DAILY_WIN_FACTORIAL;
                }

                //here we reset our daily sums so they we can use them for the next day in the for loop
                cDayGamesLost = 0;
                cDayGamesWon = 0;

                //and here we add our daily winnings to our total
                moneyGathered += dailyWonSum;

            }

            //here we change our boolean variable with a condition based on the total games won against the lost ones. 
            //Basically if we have more won games than the lost ones, then it will be true and we have won the tournament and vice versa
            torneyWon = totalDaysLost < totalDaysWon;


            // and now we simply just use our boolean expression from above to see if we have won the tourney and then print the apprpriate response
            if (torneyWon)
            {

                moneyGathered += moneyGathered * FINAL_WIN_FACTORIAL;
                Console.WriteLine($"You won the tournament! Total raised money: {moneyGathered:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {moneyGathered:f2}");
            }

        }

    }
}
