using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson8
{
    class Program
    {
        delegate void BinaryOp(int a, int b);

        static Queue<object> queue;
        static object obj;
        static void Main(string[] args)
        {
            //BinaryOp bin = new BinaryOp(Sum);
            //bin += Sum;
            //bin += new BinaryOp(Sum);
            //bin -= Sum;
            //bin(10, 20);
            //Action<int, int> action = Sum; //void
            //Func<int, string> func = ToStr; //не void
            //Func<int, int, int> action = GetNumbers;
            //IAsyncResult ires = action.BeginInvoke(10, 20, ShowGetNumbersResult, null);
            
            ////action.EndInvoke
            //while (Console.ReadLine() != "exit")
            //{   }
            obj = new object();
            queue = new Queue<object>();
            for (int i = 1; i < 100; i++)
            {
                queue.Enqueue(i);
            }

            Action<int> act = CalcQueItem;
            act.BeginInvoke(1, null, null);
            act.BeginInvoke(2, null, null);

            Console.ReadLine();
        }

        static void CalcQueItem(int id)
        {
            while (queue.Count!=0)
            {
                int number;
                Thread.Sleep(11);
                lock (obj)
                {
                    number = int.Parse(queue.Dequeue().ToString());
                }
               
                number *= number;
                Console.WriteLine("{0} - {1}", id, number);
            }
        }

        static void ShowGetNumbersResult(IAsyncResult ires)
        {
            AsyncResult res = (AsyncResult)ires;
            Func<int, int, int> item = (Func<int, int, int>)res.AsyncDelegate;

            int sum = item.EndInvoke(ires);
            Console.WriteLine("Сумма = {0}", sum);
            return;
        }

        static int GetNumbers(int a, int b)
        {
            int sum = 0;
            for (int i = a; i < b; i++)
            {
                sum += i;
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
            return sum;
        }

        static string ToStr(int a)
        {
            a = 20;
            string str1 = "1stroka";
            string str2 = "2stroka";
            return str1 + str2;
        }

        static void Sum(int a, int b)
        {
            int sum = 0;
            for (int i = a; i < b; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
        static void Mul(int a, int b)
        {
            int sum = 1;
            for (int i = a; i < b; i++)
            {
                sum *= i;
            }
            Console.WriteLine(sum);
        }

        private static void ShowVarDyn()
        {
            //
            var number = 10; //Int32 int

            var text = "wretr"; //string
            Console.WriteLine(text.Length);

            var x = GetNumber();
            //x = "qwewret"; так нельзя
            dynamic number1 = 10;
            number1 = number1 + 10;

            number1 = "text";
            number1 = number1 + 10;
            Console.WriteLine(number1);
        }
        static double GetNumber()
        {
            return Math.PI * Math.E;
        }
    }
}
