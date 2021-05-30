using System;

namespace PogChamp
{
    class Program
    {
        static void Main(string[] args)
        {

            //TriangleArea();
            //Bricks();
            //PointOnSegment();
            //PointInFigure();
            //Sum3Nums();
            //   DateAfter5Days();

        }

        private static void Sum3Nums()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int biggestNum = Math.Max(a, Math.Max(b, c));

            string result = "No";

            if(biggestNum == a)
            {

                if(b + c == a)
                {
                    if (b < c)
                    {
                        result = $"{b} + {c} = {a}";
                    }
                    else
                    {
                        result = $"{c} + {b} = {a}";
                    }
                    
                }  
                
            }else if(biggestNum == b)
            {


                if(a + c == b)
                {
                    if (a < c)
                    {
                        result = $"{a} + {c} = {b}";
                    }
                    else 
                    {
                        result = $"{c} + {a} = {b}";
                    }
                    

                }

            }else if(biggestNum == c)
            {

                if (a + b == c)
                {
                    if (a < b)
                    {
                        result = $"{a} + {b} = {c}";
                    }
                    else
                    {
                        result = $"{b} + {a} = {c}";
                    }
                    
                }
            }

            Console.WriteLine(result);
        }

        private static void PointInFigure()
        {
            //Същото като в промера но с повече писаници :D

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if(x >=2 && x<=12 && y>= -3 && y <= 1)
            {

                Console.WriteLine("in");

            }else if(x>=4 && x<= 10 && y >=-5 && y<=3)
            {

                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }


        }

        private static void PointOnSegment()
        {

            //С Мат функциите е доста по лесно но давай да върви, ползвай вградените функции бе пич не се мъчи
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());


            if (a > b)
            {
                int tmp;
                tmp = a;
                a = b;
                b = tmp;
            }

            
            int distanceFromLeft = a - c;
            int distanceFromRight = b - c;

            distanceFromRight = (distanceFromRight < 0) ? distanceFromRight * -1 : distanceFromRight;
            distanceFromLeft = (distanceFromLeft < 0) ? distanceFromLeft * -1 : distanceFromLeft; 

            if (c >= a && c <= b)
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }

            if(distanceFromLeft > distanceFromRight)
            {

                Console.WriteLine(distanceFromRight);
            }
            else
            {
                Console.WriteLine(distanceFromLeft);
            }


        }

        private static void Bricks()
        {

            int numOfBricks = int.Parse(Console.ReadLine());
            int numOfWorkers = int.Parse(Console.ReadLine());
            int volumePerCart = int.Parse(Console.ReadLine());

            int bricksPerTrip = numOfWorkers * volumePerCart;


            int numOfTrips = numOfBricks / bricksPerTrip; //делим да получим цяло число на трипоовете

            if(numOfBricks % bricksPerTrip != 0) //просто проверяваме ако няма да е цяло число трипа и има останали няколко тухли добавчме последния одд трип
            {
                numOfTrips++;
            }

            // Moже и с Math.Ceiling и кастване в double както е показано в примера, но аз го решавах без да гледам и как аз бих минал
            // Това също работи, така че е напълно относително до индивидуалния подход

            Console.WriteLine(numOfTrips);


        }

        private static void TriangleArea()
        {
            

            int x1 = int.Parse(Console.ReadLine()); 
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());

            int a = Math.Abs(x2 - x3);

            int h = Math.Abs(y2 - y1);

            double S =(double) a * h / 2;

            Console.WriteLine(S);

        }

        private static void DateAfter5Days()
        {
            int d = int.Parse(Console.ReadLine()); // четем деня
            int m = int.Parse(Console.ReadLine()); // четем месеца дори и 01 да е напоисано ще върне 1

            bool leapYear = false; // extra за високосни години игнорирайте

            int[] month30d = { 4, 6, 9, 11 }; // мързи ме да пиша в ифа затова с Array

            int daysInMonth = 31; // by default дни в месеца, тоест ако не е някой от месеците долу в проверката да ползваме тези
            int daysInFuture = 5; // колко дни в бъдеще искаме да гледаме 
            string result = ""; // празен стринг за връщане на отговор

            if (m == 2) // ако въведения месец е февруари провери дали е високосна и дай съответни брой дни който ще презапише горната променлива
            {
                daysInMonth = (!leapYear) ? 28 : 29;

            }
            else if (Array.IndexOf(month30d, m) > -1) // ако месеца съвпада с тези които трябва да имат 30 дни презапиши номера на дните в месеца с 30
            {
                daysInMonth = 30;
            }

            if (d > daysInMonth || d <= 0) // провери ако монке е въвело някой грешен ден това не е задължително да се има, както може и да се направи съответната проверка за месеца въведен от монке-то
            {
                d = daysInMonth;
            }

            d += daysInFuture; // тук събираме въведената дата с дните които искаме да видим в бъдеще

            if (d > daysInMonth)  // тук проверяваме дали резултата от горе е по-голям от дните на месеца който сме подали за да знаем дали да минем на другия месец ако не си остава същият
            {
                d -= daysInMonth; //изваждаме дните които изчислихме горе с тези в месеца за да получим датата от следващият месец
                m += 1; // сменяме месеца с следващият като добавим 1

                if (m > 12)//правим проверка ако сме на декември да минем на януари
                {
                    m = 1;
                }

            }

            result = $"{d}.{m:D2}"; // пишем си резултатът с форматиращо D2 коеото се ползва за цели числа и ако не са двъцифрени или колкото сме посочили ще ги изведе с предвождаща 0 т.е. 1 ще стане 01 автоматично, но 10 ще си остане 10


            Console.WriteLine(result); // Плюй резултатът говедо :D
        }
    }


}
