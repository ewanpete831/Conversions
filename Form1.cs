//conversions system by Ewan Peterson

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                //collect inputs
                double choice = Convert.ToDouble(choiceInput.Text);
                double value = Convert.ToDouble(valueInput.Text);

                //run conversion
                ConvertValue(choice, value);
            }
            catch
            {
                //display error message if an invalid value is inputted
                outputLabel.Text = "Please input a valid number to convert";
            }
        }

        public void ConvertValue(double choice, double value)
        {
            double convertedNum;

            //converts the value depending on which conversion the user seletcted
            switch (choice)
            {
                case 1:
                    convertedNum = value * 2.54;
                    outputLabel.Text = $"{value} inches = {convertedNum} centimetres.";
                    break;

                case 2:
                    convertedNum = value * 30.48;
                    outputLabel.Text = $"{value} feet = {convertedNum} centimetres.";
                    break;

                case 3:
                    convertedNum = value * 0.91;
                    outputLabel.Text = $"{value} yards = {convertedNum} metres.";
                    break;

                case 4:
                    convertedNum = value * 1.6;
                    outputLabel.Text = $"{value} miles = {convertedNum} kilometres.";
                    break;

                    //error message if an invalid conversion is selected
                default:
                    outputLabel.Text = "Please input a valid conversion";
                    break;

            }

        }

        
    }
}
