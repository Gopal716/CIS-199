// Grading ID: B5989
// Program 1
// Due Date: 9/27/2016
// Course Section: CIS-199-75
// Description: This program requires a user to enter 3 sets of data into some text boxes (Wall space,
//              Coats of paint desired, and price of paint per gallon). When you click the calculate
//              button, the program will return some values (Total wall space to be painted, Total gallons of
//              paint required, e.t.c.)
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog1
{
    public partial class program1Form : Form
 {
        // Declare variables
        const double LABOR_PER_HOUR = 12.50; // labor per hour is 12.50
        const double STANDARD_WALL_SPACE_PER_GALLON = 275; // wall space in sq ft painted using 1 gallon
        const double STANDARD_HOURS = 8; // time in hours required to paint 275 sq ft of wall
        double Wall_Space; // actual wall space 
        double Total_Space; // determined by actual wall space and coats desired
        double Total_Gallons; // Gallons of paint required
        double Hours; // number of hours required
        int Coats; // desired number of coats
        double PAINT_PRICE; // price of paint per gallon
        double Total_Paint_Price; // price of all the gallons of paint required
        double Total_Labor; // total cost of labor
        double Total_Cost; // total cost of the entire job

        public program1Form()
        {
            InitializeComponent();
        }
        // Calculate button Event Handler
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // captures input data and assigns them to the following variables
            Wall_Space = double.Parse(wallSpaceTextBox.Text); // captures text from wallSpaceTextBox and turns it into a double
            Coats = int.Parse(coatsOfPaintTextBox.Text); // captures text from coatsOfPaintTextBox and turns it into an int
            PAINT_PRICE = double.Parse(paintPriceTextBox.Text); // captures text from paintPriceTextBox and turns it into a double
            

            
            // calculations
            Total_Space = Wall_Space * Coats; // calculates Total wall space by multiplying actual wall space to number of coats
            Total_Gallons = Math.Ceiling((Total_Space / STANDARD_WALL_SPACE_PER_GALLON)); // calculates the required gallons of paint and rounds it to the next whole number.
            Hours = (Total_Space / STANDARD_WALL_SPACE_PER_GALLON) * STANDARD_HOURS; // calculates hours required for the paint job
            Total_Paint_Price = Total_Gallons * PAINT_PRICE; // calculates total cost for the paint only
            Total_Labor = Hours * LABOR_PER_HOUR; // calculates total labor cost
            Total_Cost = Total_Labor + Total_Paint_Price; // calculates total cost for the whole job
            

            totalWallSpaceOutputLabel.Text = Total_Space.ToString("n1"); // displays total space value on its label after converting to a string, rounded to 1 decimal space
            totalGallonsOutputLabel.Text = Total_Gallons.ToString("n0"); // displays total gallons value on its label after converting to a string, rounded to 0 decimal space
            hoursOutputLabel.Text = Hours.ToString("n1"); // displays total hours value on its label after converting to a string, rounded to 1 decimal space
            paintCostOutputLabel.Text = Total_Paint_Price.ToString("c"); // displays total paint price in currency format after converting to a string
            laborCostOutputLabel.Text = Total_Labor.ToString("c"); // displays total labor cost in currency format after converting to a string
            totalCostOutputLabel.Text = Total_Cost.ToString("c"); // displays total job cost in currency format after converting to a string
        }
    }
}
