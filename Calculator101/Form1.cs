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
        string NumInput2;
        string UserInput;
        bool ISOperationPressed;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Num_click(object sender, EventArgs e)
        {
            {
                if (ISOperationPressed)
                {
                    NumInput1 = UserInput;
                    Result_box.Text = "";
                }
            }
            Button Num = (Button)sender;
            UserInput = Num.Text;
            if (Result_box.Text != "0")
                Result_box.Text += Num.Text;
            else
                Result_box.Text = "" + Num.Text;
            ISOperationPressed = false;
        }
        private void Operation_click(object sender, EventArgs e)
        {
            {
                if (ISOperationPressed)
                {
                    NumInput1 = UserInput;
                    Result_box.Text = "";
                }
            }
            Button Operation = (Button)sender;
            Operation_str = (Operation.Text);
            Result_box.Text += (Operation_str);
            NumInput1 = UserInput;

            ISOperationPressed = true;
        }

        private void AC_Click(object sender, EventArgs e)
        {
            Result_box.Clear();
        }

        private void DEL_Click(object sender, EventArgs e)
        {
            Button delete = (Button)sender;
            if (Result_box.Text != string.Empty)
            {
                int Result_length = Result_box.Text.Length;
                if (Result_length >= 1)
                {
                    Result_box.Text = Result_box.Text.Remove(Result_length - 1);
                }
            }
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            float Result = 0.0F;
            NumInput2 = UserInput;
            float first, second;
            first = float.Parse(NumInput1);
            second = float.Parse(NumInput2);

            {
                if (Operation_str == "x")
                    Result = (first) * (second);
                Result_box.Text = string.Empty + Result.ToString();
                if (Operation_str == "/")
                    Result = (first) / (second);
                Result_box.Text = string.Empty + Result.ToString();
                if (Operation_str == "+")
                    Result = (first) + (second);
                Result_box.Text = string.Empty + Result.ToString();
                if (Operation_str == "-")
                    Result = (first) - (second);
                Result_box.Text = string.Empty + Result.ToString();
            }
        }

    }
}

