using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Created by Michael Dorfman

namespace Lab_2___Q1___Michael_Dorfman
{
    public partial class Form1 : Form
    {

        // GLOBAL VARIABLES

        // Spacer String for cleaner code
        string Spacer = " ";

        public Form1()
        {
            //Form Initialization
            InitializeComponent();
        }

        private void btnF1_Click(object sender, EventArgs e)
        {
           
            // If statement checks to see if the Firstname is empty
            if (txtFirstName.Text.Length  > 0)
            {
                // Concatenate
                // FormatOne string variable is given the Concatenated data of
                // Title, First Name, Middle Name, Last Name
                string FormatOne = txtTitle.Text + Spacer + txtFirstName.Text + Spacer + txtMiddleName.Text + Spacer + txtLastName.Text;

                // Outputs Concatenated Data from FormatOne string
                lblOutput.Text = FormatOne;
            }
            else // If form is empty then display Form Empty
            {
                lblOutput.Text = "Missing Required Value";
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Closes Active Form
            this.Close();
        }

        private void btnF2_Click(object sender, EventArgs e)
        {
            // If statement checks to see if the Firstname is empty
            if (txtFirstName.Text.Length > 0)
            {
                // Concatenate
                // First Name with Last Name from text box inputs
                lblOutput.Text = txtFirstName.Text + Spacer + txtLastName.Text;
            }
            else
            {
                // Shows you are missing data
                lblOutput.Text = "Missing Required Value";
            }
        }

        private void btnF3_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Length > 0)
            { 
                // Concatenate
                // Last name with First Name and Middle name
                // With Spacer and Comma
                lblOutput.Text = txtLastName.Text + "," + Spacer + txtFirstName.Text + Spacer + txtMiddleName.Text;
            }
            else
            {
                // Shows You are missing data
                lblOutput.Text = "Missing Required Value";
            }
}

        private void btnClear_Click(object sender, EventArgs e)
        {

            // Clears form data
            txtFirstName.Text = "";
            txtMiddleName.Text = "";
            txtLastName.Text = "";
            txtTitle.Text = "";
        }
    }
}
