using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtTotal.Text);
            double res = 1 / num1;
            txtTotal.Text = res.ToString();

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            num2 = 0;
            txtTotal.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text=="0")
                txtTotal.Text = "1";
            else
                txtTotal.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "0")
                txtTotal.Text = "2";
            else
                txtTotal.Text += "2";

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "0")
                txtTotal.Text = "3";
            else
                txtTotal.Text += "3";

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "0")
                txtTotal.Text = "4";
            else
                txtTotal.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "0")
                txtTotal.Text = "5";
            else
                txtTotal.Text += "5";

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "0")
                txtTotal.Text = "6";
            else
                txtTotal.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "0")
                txtTotal.Text = "7";
            else
                txtTotal.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "0")
                txtTotal.Text = "8";
            else
                txtTotal.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "0")
                txtTotal.Text = "9";
            else
                txtTotal.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "0")
                txtTotal.Text = "0";
            else
                txtTotal.Text += "0";
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            string s = txtTotal.Text;

            if (s.Length > 1)
            {
                s = s.Substring(0, s.Length - 1);
            }
            else
            {
                s = "0";
            }

            txtTotal.Text = s;
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
        }

        string option;
        double total;
        double num1, num2;

        private void btnMinus_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = double.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txtTotal.Text);
            switch(option)
            {
                case "+": total = num1 + num2;
                        break;
                case "-":total = num1 - num2;break;
                case "*": total = num1 * num2;break;
                case "/": total = num1 / num2;break;
            }
            txtTotal.Text = total.ToString();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = double.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = double.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtTotal.Text);
            double res = num1 / 100;
            txtTotal.Text = res.ToString(); 
        }

        private void button22_Click(object sender, EventArgs e)
        {
           
            num1 = double.Parse(txtTotal.Text);
            double k = Math.Sqrt(num1);
            txtTotal.Text = k.ToString();
        }
        double mem_value;
        private void btnMC_Click(object sender, EventArgs e)
        {
            mem_value = 0;
        }

        private void btnMplus_Click(object sender, EventArgs e)
        {
            double res = Double.Parse(txtTotal.Text);
            mem_value += res;
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            txtTotal.Text = mem_value.ToString();
         
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            mem_value = double.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = double.Parse(txtTotal.Text);
            txtTotal.Clear();
        }
    }
}
