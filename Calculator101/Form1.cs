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

        String Operation_str = "";

        public Calculator()
        {
            InitializeComponent();
        }

        private void Num_click(object sender, EventArgs e)
        {
            Button Num = (Button)sender;
            Result_box.Text = Result_box.Text + Num.Text;

        }

        private void Operation_click(object sender, EventArgs e)
        {
            Button Operation = (Button)sender;
            Operation_str = Operation.Text;
            Result_box.Text = Result_box.Text + Operation_str;
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
            else
            {
                Result_box.Text = 0.ToString();
            }
        }
    }
}
