/* Grading ID: B5989
   Program 3
   Due Date: 11/20/2016
   Course Section: CIS-199-75
   Description: This program asks you to enter completed credit hours (prior to fall 2016) and also asks
                you to enter your last name. This program will then use that information to determine your
                earliest registration date and time based on the UOFL priority registration schedule.
               
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2
{
    public partial class Form1 : Form
    {
        // Declare named constants and variables
        const double SENIOR_HOURS = 90; // will be used to check if user is senior
        const double JUNIOR_HOURS = 60; // will be used to check if user is junior
        const double SOPHOMORE_HOURS = 30; // will be used to check if user is sophomore
        const double FRESHMAN_HOURS = 30; // will be used to check if user is freshman
        const double MINIMUM_HOURS = 0; // will be used to validate that hours are not negative
        double hours; // completed hours
        char initial; // initial is a character
        string lastName; // student's last name

        public Form1()
        {
            InitializeComponent();
        }
        // precondition: First character of last name must be alphabet
        // postcondition: a registration time will be returned.
        private string GetTime(string initial)
        {
            // arrays for initials, and times
            string[] ini = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            string[] upperClassmenTimes = { "2:00 pm","2:00 pm", "2:00 pm","2:00 pm","4:00 pm","4:00 pm", "4:00 pm", "4:00 pm", "4:00 pm","8:30 am", "8:30 am", "8:30 am", "8:30 am", "8:30 am", "8:30 am","10:00 am", "10:00 am","10:00 am","10:00 am","11:30 am", "11:30 am", "11:30 am", "11:30 am", "11:30 am", "11:30 am", "11:30 am" };
            string[] lowerClassmenTimes = { "10:00 am","10:00 am","11:30 am", "11:30 am", "2:00 pm", "2:00 pm", "4:00 pm", "4:00 pm", "4:00 pm", "8:30 am", "8:30 am", "8:30 am", "10:00 am", "10:00 am", "10:00 am", "11:30 am", "11:30 am", "2:00 pm", "2:00 pm", "4:00 pm", "4:00 pm", "4:00 pm", "8:30 am", "8:30 am", "8:30 am", "8:30 am"};

            int index;                                   // Array subscript
            bool found = false;                         
            string time;                               // registration  time

            time = upperClassmenTimes[0];
            time = lowerClassmenTimes[0];                        
                                                        

            index = ini.Length - 1;            
                                                         
            while (index >= 0 && !found)
            {
                if (initial == ini[index])
                    found = true;
                else
                    --index;
            }

            if (found && hours >= JUNIOR_HOURS) // finds times for upperclassmen
                time = upperClassmenTimes[index];
            else if (found && hours < JUNIOR_HOURS) // finds time for lowerclassmen
                time = lowerClassmenTimes[index];

            return time; // returns the registration time

            // It keeps returning the time in the first postion of the array, can't figure it out, other than that i think i'm on the right track.

       }
        // when you click enter button
        private void enterBtn_Click(object sender, EventArgs e)
      {

            double.TryParse(hoursCompletedTxtBox.Text, out hours); // takes the text, converts to double and assigns to variable "hours".
            
            lastName = lastNameTxtBox.Text; // takes the text and assigns to the string variable "lastName"
            initial = lastName[0]; // defines initial as the first character from lastName.

            

            // Decision logic 

            if (double.TryParse(hoursCompletedTxtBox.Text, out hours)) // checks if conversion is successful
            {
                // if above conversion is succesful then the decison logic below is initiated

                // decision logic for seniors
                if (hours >= SENIOR_HOURS ) // checks if hours entered is (greater than or equal to required senior hours) 
                {
                    MessageBox.Show("Friday, November 4th. " + GetTime("")); // date and time output if above logic is correc
                }
                

                // decision logic for Juniors
                else if (hours >= JUNIOR_HOURS)
                {
                    MessageBox.Show("Monday, November 7th. " + GetTime(""));
                }
               


                // decision logic for sophomores
                else if (hours >= SOPHOMORE_HOURS && (initial >= 'J' && initial <= 'V'))
                {
                    MessageBox.Show("Wednesday, November 9th. " + GetTime(""));
                }
               
                else if (hours >= SOPHOMORE_HOURS && (initial <= 'I' && initial >= 'A') && (initial >= 'W' && initial <= 'Z'))
                {
                    MessageBox.Show("Thursday, November 10th. " + GetTime(""));
                }
                



                // decision logic for freshman
                else if (hours < FRESHMAN_HOURS && (initial >= 'J' && initial <= 'V'))
                {
                    MessageBox.Show("Friday, November 11th. " + GetTime(""));
                }
               
                else if ((hours < FRESHMAN_HOURS && hours >= MINIMUM_HOURS) && (initial <= 'I' && initial >= 'A') && (initial >= 'W' && initial <= 'Z'))
                {
                    MessageBox.Show("Monday, November 14th. " + GetTime(""));
                }
               


                // checks if  entered hours are less than minimum hours (should not be negative)
                else if (hours < MINIMUM_HOURS)
                {
                    MessageBox.Show("Enter Valid Hours!"); // output if hours are negative
                }

                // if initial is anything else other than A-Z
                else if (initial < 'A' || initial > 'Z')
                {
                    MessageBox.Show("Enter Valid Name!"); // output if initial is not between A-Z inclusive
                }
              

            }

            else
            {
                MessageBox.Show("Enter Credit Hours!"); // output if nothing is entered in credit hours textbox
            }
         
        }
    }

}
