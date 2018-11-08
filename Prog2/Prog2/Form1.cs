/* Grading ID: B5989
   Program 2
   Due Date: 10/16/2016
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
                if (hours >= SENIOR_HOURS && (initial >= 'J' && initial <= 'O')) // checks if hours entered is (greater than or equal to required senior hours) and (initial is between J-O, inclusive)
                {
                    MessageBox.Show("Friday, November 4th. 8:30 am"); // date and time output if above logic is correct
                }
                else if (hours >= SENIOR_HOURS && (initial >= 'P' && initial <= 'S'))
                {
                    MessageBox.Show("Friday, November 4th. 10:00 am");
                }
                else if (hours >= SENIOR_HOURS && (initial >= 'T' && initial <= 'Z'))
                {
                    MessageBox.Show("Friday, November 4th. 11:40 am");
                }
                else if (hours >= SENIOR_HOURS && (initial >= 'A' && initial <= 'D'))
                {
                    MessageBox.Show("Friday, November 4th. 2:00 pm");
                }
                else if (hours >= SENIOR_HOURS && (initial >= 'E' && initial <= 'I'))
                {
                    MessageBox.Show("Friday, November 4th. 4:00 pm");
                }


                // decision logic for Juniors
                else if (hours >= JUNIOR_HOURS && (initial >= 'J' && initial <= 'O'))
                {
                    MessageBox.Show("Monday, November 7th. 8:30 am");
                }
                else if (hours >= JUNIOR_HOURS && (initial >= 'P' && initial <= 'S'))
                {
                    MessageBox.Show("Monday, November 7th. 10:00 am");
                }
                else if (hours >= JUNIOR_HOURS && (initial >= 'T' && initial <= 'Z'))
                {
                    MessageBox.Show("Monday, November 7th. 11:40 am");
                }
                else if (hours >= JUNIOR_HOURS && (initial >= 'A' && initial <= 'D'))
                {
                    MessageBox.Show("Monday, November 7th. 2:00 pm");
                }
                else if (hours >= JUNIOR_HOURS && (initial >= 'E' && initial <= 'I'))
                {
                    MessageBox.Show("Monday, November 7th. 4:00 pm");
                }


                // decision logic for sophomores
                else if (hours >= SOPHOMORE_HOURS && (initial >= 'J' && initial <= 'L'))
                {
                    MessageBox.Show("Wednesday, November 9th. 8:30 am");
                }
                else if (hours >= SOPHOMORE_HOURS && (initial >= 'M' && initial <= 'O'))
                {
                    MessageBox.Show("Wednesday, November 9th. 10:00 am");
                }
                else if (hours >= SOPHOMORE_HOURS && (initial >= 'P' && initial <= 'Q'))
                {
                    MessageBox.Show("Wednesday, November 9th. 11:40 am");
                }
                else if (hours >= SOPHOMORE_HOURS && (initial >= 'R' && initial <= 'S'))
                {
                    MessageBox.Show("Wednesday, November 9th. 2:00 pm");
                }
                else if (hours >= SOPHOMORE_HOURS && (initial >= 'T' && initial <= 'V'))
                {
                    MessageBox.Show("Wednesday, November 9th. 4:00 pm");
                }
                else if (hours >= SOPHOMORE_HOURS && (initial >= 'W' && initial <= 'Z'))
                {
                    MessageBox.Show("Thursday, November 10th. 8:30 am");
                }
                else if (hours >= SOPHOMORE_HOURS && (initial >= 'A' && initial <= 'B'))
                {
                    MessageBox.Show("Thursday, November 10th. 10:00 am");
                }
                else if (hours >= SOPHOMORE_HOURS && (initial >= 'C' && initial <= 'D'))
                {
                    MessageBox.Show("Thursday, November 10th. 11:40 am");
                }
                else if (hours >= SOPHOMORE_HOURS && (initial >= 'E' && initial <= 'F'))
                {
                    MessageBox.Show("Thursday, November 10th. 2:00 pm");
                }
                else if (hours >= SOPHOMORE_HOURS && (initial >= 'G' && initial <= 'I'))
                {
                    MessageBox.Show("Thursday, November 10th. 4:00 pm");
                }



                // decision logic for freshman
                else if (hours < FRESHMAN_HOURS && (initial >= 'J' && initial <= 'L'))
                {
                    MessageBox.Show("Friday, November 11th. 8:30 am");
                }
                else if ((hours < FRESHMAN_HOURS && hours >= MINIMUM_HOURS) && (initial >= 'M' && initial <= 'O'))
                {
                    MessageBox.Show("Friday, November 11th. 10:00 am");
                }
                else if ((hours < FRESHMAN_HOURS && hours >= MINIMUM_HOURS) && (initial >= 'P' && initial <= 'Q'))
                {
                    MessageBox.Show("Friday, November 11th. 11:40 am");
                }
                else if ((hours < FRESHMAN_HOURS && hours >= MINIMUM_HOURS) && (initial >= 'R' && initial <= 'S'))
                {
                    MessageBox.Show("Friday, November 11th. 2:00 pm");
                }
                else if ((hours < FRESHMAN_HOURS && hours >= MINIMUM_HOURS) && (initial >= 'T' && initial <= 'V'))
                {
                    MessageBox.Show("Friday, November 11th. 4:00 pm");
                }
                else if ((hours < FRESHMAN_HOURS && hours >= MINIMUM_HOURS) && (initial >= 'W' && initial <= 'Z'))
                {
                    MessageBox.Show("Monday, November 14th. 8:30 am");
                }
                else if ((hours < FRESHMAN_HOURS && hours >= MINIMUM_HOURS) && (initial >= 'A' && initial <= 'B'))
                {
                    MessageBox.Show("Monday, November 14th. 10:00 am");
                }
                else if ((hours < FRESHMAN_HOURS && hours >= MINIMUM_HOURS) && (initial >= 'C' && initial <= 'D'))
                {
                    MessageBox.Show("Monday, November 14th. 11:40 am");
                }
                else if ((hours < FRESHMAN_HOURS && hours >= MINIMUM_HOURS) && (initial >= 'E' && initial <= 'F'))
                {
                    MessageBox.Show("Monday, November 14th. 2:00 pm");
                }
                else if ((hours < FRESHMAN_HOURS && hours >= MINIMUM_HOURS) && (initial >= 'G' && initial <= 'I'))
                {
                    MessageBox.Show("Monday, November 14th. 4:00 pm");
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
/*
  Things i couldn't figure out:
 
  Make a decision logic to test if Last name textbox is empty

  My code validates if first initial is an alphabet but i couldn't figure out how to validate the whole name
  example: !HARAMBE (since first character is not alphabetical my code will give an error messagebox)
           HARAMBE! (my code accepts the name because it only checks the first character to see if it's alphabetical)
 

 */
 