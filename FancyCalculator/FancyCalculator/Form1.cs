/*
 * AZZA ELGENDY
 * A 1 
 * fancyCalculator
 * due date Friday January 26th,2018
 * 
 * 
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

namespace FancyCalculator
{
    public partial class calculatorForm : Form
    {
        public calculatorForm()
        {
            InitializeComponent();
            Calc_Enable();

        }

        double number = 0;
        double answer = 0;
        string operation = "";


        public void Calc_Enable()
        {

            OnOffButton.BackColor = Color.OrangeRed;

            OnOffButton.Enabled = true;
            Clearbutton.Enabled = false;
            Negativebutton.Enabled = false;
            addButton.Enabled = false;
            subtButton.Enabled = false;
            divButton.Enabled = false;
            Multibutton.Enabled = false;
            DecimalButton.Enabled = false;
            num0button.Enabled = false;
            num1button.Enabled = false;
            num2button.Enabled = false;
            num3button.Enabled = false;
            num4button.Enabled = false;
            num5button.Enabled = false;
            num6button.Enabled = false;
            Num7button.Enabled = false;
            num8button.Enabled = false;
            num9button.Enabled = false;
            equalButton.Enabled = false;
            backSpaceButton.Enabled = false;
            resultlabel.Text = "";


        }


        public void CalcDiable()
        {
            OnOffButton.BackColor = Color.Green;
            Clearbutton.Enabled = true;
            Negativebutton.Enabled = true;
            addButton.Enabled = true;
            subtButton.Enabled = true;
            divButton.Enabled = true;
            Multibutton.Enabled = true;
            DecimalButton.Enabled = true;
            num0button.Enabled = true;
            num1button.Enabled = true;
            num2button.Enabled = true;
            num3button.Enabled = true;
            num4button.Enabled = true;
            num5button.Enabled = true;
            num6button.Enabled = true;
            Num7button.Enabled = true;
            num8button.Enabled = true;
            num9button.Enabled = true;
            equalButton.Enabled = true;
            backSpaceButton.Enabled = true;


        }
        public void DoMath()
        {
            switch (operation)
            {
                case "+":
                    answer = number + double.Parse(resultlabel.Text);
                    resultlabel.Text = answer.ToString();

                    break;
                case "-":
                    answer = number - double.Parse(resultlabel.Text);
                    resultlabel.Text = answer.ToString();
                    break;
                case "*":
                    answer = number * double.Parse(resultlabel.Text);
                    resultlabel.Text = answer.ToString();
                    break;
                case "/":


                    if (resultlabel.Text == "0")
                    {
                        resultlabel.Text = "ERROR";
                    }
                    else
                    {
                        try
                        {
                            answer = number / double.Parse(resultlabel.Text);
                            resultlabel.Text = answer.ToString();
                        }
                        catch (Exception)
                        {

                            resultlabel.Text = "";
                        }

                    }

                    break;
                default:
                    break;

            }

        }
        public void disableOrEnableNumbers(bool enabled)
        {
            DecimalButton.Enabled = enabled;
            num0button.Enabled = enabled;
            num1button.Enabled = enabled;
            num2button.Enabled = enabled;
            num3button.Enabled = enabled;
            num4button.Enabled = enabled;
            num5button.Enabled = enabled;
            num6button.Enabled = enabled;
            Num7button.Enabled = enabled;
            num8button.Enabled = enabled;
            num9button.Enabled = enabled;
        }
        //OnOff
        private void button1_Click(object sender, EventArgs e)
        {
            //OnOffButton.BackColor = Color.Green;

            if (OnOffButton.BackColor == Color.OrangeRed)
            {
                CalcDiable();
                OnOffButton.BackColor = Color.Green;
            }
            else
            {
                OnOffButton.BackColor = Color.OrangeRed;
                Calc_Enable();
            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {

            resultlabel.Text = "";
            disableOrEnableNumbers(true);
        }



        private void Num7button_Click(object sender, EventArgs e)
        {
            resultlabel.Text += "7";

        }

        private void num5button_Click(object sender, EventArgs e)
        {
            resultlabel.Text += "5";
        }

        private void num8button_Click(object sender, EventArgs e)
        {
            resultlabel.Text += "8";
        }

        private void num9button_Click(object sender, EventArgs e)
        {
            resultlabel.Text += "9";
        }

        private void num6button_Click(object sender, EventArgs e)
        {
            resultlabel.Text += "6";
        }

        private void num2button_Click(object sender, EventArgs e)
        {
            resultlabel.Text += "2";
        }

        private void num3button_Click(object sender, EventArgs e)
        {
            resultlabel.Text += "3";
        }

        private void num1button_Click(object sender, EventArgs e)
        {
            resultlabel.Text += "1";
        }

        private void num0button_Click(object sender, EventArgs e)
        {
            resultlabel.Text += "0";
        }

        private void Negativebutton_Click(object sender, EventArgs e)
        {
            resultlabel.Text = "-" + resultlabel.Text;
            if (resultlabel.Text.Contains("-"))
            {
                Negativebutton.Enabled = false;
            }
            else
            {
                if (!resultlabel.Text.Contains("-") && resultlabel.Text == " ")
                {
                    Negativebutton.Enabled = true;
                }

            }


        }

private void DecimalButton_Click(object sender, EventArgs e)
        {
            resultlabel.Text += ".";

            if (resultlabel.Text.Contains("."))
            {
                DecimalButton.Enabled = false;
            }
            else
            {
                if (!resultlabel.Text.Contains(".")) //&& resultlabel.Text == "")
                {
                    DecimalButton.Enabled = true;
                }

            }


        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            // resultlabel.Text += "=";
            DoMath();
            Negativebutton.Enabled = true;
            DecimalButton.Enabled = true;
            disableOrEnableNumbers(false);
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //resultlabel.Text += "+";
            number = double.Parse(resultlabel.Text);
            resultlabel.Text = "";
            operation = "+";
            Negativebutton.Enabled = true;
            DecimalButton.Enabled = true;
            disableOrEnableNumbers(true);
            //resultlabel.Text = number.ToString() + "+";
            number += answer ;

        }

        private void subtButton_Click(object sender, EventArgs e)
        {
            //resultlabel.Text += "-";
            number = double.Parse(resultlabel.Text);
            resultlabel.Text = "";
            operation = "-";
            Negativebutton.Enabled = true;
            DecimalButton.Enabled = true;
            disableOrEnableNumbers(true);
        }

        private void Multibutton_Click(object sender, EventArgs e)
        {
            //resultlabel.Text += "*";
            number = double.Parse(resultlabel.Text);
            resultlabel.Text = "";
            operation = "*";
            Negativebutton.Enabled = true;
            DecimalButton.Enabled = true;
            disableOrEnableNumbers(true);
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            // resultlabel.Text += "/";
            number = double.Parse(resultlabel.Text);
            resultlabel.Text = "";
            operation = "/";
            Negativebutton.Enabled = true;
            DecimalButton.Enabled = true;
            disableOrEnableNumbers(true);
        }

        private void resultlabel_Click(object sender, EventArgs e)
        {

        }

        private void num4button_Click(object sender, EventArgs e)
        {
            resultlabel.Text += "4";
        }

        private void backSpaceButton_Click(object sender, EventArgs e)
        {
            int length = resultlabel.Text.Length - 1;
            string text = resultlabel.Text;
            resultlabel.Text = "";
            for (int i = 0; i < length; i++)
            {
                resultlabel.Text = resultlabel.Text + text[i];
            }
            
        }
    }
}
