// File Prolog
// Name: Rick Puckett & Aaron Merril
// CS 1400 Section 003
// Project: CS1400_Project_05
// Date: 10/18/13
// 
// We declare that the following code was written by us or provided 
// by the instructor for this project. We have spent at least 75% 
// pair programming this project. We understand that copying source
// code from any other source constitutes cheating, and that we will receive
// a zero on this project if we are found in violation of this policy.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_5
{
    //ShippingCalc Class
    public class ShippingCalc
    {
        //Constant Variables
        private double ST_CAT_A = 3.00;
        private double ST_CAT_B = 1.45;
        private double ST_HAWAII = 2.50;

        private double EX_CAT_A = 4.00;
        private double EX_CAT_B = 2.50;
        private double EX_HAWAII = 5.00;

        private double SAME_CAT_A = 5.50;
        private double SAME_CAT_B = 3.00;
        private double SAME_HAWAII = 8.00;

        //Variable
        private int items;
        private double weight;


        #region Setters 
        //Method: SetItems
        //Purpose: To set the initial item number
        //Parameters: items as integers
        //Returns: none
        public void SetItems(int item)
        {
            items = item;
        }
        //Method: SetWeight
        //Purpose: to set the initial weight
        //Parameters: weight as a double
        //Returns: none
        public void SetWeight(double wait)
        {
            weight = wait;
        }
        #endregion Setters

        #region Getters
        //Method: GetItems
        //Purpose: to get number of items from user
        //Parameters: none
        //Returns: number of items an integers
        public int GetItems()
        {
            return items;
        }

        //Method: GetWeight
        //Purpose: to get amount of weight from user
        //Parameters: none
        //Returns: amount of weight as doubles
        public double GetWeight()
        {
            return weight;
        }

        #endregion Getter

        #region Calculation Methods

        #region Standard Shipping Methods
        //Method: CalcStandardCatA
        //Purpose: calculate standard shipping rate by item
        //Parameters: none
        //Returns: standard shipping cost
        public double CalcStandardCatA()
        {
            return items * ST_CAT_A;
        }

        //Method: CalcStandardCatAHawaii
        //Purpose: calculate standard shipping with surcharge by item
        //Parameters: none
        //Returns: standard shipping cost with surcharge
        public double CalcStandardCatAHawaii()
        {
            return (items * ST_CAT_A) + ST_HAWAII;
        }

        //Method: CalcStandardCatB
        //Purpose: calculate standard shipping rate bt weight
        //Parameters: none
        //Returns: standard shipping cost
        public double CalcStandardCatB()
        {
            return weight * ST_CAT_B;
        }

        //Method: CalcStandardCatBHawaii
        //Purpose: calculate standard shipping with surcharge by weight
        //Parameters: none
        //Returns: standard shipping cost with surcharge
        public double CalcStandardCatBHawaii()
        {
            return (weight * ST_CAT_B) + ST_HAWAII;
        }

        #endregion Standard Shipping Methods

        #region Express Shipping Methods

        //Method:CalcExpressCatA
        //Purpose: calculate Express shipping by item
        //Parameters: none
        //Returns:Express shipping cost
        public double CalcExpressCatA()
        {
            return items * EX_CAT_A;
        }

        //Method:CalcExpressCatAHawaii
        //Purpose:calculate Express shipping by item with surcharge
        //Parameters:none
        //Returns:Express shipping cost with surcharge
        public double CalcExpressCatAHawaii()
        {
            return (items * EX_CAT_A) + EX_HAWAII;
        }

        //Method:CalcExpressCatB
        //Purpose:calculate Express shipping by weight
        //Parameters:none
        //Returns:Express shipping cost
        public double CalcExpressCatB()
        {
            return weight * EX_CAT_B;
        }

        //Method:CalcExpressCatBHawaii
        //Purpose:calculate Express shipping by weight with surcharge
        //Parameters:none
        //Returns:Express shipping cost with surcharge
        public double CalcExpressCatBHawaii()
        {
            return (weight * EX_CAT_B) + EX_HAWAII;
        }


        #endregion Express Shipping Methods

        #region SameDay Shipping Methods

        //Method:CalcSameCatA
        //Purpose: calculate Same day shipping by item
        //Parameters: none
        //Returns: Same day shipping cost
        public double CalcSameCatA()
        {
            return items * SAME_CAT_A;
        }

        //Method:CalcSameCatAHawaii
        //Purpose: calculate Same day shipping by item with surcharge
        //Parameters: none
        //Returns: Same day shipping cost
        public double CalcSameCatAHawaii()
        {
            return (items * SAME_CAT_A) + SAME_HAWAII;
        }

        //Method:CalcSameCatB
        //Purpose: calculate Same day shipping by weight
        //Parameters: none
        //Returns: Same day shipping cost
        public double CalcSameCatB()
        {
            return weight * SAME_CAT_B;
        }

        //Method:CalcSameCatBHawaii
        //Purpose: calculate Same day shipping by weight with surcharge
        //Parameters: none
        //Returns: Same day shipping cost
        public double CalcSameCatBHawaii()
        {
            return (weight * SAME_CAT_B) + SAME_HAWAII;
        }

        #endregion SameDay Shipping Methods

        #endregion Calculations



    }
}
