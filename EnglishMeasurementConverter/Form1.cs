using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishMeasurementConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Exit button will close the form or window
            this.Close();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //Reset button will clear all controls that can be changed by the user
            userInputBox.Text = "";
            userOutputBox.Text = "";
            fromListBox.ClearSelected();
            toListBox.ClearSelected();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            //Starting with the try/catch to display any possible errors to user
            try
            {
                //Creating variables
                double Number, Total = 0;

                //Setting Focus for user input
                userInputBox.Focus();

                //Input Validation
                if (!(double.TryParse(userInputBox.Text, out Number)))
                {
                    MessageBox.Show("Please input a valid number, Try again.");
                }

                //Math Time! (Inches to Yards)
                if (fromListBox.Text == "Inches" && toListBox.Text == "Yards") {
                    Total = Number / 36;
                    userOutputBox.Text = Total.ToString("f1") + " " + toListBox.Text;
                }

                //Math Time! (Inches to Feet)
                if (fromListBox.Text == "Inches" && toListBox.Text == "Feet")
                {
                    Total = Number / 12;
                    userOutputBox.Text = Total.ToString("f1") + " " + toListBox.Text;
                }

                //Math Time! (Feet to Yards)
                if (fromListBox.Text == "Feet" && toListBox.Text == "Yards")
                {
                    Total = Number / 3;
                    userOutputBox.Text = Total.ToString("f1") + " " + toListBox.Text;
                }

                //Math Time! (Feet to Inches)
                if (fromListBox.Text == "Feet" && toListBox.Text == "Inches")
                {
                    Total = Number * 12;
                    userOutputBox.Text = Total.ToString("f1") + " " + toListBox.Text;
                }

                //Math Time! (Yards to Inches)
                if (fromListBox.Text == "Yards" && toListBox.Text == "Inches")
                {
                    Total = Number * 36;
                    userOutputBox.Text = Total.ToString("f1") + " " + toListBox.Text;
                }
                //Math Time! (Yards to Feet)
                if (fromListBox.Text == "Yards" && toListBox.Text == "Feet")
                {
                    Total = Number * 3;
                    userOutputBox.Text = Total.ToString("f1") + " " + toListBox.Text;
                }

                //Math Time! (Same FROM and TO selected)
                if (fromListBox.SelectedItem == toListBox.SelectedItem)
                {
                    userOutputBox.Text = Number + " " + fromListBox.Text;
                }
            }

            //Catch will display any possible errors with program
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
