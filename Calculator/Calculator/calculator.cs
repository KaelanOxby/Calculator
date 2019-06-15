// Kaelan Oxby
// 15/6/2019
// V1.0

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        // When the Button is pressed Takes the text from the button and places it
        // on the Display text Field.(1)
        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnOne.Text;
        }

        // When the Button is pressed Takes the text from the button and places it
        // on the Display text Field.(2)
        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnTwo.Text;
        }

        // When the Button is pressed Takes the text from the button and places it
        // on the Display text Field.(3)
        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnThree.Text;
        }

        // When the Button is pressed Takes the text from the button and places it
        // on the Display text Field.(4)
        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFour.Text;
        }

        // When the Button is pressed Takes the text from the button and places it
        // on the Display text Field.(5)
        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFive.Text;
        }

        // When the Button is pressed Takes the text from the button and places it
        // on the Display text Field.(6)
        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSix.Text;
        }

        // When the Button is pressed Takes the text from the button and places it
        // on the Display text Field.(7)
        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSeven.Text;
        }

        // When the Button is pressed Takes the text from the button and places it
        // on the Display text Field.(8)
        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnEight.Text;
        }

        // When the Button is pressed Takes the text from the button and places it
        // on the Display text Field.(9)
        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnNine.Text;
        }

        // When the Button is pressed Clears All the Fields That have Editable Text
        // In the Program.
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            txtDisplay2.Clear();
            txtError.Clear();
        }

        // When the Button is pressed Takes the text from the button and places it
        // on the Display text Field. (0)
        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnZero.Text;
        }

        // When Button is Pressed Adds a Decimal Place To the Text View
        // It also checks if there are any values in the Text View
        // If there are none it adds (0.) instead of just (.) to the field
        // It also checks if there is already a (.) if there is it will not
        // Place anything into the Text View.
        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDisplay.Text.Contains("."))
                {
                    txtDisplay.Text = txtDisplay.Text;
                }
                else
                {
                    if (txtDisplay.Text == "")
                    {
                        txtDisplay.Text = txtDisplay.Text + "0.";
                    }
                    else
                    {
                        txtDisplay.Text = txtDisplay.Text + btnStop.Text;
                    }
                }
            } catch
            {

            }
        }

        double total1 = 0;
        double total2 = 0;
        double result = 0;
        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool divideButtonClicked = false;
        bool multiplyButtonClicked = false;

        // When Equals Button is Pressed Checks to see what Arithmetic has been used
        // This is done through boolean values for addition, subtraction, etc.
        // It used If statements to check for each boolean then uses the Arithmetic
        // Library to do a Calculation using the two variables entered.
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (plusButtonClicked == true)
            {
                try
                {
                    double a = double.Parse(txtDisplay.Text);
                    result = Arithmetic.Arithmetic.Add(total1, a);
                    total1 = 0;
                } catch(Exception)
                {
                    MessageBox.Show("Incorrect Input");
                }
            }
            else if (minusButtonClicked == true)
            {
                try
                {
                    double a = double.Parse(txtDisplay.Text);
                    result = Arithmetic.Arithmetic.Sub(total1, a);
                    total1 = 0;
                }
                catch (Exception)
                {
                    MessageBox.Show("Incorrect Input");
                }
            }
            else if (divideButtonClicked == true)
            {
                try
                {
                    double a = double.Parse(txtDisplay.Text);
                    result = Arithmetic.Arithmetic.Div(total1, a);
                    total1 = 0;
                }
                catch (Exception)
                {
                    MessageBox.Show("Incorrect Input");
                }
            }
            else if (multiplyButtonClicked == true)
            {
                try
                {
                    double a = double.Parse(txtDisplay.Text);
                    result = Arithmetic.Arithmetic.Mult(total1, a);
                    total1 = 0;
                }
                catch (Exception)
                {
                    MessageBox.Show("Incorrect Input");
                }
            }
            txtDisplay.Text = result.ToString();
            
            txtDisplay2.Text = "";
        }

        // When the Plus Button is pressed Takes the Text from The Button and adds
        // It after the numbers that have been entered.
        // It then Places the Number and Addition sign into the Second Window
        // To show the User What Calculation is being done.
        // It also sets the plusButtonClicked boolean to true and all the others to false
        private void btnPlus_Click(object sender, EventArgs e)
        {
            try
            {
                txtError.Clear();
                total1 += double.Parse(txtDisplay.Text);
                txtDisplay2.Text += " " + txtDisplay.Text + " " + btnPlus.Text;
                txtDisplay.Clear();

                plusButtonClicked = true;
                minusButtonClicked = false;
                divideButtonClicked = false;
                multiplyButtonClicked = false;
            }
            catch
            {
                txtError.Text = "Please Enter a Number";
            }
        }

        // When the Subtraction Button is pressed Takes the Text from The Button and adds
        // It after the numbers that have been entered.
        // It then Places the Number and Subtraction sign into the Second Window
        // To show the User What Calculation is being done.
        // It also sets the minusButtonClicked boolean to true and all the others to false
        private void btnSub_Click(object sender, EventArgs e)
        {
            try
            {
                txtError.Clear();
                total1 += double.Parse(txtDisplay.Text);
                txtDisplay2.Text += " " + txtDisplay.Text + " " + btnSub.Text;
                txtDisplay.Clear();

                plusButtonClicked = false;
                minusButtonClicked = true;
                divideButtonClicked = false;
                multiplyButtonClicked = false;
            } catch
            {
                txtError.Text = "Please Enter a Number";
            }
            
        }

        // When the Divide Button is pressed Takes the Text from The Button and adds
        // It after the numbers that have been entered.
        // It then Places the Number and Divide sign into the Second Window
        // To show the User What Calculation is being done.
        // It also sets the divideButtonClicked boolean to true and all the others to false
        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                txtError.Clear();
                if (txtDisplay.Text == "0")
                {
                    txtError.Text = "You Cannot Divide by 0";
                    txtDisplay.Clear();
                } else
                {
                    total1 += double.Parse(txtDisplay.Text);
                    txtDisplay2.Text += " " + txtDisplay.Text + " " + btnDivide.Text;
                    txtDisplay.Clear();

                    plusButtonClicked = false;
                    minusButtonClicked = false;
                    divideButtonClicked = true;
                    multiplyButtonClicked = false;
                }
                
            }
            catch
            {
                txtError.Text = "Please Enter a Number";
            }
            
        }

        // When the Multiply Button is pressed Takes the Text from The Button and adds
        // It after the numbers that have been entered.
        // It then Places the Number and Multiplication sign into the Second Window
        // To show the User What Calculation is being done.
        // It also sets the multiplyButtonClicked boolean to true and all the others to false
        private void btnTimes_Click(object sender, EventArgs e)
        {
            try
            {
                txtError.Clear();
                total1 += double.Parse(txtDisplay.Text);
                txtDisplay2.Text += " " + txtDisplay.Text + " " + btnTimes.Text;
                txtDisplay.Clear();

                plusButtonClicked = false;
                minusButtonClicked = false;
                divideButtonClicked = false;
                multiplyButtonClicked = true;
            }
            catch
            {
                txtError.Text = "Please Enter a Number";
            }
        }

        // When the Button is pressed it takes the number from the txtDisplay
        // and parses it as a double so that it can be calculated.
        // It then uses the Algebra Library to Square the number and set
        // the txtDisplay to the answer
        // It also sets the txtDisplay2 to what has been squared.
        private void btnSQRT_Click(object sender, EventArgs e)
        {
            try
            {
                txtError.Clear();
                double num = double.Parse(txtDisplay.Text);
                if (num >= 0)
                {
                    txtDisplay.Text = Algebraic.Algebra.SquareRoot(num).ToString();
                    txtDisplay2.Text = num.ToString();
                }
                else
                {
                    MessageBox.Show("Number must be positive", "Error Message");
                    txtDisplay.Text = "0";
                }
            }
            catch
            {   
                txtError.Text = ("You cannot get the Square Root of Nothing" + "    .Sorry");
            }
            
        }

        // This is the Clear Button on the ToolStrip that Clears all Editable Fields
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            txtDisplay2.Clear();
            txtError.Clear();
        }

        // Quit Button on ToolStrip that Sets a Message Box With a Yes/No Question
        // If yes is pressed it closes the application.
        // If no is pressed it does nothing and closes the message box.
        private void quitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        // When the Button is pressed it takes the number from the txtDisplay
        // and parses it as a double so that it can be calculated.
        // It then uses the Algebra Library to do the Inv Calculation to the number 
        // and set the txtDisplay to the answer
        // It also sets the txtDisplay2 to what has been inverted.
        private void btnInv_Click(object sender, EventArgs e)
        {

            try
            {
                txtError.Clear();
                double num = double.Parse(txtDisplay.Text);
                double result;
                if (num == 0)
                {
                    txtError.Text = ("You cannot Invert 0");
                } else
                {
                    result = Algebraic.Algebra.Invert(num);
                    txtDisplay.Text = result.ToString();
                    txtDisplay2.Text = ("1 / " + num);

                }
                
            } catch
            {
                txtError.Text = "Please Enter A Value to Invert";
            }

        }

        // When the Button is pressed it takes the number from the txtDisplay
        // and parses it as a double so that it can be calculated.
        // It then uses the Algebra Library to CubeRoot the number and set
        // the txtDisplay to the answer
        // It also sets the txtDisplay2 to what has been Cubed.
        private void btnCube_Click(object sender, EventArgs e)
        {
            try
            {
                txtError.Clear();
                double num = double.Parse(txtDisplay.Text);
                if (num >= 0)
                {
                    txtDisplay.Text = Algebraic.Algebra.CubeRoot(num).ToString();
                    txtDisplay2.Text = num.ToString();
                }
                else
                {
                    MessageBox.Show("Number must be positive", "Error Message");
                    txtDisplay.Text = "0";
                }
            }
            catch
            {
                txtError.Text = "Please Enter A Value";
            }
        }

        // Parses the Number from the txtDisplay to a double and assigns it
        // to the total1 double. The number is then calculated using the Trigonometric
        // Library using Tan and the answer is then places into the txtDisplay.
        // The original number and calculation done is placed into txtDisplay2.
        private void btnTan_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDisplay.Text == "90")
                {
                    txtError.Text = "Invalid";
                    txtDisplay.Clear();
                } else
                {
                    txtError.Clear();
                    total1 = double.Parse(txtDisplay.Text);
                    txtDisplay2.Text = btnTan.Text + "(" + txtDisplay.Text + ")";
                    txtDisplay.Clear();

                    total2 = Trigonometric.Trig.Tan(total1);
                    txtDisplay.Text = total2.ToString();
                    total1 = 0;
                }
            } catch
            {
                txtError.Text = "Please Enter a Number";
            }
            

        }

        // Parses the Number from the txtDisplay to a double and assigns it
        // to the total1 double. The number is then calculated using the Trigonometric
        // Library using Cos and the answer is then places into the txtDisplay.
        // The original number and calculation done is placed into txtDisplay2.
        private void btnCos_Click(object sender, EventArgs e)
        {
            
            try
            {
                txtError.Clear();
                total1 = double.Parse(txtDisplay.Text);
                txtDisplay2.Text = btnCos.Text + "(" + txtDisplay.Text + ")";
                txtDisplay.Clear();

                total2 = Trigonometric.Trig.Cos(total1);
                txtDisplay.Text = total2.ToString();
                total1 = 0;
            }
            catch
            {
                txtError.Text = "Please Enter a Number";
            }
        }

        // Parses the Number from the txtDisplay to a double and assigns it
        // to the total1 double. The number is then calculated using the Trigonometric
        // Library using Sin and the answer is then places into the txtDisplay.
        // The original number and calculation done is placed into txtDisplay2.
        private void btnSin_Click(object sender, EventArgs e)
        {
            try
            {
                txtError.Clear();
                total1 = double.Parse(txtDisplay.Text);
                txtDisplay2.Text = btnSin.Text + "(" + txtDisplay.Text + ")";
                txtDisplay.Clear();

                total2 = Trigonometric.Trig.Sin(total1);
                txtDisplay.Text = total2.ToString();
                total1 = 0;
            }
            catch
            {
                txtError.Text = "Please Enter a Number";
            }
        }

        // Parses the Number from the txtDisplay to a double and assigns it
        // to the total1 double. The number is then calculated using the Trigonometric
        // Library using Inverted Cos and the answer is then places into the txtDisplay.
        // The original number and calculation done is placed into txtDisplay2.
        private void btnInvCos_Click(object sender, EventArgs e)
        {
            
            try
            {
                txtError.Clear();
                total1 = double.Parse(txtDisplay.Text);
                txtDisplay2.Text = btnInvCos.Text + "(" + txtDisplay.Text + ")";
                txtDisplay.Clear();

                total2 = Trigonometric.Trig.InvCos(total1);
                txtDisplay.Text = total2.ToString();
                total1 = 0;

            }
            catch
            {
                txtError.Text = "Please Enter a Number";
            }
        }

        // Parses the Number from the txtDisplay to a double and assigns it
        // to the total1 double. The number is then calculated using the Trigonometric
        // Library using Inverted Tan and the answer is then places into the txtDisplay.
        // The original number and calculation done is placed into txtDisplay2.
        private void btnInvTan_Click(object sender, EventArgs e)
        {
            
            try
            {
                txtError.Clear();
                total1 = double.Parse(txtDisplay.Text);
                txtDisplay2.Text = btnInvTan.Text + "(" + txtDisplay.Text + ")";
                txtDisplay.Clear();

                total2 = Trigonometric.Trig.InvTan(total1);
                txtDisplay.Text = total2.ToString();
                total1 = 0;
            }
            catch
            {
                txtError.Text = "Please Enter a Number";
            }
        }

        // Parses the Number from the txtDisplay to a double and assigns it
        // to the total1 double. The number is then calculated using the Trigonometric
        // Library using Inverted Sin and the answer is then places into the txtDisplay.
        // The original number and calculation done is placed into txtDisplay2.
        private void btnInvSin_Click(object sender, EventArgs e)
        {
            
            try
            {
                txtError.Clear();
                total1 = double.Parse(txtDisplay.Text);
                txtDisplay2.Text = btnInvSin.Text + "(" + txtDisplay.Text + ")";
                txtDisplay.Clear();

                total2 = Trigonometric.Trig.InvSin(total1);
                txtDisplay.Text = total2.ToString();
                total1 = 0;
            }
            catch
            {
                txtError.Text = "Please Enter a Number";
            }
        }

        // This switches the value from negative to positive in txtDisplay
        // Using the Text.Remove Method.
        private void btnSwitch_Click(object sender, EventArgs e)
        {
            try
            {
                txtError.Clear();
                if (txtDisplay.Text.Contains("-"))
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(0, 1);
                }
                else
                {
                    txtDisplay.Text = "-" + txtDisplay.Text;
                }
            }
            catch
            {
                txtError.Text = "Please Enter a Number to Switch";
            }
        }

        // This Removes one number from the txtDisplay using the text.Remove method
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            try
            {
                txtError.Clear();
                
                string s = txtDisplay.Text;
                s = s.Remove(s.Length - 1);
                txtDisplay.Text = s;
                
            }
            catch
            {
                txtError.Text = "You Cannot Get rid of Nothing";
            }
        }
    }
}
