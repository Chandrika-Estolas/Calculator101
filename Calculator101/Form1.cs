using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator101
{
    public partial class Calculator : Form
    {

        string Operation_str;
        string NumInput1;
        string UserInput;
        float second;
        bool IsOperationPressed;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Num_click(object sender, EventArgs e)
        {
            {
                if (IsOperationPressed)
                {
                    Result_box.Text = "";
                }
            }
            Button Num = (Button)sender;
            UserInput = Num.Text;
            if (Result_box.Text != "0")
                Result_box.Text += UserInput;
            else
                Result_box.Text = "" + UserInput;

            NumInput1 = UserInput;
            IsOperationPressed = false;
        }
        private void Operation_click(object sender, EventArgs e)
        {
            {
                if (IsOperationPressed)
                {
                    NumInput1 = UserInput;
                    Result_box.Text = "";
                }
            }
            Button Operation = (Button)sender;
            Operation_str = (Operation.Text);
            NumInput1 = Result_box.Text;
            Result_box.Text += Operation_str;
            Result_label.Text = NumInput1;
            IsOperationPressed = true;
        }

        private void AC_Click(object sender, EventArgs e)
        {
            Result_box.Clear();
            Result_label.Text = "0";
        }

        private void DEL_Click(object sender, EventArgs e)
        {
            if (Result_box.Text != string.Empty)
            {
                int Result_box_length = (Result_box.Text.Length);
                if (Result_box_length >= 1)
                {
                    Result_box.Text = Result_box.Text.Remove(Result_box_length - 1);
                }
            }
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            string NumInput2;
            float Result = 0.0F;
            NumInput2 = Result_box.Text;
            second = float.Parse(NumInput2);
            {
                if (Operation_str == "x")
                    Result = float.Parse(Result_label.Text) * (second);
                Result_box.Text = string.Empty + Result.ToString();

                if (Operation_str == "/")
                {
                    if (second == 0)
                    {
                        Result_box.Text = "Undefined";
                    }
                    else
                    { 
                        Result = float.Parse(Result_label.Text) / (second);
                        Result_box.Text = string.Empty + Result.ToString();
                    }
                }

                if (Operation_str == "+")
                    Result = float.Parse(Result_label.Text) + (second);
                Result_box.Text = string.Empty + Result.ToString();

                if (Operation_str == "-")
                    Result = float.Parse(Result_label.Text) - (second);
                Result_box.Text = string.Empty + Result.ToString();
            }
            Result_label.Text = Convert.ToString(Result);
            }
        } 
    }




