using System;

namespace Group19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //int number;  //объявление
            //number = 10; //инициализация
            //int number2 = 100;
            //number = 10 * 265 + 6616 - 651;
            //number = 10 - number;
            //Console.WriteLine(number);

            //Console.WriteLine();
            //number = 56;
            //double price = (double)number / 10;
            //Console.WriteLine(price);

            //string text = "235";
            //int number3 = int.Parse(text);
            //number3 = number3 + 1;
            //Console.WriteLine(number3);

            //char symbol = 'A';
            //Console.WriteLine(symbol);

            //Console.WriteLine("a"+"b"+"c");
            //Console.WriteLine((int)'1');

            //bool flag = true;
            //flag = true && false;
            //Console.WriteLine(!flag);

            //int number = 10;
            //number += 2;
            //number = number + 2;
            Console.WriteLine("Введите число 1");
            int day2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Считано занчение {0}", day2);

            DateTime date2 = new DateTime(2016, 12, day2, 16, 52, 0);
            DateTime date1 = new DateTime(2016, 12, 15, 18, 41, 0);
            TimeSpan span = date2 - date1;
            Console.WriteLine(span);
            //Console.WriteLine(date.DayOfWeek);

            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("4865132");

        }
    }
}
