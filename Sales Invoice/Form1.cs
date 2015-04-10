//Aaron Merrill
//CS 1400 003
//Project 04
//10/09/13
// 
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_Invoice
{
    public partial class Form1 : Form
    {
        //A class level reference to a sales invoice
        private SalesInvoice si;

        public Form1()
        {
            InitializeComponent();

            //Creates a new sales invoice object
            si = new SalesInvoice();
        }

        // The exitToolStripMenuItem1 method
        // Purpose: To close the window and terminate the application
        // Parameters: The object generating the event 
        // and the event arguments
        // Returns: None
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // The aboutToolStripMenuItem method
        // Purpose: shows additional information about program
        // Parameters: The object generating the event 
        // and the event arguments
        // Returns: None
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aaron Merrill \nCS 1400 \nProject 4");
        }

        // The purchaseBtn method
        // Purpose: to activate the sales invoice by calculating expressions
        // and calling various methods from the Sales Invoice class
        // Parameters: The object generating the event 
        // and the event arguments
        // Returns: None
        private void purchaseBtn_Click(object sender, EventArgs e)
        {
            //Assigns user input to variable and sets it in the respective method
            double cost = double.Parse(priceTxBx.Text);
            si.SetCost(cost);

            //Assigns user input to variable and sets it in the respective method
            int units = int.Parse(unitsTxBx.Text);
            si.SetUnits(units);

            //Calls methods to retrieve the cost and the unit quantity
            si.GetCost();
            si.GetUnits();

            //Calls multiple methods to calculate cost and taxes
            si.CalcNetPrice();
            si.CalcGrossPrice();
            si.CalcLocalTax();
            si.CalcStateTax();
         
            //Calculates the net price and assigns to variable
            double netPrice = si.CalcNetPrice();
            //Calculates the gross price and assigns to variable
            double grossPrice = si.CalcGrossPrice();
            //Calculates the local tax price and assigns to variable
            double localTaxPrice = si.CalcLocalTax();            
            //Calculates the state tax price and assigns to variable
            double stateTaxPrice = si.CalcStateTax();            
            //Creates a pop up windows box that shows all values for the sales invoice
            MessageBox.Show(string.Format("Sales Invoice.... \nQuantity: {0} units \n Price: {1:c} each \n------------------\nNet Price: {2:c} \nState Sales Tax: {3:c} \nLocal Sales Tax: {4:c} \nTotal Price: {5:c}", units, cost, netPrice, stateTaxPrice, localTaxPrice, grossPrice));         
        }

        // The clearBtn method
        // Purpose: This clears all textboxes in the form
        // Parameters: The object generating the event 
        // and the event arguments
        // Returns: None
        private void clearBtn_Click(object sender, EventArgs e)
        {
            //clears all values in the quantity text box
            unitsTxBx.Clear();
            //clears all values in the price text box
            priceTxBx.Clear();
        }

    }
}
