using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasPriceCalculator
{
    public partial class Form1 : Form
    {//test
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "1/8 Tank", "1/4 Tank", "3/8 Tank", "1/2 Tank", "5/8 Tank", "3/4 Tank", "7/8 Tank" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please Select your Current Gas Level", "Error");
            }
            else if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please Enter your Tank Size & the Current Gas Price", "Error");
            }
            else
            {
                double gallons = Convert.ToDouble(textBox1.Text);
                double price = Convert.ToDouble(textBox2.Text);
                double gasGauge = 0;

                if (comboBox1.SelectedItem == "1/8 Tank")
                {
                    gasGauge = 0.875;
                }
                else if (comboBox1.SelectedItem == "1/4 Tank")
                {
                    gasGauge = 0.75;
                }
                else if (comboBox1.SelectedItem == "3/8 Tank")
                {
                    gasGauge = 0.625;
                }
                else if (comboBox1.SelectedItem == "1/2 Tank")
                {
                    gasGauge = 0.5;
                }
                else if (comboBox1.SelectedItem == "5/8 Tank")
                {
                    gasGauge = 0.375;
                }
                else if (comboBox1.SelectedItem == "3/4 Tank")
                {
                    gasGauge = 0.25;
                }
                else if (comboBox1.SelectedItem == "7/8 Tank")
                {
                    gasGauge = 0.125;
                }

                double total = gallons * price * gasGauge;
                label6.Text = total.ToString("F2"); //F2 rounds up and also makes it so that if the result has only a tens decimal and no ones decimal, it will add a trailing zero to the tens decimal (ex: .9 becomes .90 to make it look more like money)
            }
        }
    }
}