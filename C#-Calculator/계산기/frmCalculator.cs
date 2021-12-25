using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace 계산기
{
    public partial class frmCalculator : Form
    {
        enum BOP {Plus, Minus, Multiply, Divide, Remainder}
        BOP binaryOperator;
        bool isBOPClick = false;

        double operand1 = 0, operand2 = 0;
        bool IsNewClick = true;

        public frmCalculator()
        {
            InitializeComponent();
        }
        private void buttonClick(string arg)
        {
            if (IsNewClick)
            {
                lblOutput.Text = arg;
                IsNewClick = false;

            }
            else
            {
                lblOutput.Text += arg;
            }
            if(!lblOutput.Text.Contains("."))
            {
                double result = double.Parse(lblOutput.Text);
                lblOutput.Text = string.Format("{0:#,0.#####################}", result);
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {
            buttonClick("1");
        }

        private void lbl2_Click(object sender, EventArgs e)
        {
            buttonClick("2");

        }

        private void lbl3_Click(object sender, EventArgs e)
        {
            buttonClick("3");
        }

        private void lbl0_Click(object sender, EventArgs e)
        {
            if(lblOutput.Text == "0")
            {
                lblOutput.Text = "0";
            }
            else
            {
                buttonClick("0");
            }
            
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if(lblOutput.Text.Contains("."))
            {
                SystemSounds.Beep.Play();
            }
            else
            {
                lblOutput.Text += ".";
                IsNewClick = false;
            }
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            int length = lblOutput.Text.Length;
            if(lblOutput.Text.Contains("-")&&length==2)
            {
                lblOutput.Text = "0";
                IsNewClick = true;
            }
            else if((length <=1)||(lblOutput.Text=="0."))
            {
                lblOutput.Text = "0";
                IsNewClick = true;
            }
            else
            {
                lblOutput.Text = lblOutput.Text.Substring(0, length - 1);
            }
        }

        private void btnEuqal_Click(object sender, EventArgs e)
        {
    
            double result = compute( );
            lblOutput.Text = string.Format("{0:#,0.#####################}", result);
            IsNewClick = true;
            lblExpression.Text = "";
            isBOPClick = false;

        }

        private double compute()
        {
            double result = 0;
            operand2 = double.Parse(lblOutput.Text);
            switch (binaryOperator)
            {
                case BOP.Plus:
                    result = operand1 + operand2;
                    break;
                case BOP.Minus:
                    result = operand1 - operand2;
                    break;
                case BOP.Multiply:
                    result = operand1 * operand2;
                    break;
                case BOP.Divide:
                    if (operand2 == 0)
                    {
                        lblOutput.Text = "0으로 나눌수 없습니다.";
                        SystemSounds.Beep.Play();
                    }
                    else
                    {
                        result = operand1 / operand2;
                    }
                    break;

                case BOP.Remainder:
                    result = operand1 % operand2;
                    break;
            }
            return result;
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            lblOutput.Text=(-(double.Parse(lblOutput.Text))).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSQRT_Click(object sender, EventArgs e)
        {
            lblExpression.Text = "sqrt(" + lblOutput.Text + ")";
            double result = Math.Sqrt(double.Parse(lblOutput.Text));
            lblOutput.Text = string.Format("{0:#,0.#####################}", result);

        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            lblExpression.Text = "sin(" + lblOutput.Text + ")";
            double result = Math.Sin(double.Parse(lblOutput.Text));
            lblOutput.Text = string.Format("{0:#,0.#####################}", result);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "0";
            IsNewClick = true;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "0";
            IsNewClick = true;
            lblExpression.Text = "0";
            isBOPClick = false;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            BOPClick(BOP.Plus);

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            BOPClick(BOP.Minus);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            BOPClick(BOP.Divide);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            BOPClick(BOP.Multiply);
        }


        private void lbl4_Click(object sender, EventArgs e)
        {
            buttonClick("4");
        }

        private void lbl5_Click(object sender, EventArgs e)
        {
            buttonClick("5");
        }

        private void lbl6_Click(object sender, EventArgs e)
        {
            buttonClick("6");
        }

        private void lbl7_Click(object sender, EventArgs e)
        {
            buttonClick("7");
        }

        private void lbl8_Click(object sender, EventArgs e)
        {
            buttonClick("8");
        }

        private void lbl9_Click(object sender, EventArgs e)
        {
            buttonClick("9");
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            lblExpression.Text = "cos(" + lblOutput.Text + ")";
            double result = Math.Cos(double.Parse(lblOutput.Text));
            lblOutput.Text = string.Format("{0:#,0.#####################}", result);
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            lblExpression.Text = "tan(" + lblOutput.Text + ")";
            double result = Math.Tan(double.Parse(lblOutput.Text));
            lblOutput.Text = string.Format("{0:#,0.#####################}", result);
        }

        private void btnRemainder_Click(object sender, EventArgs e)
        {
            BOPClick(BOP.Remainder);
        }

        private void lblOutput_Click(object sender, EventArgs e)
        {

        }

        private void BOPClick (BOP argbop)
        {
            
            switch(argbop)
            {
                case BOP.Plus:
                    lblExpression.Text += lblOutput.Text + " + ";
                    binaryOperator = BOP.Plus;
                    break;

                case BOP.Minus:
                    lblExpression.Text += lblOutput.Text + " - ";
                    binaryOperator = BOP.Minus;
                    break;

                case BOP.Multiply:
                    lblExpression.Text += lblOutput.Text + " * ";
                    binaryOperator = BOP.Multiply;
                    break;

                case BOP.Divide:
                    
                    lblExpression.Text += lblOutput.Text + " / ";
                    binaryOperator = BOP.Divide;
                    break;

                    
                case BOP.Remainder:
                    lblExpression.Text += lblOutput.Text + " % ";
                    binaryOperator = BOP.Remainder;
                    break;
            }
            if (isBOPClick)
            {
                double result = compute();
                lblOutput.Text = string.Format("{0:#,0.#####################}", result);
            }
            isBOPClick = true;
            IsNewClick = true;
            operand1 = double.Parse(lblOutput.Text);

        }
    }
}
