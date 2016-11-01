using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Project: Workshop Selector
//Class: CP140
//Author: Michael Dorfman
//Date: 10/23/2016
//Extensive documentation has been provided 
// to better understand the program

namespace Assignment_1___Workshop_Selector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Add Workshops
            lb_workshop.Items.Add("Handling Stress"); //3 days      reg = 1000
            lb_workshop.Items.Add("Time Management"); //3 days     reg = 800
            lb_workshop.Items.Add("Supervision Skills"); //3 days  reg = 1500
            lb_workshop.Items.Add("Negotiation"); //5 days         reg = 1300
            lb_workshop.Items.Add("How to Interview"); //1 days     reg = 500

            //Add Locations
            lb_location.Items.Add("Austin"); //$150 lodging
            lb_location.Items.Add("Chicago"); //$225 lodging
            lb_location.Items.Add("Dallas"); //$175 lodging
            lb_location.Items.Add("Orlando"); //$300 lodging
            lb_location.Items.Add("Phoenix"); //$175 lodging
            lb_location.Items.Add("Raleigh"); //$150 lodging
        }

        /*
            *** CALCULATION FUNCTION ***
            Recieves 3 integers and performs a calculation and returns
            a result based on a calculation
        */
        public double calcTotal(int reg, int days, int lodge)
        {
            int result = reg + (lodge * days);
            return result;
        }

        /******************************************
         DOCUMENTATION FOR IF / ELSEIF STATETMENTS
        ===========================================

            *** WORKING VARIABLES ***
            _reg = #; <--- Registration Cost as Int
            _days = #; <--- Workshop Days as Int
            _workshop = "WorkshopName"; <--- Workshop Name as String

            *** IF/ELSE IF STATEMENT EXPLAINED ***

            ** COMPARES STRING VALUES **
            if((string)lb_workshop.SelectedItem == _workshop && (string)lb_location.SelectedItem == "LocationName") 
            {
                _lodge = 150; <--- Lodging Cost (Changes depending on location)
                txtRegistration.Text = "$" + _reg.ToString(); <--- Registration # to string to textbox text
                txtLodging.Text = "$" + _lodge.ToString(); <--- Lodging Cost # to string to textbox text
                txtTotal.Text = "$" + calcTotal(_reg, _days, _lodge).ToString(); <--- Output of function to string to textbox text
            }


        ===========================================
        ******************************************/

        private void btn_Process_Click(object sender, EventArgs e)
        {
            //Variable Declaration
            int _reg, _lodge, _days;
            string _workshop;

            //Handling Stress Selection
            _reg = 1000;
            _days = 3;
            _workshop = "Handling Stress";
            if((string)lb_workshop.SelectedItem == _workshop && (string)lb_location.SelectedItem == "Austin")
            {
                _lodge = 150;
                txtRegistration.Text = "$" + _reg.ToString();
                txtLodging.Text = "$" + _lodge.ToString();
                txtTotal.Text = "$" + calcTotal(_reg, _days, _lodge).ToString();
            }
            else if((string)lb_workshop.SelectedItem == _workshop && (string)lb_location.SelectedItem == "Chicago")
            {
                _lodge = 225;
                txtRegistration.Text = "$" + _reg.ToString();
                txtLodging.Text = "$" + _lodge.ToString();
                txtTotal.Text = "$" + calcTotal(_reg, _days, _lodge).ToString();
            }
            else if ((string)lb_workshop.SelectedItem == _workshop && (string)lb_location.SelectedItem == "Dallas")
            {
                _lodge = 175;
                txtRegistration.Text = "$" + _reg.ToString();
                txtLodging.Text = "$" + _lodge.ToString();
                txtTotal.Text = "$" + calcTotal(_reg, _days, _lodge).ToString();
            }
            else if ((string)lb_workshop.SelectedItem == _workshop && (string)lb_location.SelectedItem == "Orlando")
            {
                _lodge = 300;
                txtRegistration.Text = "$" + _reg.ToString();
                txtLodging.Text = "$" + _lodge.ToString();
                txtTotal.Text = "$" + calcTotal(_reg, _days, _lodge).ToString();
            }
            else if ((string)lb_workshop.SelectedItem == _workshop && (string)lb_location.SelectedItem == "Phoenix")
            {
                _lodge = 175;
                txtRegistration.Text = "$" + _reg.ToString();
                txtLodging.Text = "$" + _lodge.ToString();
                txtTotal.Text = "$" + calcTotal(_reg, _days, _lodge).ToString();
            }
            else if ((string)lb_workshop.SelectedItem == _workshop && (string)lb_location.SelectedItem == "Raleigh")
            {
                _lodge = 150;
                txtRegistration.Text = "$" + _reg.ToString();
                txtLodging.Text = "$" + _lodge.ToString();
                txtTotal.Text = "$" + calcTotal(_reg, _days, _lodge).ToString();
            }

            //Time Management Selection
            _reg = 800;
            _days = 3;
            _workshop = "Time Management";
            if ((string)lb_workshop.SelectedItem == _workshop && (string)lb_location.SelectedItem == "Austin")
            {
                _lodge = 150;
                txtRegistration.Text = "$" + _reg.ToString();
                txtLodging.Text = "$" + _lodge.ToString();
                txtTotal.Text = "$" + calcTotal(_reg, _days, _lodge).ToString();
            }
            else if ((string)lb_workshop.SelectedItem == _workshop && (string)lb_location.SelectedItem == "Chicago")
            {
                _lodge = 225;
                txtRegistration.Text = "$" + _reg.ToString();
                txtLodging.Text = "$" + _lodge.ToString();
                txtTotal.Text = "$" + calcTotal(_reg, _days, _lodge).ToString();
            }
            else if ((string)lb_workshop.SelectedItem == _workshop && (string)lb_location.SelectedItem == "Dallas")
            {
                _lodge = 175;
                txtRegistration.Text = "$" + _reg.ToString();
                txtLodging.Text = "$" + _lodge.ToString();
                txtTotal.Text = "$" + calcTotal(_reg, _days, _lodge).ToString();
            }
            else if ((string)lb_workshop.SelectedItem == _workshop && (string)lb_location.SelectedItem == "Orlando")
            {
                _lodge = 300;
                txtRegistration.Text = "$" + _reg.ToString();
                txtLodging.Text = "$" + _lodge.ToString();
                txtTotal.Text = "$" + calcTotal(_reg, _days, _lodge).ToString();
            }
            else if ((string)lb_workshop.SelectedItem == _workshop && (string)lb_location.SelectedItem == "Phoenix")
            {
                _lodge = 175;
                txtRegistration.Text = "$" + _reg.ToString();
                txtLodging.Text = "$" + _lodge.ToString();
                txtTotal.Text = "$" + calcTotal(_reg, _days, _lodge).ToString();
            }
            else if ((string)lb_workshop.SelectedItem == _workshop && (string)lb_location.SelectedItem == "Raleigh")
            {
                _lodge = 150;
                txtRegistration.Text = "$" + _reg.ToString();
                txtLodging.Text = "$" + _lodge.ToString();
                txtTotal.Text = "$" + calcTotal(_reg, _days, _lodge).ToString();
            }

            //Supervision Skills Selection
            _reg = 1500;
            _days = 3;
            _workshop = "Supervision Skills";
            if ((string)lb_workshop.SelectedItem == _workshop && (string)lb_location.SelectedItem == "Austin")
            {
                _lodge = 150;
                txtRegistration.Text = "$" + _reg.ToString();
                txtLodging.Text = "$" + _lodge.ToString();
                txtTotal.Text = "$" + calcTotal(_reg, _days, _lodge).ToString();
            }
            else if ((string)lb_workshop.SelectedItem == _workshop && (string)lb_location.SelectedItem == "Chicago")
            {
                _lodge = 225;
                txtRegistration.Text = "$" + _reg.ToString();
                txtLodging.Text = "$" + _lodge.ToString();
                txtTotal.Text = "$" + calcTotal(_reg, _days, _lodge).ToString();
            }
            else if ((string)lb_workshop.SelectedItem == _workshop && (string)lb_location.SelectedItem == "Dallas")
            {
                _lodge = 175;
                txtRegistration.Text = "$" + _reg.ToString();
                txtLodging.Text = "$" + _lodge.ToString();
                txtTotal.Text = "$" + calcTotal(_reg, _days, _lodge).ToString();
            }
            else if ((string)lb_workshop.SelectedItem == _workshop && (string)lb_location.SelectedItem == "Orlando")
            {
                _lodge = 300;
                txtRegistration.Text = "$" + _reg.ToString();
                txtLodging.Text = "$" + _lodge.ToString();
                txtTotal.Text = "$" + calcTotal(_reg, _days, _lodge).ToString();
            }
            else if ((string)lb_workshop.SelectedItem == _workshop && (string)lb_location.SelectedItem == "Phoenix")
            {
                _lodge = 175;
                txtRegistration.Text = "$" + _reg.ToString();
                txtLodging.Text = "$" + _lodge.ToString();
                txtTotal.Text = "$" + calcTotal(_reg, _days, _lodge).ToString();
            }
            else if ((string)lb_workshop.SelectedItem == _workshop && (string)lb_location.SelectedItem == "Raleigh")
            {
                _lodge = 150;
                txtRegistration.Text = "$" + _reg.ToString();
                txtLodging.Text = "$" + _lodge.ToString();
                txtTotal.Text = "$" + calcTotal(_reg, _days, _lodge).ToString();
            }

            //Negotiation Selection
            _reg = 1300;
            _days = 5;
            _workshop = "Negotiation";
            if ((string)lb_workshop.SelectedItem == _workshop && (string)lb_location.SelectedItem == "Austin")
            {
                _lodge = 150;
                txtRegistration.Text = "$" + _reg.ToString();
                txtLodging.Text = "$" + _lodge.ToString();
                txtTotal.Text = "$" + calcTotal(_reg, _days, _lodge).ToString();
            }
            else if ((string)lb_workshop.SelectedItem == _workshop && (string)lb_location.SelectedItem == "Chicago")
            {
                _lodge = 225;
                txtRegistration.Text = "$" + _reg.ToString();
                txtLodging.Text = "$" + _lodge.ToString();
                txtTotal.Text = "$" + calcTotal(_reg, _days, _lodge).ToString();
            }
            else if ((string)lb_workshop.SelectedItem == _workshop && (string)lb_location.SelectedItem == "Dallas")
            {
                _lodge = 175;
                txtRegistration.Text = "$" + _reg.ToString();
                txtLodging.Text = "$" + _lodge.ToString();
                txtTotal.Text = "$" + calcTotal(_reg, _days, _lodge).ToString();
            }
            else if ((string)lb_workshop.SelectedItem == _workshop && (string)lb_location.SelectedItem == "Orlando")
            {
                _lodge = 300;
                txtRegistration.Text = "$" + _reg.ToString();
                txtLodging.Text = "$" + _lodge.ToString();
                txtTotal.Text = "$" + calcTotal(_reg, _days, _lodge).ToString();
            }
            else if ((string)lb_workshop.SelectedItem == _workshop && (string)lb_location.SelectedItem == "Phoenix")
            {
                _lodge = 175;
                txtRegistration.Text = "$" + _reg.ToString();
                txtLodging.Text = "$" + _lodge.ToString();
                txtTotal.Text = "$" + calcTotal(_reg, _days, _lodge).ToString();
            }
            else if ((string)lb_workshop.SelectedItem == _workshop && (string)lb_location.SelectedItem == "Raleigh")
            {
                _lodge = 150;
                txtRegistration.Text = "$" + _reg.ToString();
                txtLodging.Text = "$" + _lodge.ToString();
                txtTotal.Text = "$" + calcTotal(_reg, _days, _lodge).ToString();
            }

            //How to Interview Selection
            _reg = 500;
            _days = 1;
            _workshop = "How to Interview";
            if ((string)lb_workshop.SelectedItem == _workshop && (string)lb_location.SelectedItem == "Austin")
            {
                _lodge = 150;
                txtRegistration.Text = "$" + _reg.ToString();
                txtLodging.Text = "$" + _lodge.ToString();
                txtTotal.Text = "$" + calcTotal(_reg, _days, _lodge).ToString();
            }
            else if ((string)lb_workshop.SelectedItem == _workshop && (string)lb_location.SelectedItem == "Chicago")
            {
                _lodge = 225;
                txtRegistration.Text = "$" + _reg.ToString();
                txtLodging.Text = "$" + _lodge.ToString();
                txtTotal.Text = "$" + calcTotal(_reg, _days, _lodge).ToString();
            }
            else if ((string)lb_workshop.SelectedItem == _workshop && (string)lb_location.SelectedItem == "Dallas")
            {
                _lodge = 175;
                txtRegistration.Text = "$" + _reg.ToString();
                txtLodging.Text = "$" + _lodge.ToString();
                txtTotal.Text = "$" + calcTotal(_reg, _days, _lodge).ToString();
            }
            else if ((string)lb_workshop.SelectedItem == _workshop && (string)lb_location.SelectedItem == "Orlando")
            {
                _lodge = 300;
                txtRegistration.Text = "$" + _reg.ToString();
                txtLodging.Text = "$" + _lodge.ToString();
                txtTotal.Text = "$" + calcTotal(_reg, _days, _lodge).ToString();
            }
            else if ((string)lb_workshop.SelectedItem == _workshop && (string)lb_location.SelectedItem == "Phoenix")
            {
                _lodge = 175;
                txtRegistration.Text = "$" + _reg.ToString();
                txtLodging.Text = "$" + _lodge.ToString();
                txtTotal.Text = "$" + calcTotal(_reg, _days, _lodge).ToString();
            }
            else if ((string)lb_workshop.SelectedItem == _workshop && (string)lb_location.SelectedItem == "Raleigh")
            {
                _lodge = 150;
                txtRegistration.Text = "$" + _reg.ToString();
                txtLodging.Text = "$" + _lodge.ToString();
                txtTotal.Text = "$" + calcTotal(_reg, _days, _lodge).ToString();
            }

        }
    }
}
