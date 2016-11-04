using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// CREATED BY MICHAEL DORFMAN

namespace Lab_2___Q2___Michael_Dorfman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //15% Tip
            //7% Tax

            // Declaring Variables
            double Charge = double.Parse(txtCharge.Text);
            double Tip ;
            double Tax;
            double Total;

            // Inject dollar sign into output
            string Dollar = "$";

            // Applying 15% Tip
            Tip = Charge * 0.15;
            txtTip.Text = Dollar + Tip.ToString();

            // Apply 7% Tax
            Tax = Charge * 0.07;
            txtTax.Text = Dollar + Tax.ToString();

            // Calculate Total Cost
            Total = Charge + Tip + Tax;
            txtTotal.Text = Dollar + Total.ToString();


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close Form
            this.Close();
        }

        private void clearForm_Click(object sender, EventArgs e)
        {
            // Fill Form with Default Data
            txtCharge.Text = "";
            txtTax.Text = "$0.00";
            txtTip.Text = "$0.00";
            txtTotal.Text = "$0.00";
        }
    }
}
