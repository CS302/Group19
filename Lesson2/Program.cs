using System;

namespace Lesson2
{
    class Program
    {

        static void Main(string[] args)
        {
            //int number = 5;
            //int[] numbers = new int[number];
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;
            //numbers[3] = 4;
            //numbers[4] = 5;

            //Console.WriteLine(numbers.Length);
            //Console.WriteLine(numbers.GetLength(0));
            //Console.WriteLine("-----------------");

            //int[,] table = new int[2, 3];
            //table[0, 0] = 1;
            //table[0, 1] = 2;
            //table[0, 2] = 3;

            //table[1, 0] = 4;
            //table[1, 1] = 5;
            //table[1, 2] = 6;
            //Console.WriteLine("-------------------");
            //Console.WriteLine(table.Length);
            //Console.WriteLine(table.GetLength(0));
            //Console.WriteLine(table.GetLength(1));

            //ShowRefAndValueTypes();

            //string comand = Console.ReadLine();
            //switch (comand)
            //{
            //    case "1":
            //        Console.WriteLine("Работа завершена");
            //        break;
            //    case "2":
            //    case "Option2":
            //        Console.WriteLine("Включена опция");
            //        break;
            //    default:
            //        Console.WriteLine("Работа выполняется");
            //        break;
            //}

            for (int i = 0; i <= 10; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i);
                }
            }

            int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //string text = Console.ReadLine();
            //while (text != "exit")
            //{
            //    Console.WriteLine("Выполняется работа");
            //    text = Console.ReadLine();
            //}
            //Console.WriteLine("Работа завершена");
            string text;
            do
            {
                Console.WriteLine("Выполняется работа");
                text = Console.ReadLine();

            } while (text != "exit");
            Console.WriteLine("Работа завершена");
            
        }

        static void ShowRefAndValueTypes()
        {
            int[] arr1 = new int[2] { 5, 5 };
            int[] arr2 = new int[2] { 9, 9 };
            Console.WriteLine(arr1[0] + "  " + arr1[1]);
            Console.WriteLine(arr2[0] + "  " + arr2[1]);
            Console.WriteLine("----------------------");

            arr1 = arr2;
            Console.WriteLine(arr1[0] + "  " + arr1[1]);
            Console.WriteLine(arr2[0] + "  " + arr2[1]);
            Console.WriteLine("----------------------");

            arr2[0] = 100;
            arr2[1] = 100;
            Console.WriteLine(arr1[0] + "  " + arr1[1]);
            Console.WriteLine(arr2[0] + "  " + arr2[1]);
            Console.WriteLine("----------------------");


            int a = 5;
            int b = 9;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("-----------");

            a = b;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("-----------");

            b = 100;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("-----------");
        }

        static int DoSmth(int a, int b)
        {
            return (int)Math.Pow(a + b, 2);
        }

    }
}
