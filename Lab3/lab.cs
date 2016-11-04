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
    CP140 - Lab 3
    Michael Dorfman
    09/30/2016
    Revised: 11/04/2016 (1:13 AM)
*/

namespace CP140_lab3
{
    public partial class Form1 : Form
    {
        private int myVariable;

        public Form1()
        {
            InitializeComponent();
        }

        private void mysteryButton1_Click(object sender, EventArgs e)
        {
            doSomething();
        }

        private void mysteryButton2_Click(object sender, EventArgs e)
        {
            int anotherVariable;
            // write code here that will set the answer1label to disply the NAME of the 
            // field in this program
            answer1Label.Text = "anotherVariable";
            // add code that will change the text of the lonelyButton to disply click me
            //  but the k in click me will an access key
            lonelyButton.Text = "Clic&k me";
            answer2Label.Text = "<k> is now an access key and when pressed a messagebox shows and the label text changes color";
        }

        private void doSomething()
        {
            int intValue;
            if (this.valueTextbox.Text == "")
            {
                MessageBox.Show("You must enter a value in the textbox before you click me.");
            }
            else
            {
                if (int.TryParse(valueTextbox.Text, out intValue))
                {
                    MessageBox.Show("you enetered an integer: YAY!");
                    for (int i = 0; i < intValue; i++)
                    {
                        try
                        {
                            labelYouCantSeeMe.Text += "-" + (15 / i).ToString("n2");
                            //value i = 0
                            //value intValue = 10
                        }
                        catch
                        {
                            MessageBox.Show("nope, wow");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("I am looking for an integer");
                }
            }
        }

        private void lonelyButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ya?");
			
			//Changes font color to green
            answer1Label.ForeColor = System.Drawing.Color.Green;
			
			//Moves collection 15 pixels right from the left
            myCollection.Left = 15;
        }
    }
}
