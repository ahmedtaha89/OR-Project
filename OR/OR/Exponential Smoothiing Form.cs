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
    public partial class Exponential_Smoothiing_Form : System.Windows.Forms.Form
    {
        public Exponential_Smoothiing_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Expected
            double ex2 = ( double.Parse(textBox9.Text) * double.Parse(textBox1.Text)) + ( (1 - double.Parse(textBox9.Text) ) * double.Parse(textBox1.Text));
             textBox11.Text = ex2.ToString();

            double ex3 = (double.Parse(textBox9.Text) * double.Parse(textBox2.Text)) + ((1 - double.Parse(textBox9.Text)) * ex2);
            textBox12.Text = ex3.ToString();

            double ex4 = (double.Parse(textBox9.Text) * double.Parse(textBox3.Text)) + ((1 - double.Parse(textBox9.Text)) * ex3);
            textBox17.Text = ex4.ToString();

            double ex5 = (double.Parse(textBox9.Text) * double.Parse(textBox4.Text)) + ((1 - double.Parse(textBox9.Text)) * ex4);
            textBox13.Text = ex5.ToString();

            double ex6 = (double.Parse(textBox9.Text) * double.Parse(textBox5.Text)) + ((1 - double.Parse(textBox9.Text)) * ex5);
            textBox14.Text = ex6.ToString();

            double ex7 = (double.Parse(textBox9.Text) * double.Parse(textBox6.Text)) + ((1 - double.Parse(textBox9.Text)) * ex6);
            textBox15.Text = ex7.ToString();

            double ex8 = (double.Parse(textBox9.Text) * double.Parse(textBox7.Text)) + ((1 - double.Parse(textBox9.Text)) * ex7);
            textBox16.Text = ex8.ToString();

            //Error

            double error1 = double.Parse(textBox2.Text) - ex2;
            textBox19.Text = error1.ToString();

            double error2 = double.Parse(textBox3.Text) - ex3;
            textBox18.Text = error2.ToString();


            double error3 = double.Parse(textBox4.Text) - ex3;
            textBox10.Text = error3.ToString();

            double error4 = double.Parse(textBox5.Text) - ex4;
            textBox23.Text = error4.ToString();



            double error5 = double.Parse(textBox6.Text) - ex5;
            textBox22.Text = error5.ToString();


            double error6 = double.Parse(textBox7.Text) - ex6;
            textBox21.Text = error6.ToString();


            //double error7 = double.Parse(textBox8.Text) - ex7;
            //textBox20.Text = error7.ToString();


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
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox21.Clear();
            textBox22.Clear();
            textBox23.Clear();
            textBox24.Clear();
            textBox25.Clear();
            textBox26.Clear();
            textBox27.Clear();
            textBox28.Clear();
            textBox29.Clear();
            textBox30.Clear();
            textBox31.Clear();
            textBox32.Clear();
            textBox32.Clear();
            textBox33.Clear();
            textBox34.Clear();



        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
