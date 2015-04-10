// File Prologue
// Name: Aaron Merrill
// Course: CS 1400 003
// Project: 01
// Date: 9/10/2013
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

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // The exitToolStripMenuItem1 method
        // Purpose: closes the window and terminates the program
        // Parameters: The object generating the event 
        // and the event arguments
        // Returns: None
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // The aboutToolStripMenuItem method
        // Purpose: To show information about program
        // Parameters: The object generating the event 
        // and the event arguments
        // Returns: none
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aaron Merrill\n CS1400\n Project 01");
        }

        // The sumButton_Click method
        // Purpose: takes the sum of numOne and numTwo
        // Parameters: sender: The object generating the event 
        // and e: the event arguments
        // Returns: none
        private void sumButton_Click(object sender, EventArgs e)
        {

            double numOne = double.Parse(numBox1.Text);
            double numTwo = double.Parse(numBox2.Text);
            double theResult = numOne + numTwo;
            string outStr = String.Format("{0:f}", theResult);
            outputBox.Text = outStr;

        }

        // The diffButton_Click method
        // Purpose: takes the difference of numOne from numTwo
        // Parameters: sender: The object generating the event 
        // and e: the event arguments
        // Returns: none
        private void diffButton_Click(object sender, EventArgs e)
        {
            double numOne = double.Parse(numBox1.Text);
            double numTwo = double.Parse(numBox2.Text);
            double theResult = numOne - numTwo;
            string outStr = String.Format("{0:f}", theResult);
            outputBox.Text = outStr;
        }

        // The quoButton_Click method
        // Purpose: takes the quotient of numOne from numTwo
        // Parameters: sender: The object generating the event 
        // and e: the event arguments
        // Returns: none
        private void quoButton_Click(object sender, EventArgs e)
        {
            double numOne = double.Parse(numBox1.Text);
            double numTwo = double.Parse(numBox2.Text);
            double theResult = numOne / numTwo;
            string outStr = String.Format("{0:f}", theResult);
            outputBox.Text = outStr;
        }

        // The prodButton_Click method
        // Purpose: takes the product of numOne and numTwo
        // Parameters: sender: The object generating the event 
        // and e: the event arguments
        // Returns: none
        private void prodButton_Click(object sender, EventArgs e)
        {
            double numOne = double.Parse(numBox1.Text);
            double numTwo = double.Parse(numBox2.Text);
            double theResult = numOne * numTwo;
            string outStr = String.Format("{0:f}", theResult);
            outputBox.Text = outStr;
        }
        // The clearButton_Click method
        // Purpose: clears all text in textboxes
        // Parameters: sender: The object generating the event 
        // and e: the event arguments
        // Returns: none
        private void clearButton_Click(object sender, EventArgs e)
        {
            numBox1.Clear();
            numBox2.Clear();
            outputBox.Clear();
        }
    }
}
