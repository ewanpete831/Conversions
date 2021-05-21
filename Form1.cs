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

                //decide which conversion to do
                switch (choice)
                {
                    case 1:
                        double convertedInches = InchToCm(value);
                        outputLabel.Text = $"{value} inches = {convertedInches.ToString("#.##")} cm";
                        break;

                    case 2:
                        double convertedFeet = FeetToCm(value);
                        outputLabel.Text = $"{value} feet = {convertedFeet.ToString("#.##")} cm";
                        break;

                    case 3:
                        double convertedYards = YardsToMetres(value);
                        outputLabel.Text = $"{value} yards = {convertedYards.ToString("#.##")} metres";
                        break;

                    case 4:
                        double convertedMiles = MilesToKilometres(value);
                        outputLabel.Text = $"{value} miles = {convertedMiles.ToString("#.##")} kilometres";
                        break;

                    //error message if an invalid conversion is selected
                    default:
                        outputLabel.Text = "Please input a valid conversion";
                        break;
                }
            }
            catch
            {
                //display error message if an invalid value is inputted
                outputLabel.Text = "Please input a valid number to convert";
            }
        }

        /// <summary> 
        /// converts from inches to cm
        /// </summary>
        /// <param name="value">number of units being converted</param>
        /// <returns>converted number of units</returns>
        public double InchToCm(double value)
        {
            double convertedNum = value * 2.54;
            return convertedNum;
        }

        /// <summary>
        /// converts from feet to cm
        /// </summary>
        /// <param name="value">number of units being converted</param>
        /// <returns>converted number of units</returns>
        public double FeetToCm(double value)
        {
            double convertedNum = value * 30.48;
            return convertedNum;
        }

        /// <summary>
        /// converts from yards to metres
        /// </summary>
        /// <param name="value">number of units being converted</param>
        /// <returns>converted number of units</returns>
        public double YardsToMetres(double value)
        {
            double convertedNum = value * 0.91;
            return convertedNum;
        }

        /// <summary>
        /// converts from miles to kilometres
        /// </summary>
        /// <param name="value">number of units being converted</param>
        /// <returns>converted number of units</returns>
        public double MilesToKilometres(double value)
        {
            double convertedNum = value * 1.6;
            return convertedNum;
        }
    }
}
