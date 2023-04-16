using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class testAverage : Form
    {
        public testAverage()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Add a try-catch block to catch any exceptions.
            try
            {
                double test1;
                double test2;
                double test3;
                double average;

                // Get the three test scores.
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);

                // Calculate the average test score.
                average = (test1 + test2 + test3) / 3.0;

                //Display the output of the average rounded to 1 decimal place
                averageLabel.Text = average.ToString("n1");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes and Label.
            test1TextBox.Clear();
            test2TextBox.Clear();
            test3TextBox.Clear();
            averageLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
