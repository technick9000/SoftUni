using System;

namespace First_Course
{
    class Program
    {
        static void Main(string[] args)
        {


            double deposit = double.Parse(Console.ReadLine());
            int deadline = int.Parse(Console.ReadLine());
            double annualInterestPercent = double.Parse(Console.ReadLine());


            double interest = deposit * (annualInterestPercent / 100);
            double interestPerMonth = interest / 12;

            double sum = deposit + deadline * interestPerMonth;
            Console.WriteLine(sum);




        }
    }
}