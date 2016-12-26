using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker1 = new Worker("Hulk", 27, 61311546);
            //worker1.name = "Hulk";
            //worker1.age = 27;
            //worker1.snn = 6131546;
            worker1.Age = -32;
            Console.WriteLine(worker1.Age);
            worker1.Print();
            
            Worker worker2 = new Worker("John", 47, 132146);
            worker2.Print();

            Random rnd = new Random();
            

            Worker worker3 = new Worker("Alex", rnd.Next(1, 101));
            worker3.Print();
            Console.WriteLine(Worker.count);
        }
    }

    class Worker
    {
        public string name;
        private int age; //поле 
        public int snn;
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

        public void Print()
        {
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Возраст: " + Age);
            Console.WriteLine("ИНН: " + snn);
            Console.WriteLine();
        }

        public Worker(string name, int age, int snn)
        {
            this.name = name;
            Age = age;
            this.snn = snn;
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
}
