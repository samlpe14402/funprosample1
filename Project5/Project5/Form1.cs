using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project5
{
    public partial class Form1 : Form
    {
        double exchange_rate = 1.3170;
        double exchange_fee = 1.25;
        double resulting_number;
        public Form1()
        {
            InitializeComponent();
        }

        private void main_input1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double userinput;



            if (double.TryParse(main_input1.Text, out userinput))
            {
                resulting_number = (userinput * exchange_rate);


                resulting_number = resulting_number - (resulting_number * exchange_fee/ 100);



                euro_amount.Text = userinput.ToString() + " Euros";


                label1.ForeColor = System.Drawing.Color.Black;


                label1.Text =" It is a number - " + userinput.ToString() + " Congratulations!!!";


                exchanged_amount.Text = resulting_number.ToString() + "$ you have now";
            }
            else
            {
                label1.ForeColor = System.Drawing.Color.Red;
                label1.Text = "Incorrect entry. Try again and input integer or float value!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtu.be/dQw4w9WgXcQ?t=20autoplay=1");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
