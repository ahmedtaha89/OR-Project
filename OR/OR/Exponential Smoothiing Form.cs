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

            double error1 = int.Parse(textBox2.Text) - ex2;
            textBox19.Text = error1.ToString();

            double error2 = int.Parse(textBox3.Text) - ex3;
            textBox18.Text = error2.ToString();


            double error3 = int.Parse(textBox4.Text) - ex4;
            textBox10.Text = error3.ToString();

            double error4 = int.Parse(textBox5.Text) - ex5;
            textBox23.Text = error4.ToString();



            double error5 = int.Parse(textBox6.Text) - ex6;
            textBox22.Text = error5.ToString();


            double error6 = int.Parse(textBox7.Text) - ex7;
            textBox21.Text = error6.ToString();


           // |Error|

            double abs_error1 = Math.Abs(error1);
            textBox26.Text = abs_error1.ToString();

            double abs_error2 = Math.Abs(error2);
            textBox25.Text = abs_error2.ToString();

            double abs_error3 = Math.Abs(error3);
            textBox24.Text = abs_error3.ToString();

            double abs_error4 = Math.Abs(error4);
            textBox30.Text = abs_error4.ToString();

            double abs_error5 = Math.Abs(error5);
            textBox29.Text = abs_error5.ToString();

            double abs_error6 = Math.Abs(error6);
            textBox28.Text = abs_error6.ToString();


            // |Error|^2


            double sqr_error1 = Math.Pow(error1,2);
            textBox33.Text = sqr_error1.ToString();

            double sqr_error2 = Math.Pow(error2,2);
            textBox32.Text = sqr_error2.ToString();

            double sqr_error3 = Math.Pow(error3,2);
            textBox31.Text = sqr_error3.ToString();

            double sqr_error4 = Math.Pow(error4,2);
            textBox37.Text = sqr_error4.ToString();

            double sqr_error5 = Math.Pow(error5,2);
            textBox36.Text = sqr_error5.ToString();

            double sqr_error6 = Math.Pow(error6,2);

            textBox35.Text = sqr_error6.ToString();

            //MSE 
            double  MAD= (abs_error1 + abs_error2 + abs_error3 + abs_error4 + abs_error5 + abs_error6) /6;
            textBox16.Text= MAD.ToString();

            // MAD
            double MSE = (sqr_error1  + sqr_error2 + sqr_error3+ sqr_error4+ sqr_error5 + sqr_error6)/6;
            textBox20.Text= MSE.ToString();


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
            textBox28.Clear();
            textBox29.Clear();
            textBox30.Clear();
            textBox31.Clear();
            textBox32.Clear();
            textBox32.Clear();
            textBox33.Clear();
            textBox37.Clear();
            textBox36.Clear();
            textBox35.Clear();






        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
