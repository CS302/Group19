﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersLibrary
{
    public class Driver : Worker
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
}
