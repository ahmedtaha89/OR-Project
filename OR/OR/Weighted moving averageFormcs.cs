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
    public partial class Weighted_moving_averageFormcs : System.Windows.Forms.Form
    {
        public Weighted_moving_averageFormcs()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
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
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox18.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox22.Clear();
            textBox23.Clear();
            textBox24.Clear();
            textBox26.Clear();
            textBox27.Clear();
            textBox28.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           //Expected

            double ex1 = double.Parse(textBox9.Text) * double.Parse(textBox1.Text) + double.Parse(textBox10.Text) * double.Parse(textBox2.Text) + double.Parse(textBox11.Text) * double.Parse(textBox3.Text) + double.Parse(textBox12.Text) * double.Parse(textBox4.Text);
            textBox13.Text = ex1.ToString();
            
            double ex2 = double.Parse(textBox9.Text) * double.Parse(textBox2.Text) + double.Parse(textBox10.Text) * double.Parse(textBox3.Text) + double.Parse(textBox11.Text) * double.Parse(textBox4.Text) + double.Parse(textBox12.Text) * double.Parse(textBox5.Text);
            textBox14.Text = ex2.ToString();
           
            double ex3 = double.Parse(textBox9.Text) * double.Parse(textBox3.Text) + double.Parse(textBox10.Text) * double.Parse(textBox4.Text) + double.Parse(textBox11.Text) * double.Parse(textBox5.Text) + double.Parse(textBox12.Text) * double.Parse(textBox6.Text);
            textBox15.Text = ex3.ToString();

            double ex4 = double.Parse(textBox9.Text) * double.Parse(textBox4.Text) + double.Parse(textBox10.Text) * double.Parse(textBox5.Text) + double.Parse(textBox11.Text) * double.Parse(textBox6.Text) + double.Parse(textBox12.Text) * double.Parse(textBox7.Text);
            textBox16.Text = ex4.ToString();


            //Error

            double error1 = double.Parse(textBox5.Text) - double.Parse(textBox13.Text);
            textBox20.Text = error1.ToString();

            double error2 = double.Parse(textBox6.Text) - double.Parse(textBox14.Text);
            textBox19.Text = error2.ToString();

            double error3 = double.Parse(textBox7.Text) - double.Parse(textBox15.Text);
            textBox18.Text = error3.ToString();

            // Abs Error 

            double abs_error1 = Math.Abs(error1);
            textBox24.Text = abs_error1.ToString();


            double abs_error2 = Math.Abs(error2);
            textBox23.Text = abs_error2.ToString();

            double abs_error3 = Math.Abs(error3);
            textBox22.Text = abs_error3.ToString();



            // |Error|^2 


           double pow_error1 = Math.Pow(error1,2);
            textBox28.Text = pow_error1.ToString();

           double pow_error2 = Math.Pow(error2,2);
            textBox27.Text = pow_error2.ToString();

            double pow_error3 = Math.Pow(error3,2);
            textBox26.Text = pow_error3.ToString();

            // MSE
            double MSE = (pow_error1 + pow_error2 + pow_error3)/3;
            textBox29.Text = MSE.ToString();
            double MAD = (abs_error1+abs_error2+abs_error3)/3;
            textBox30.Text = MAD.ToString();



        }

        private void Weighted_moving_averageFormcs_Load(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
    }
}
