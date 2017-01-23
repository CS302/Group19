using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkersLibrary;

namespace Lesson7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            Manager mn1 = new Manager("Ivan", 64, 63846, 4);
            double tax = mn1.PayTax(); //результат метода из интерфейса
            Driver dr1 = new Driver("John", 34, 683134, "BMW", 256);
            richTextBox1.Text = mn1.name;

            List<Worker> list = new List<Worker>();
            list.Add(mn1);
            list.Add(dr1);
            //теперь ни числа, ни строки в лист положить нельзя
            list[0].name = "";
            
            foreach (Worker item in list)
            {
                item.Print();
            }
            foreach (var item in collection)
            {
                
            }
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(15);
            stack.Pop();
            stack.Peek();
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }
            while (stack.Count != 0)
            {
                stack.Pop();
            }

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(15); //помещает в очередь
            queue.Dequeue(); //извлекает и удаляет
            queue.Peek(); //позволяет посмотреть на содержимое головы

            Dictionary<string, int> dict = new Dictionary<string, int>();
            if (!dict.ContainsKey("txt"))
            {
                dict.Add("txt", 10);
            }
            
            dict["txt"] += 1;
            foreach (KeyValuePair<string, int> item in dict)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            MessageBox.Show("Привет еще раз!");
            int number = 150;
            Form2 f2 = new Form2(number);
            f2.ShowDialog();
        }
    }

}
