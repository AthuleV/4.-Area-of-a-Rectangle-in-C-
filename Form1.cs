using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.Area_of_a_Rectangle_in_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the length and width from user input
            if (double.TryParse(textBox1.Text, out double length) && length >= 0 &&
                double.TryParse(textBox2.Text, out double width) && width >= 0)
            {
                // Calculate the area of the rectangle: A = length * width
               double area = length * width;

                // Convert the area to a string and set it on textBox3
                textBox3.Text = area.ToString("F2");
            }
            else
            {
                // Display an error message if the input is invalid
                MessageBox.Show("Invalid input. Please enter non-negative numbers for length and width.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double length) && length >= 0 &&
                double.TryParse(textBox2.Text, out double width) && width >= 0)
            {
                // Calculate the perimeter of the rectangle: P = 2 * (length + width)
                double perimeter = 2 * (length + width);

                // Display the result
                textBox4.Text = perimeter.ToString("F2");
               
            }
            else
            {
                // Display an error message if the input is invalid
                MessageBox.Show("Invalid input. Please enter non-negative numbers for length and width.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
