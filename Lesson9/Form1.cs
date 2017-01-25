using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Process[] proc = Process.GetProcesses();
            //foreach (var item in proc)
            //{
            //    if (item.ProcessName == "notepad++")
            //    {
            //        item.Kill();
            //    }
            //}
            //Process.Start("notepad++", @"C:\Lesson6\1.txt");
            //Process.Start("chrome", "http:\\yandex.ru");
            //ProcessStartInfo info = new ProcessStartInfo();
            //info.FileName = "chrome";
            //info.Arguments = "http:\\yandex.ru";
            //info.WindowStyle = ProcessWindowStyle.Maximized;
            //Process.Start(info);
            Thread.Sleep(10000);
        }
    }
}
