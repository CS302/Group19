using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Свойства и методы для строк
            //string text = "\a";
            ////text = "первая641331\rвторая";
            //string[] symbols = new string[] {"\\", "|", "/", "-" };
            //for (int i = 0; i < 10000; i++)
            //{
            //    Console.Write(symbols[i%4]+"\r");
            //    Thread.Sleep(100);
            //}

            //            string path = @"C:\Lesson5\1.txt";
            //            //path = Console.ReadLine();
            //            Console.WriteLine("наши занятия 'сложные'");

            //            path = @"первая
            //вторая строка
            //                третья строка";
            //            Console.WriteLine(path);

            //string text = "простая строка";
            //Console.WriteLine(text.Length);
            //Console.WriteLine(text[text.Length - 1]);

            //Console.WriteLine(text.CompareTo("Пложная строка"));
            //Console.WriteLine(text.Contains("стр"));
            //Console.WriteLine(text.Insert(0, "Это "));
            //Console.WriteLine(text.Remove(8, 3));

            //Console.WriteLine(text.Replace("простая", "сложная"));

            //string data = "6551 651696 846 463 6 64 63";
            //string[] items = data.Split(' '); // {"6551", "651696", ..}
            //int sum = 0;
            //for (int i = 0; i < items.Length; i++)
            //{
            //    sum += int.Parse(items[i]);
            //}
            //Console.WriteLine(sum);

            //data = String.Join(" ", items);
            //Console.WriteLine(data);

            //string username = "|user|";
            //Console.WriteLine(username);
            //username = username.Trim('|');
            //Console.WriteLine(username);

            //int n = 1000000;
            //string data = String.Empty; //""

            //Console.WriteLine(data);

            //StringBuilder text = new StringBuilder();
            //Console.WriteLine(text.Capacity);
            //for (int i = 0; i < n; i++)
            //{
            //    text.Append(i);
            //}
            //Console.WriteLine(text.Length);
            //Console.WriteLine(text.MaxCapacity); 
            #endregion

            string message = String.Format("Координата X = {0}\nКоордината Y = {1}, еще раз X = {0}, Y = {1}", 10, 15);


            Console.WriteLine(message);

            double price = 99.9999;
            Console.WriteLine("Цена = {0}", price);
            Console.WriteLine();
            Console.WriteLine("Цена = {0:e}", price);
            Console.WriteLine();
            Console.WriteLine("Цена = {0:c}", price);
            Console.WriteLine();
            Console.WriteLine("Цена = {0:.####}", price);

            DateTime date = DateTime.Now;
            Console.WriteLine(date.ToShortDateString());
            Console.WriteLine("{0:dd.MM.yy hh:mm}", date);
        }
    }
}
