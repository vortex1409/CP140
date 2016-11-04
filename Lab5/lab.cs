using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Class: CP140
Project: Week 7 Lab 5
Description: Temp Converter
Name: Michael Dorfman
Date: 10/21/2016
*/

namespace Lab_5___Michael_Dorfman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Temp Conversion Function
        //Recieves C and calculates F
        public double tempConversion(int C)
        {
            //Local Variables
            double _F;

            //Calculation
            _F = ((9.0 / 5.0) * C) + 32.0;

            //Returning value
            return _F;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //Variables
            double F = 0.0;
            int C = 0;

            //Do Loop for looping through temp conversion
            //and adds values to listbox while incrementing
            //by one every loop
            do
            {
                //Assigns function return to variable in loop
                F = tempConversion(C);

                //Ouputs data to list box in a styled fashion
                tempBox.Items.Add(C + "C = " + F + "F");

                //Increments C by one
                C++;
            }
            while (C <= 20); //Ends the do loop when C is equal or greater than 20

            //Disables the convert button to prevent reuse before clearing of
            //the list box
            btnConvert.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Closes the form
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clears listbox items
            tempBox.Items.Clear();
            
            //Enables the Convert Button
            btnConvert.Enabled = true;
        }
    }
}
