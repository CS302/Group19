using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersLibrary
{
    public abstract class Worker
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
            : this(name, age, 0)
        { }

        static Worker()
        {
            count = 0;
        }
    }
}
