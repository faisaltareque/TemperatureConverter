using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConverter
{
    public partial class Form1 : Form
    {

        public Form1()
        {            
            InitializeComponent();            
        }

        public void reset()
        {
            radioButtonKelToCel.Checked = false;
            radioButtonFahrenToKel.Checked = false;
            radioButtonFahrenToCel.Checked = false;
            radioButtonCelToKel.Checked = false;
            radioButtonCelToFahren.Checked = false;
            inputTextBox.Text = "";
            outputTextBox.Text = "";
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            String input = inputTextBox.Text;
            if(input == string.Empty)
            {
                outputTextBox.Text = "Can not Convert Null";
                return;
            }
            double inputValue = double.Parse(inputTextBox.Text);
            if (radioButtonFahrenToCel.Checked)
            {
                double celsuis = (inputValue - 32.0) * (5.0 / 9.0);
                outputTextBox.Text = celsuis.ToString();
            }else if (radioButtonCelToFahren.Checked)
            {
                double fahrenheit = (inputValue) * (9.0 / 5.0) + 32;
                outputTextBox.Text = fahrenheit.ToString();
            }
            else if (radioButtonCelToKel.Checked)
            {
                double kelvin = (inputValue) + 273.0;
                outputTextBox.Text = kelvin.ToString();
            }
            else if (radioButtonKelToCel.Checked)
            {
                double celsius = (inputValue) - 273.0;
                outputTextBox.Text = celsius.ToString();
            }
            else if (radioButtonFahrenToKel.Checked)
            {
                double kelvin = (inputValue - 32.0) * (5.0 / 9.0)+273.0;
                outputTextBox.Text = kelvin.ToString();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
