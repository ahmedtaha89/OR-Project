using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OR
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum_x  = (double.Parse(textBox1.Text) + double.Parse(textBox2.Text) + double.Parse(textBox3.Text) + double.Parse(textBox4.Text));

            double sum_y =  (double.Parse(textBox5.Text) + double.Parse(textBox6.Text) + double.Parse(textBox7.Text) + double.Parse(textBox8.Text));

           
            double sum_xx = (Math.Pow(double.Parse(textBox1.Text), 2) + Math.Pow(double.Parse(textBox2.Text), 2) + Math.Pow(double.Parse(textBox3.Text), 2) + Math.Pow(double.Parse(textBox4.Text), 2));
            
            double sum_xy = (double.Parse(textBox1.Text) * double.Parse(textBox5.Text)  + double.Parse(textBox2.Text)  * double.Parse(textBox6.Text) + double.Parse(textBox3.Text) * double.Parse(textBox7.Text) + double.Parse(textBox4.Text) * double.Parse(textBox8.Text));

            double a = ((sum_y * sum_xx) - (sum_x * sum_xy)) / ((4*sum_xx) - (Math.Pow(sum_x,2)));

            double b = ((4* sum_xy ) - (sum_x * sum_y) ) / ((4*sum_xx) - (sum_xx));

            double y = a + b*sum_x;

            textBox11.Text = y.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox11.Clear();


        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Weighted_moving_averageFormcs().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Exponential_Smoothiing_Form().ShowDialog();
        }
    }
}
