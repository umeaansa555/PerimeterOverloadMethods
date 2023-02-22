using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverloadMethods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            instructionLabel.Text = "Enter: \n\n1 value for a circle\n2 values for a rectangle";
        }

        private void areaButton_Click(object sender, EventArgs e)
        {
           
            double num1, num2, num3, answer;

            if (value1Input.Text == "" && value2Input.Text == "" && value3Input.Text == "")
            {
                areaOutput.Text = "Please enter at least 1 value";
            }
            else if (value2Input.Text == "" && value3Input.Text == "")
            {
                num1 = Convert.ToDouble(value1Input.Text);
                answer = Perimeter(num1);
                areaOutput.Text = $"The perimeter of the circle is {answer}";
            }

            else if (value3Input.Text == "")
            {
                num1 = Convert.ToDouble(value1Input.Text);
                num2 = Convert.ToDouble(value2Input.Text);
                answer = Perimeter(num1, num2);
                areaOutput.Text = $"The perimeter of the rectangle is {answer}";
            }
            else
            {
                num1 = Convert.ToDouble(value1Input.Text);
                num2 = Convert.ToDouble(value2Input.Text);
                num3 = Convert.ToDouble(value3Input.Text);
                answer = Perimeter(num1, num2, num3);
                areaOutput.Text = $"The perimeter of the triangle is {answer}";
            }
        }

        public double Perimeter(double diameter)
        {
            double p = 3.14 * diameter;
            return p;
        }
        public double Perimeter(double length, double width)
        {
            double p = (2 * length) * (2 * width);
            return p;

        }
        public double Perimeter(double a, double b, double c)
        {
            double p = a + b + c;
            return p;
            
        }
    }
}
