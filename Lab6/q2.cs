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
    Lab 6 - Question 2
    Author: Michael Dorfman
    Date: 11/04/2016
*/
namespace Lab_6_2___Michael_Dorfman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Recieves two doubles and returns a double
        private void KineticEnergy(double _mass, double _velocity, out double KE)
        {
            KE = (0.5 * (_mass * (Math.Pow(_velocity, 2))));
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Declaring Output Variabke
            double _KEOut;
            //Calls Function and sends converted input strings to doubles
            // and outputs a double
            KineticEnergy(Convert.ToDouble(txtMass.Text), Convert.ToDouble(txtVelocity.Text), out _KEOut);
            //Converts outputted double to string and passes to texbox text
            txtEnergy.Text = Convert.ToString(_KEOut);
        }
    }
}
