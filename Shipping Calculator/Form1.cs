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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_5
{
    //Class Form1
    public partial class Form1 : Form
    {

        //Setting reference to ShippingCalc Class
        ShippingCalc sc;

        public Form1()
        {
            InitializeComponent();
        }

        // Method: The exitToolStripMenuItem1 method
        // Purpose: To exit/terminate window upon selecting exit.  force close. 
        // Parameters: sending object and event methods
        // Return: no return
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Method: aboutToolStripMenuItem_Click
        //Purpose: shows an about box pop up
        //Parameters: sending object and event methods
        //Returns: none
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rick Puckett\nAaron Merrill\nCS1400\nProject 5");
        }


        //Method: comboBox3_SelectedIndexChanged
        //Purpose: to change lable based on weight or item
        //Parameters: sending object and event methods
        //Returns: none
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox3.Text != "Per Item")
            {
                label5.Text = "Number of Pounds:";
            }
            else 
            {
                label5.Text = "Number of Items:";
            }
        }

        //Method: calcShippingButton_Click
        //Purpose: to calculate overall shipping costs
        //Parameters: sending object and event methods
        //Returns: none
        private void calcShippingButton_Click(object sender, EventArgs e)
        {
            //Creates shipping calculator objuct
            sc = new ShippingCalc();

            //Getting info from text boxes and setting the item number and weight
            sc.SetItems(int.Parse(numbUnitsTxtBox.Text));
            sc.SetWeight(double.Parse(numbUnitsTxtBox.Text));

            //ship by item
            if (comboBox3.Text == "Per Item")
            {
                if (radioButton2.Checked == true)
                {
                    if (comboBox1.Text == "Standard")
                    {
                        shipCostsTxtBox.Text = string.Format("{0:C}", sc.CalcStandardCatA());
                    }
                    else if (comboBox1.Text == "Express")
                    {
                        shipCostsTxtBox.Text = string.Format("{0:C}", sc.CalcExpressCatA());
                    }
                    else
                    {
                        shipCostsTxtBox.Text = string.Format("{0:C}", sc.CalcSameCatA());
                    }
                }

                //ship by item with surcharge
                else if (radioButton2.Checked != true)
                {
                    if (comboBox1.Text == "Standard")
                    {
                        shipCostsTxtBox.Text = string.Format("{0:C}", sc.CalcStandardCatAHawaii());
                    }
                    else if (comboBox1.Text == "Express")
                    {
                        shipCostsTxtBox.Text = string.Format("{0:C}", sc.CalcExpressCatAHawaii());
                    }
                    else
                    {
                        shipCostsTxtBox.Text = string.Format("{0:C}", sc.CalcSameCatAHawaii());
                    }
                }
             }//end shipping by item

                //shipping by weight
                else if (comboBox3.Text == "By Weight")
                {
                  if (radioButton2.Checked == true)
                  {
                    if (comboBox1.Text == "Standard")
                    {
                        shipCostsTxtBox.Text = string.Format("{0:C}", sc.CalcStandardCatB());
                    }
                    else if (comboBox1.Text == "Express")
                    {
                        shipCostsTxtBox.Text = string.Format("{0:C}", sc.CalcExpressCatB());
                    }
                    else
                    {
                        shipCostsTxtBox.Text = string.Format("{0:C}", sc.CalcSameCatB());
                    }
                  }

                  //ship by weight with surcharge
                  else if (radioButton2.Checked != true)
                  {
                    if (comboBox1.Text == "Standard")
                    {
                        shipCostsTxtBox.Text = string.Format("{0:C}", sc.CalcStandardCatBHawaii());
                    }
                    else if (comboBox1.Text == "Express")
                    {
                        shipCostsTxtBox.Text = string.Format("{0:C}", sc.CalcExpressCatBHawaii());
                    }
                    else
                    {
                        shipCostsTxtBox.Text = string.Format("{0:C}", sc.CalcSameCatBHawaii());
                    }
                  }
              }//end by weight

        }//end calcShippingButton_Click method

    }//End Class Form1

}//end namespace
