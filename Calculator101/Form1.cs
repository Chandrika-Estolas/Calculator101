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
        public Calculator()
        {
            InitializeComponent();
        }

        private void Num_click(object sender, EventArgs e)
        {
            Button bnum = (Button)sender;
            Result_box.Text = Result_box.Text + bnum.Text;

        }

        private void Operation_click(object sender, EventArgs e)
        {
            Button bOperation = (Button)sender;
            Result_box.Text = Result_box.Text + bOperation;
        }

        private void Equal_click(object sender, EventArgs e)
        {

        }

        private void AC_Click(object sender, EventArgs e)
        {
            Result_box.Clear();
        }
    }
}
