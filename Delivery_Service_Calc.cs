// File Prologue
// Name: Aaron Merrill, Kevin Larson
// Course: CS 1400 003
// Project: 02
// Date: 9/19/2013
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

namespace Good_Guys_Delivery_Service
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        // The aboutToolStripMenuItem2 method
        // Purpose: To show information about program
        // Parameters: The object generating the event 
        // and the event arguments
        // Returns: none
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aaron Merrill\n Kevin Larson\n CS 1400\n Project 02");
        }

        // The calculate method
        // Purpose: To calculate proper time for new delivery time
        // Parameters: The object generating the event 
        // and the event arguments
        // Returns: none
        private void calculate_Click(object sender, EventArgs e)
        {
            //Delcare constant values regaring 24 hour format
            int HUN_HOUR = 100;
            int MIN_PER_HOUR = 60;
            double TIME_PERCENTAGE = .25;


            //collect start time value into minutes--------------------------------------------------------

            //Get user value in step one.
            //convert value to integer and store in variable (startTime).
            int startTime = int.Parse(oldStart.Text);
            //Get user value in step two
            //convert value to integer and store in variable (endTime).
            int endTime = int.Parse(oldEnd.Text);

            //take startTime and divide it by 100 (or HUN_HOUR)
            int hourValueOne = startTime / HUN_HOUR;

            //get the remander of startTime divided by HUN_HOUR
            int remanderMinutesOne = startTime % HUN_HOUR;


            //take hourValue and multiply it by MIN_PER_HOUR (name it "minuteWithHour")
            int hourMinutesOne = hourValueOne * MIN_PER_HOUR;

            //take hourminutes and add the remander
            int startMinutesOne = hourMinutesOne + remanderMinutesOne;

            //Collect endtime value into mintues-----------------------------------------------------

            //take startTime and divide it by 100 (or HUN_HOUR)
            int hourValueTwo = endTime / HUN_HOUR;

            //get the remander of startTime divided by HUN_HOUR
            int remanderMinutesTwo = endTime % HUN_HOUR;

            //take hourValue and multiply it by MIN_PER_HOUR (name it "minuteWithHour")
            int hourMinutesTwo = hourValueTwo * MIN_PER_HOUR;

            //take hourminutes and add the remander
            int endMinutesTwo = hourMinutesTwo + remanderMinutesTwo;

            //New Arrival Calculation ---------------------------------------------------------------

            //subtract startMinutes from endMinutes 
            int minuteDifference = endMinutesTwo - startMinutesOne;

            //multiply total minutes by TIME_PERCENTAGE
            int percentMinutes = (int)(minuteDifference * TIME_PERCENTAGE);

            //add the percentage minutes to the total minutes
            int newTimeMinutes = percentMinutes + endMinutesTwo;

            //this is hours
            int newArrivalHour = newTimeMinutes / MIN_PER_HOUR;

            //this is minutes
            int newArrivalTimeRemainder = newTimeMinutes % MIN_PER_HOUR;

            //mulitply newArrival time by 100
            int newArrivalTimeFormat = newArrivalHour * HUN_HOUR;

            // take newArrivalTimeFormat and add it to the NewArrivalTimeReminder
            int newestTimeInFinalFormat = newArrivalTimeFormat + newArrivalTimeRemainder;

            //convert new time into string value
            string newTimeOutStr = string.Format("{0:d4}", newestTimeInFinalFormat);

            //display the new time value in the new arrival time text box
            newEnd.Text = newTimeOutStr;



        }
    }
}
