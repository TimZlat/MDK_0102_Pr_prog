using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace П11_20_пр3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ввод исходных данных
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double z = Convert.ToDouble(textBox3.Text);
            //вывод результата в окно результата
            textBox4.Text = "Результат работы:"+Environment.NewLine;
            textBox4.Text += "При Х = " + textBox1.Text + Environment.NewLine;
            textBox4.Text += "    Y = " + textBox2.Text + Environment.NewLine;
            textBox4.Text += "    Z = " + textBox3.Text + Environment.NewLine;
            // вычисляем выражение
            double u;
            if ((z-x)==0)
            {
                u = y * Math.Sin(x) * Math.Sin(x) + z;
            }
            else
                if ((z-x)<0)
            {
                u = y * Math.Exp(Math.Sin(x)) - z;
            }
            else
                u = y * Math.Sin(Math.Sin(x)) + z;

            textBox4.Text += "U = " + u.ToString() + Environment.NewLine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
