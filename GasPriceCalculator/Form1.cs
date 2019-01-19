using System;
using System.Windows.Forms;

namespace GasPriceCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxGasLevel.Items.AddRange(new string[] { "1/8 Tank", "1/4 Tank", "3/8 Tank", "1/2 Tank", "5/8 Tank", "3/4 Tank", "7/8 Tank" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxGasLevel.SelectedItem == null)
            {
                MessageBox.Show("Please Select your Current Gas Level", "Error");
            }
            else if (textBoxTankCapacity.Text == "" || textBoxGasPrice.Text == "")
            {
                MessageBox.Show("Please Enter your Tank Size & the Current Gas Price", "Error");
            }
            else
            {
                double gallons = 0, price = 0, gasGauge = 0, total = 0;
                try
                {
                    gallons = Convert.ToDouble(textBoxTankCapacity.Text);
                    price = Convert.ToDouble(textBoxGasPrice.Text);
                }
                catch
                {
                    MessageBox.Show("Please enter a number.");
                }

                switch (comboBoxGasLevel.SelectedItem)
                {
                    case "1/8 Tank":
                        gasGauge = 0.875;
                        break;
                    case "1/4 Tank":
                        gasGauge = 0.75;
                        break;
                    case "3/8 Tank":
                        gasGauge = 0.625;
                        break;
                    case "1/2 Tank":
                        gasGauge = 0.5;
                        break;
                    case "5/8 Tank":
                        gasGauge = 0.375;
                        break;
                    case "3/4 Tank":
                        gasGauge = 0.25;
                        break;
                    case "7/8 Tank":
                        gasGauge = 0.125;
                        break;
                }

                total = gallons * price * gasGauge;
                labelTotalCost.Text = total.ToString("F2"); //F2 rounds up and also makes it so that if the result has only a tens decimal and no ones decimal, it will add a trailing zero to the tens decimal (ex: .9 becomes .90 to make it look more like money)
            }
        }
    }
}