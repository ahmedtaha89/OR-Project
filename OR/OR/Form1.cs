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

            //sum
         
            double sum_x  = (double.Parse(textBox1.Text) + double.Parse(textBox2.Text) + double.Parse(textBox3.Text) + double.Parse(textBox4.Text));         
            textBox18.Text = sum_x.ToString();
            
            double sum_y =  (double.Parse(textBox5.Text) + double.Parse(textBox6.Text) + double.Parse(textBox7.Text) + double.Parse(textBox8.Text));
            textBox19.Text = sum_y.ToString();

            //x*x

            double xx1 = (Math.Pow(double.Parse(textBox1.Text), 2));
            textBox9.Text = xx1.ToString();

            double xx2 = (Math.Pow(double.Parse(textBox2.Text), 2));
            textBox10.Text = xx2.ToString();

            double xx3 = (Math.Pow(double.Parse(textBox3.Text), 2));
            textBox12.Text = xx3.ToString();

            double xx4 = (Math.Pow(double.Parse(textBox4.Text), 2));
            textBox13.Text = xx4.ToString();

            // x*y
            double xy1 = (double.Parse(textBox1.Text) * double.Parse(textBox5.Text));
            textBox14.Text = xy1.ToString();

            double xy2 = (double.Parse(textBox2.Text) * double.Parse(textBox6.Text));
            textBox15.Text = xy2.ToString();

            double xy3 = (double.Parse(textBox3.Text) * double.Parse(textBox7.Text));
            textBox16.Text = xy3.ToString();

            double xy4 = (double.Parse(textBox4.Text) * double.Parse(textBox8.Text));
            textBox17.Text = xy4.ToString();


            // sum xx
            double sum_xx = xx1 + xx2 + xx3 + xx4;
            textBox20.Text = sum_xx.ToString();

            // sum xy
            double sum_xy = xy1 + xy2 + xy3 + xy4;
            textBox21.Text = sum_xy.ToString();

            double a = ((sum_y * sum_xx) - (sum_x * sum_xy)) / ((4*sum_xx) - (Math.Pow(sum_x,2)));

            double b = ((4* sum_xy ) - (sum_x * sum_y) ) / ((4*sum_xx) - (sum_xx));

            double y = Math.Round((a + b * sum_x), 2);

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
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();



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

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
