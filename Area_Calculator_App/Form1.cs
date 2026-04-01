using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area_Calculator_App
{
    public partial class Form1 : Form
    {
        //Pabitra Shrestha
        //13/02/2026
        //Area Calculator
        public Form1()
        {
            InitializeComponent();
        }

        //event Handler for the calculate button
        //Identifies the selected shape, perform the calculation and display step by step process
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Validation Check
            //check if the radio button and cumbo box are selected 
            if ((rdbCircle.Checked && cmbRadius.SelectedIndex == -1) ||
                (rdbTriangle.Checked && cmbBase.SelectedIndex == -1) ||
                (rdbRectangle.Checked && cmbLength.SelectedIndex == -1) ||
                (rdbSquare.Checked && cmbSideLength.SelectedIndex == -1))

                {

                lblResult.Text = " Error:select unit.";
                    return;

                }
            
            try
            {
                //Initialize a string for final result
                string resultText = "";

                //1. Circle Calculation
                if (rdbCircle.Checked)
                {
                    //Convert input text to double and select the unit
                    double r = double.Parse(txtRadius.Text);
                    string unit = cmbRadius.SelectedItem?.ToString() ?? "units";
                    //V

                    //Circle: Area = π * r²
                    // double area = Math.PI * Math.Pow(r, 2);
                    double area = CalculateCircleArea(r);
                    //Validation for Negative number
                    if (r <= 0)
                    {
                        MessageBox.Show("Please enter Positive Number");
                        return;
                    }

                    //Build the display string with formula 
                    resultText = "Shape: Circle\n" +
                                 "Area = π * r²\n" +
                                 $"Area = 3.14159 x ({r} x {r})\n" +
                                 $"Total: {area:F2} Square {unit}";
                }

                //2. Triangle Calculation
                else if (rdbTriangle.Checked)
                {
                    //Convert input text to double and select the unit
                    double b = double.Parse(txtBase.Text);
                    double height = double.Parse(txtHeight.Text);
                    string unit = cmbBase.SelectedItem?.ToString() ?? "units";

                    //Math: Area = 0.5 * b *h 
                    //Calling Method 
                    double area = CalculateTriangleArea( b, height);

                    //validation for Negative Number
                    if(b<=0 || height <= 0)
                    {
                        MessageBox.Show("Please Enter the Positive NUmber");
                        return;
                    }


                    //display the result
                    resultText = "SHAPE: Triangle\n" +
                                "Area = (Base x Height) / 2\n" +
                                $"({b}x{height}) /2 \n" +
                                $"TOTAL : {area} Square {unit}";

                }

                //3. Rectangle Calculation
                else if (rdbRectangle.Checked)
                {
                    //Convert input text
                    double length = double.Parse(txtLength.Text);
                    double width = double.Parse(txtWidth.Text);
                    string unit = cmbWidth.SelectedItem?.ToString() ?? "units";

                    //Area= length * Width
                    //Calling method
                    double area = CalculateRectangleArea(length, width);

                    // validation for Negative Numbers
                    if(length <= 0 || width <= 0)
                    {
                        MessageBox.Show("Please Enter the positive number");
                        return;
                    }
                    //display result
                    resultText = " SHAPE: Rectangle\n" +
                                "Area = Length x Width \n" +
                                $"{length}x{width}\n" +
                                $"TOTAL: {area:F2} Square {unit}";
                }

                //4. Square Calculation
                else if (rdbSquare.Checked)
                {
                    double side = double.Parse(txtSideLength.Text);
                    string unit = cmbSideLength.SelectedItem?.ToString() ?? "units";

                    //Ares = side * Side
                    //calling method
                    double area = CalculateSquareArea(side);

                    //Validation for negative side length
                    if(side <= 0)
                    {
                        MessageBox.Show("Please Enter the Positive Number");
                        return;
                    }

                    //Display result
                    resultText = "SHAPE: Square\n" +
                                "Area= Side²\n" +
                                $"{side}x{side}\n" +
                                $"TOTAL: {area:F2} Square {unit}";
                }
                else
                {
                    //if no radio button is selected
                    resultText = "Please select a shape to calculate.";
                }
                

                //Display the final built string in the result label
                lblResult.Text = resultText;

            }
            catch (FormatException)
            {
                //error is the user enter text or leave field empty
                lblResult.Text = "Error:numeric values only";

            }
            catch (Exception ex) 
            { 
                //Catch all other unexpected errors
                lblResult.Text = "Error:" + ex.Message;
            }


        }
        //Method to calculate Circle area
        private double CalculateCircleArea(double radius)
        {
            //Convert input text to double and select the unit
            double r = double.Parse(txtRadius.Text);
            //Circle: Area = π * r²
            double area = Math.PI * Math.Pow(r, 2);
            return area;

        }

        //method to calculate Area of Triangle
        private double CalculateTriangleArea(double b, double height)
        {
            //base = double.Parse(txtBase.Text);
            // height = double.Parse(txtHeight.Text);

            double area = 0.5 * b * height;
            return area;
        }

        //Method to calculate Area of Rectangle
        private double CalculateRectangleArea(double length, double width)
        {
            // length = double.Parse(txtLength.Text);
            //width = double.Parse(txtWidth.Text);

            double area = length * Width;
            return area;

        }

        //Method to calculate Area of Square
        private double CalculateSquareArea(double side)
        {
            double area = side*side;
            return area;

        }

        //reset all the input fields 
        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear all the text input boxes
            txtRadius.Text = "";
            txtBase.Text = "";
            txtHeight.Text = "";
            txtLength.Text = "";
            txtWidth.Text = "";
            txtSideLength.Text = "";
            cmbRadius.SelectedIndex = -1;
            cmbBase.SelectedIndex = -1;
            cmbHeight.SelectedIndex = -1;
            cmbLength.SelectedIndex = -1;
            cmbWidth.SelectedIndex = -1;
            cmbSideLength.SelectedIndex = -1;


            //Resett the Display unit label
            lblResult.Text = "The Results Displays here";

            // Unchecked radio buttons
            rdbCircle.Checked = false;
            rdbTriangle.Checked = false;
            rdbRectangle.Checked = false;
            rdbSquare.Checked = false;

        }

        //Close the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //change the selection of unit
        private void cmbBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBase.SelectedIndex != -1)
            {
                
                cmbHeight.SelectedIndex = cmbBase.SelectedIndex;
            }
        }

        //if user select the length unit, the width to match immediately
        private void cmbLength_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLength.SelectedIndex != -1)
            {
                
                cmbWidth.SelectedIndex = cmbLength.SelectedIndex;
            }
        }
        //end of cmblength_selected 
    }
}
