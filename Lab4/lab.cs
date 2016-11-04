using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Name: Michael Dorfman
// CP140 Lab #4
// 10/07/2016

namespace Lab_4___Michael_Dorfman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Ensures textboxes are empty
            txtWeight.Text = "";
            txtMass.Text = "";
            txtDigit.Text = "";
            txtNumeral.Text = "";
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            int digit = int.Parse(txtDigit.Text);

            // Error catchinbg if value is greater than 10 or less than 0
            if (digit > 10 || digit < 0)
            {
                // Displays error message
                MessageBox.Show("Value was either higher or lower than 10");
            }
            else
            {

                // Checks the numbers and displays values
                if (digit == 1)
                {
                    txtNumeral.Text = "I";
                }
                else if (digit == 2)
                {
                    txtNumeral.Text = "II";
                }
                else if(digit == 3)
                {
                    txtNumeral.Text = "III";
                }
                else if (digit == 4)
                {
                    txtNumeral.Text = "IV";
                }
                else if (digit == 5)
                {
                    txtNumeral.Text = "V";
                }
                else if (digit == 6)
                {
                    txtNumeral.Text = "VI";
                }
                else if (digit == 7)
                {
                    txtNumeral.Text = "VII";
                }
                else if (digit == 8)
                {
                    txtNumeral.Text = "VIII";
                }
                else if (digit == 9)
                {
                    txtNumeral.Text = "IX";
                }
                else if (digit == 10)
                {
                    txtNumeral.Text = "X";
                }
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Converts input string to double
            double input_mass = double.Parse(txtMass.Text);

            // Calculates weight
            double weight = input_mass * 9.81;

            // Compares calculated weight 
            if (weight > 1000)
            {
                //Output information
                MessageBox.Show("Weight is Too Heavy");
                txtWeight.Text = System.Convert.ToString(weight) + " N";
            }
            else if (weight < 10)
            {
                //Output information
                MessageBox.Show("Weight is Too Light");
                txtWeight.Text = System.Convert.ToString(weight) + " N";
            }
            else
            {
                // If information is within desired region output information
                txtWeight.Text = System.Convert.ToString(weight) + " N";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clears textbox data
            txtWeight.Text = "";
            txtMass.Text = "";
            txtDigit.Text = "";
            txtNumeral.Text = "";
        }
    }
}
