using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace квадратное_уравнение
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x1;
            double x2;
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox3.Text);
            double c = Convert.ToDouble(textBox5.Text);
            double dis = 0;


            dis = Math.Pow(b, 2) - (4 * a * c);
            if (dis>0)
            {
                x1 = (-b + Math.Sqrt(dis)) / (2 * a);
                x2 = (-b - Math.Sqrt(dis)) / (2 * a);
                listBox1.Show();
                listBox1.Items.Add("X1 = " + x1);
                listBox1.Items.Add("X2 = " + x2);
            }
            if (dis == 0)
            {
                x1 = -b / 2 * a;
                listBox1.Show();
                listBox1.Items.Add("X = " + x1); 
            }
            if (dis<0)
            {
                listBox1.Hide();
                MessageBox.Show("Уравнение не имеет корней! ");
            }
        }
    }
}
