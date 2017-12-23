using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime___Michael_Dorfman
{
    public partial class Form1 : Form
    {

        bool IsPrime(int number)
        {
            int i;
            for (i = 2; i <= number - 1; i++)
            {
                if (number % i == 0)
                {
                    return true;
                }
            }
            if (i == number)
            {
                return true;
            }
            return false;

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            int input = 0;
            bool checkvar;

            do
            {
                checkvar = IsPrime(input);
                if (checkvar == true)
                {
                    PrimeOut.Items.Add(input);
                }
                else if (checkvar == false)
                {
                    PrimeOut.Items.Add("NOT PRIME");
                }
                input++;
            } while (input <= 100);
        }
    }
}
