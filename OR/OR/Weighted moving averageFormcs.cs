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

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            double ex1 = double.Parse(textBox9.Text) * double.Parse(textBox1.Text) + double.Parse(textBox10.Text) * double.Parse(textBox2.Text) + double.Parse(textBox11.Text) * double.Parse(textBox3.Text) + double.Parse(textBox12.Text) * double.Parse(textBox4.Text);
            textBox13.Text = ex1.ToString();
            
            double ex2 = double.Parse(textBox9.Text) * double.Parse(textBox2.Text) + double.Parse(textBox10.Text) * double.Parse(textBox3.Text) + double.Parse(textBox11.Text) * double.Parse(textBox4.Text) + double.Parse(textBox12.Text) * double.Parse(textBox5.Text);
            textBox14.Text = ex2.ToString();
           
            double ex3 = double.Parse(textBox9.Text) * double.Parse(textBox3.Text) + double.Parse(textBox10.Text) * double.Parse(textBox4.Text) + double.Parse(textBox11.Text) * double.Parse(textBox5.Text) + double.Parse(textBox12.Text) * double.Parse(textBox6.Text);
            textBox15.Text = ex3.ToString();

            double ex4 = double.Parse(textBox9.Text) * double.Parse(textBox4.Text) + double.Parse(textBox10.Text) * double.Parse(textBox5.Text) + double.Parse(textBox11.Text) * double.Parse(textBox6.Text) + double.Parse(textBox12.Text) * double.Parse(textBox7.Text);
            textBox16.Text = ex4.ToString();

            double e1 = double.Parse(textBox5.Text) - double.Parse(textBox13.Text);
            textBox20.Text = e1.ToString();

            double e2 = double.Parse(textBox6.Text) - double.Parse(textBox14.Text);
            textBox19.Text = e2.ToString();

            double e3 = double.Parse(textBox7.Text) - double.Parse(textBox15.Text);
            textBox18.Text = e3.ToString();

            double e4 = double.Parse(textBox8.Text) - double.Parse(textBox16.Text);
            textBox17.Text = e4.ToString();


        }

    }
}
