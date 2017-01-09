using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_4
{
    /*
     * Файл Program.cs правой кнопкой - > Перейти к схеме класов
     * Файл Program.cs правой кнопкой - > Показать на карте кода
     */
    class Program
    {
        static void Main(string[] args)
        {
            
            Worker[] workers = new Worker[3];
            workers[0] = new Manager("Hulk", 49, 864351, 15);
            workers[1] = new Driver("John", 28, 65364, "Audi", 256);
            workers[2] = new Manager("Ivan", 29, 46513, 15);

            for (int i = 0; i < workers.Length; i++)
            {
                workers[i].Print();
                Console.WriteLine();
            }
            
        }
    }

    abstract class Worker
    {
        public string name;
        private int age; //поле 
        protected int snn;
        protected int salary;
        public static int count;

        public int Age //свойство
        {
            set 
            {
                if (value < 0)
                {
                    Console.WriteLine("Невозможно задать возраст");
                }
                else
	            {
                    age = value;
	            }
            }
            get { return age; }
        }

        public void SetAge(int a)
        {
            if (a < 0)
            {
                Console.WriteLine("Невозможно задать возраст");
            }
            else
            {
                age = a;
            }
        }

        public int GetAge()
        {
            return age;
        }

        public abstract double GetBonus();
        //{
        //    return 0; - было нужно для виртуального метода.
        //}   при переходе к абстрактному методу реализация уже не нужна.

        public virtual void Print()
        {
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Возраст: " + Age);
            Console.WriteLine("ИНН: " + snn);
            Console.WriteLine("З/П: " + salary);
        }

        public Worker(string name, int age, int snn)
        {
            this.name = name;
            Age = age;
            this.snn = snn;
            this.salary = 35000;
            count++;
        }
        public Worker(string name, int age)
            :this(name, age, 0)
        {   }

        static Worker()
        {
            count = 0;
        }
    }

    class Driver : Worker
    {
        public string carType;
        public int hours;

        public Driver(string name, int age, int snn, string carType, int hours)
            : base(name, age, snn)
        {
            this.carType = carType;
            this.hours = hours;
            salary = 45000;
        }

        public override double GetBonus()
        {
            return hours * 100;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Машина: " + carType);
            Console.WriteLine("Кол-во часов: " + hours);
            Console.WriteLine("Премия: " + GetBonus());
            Console.WriteLine();
        }
    }

    sealed class Manager : Worker
    {
        public int projCount;

        public Manager(string name, int age, int snn, int projCount)
            : base(name, age, snn)
        {
            this.projCount = projCount;
            salary = 55000;
        }

        public override double GetBonus()
        {
            return projCount * 1500;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Кол-во проектов: " + projCount);
            Console.WriteLine("Премия: " + GetBonus());
            Console.WriteLine();
        }
    }

}
