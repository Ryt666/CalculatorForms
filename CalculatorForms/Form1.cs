using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorForms
{
    public partial class Form1 : Form
    {
        FormatLine formatLine;
        public Form1()
        {
            InitializeComponent();
        }

        private void One_Click(object sender, EventArgs e)
        {
            TextField.Text += One.Text;
        }

        private void Two_Click(object sender, EventArgs e)
        {
            TextField.Text += Two.Text;
        }

        private void Three_Click(object sender, EventArgs e)
        {
            TextField.Text += Three.Text;
        }

        private void Four_Click(object sender, EventArgs e)
        {
            TextField.Text += Four.Text;
        }

        private void Five_Click(object sender, EventArgs e)
        {
            TextField.Text += Five.Text;
        }

        private void Sex_Click(object sender, EventArgs e)
        {
            TextField.Text += Sex.Text;
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            TextField.Text += Seven.Text;
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            TextField.Text += Eight.Text;
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            TextField.Text += Nine.Text;
        }

        private void Null_Click(object sender, EventArgs e)
        {
            TextField.Text += Null.Text;
        }

        private void comma_Click(object sender, EventArgs e)
        {
            TextField.Text += comma.Text;
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            TextField.Text += Plus.Text;
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            TextField.Text += Minus.Text;
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            TextField.Text += Divide.Text;
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            TextField.Text += Multiply.Text;
        }

        private void Degree_Click(object sender, EventArgs e)
        {
            TextField.Text += Degree.Text;
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            TextField.Text += Sqrt.Text;
        }

        private void Ravno_Click(object sender, EventArgs e)
        {
            formatLine = new FormatLine(TextField.Text);
            TextField.Text = formatLine.Res;
        }

        private void BracketR_Click(object sender, EventArgs e)
        {
            TextField.Text += BracketR.Text;
        }

        private void BracketL_Click(object sender, EventArgs e)
        {
            TextField.Text += BracketL.Text;
        }

        private void ImageLeft_Click(object sender, EventArgs e)
        {
            TextField.Text = TextField.Text.Remove(TextField.Text.Length - 1);
        }

        private void Del_Click(object sender, EventArgs e)
        {
            TextField.Text = "";
        }
    }
}
