using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson7
{
    public partial class Form2 : Form
    {
        public Form2(int number)
        {
            int x = number + 10;
            InitializeComponent();
            richTextBox1.Text = String.Format("Открылась вторая форма\nЧисло = {0}", x);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(richTextBox1.Text);
                number = 10;
                number = 15;
                number = 635;
                richTextBox2.Text = (number * number).ToString();
            }
            catch (FormatException ex1)
            {
                richTextBox2.Text = "Нельзя вводить буквы. Можно только цифры.";
            }
            catch (OverflowException ex2)
            {
                string s = ex2.Message;
                richTextBox2.Text = String.Format("Число является недопустимо маленьким или большим для типа int.\nИспользуйте диапазон [{0}, {1}]", int.MinValue, int.MaxValue);
            }
            catch (Exception ex)
            {
                string s = ex.Message;
            }
            finally
            {
                //закрытие потоков
            }
        }    
            
    }
}
