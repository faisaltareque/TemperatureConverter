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
            errorTextLabel.Text = "";
            errorTextLabel.Visible = false;
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            String input = inputTextBox.Text;
            if(input == string.Empty)
            {
                errorTextLabel.Text = "Can not Convert empty value";
                errorTextLabel.Visible = true;
                return;
            }


            double parsedInputVal;

            bool isNumeric = double.TryParse(input, out parsedInputVal);

            if (!isNumeric)
            {
                errorTextLabel.Text = "Please put a number for coversion";
                errorTextLabel.Visible = true;
                return;
            } else {
                errorTextLabel.Visible = false;

                if (radioButtonFahrenToCel.Checked)
                {
                    double celcius = (parsedInputVal - 32.0) * (5.0 / 9.0);
                    outputTextBox.Text = celcius.ToString();
                } else if (radioButtonCelToFahren.Checked)
                {
                    double fahrenheit = (parsedInputVal) * (9.0 / 5.0) + 32;
                    outputTextBox.Text = fahrenheit.ToString();
                }
                else if (radioButtonCelToKel.Checked)
                {
                    double kelvin = (parsedInputVal) + 273.0;
                    outputTextBox.Text = kelvin.ToString();
                }
                else if (radioButtonKelToCel.Checked)
                {
                    double celsius = (parsedInputVal) - 273.0;
                    outputTextBox.Text = celsius.ToString();
                }
                else if (radioButtonFahrenToKel.Checked)
                {
                    double kelvin = (parsedInputVal - 32.0) * (5.0 / 9.0) + 273.0;
                    outputTextBox.Text = kelvin.ToString();
                }
                else
                {
                    errorTextLabel.Text = "Choose a conversion type";
                    errorTextLabel.Visible = true;
                }
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
