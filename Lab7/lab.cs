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
    Project: Week 10 Lab
    Description: Hospital Cost Calculator
    Name: Michael Dorfman
    Date: 11/11/2016
    Class: CP140 OOP1
*/
namespace Week_10___Michael_Dorfman
{
    public partial class Form1 : Form
    {
        // Calculates the Stay Charge
        // Recieves 1 int variable
        private int CalcStayCharges(int days)
        {
            int result;
            result = 350 * days;
            return result;
        }

        // Calculates the Misc Charges and returns the result
        // Recieves 3 double variables
        private double CalcMiscCharges(double med, double surge, double lab, double rehab)
        {
            double result;
            result = med + surge + lab +rehab;
            return result;
        }

        // Calculates the total cost of the Misc and Stay charges and returns the result
        // Recieves 2 double variables
        private double CalcTotalCharges(double misc, double StayCharge)
        {
            double result;
            result = misc + StayCharge;
            return result;
        }

        public Form1()
        {
            InitializeComponent();
            btnClear.Enabled = false;
        }

        // Calls the calculation functions and displays the result
        // Alters button enabled value depending on the 
        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Declare Variables
            int TotalStay;
            double TotalMisc, OverallTotal;

            // Call functions and return to variables
            TotalStay = CalcStayCharges(Convert.ToInt32(txtDays.Text));
            TotalMisc = CalcMiscCharges(Convert.ToDouble(txtMedCharge.Text), Convert.ToDouble(txtSurgCharge.Text), Convert.ToDouble(txtLabFees.Text), Convert.ToDouble(txtRehab.Text));
            OverallTotal = CalcTotalCharges(TotalMisc, TotalStay);

            // Convert returned values to string and put into read-only textbox
            txtStayCharge.Text = "$" + Convert.ToString(TotalStay);
            txtMiscCharge.Text = "$" + Convert.ToString(TotalMisc);
            txtTotal.Text = "$" + Convert.ToString(OverallTotal);

            // Swap button enabled status
            btnClear.Enabled = true;
            btnCalc.Enabled = false;
        }

        // Clears all text boxes of their values (calculated or entered)
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDays.Text = "";
            txtLabFees.Text = "";
            txtMedCharge.Text = "";
            txtRehab.Text = "";
            txtSurgCharge.Text = "";
            txtTotal.Text = "";
            txtStayCharge.Text = "";
            txtMiscCharge.Text = "";

            btnClear.Enabled = false;
            btnCalc.Enabled = true;
        }

        // Closes the form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Igonre... nothing to see here
        }
    }
}
