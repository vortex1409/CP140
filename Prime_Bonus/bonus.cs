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
    Project: Prime - Bonus Assignment (Q8 & Q9)
    Description: Checks to see if number is prime and then prints then adds number to a listbox
    Class: CP140 - OOP1
    Name: Michael Dorfman
    Date: 11/15/2016
*/
namespace Prime___Michael_Dorfman
{
    public partial class Form1 : Form
    {
        // Prime Number Checker Function
        // Recieves integer value
        // Returns boolean value
        bool IsPrime(int input)
        {
            // Checks to see if the input number has a remainder
            // if the number's remainder is equal to 0 the number is not prime
            if (input > 1)
            {
                for (int i = 2; i <= (input / 2); i++)
                {
                    // If mod result is eequal to zero then nymber is prime
                    if ((input % i) == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            // If number is less than 1 then it is not prime by definition
            else
            {
                return false;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Ignore
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            // For Loop increments  by one, starting at 1 and goes to 100
            // If statement inside For Loop takes value of the increment
            // and passes it through the is prime function and if the value
            // is true the number is added to the listbox
            for (int cv = 1; cv < 100; cv++)
            {
                if (IsPrime(cv) == true)
                {
                    PrimeOut.Items.Add(cv);
                }
            }
        }
    }
}
