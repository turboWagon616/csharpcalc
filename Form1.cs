/* John O'Rourke
 * c00102707
 * 3rd Year Advanced Programming - Software Development CW207
 * C# Lab 1 - Part 1 - Calculator
 * 10/1/2018 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculator1
{
    public partial class CalculatorFrame : Form
    {
        public CalculatorFrame()
        {
            InitializeComponent();
        }

        // Deal with button clicks - number buttons
        private void zero_Click(object sender, EventArgs e)
        {
            resultField.Text += 0;
        }

        private void one_Click(object sender, EventArgs e)
        {
            resultField.Text += 1;
        }

        private void two_Click(object sender, EventArgs e)
        {
            resultField.Text += 2;
        }

        private void three_Click(object sender, EventArgs e)
        {
            resultField.Text += 3;
        }

        private void four_Click(object sender, EventArgs e)
        {
            resultField.Text += 4;
        }

        private void five_Click(object sender, EventArgs e)
        {
            resultField.Text += 5;
        }

        private void six_Click(object sender, EventArgs e)
        {
            resultField.Text += 6;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            resultField.Text += 7;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            resultField.Text += 8;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            resultField.Text += 9;
        }

        // Deal with button clicks - operator and other buttons
        private void divide_Click(object sender, EventArgs e)
        {
            resultField.Text += " / ";
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            resultField.Text = "";
        }

        private void clearExisting_Click(object sender, EventArgs e)
        {
            resultField.Text = "";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            resultField.Text += " * ";
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            resultField.Text += " - ";
        }

        private void add_Click(object sender, EventArgs e)
        {
            resultField.Text += " + ";
        }

        // When equals button is pressed, do the calculation on the contents of the resultField
        private void equals_Click(object sender, EventArgs e)
        {
            string math = resultField.Text;
            string value = new DataTable().Compute(math, null).ToString();
            resultField.Text = "";
            resultField.Text = value;
        }
    }
}
