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

    Project: Assignment 1 - Color Mixer
    Class: CP140
    Author: Michael Dorfman

*/
namespace Assignment_1___Color_Mixer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMix_Click(object sender, EventArgs e)
        {
            /******************************************
            DOCUMENTATION FOR IF / ELSEIF STATETMENTS
            ===========================================

            if (<RadioButton_leftside>.Checked == true && <radiobutton_rightside>.Checked == true || <radiobutton_rightside>.Checked == true && <RadioButton_leftside>.Checked == true)
            {
                this.BackColor = System.Drawing.Color.<color>; <--- Changes color of the form background color
            }

            ===========================================
            ******************************************/
            if (rb_Red.Checked == true && rb_Blue_2.Checked == true || rb_Red_2.Checked == true && rb_Blue.Checked == true)
            {
                this.BackColor = System.Drawing.Color.Purple;
            }
            else if (rb_Red.Checked == true && rb_Yellow_2.Checked == true || rb_Red_2.Checked == true && rb_Yellow.Checked == true)
            {
                this.BackColor = System.Drawing.Color.Orange;
            }
            else if (rb_Blue.Checked == true && rb_Yellow_2.Checked == true || rb_Blue_2.Checked == true && rb_Yellow.Checked == true)
            {
                this.BackColor = System.Drawing.Color.Green;
            }
            else if (rb_Red.Checked == true && rb_Red_2.Checked == true || rb_Red_2.Checked == true && rb_Red.Checked == true)
            {
                this.BackColor = System.Drawing.Color.Red;
            }
            else if (rb_Blue.Checked == true && rb_Blue_2.Checked == true || rb_Blue_2.Checked == true && rb_Blue.Checked == true)
            {
                this.BackColor = System.Drawing.Color.Blue;
            }
            else if (rb_Yellow.Checked == true && rb_Yellow_2.Checked == true || rb_Yellow_2.Checked == true && rb_Yellow.Checked == true)
            {
                this.BackColor = System.Drawing.Color.Yellow;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
