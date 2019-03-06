using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string result;
        private void button1_Click(object sender, EventArgs e)
        {


            switch (comboBox1.Text)
            {
                case "Обьединение":
                    result = Objedinenie(textBox1.Text, textBox2.Text);
                    break;


                case "Пересечение":
                    result = Peresechenie(textBox1.Text, textBox2.Text);
                    break;

                case "Разность":
                    result = Raznost(textBox1.Text, textBox2.Text);
                    break;

                case "Симметричная разность":
                    result = Simetrich(textBox1.Text, textBox2.Text);
                    break;
            }



            string Objedinenie(string first, string second)
            {
                string[] povtor = new string[first.Length + second.Length];
                string result = "";
                for (int i = 0; i < first.Length; i++)
                {
                    bool hot1 = false;
                    for (int j = 0; j < povtor.Length; j++)
                    {
                        if (Convert.ToString(first[i]) == povtor[j])
                        {
                            hot1 = true;
                        }
                    }
                    if (!hot1)
                    {
                        textBox3.Text = result += first[i] + " ";
                        for (int m = 0; m < povtor.Length; m++)
                        {
                            if (povtor[m] == null)
                            {
                                povtor[m] = Convert.ToString(first[i]);
                                break;
                            }
                        }
                    }
                }
                for (int i = 0; i < second.Length; i++)
                {
                    bool hot1 = false;
                    for (int j = 0; j < povtor.Length; j++)
                    {
                        if (Convert.ToString(second[i]) == povtor[j])
                        {
                            hot1 = true;
                        }
                    }
                    if (!hot1)
                    {
                        textBox3.Text = result += second[i] + " ";
                        for (int m = 0; m < povtor.Length; m++)
                        {
                            if (povtor[m] == null)
                            {
                                povtor[m] = Convert.ToString(second[i]);
                                break;
                            }
                        }
                    }
                }
                return result;
            }

            string Peresechenie(string first, string second)
            {
                string result = "";
                for (int i = 0; i < first.Length; i++)
                {
                    bool nalichie = false;
                    for (int j = 0; j < second.Length; j++)
                    {
                        if (first[i] == second[j])
                        {
                            nalichie = true;
                        }
                    }
                    if (nalichie)
                    {
                        textBox3.Text = result += first[i] + " ";
                    }

                }
                return result;

            }
            string Raznost(string first, string second)
            {
                string result = "";
                for (int i = 0; i < first.Length; i++)
                {
                    bool nalichie = false;
                    for (int j = 0; j < second.Length; j++)
                    {
                        if (first[i] == second[j])
                        {
                            nalichie = true;
                        }
                    }
                    if (!nalichie)
                    {
                        textBox3.Text = result += first[i] + " ";
                    }

                }
                return result;
            }
            string Simetrich(string first, string second)
            {
                string result = "";
                result += Raznost(first, second);
                result += Raznost(second, first);
                return result;

            }
        }
    }
}