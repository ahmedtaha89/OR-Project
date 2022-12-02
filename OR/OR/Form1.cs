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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int sum_x  = int.Parse(textBox1.Text) + int.Parse(textBox2.Text) + int.Parse(textBox3.Text) + int.Parse(textBox4.Text);

           int sum_y =  (int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text));

           int sum_xx = (int.Parse(textBox1.Text)^2 + int.Parse(textBox2.Text)^2 + int.Parse(textBox3.Text)^2 + int.Parse(textBox4.Text)^2);

           int sum_xy = (int.Parse(textBox1.Text) * int.Parse(textBox5.Text)  + int.Parse(textBox2.Text)  * int.Parse(textBox6.Text) + int.Parse(textBox3.Text) * int.Parse(textBox7.Text) + int.Parse(textBox4.Text) * int.Parse(textBox8.Text));

            double a = ((sum_y * sum_xx) - (sum_x * sum_xy) / (4 * sum_xx - sum_x^2));

            double b = ((4* sum_xy ) - (sum_x * sum_y) / ( (4*sum_xx) - sum_xx));

            double y = a + b * sum_x;

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
    }
}
