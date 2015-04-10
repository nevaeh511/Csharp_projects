// File Prolog
// Name: Aaron Merrill
// CS 1400 Section 003
// Project: CS1400_Lab_10
// Date: 12/5/13
// 
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;
using System.IO;

static class Program
{
    const double NUM_A = 35.74;
    const double NUM_B = 0.6215;
    const double NUM_C = 35.75;
    const double NUM_D = 0.4275;
    const double EXPO = 0.16;

    static void Main()
    {
        Console.WriteLine("Chill Factor Calculator \n");
        Console.WriteLine("Aaron Merrill \nCS1400 Project 10");
        Console.WriteLine("----------------------------------------------\n");

        //Find path for inputed file name
        string environment = System.Environment.GetFolderPath
        (System.Environment.SpecialFolder.Personal) + "\\";

        //ask user for file name and save to variable
        Console.Write("Enter your file name for data input: ");
        string input = Console.ReadLine();
        //save concatenated variables to new variable
        string path = environment + input;
        //open the file
        StreamReader chillFactor = new StreamReader(path);
        //--------------------------------------------------------------------------------
        Console.WriteLine();
        string row;
        //Enter a do while loop
        do
        {
            //reads each line of text & stores in variable
            row = chillFactor.ReadLine();
            if (row != null)
            {
                //split numbers in each row
                string[] splitData = row.Split();

                //save first number from split row to variable
                double temperature = double.Parse(splitData[0]);

                //save second number from split row to variable
                double windSpeed = double.Parse(splitData[1]);

                //display results
                Console.WriteLine("With a temperature of {0:f0} degrees \nand wind speed of {1:f0} mph", temperature, windSpeed);
                Console.WriteLine("The Chill Factor will be {0:f} degrees fahrenheit \n", ChillFactorCalcutation(temperature, windSpeed));
            }
        } while (row != null);

        Console.ReadLine();
    }//End Main()

    // The ChillFactorCalculation method
    // Purpose: calculates wind speed and temperature for chill factor index.
    // Parameters: takes two numbers as doubles
    // Returns: a double of chill factor index
    static double ChillFactorCalcutation(double _t, double _v)
    {
        double temp = _t;
        double speed = _v;
        double chill = 0;
        chill = NUM_A + (NUM_B * temp) - (NUM_C * Math.Pow(speed, EXPO)) + (NUM_D * temp * Math.Pow(_v, EXPO));
        return chill;
    }

}//End class Program

