using System;
using System.Collections.Generic;

namespace SoftUniLab_NestedLoops_13_03_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Clock();
            //MultiplicationTable();
            //Combinations();
            //SumOfTwoNumbers();
            //Travelling();
            //Buliding();
            CinemaTickets();
        }



        private static void Clock()
        {
            for (int h = 0; h < 24; h++)
            {
                for (int m = 0; m < 60; m++)
                {
                    Console.WriteLine($"{h}:{m}");
                }
            }
        }

        private static void MultiplicationTable()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {

                    Console.WriteLine($"{i} * {j} = {i * j}");

                }
            }
        }
        private static void Combinations()
        {

            int input = int.Parse(Console.ReadLine());
            int counter = 0;
            int x1, x2, x3, result;

            for (x1 = 0; x1 <= input; x1++)
            {
                for (x2 = 0; x2 <= input; x2++)
                {
                    for (x3 = 0; x3 <= input; x3++)
                    {

                        result = x1 + x2 + x3;

                        if (result == input) counter++;


                    }
                }
            }

            Console.WriteLine(counter.ToString());
        }

        private static void SumOfTwoNumbers()
        {
            //    Първи ред – начало на интервала – цяло число в интервала[1...999]
            //    Втори ред – край на интервала – цяло число в интервала[по - голямо от първото число...1000]
            //    Трети ред – магическото число – цяло число в интервала[1...10000]

            int startRange, endRange, magicNumber, counter = 0;

            int.TryParse(Console.ReadLine(), out startRange);
            int.TryParse(Console.ReadLine(), out endRange);
            int.TryParse(Console.ReadLine(), out magicNumber);

            int trueStartRange = Math.Min(startRange, endRange);
            int trueEndRange = Math.Max(startRange, endRange);

            bool resultFound = false;

            for (int i = trueStartRange; i <= trueEndRange; i++)
            {

                for (int j = trueStartRange; j <= trueEndRange; j++)
                {
                    counter++;
                    if (i + j == magicNumber && !resultFound)
                    {
                        resultFound = true;
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicNumber})");
                        break;
                    }


                }



            }

            if (!resultFound)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
            }

        }

        private static void Travelling()
        {

            string destination = "";
            decimal destinationPrice = 0, sumSaved = 0, totalSumSaved = 0;

            while (destination != "End")
            {

                destination = Console.ReadLine();
                decimal.TryParse(Console.ReadLine(), out destinationPrice);

                while (totalSumSaved < destinationPrice)
                {
                    decimal.TryParse(Console.ReadLine(), out sumSaved);
                    totalSumSaved += sumSaved;
                }

                if (totalSumSaved >= destinationPrice && destination != "End")
                {
                    Console.WriteLine($"Going to {destination}!");
                    totalSumSaved = 0;
                }

            }

        }

        private static void Buliding()
        {

            int totalFloors, roomsPerFloor;
            string currentApratmentPrefix, currentFloorRooms = "";

            int.TryParse(Console.ReadLine(), out totalFloors);
            int.TryParse(Console.ReadLine(), out roomsPerFloor);



            for (int cFloor = totalFloors; cFloor > 0; cFloor--)
            {

                currentApratmentPrefix = (cFloor == totalFloors) ? "L" : "A";

                for (int cRoom = 0; cRoom < roomsPerFloor; cRoom++)
                {
                    if (cFloor % 2 == 0 && cFloor != totalFloors)
                    {
                        currentFloorRooms += $"O{cFloor}{cRoom} ";
                    }
                    else
                    {
                        currentFloorRooms += $"{currentApratmentPrefix}{cFloor}{cRoom} ";
                    }

                }

                currentFloorRooms += System.Environment.NewLine;
            }

            Console.WriteLine(currentFloorRooms);

        }

        private static void CinemaTickets()
        {
            string movieTitle = "", ticketType = "";
            int totalHallSeats, totalTickets = 0, cMovieTotalTickets = 0;
            double currentHallOccupancyPercentage, finalStudentOccupancyPercantege, finalStandardOccupancyPercantege, finalKidOccupancyPercantege;
            Dictionary<string, int> tickets = new Dictionary<string, int>();
            Dictionary<string, int> cMovieTickets = new Dictionary<string, int>();

            tickets.Add("student", 0);
            tickets.Add("standard", 0);
            tickets.Add("kid", 0);

            cMovieTickets.Add("student", 0);
            cMovieTickets.Add("standard", 0);
            cMovieTickets.Add("kid", 0);

            while (true)
            {


                movieTitle = Console.ReadLine();

                if (movieTitle == "Finish") break;

                int.TryParse(Console.ReadLine(), out totalHallSeats);

                while (ticketType != "End" && (cMovieTotalTickets < totalHallSeats))
                {

                    ticketType = Console.ReadLine();


                    if (ticketType != "End")
                    {
                        tickets[ticketType]++;
                        cMovieTickets[ticketType]++;
                        totalTickets++;
                        cMovieTotalTickets++;
                    }


                }


                if (movieTitle != "Finish")
                {

                    currentHallOccupancyPercentage = (double)(cMovieTickets["student"] + cMovieTickets["standard"] + cMovieTickets["kid"]) / totalHallSeats * 100;
                    Console.WriteLine($"{movieTitle} - {currentHallOccupancyPercentage:f2}% full.");

                }


                cMovieTickets["student"] = 0;
                cMovieTickets["standard"] = 0;
                cMovieTickets["kid"] = 0;
                ticketType = "";
                cMovieTotalTickets = 0;
            }

            finalStudentOccupancyPercantege = (double) tickets["student"] / totalTickets * 100;
            finalStandardOccupancyPercantege = (double) tickets["standard"] / totalTickets * 100;
            finalKidOccupancyPercantege = (double) tickets["kid"] / totalTickets * 100;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{finalStudentOccupancyPercantege:f2}% student tickets.");
            Console.WriteLine($"{finalStandardOccupancyPercantege:f2}% standard tickets.");
            Console.WriteLine($"{finalKidOccupancyPercantege:f2}% kids tickets.");



        }
    }
}
