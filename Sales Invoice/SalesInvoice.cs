//Aaron Merrill
//CS 1400 003
//Project 04
//10/09/13
// 
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// -----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Invoice
{
    //The class blueprint for creation of SalesInvoice object
    class SalesInvoice
    {
        //Declares some constant variable of the class
        private const double STATE_TAX = .0745;
        private const double LOCAL_TAX = .025;

        //Declares some initial variables of the class
        private int units = 0;
        private double cost = 0.00;

        //Setter methods--------------------------------------------------------

        // The SetUnits method
        // Purpose: This set the item quanity value
        // Parameters: Takes an argument as a type integer
        // Returns: None
        public void SetUnits(int unitNum)
        {
            units = unitNum;
        }

        // The SetCost method
        // Purpose: This sets the value for the cost of items
        // Parameters: Takes an argument as type double
        // Returns: None
        public void SetCost(double costNum)
        {
            cost = costNum;
        }

        //Getter methods-----------------------------------------------------------

        // The GetUnits method
        // Purpose: Retrieves the value for the number of units
        // Parameters: None
        // Returns: The value for units as an integer
        public int GetUnits()
        {
            return units;
        }

        // The GetCost method
        // Purpose: Retrieves the value for the cost of units
        // Parameters: None
        // Returns: The value of the cost of units as a double
        public double GetCost()
        {
            return cost;
        }

        //Data manipulation methods-------------------------------------------------

        // The CalcStateTax method
        // Purpose: To calculate the amount for state sales tax
        // Parameters: None
        // Returns: The cost for state sales tax as a double
        public double CalcStateTax()
        {
            double stateTaxCost = STATE_TAX * CalcNetPrice();
            return stateTaxCost;
        }

        // The CalcLocalTax method
        // Purpose: To calculate the amount for local sales tax
        // Parameters: None
        // Returns: The cost for local sales tax as double
        public double CalcLocalTax()
        {
            double localTaxCost = LOCAL_TAX * CalcNetPrice();
            return localTaxCost;
        }

        // The CalcNetPrice method
        // Purpose: To calculate the net price of the sale
        // Parameters: None
        // Returns: The amount for net price as a double
        public double CalcNetPrice()
        {
            double netPrice = (double)(cost * units);
            return netPrice;
        }

        // The CalcGrossPrice method
        // Purpose: To calculate the gross price of the sale
        // Parameters: None
        // Returns: The amount for gross price as a double
        public double CalcGrossPrice()
        {
            double grossPrice = CalcNetPrice() + CalcLocalTax() + CalcStateTax();
            return grossPrice;
        }

    }
}
