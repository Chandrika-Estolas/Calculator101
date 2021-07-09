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
        VariablesandMethod VariablesandMethod = new VariablesandMethod();

        public Calculator()
        {
            InitializeComponent();
        }

        private void Num_click(object sender, EventArgs e)
        {
            {
                if (VariablesandMethod.IsOperationPressed)
                {
                    Result_box.Text = "";
                }
            }
            Button Num = (Button)sender;
            VariablesandMethod.UserInput = Num.Text;
            if (Result_box.Text != "0")
                Result_box.Text += VariablesandMethod.UserInput;
            else
                Result_box.Text = "" + VariablesandMethod.UserInput;

            VariablesandMethod.NumInput1 = VariablesandMethod.UserInput;
            VariablesandMethod.IsOperationPressed = false;
        }
        private void Operation_click(object sender, EventArgs e)
        {
            {
                if (VariablesandMethod.IsOperationPressed)
                {
                    VariablesandMethod.NumInput1 = VariablesandMethod.UserInput;
                    Result_box.Text = "";
                }
            }
            Button Operation = (Button)sender;
            VariablesandMethod.Operation_str = (Operation.Text);
            VariablesandMethod.NumInput1 = Result_box.Text;
            Result_box.Text += VariablesandMethod.Operation_str;
            Result_label.Text = VariablesandMethod.NumInput1;
            VariablesandMethod.IsOperationPressed = true;
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
            VariablesandMethod.NumInput1 = Result_label.Text;
            VariablesandMethod.NumInput2 = Result_box.Text;
            VariablesandMethod.Calculation();
            Result_label.Text = Convert.ToString(VariablesandMethod.Result);
            Result_box.Text = VariablesandMethod.NumInput2;
        }

        }
    } 




