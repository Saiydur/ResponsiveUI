using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResponsiveUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float takeNum, ans;
        string operation;
        # region DigitButton
        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplayCalc.Text += "0";
            lblShowCalc.Text += "0";
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            txtDisplayCalc.Text += "00";
            lblShowCalc.Text += "00";
        }

        private void btn000_Click(object sender, EventArgs e)
        {
            txtDisplayCalc.Text += "000";
            lblShowCalc.Text += "000";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplayCalc.Text += "1";
            lblShowCalc.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplayCalc.Text += "2";
            lblShowCalc.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplayCalc.Text += "3";
            lblShowCalc.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplayCalc.Text += "4";
            lblShowCalc.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplayCalc.Text += "5";
            lblShowCalc.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplayCalc.Text += "6";
            lblShowCalc.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplayCalc.Text += "7";
            lblShowCalc.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplayCalc.Text += "8";
            lblShowCalc.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplayCalc.Text += "9";
            lblShowCalc.Text += "9";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            operation = "add";
            takeNum = float.Parse(txtDisplayCalc.Text);
            txtDisplayCalc.Clear();
            txtDisplayCalc.Focus();
            lblShowCalc.Text +=" + ";
        }
        private void btnSub_Click(object sender, EventArgs e)
        {
            operation = "sub";
            takeNum = float.Parse(txtDisplayCalc.Text);
            txtDisplayCalc.Clear();
            txtDisplayCalc.Focus();
            lblShowCalc.Text = takeNum.ToString() + " - ";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            operation = "multi";
            takeNum = float.Parse(txtDisplayCalc.Text);
            txtDisplayCalc.Clear();
            txtDisplayCalc.Focus();
            lblShowCalc.Text = takeNum.ToString() + " * ";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operation = "div";
            takeNum = float.Parse(txtDisplayCalc.Text);
            txtDisplayCalc.Clear();
            txtDisplayCalc.Focus();
            lblShowCalc.Text = takeNum.ToString() + " / ";
        }
        private void btnDot_Click(object sender, EventArgs e)
        {
            txtDisplayCalc.Text += ".";
            lblShowCalc.Text += ".";
        }
        #endregion

        #region calculator Operatiopn
        private void btnEqual_Click(object sender, EventArgs e)
        {

            try
            {
                switch (operation)
                {
                    case "add":
                        ans = takeNum + float.Parse(txtDisplayCalc.Text);
                        MessageBox.Show(ans.ToString());
                        txtDisplayCalc.Text = ans.ToString();
                        lblShowCalc.Text = ans.ToString();
                        break;
                    case "sub":
                        ans = takeNum - float.Parse(txtDisplayCalc.Text);
                        MessageBox.Show(ans.ToString());
                        txtDisplayCalc.Text = ans.ToString();
                        lblShowCalc.Text = ans.ToString();
                        break;
                    case "multi":
                        ans = takeNum * float.Parse(txtDisplayCalc.Text);
                        MessageBox.Show(ans.ToString());
                        txtDisplayCalc.Text = ans.ToString();
                        lblShowCalc.Text = ans.ToString();
                        break;
                    case "div":
                        try
                        {
                            ans = takeNum / float.Parse(txtDisplayCalc.Text);
                            MessageBox.Show(ans.ToString());
                            txtDisplayCalc.Text = ans.ToString();
                            lblShowCalc.Text = ans.ToString();
                        }
                        catch (Exception exp)
                        {
                            MessageBox.Show(exp.Message.ToString());
                        }
                        break;

                }
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            int len = txtDisplayCalc.TextLength - 1;
            string txt = txtDisplayCalc.Text;
            txtDisplayCalc.Clear();
            for (int i = 0; i < len; i++)
            {
                txtDisplayCalc.Text = txtDisplayCalc.Text + txt[i];
                
            }
            lblShowCalc.Text = txtDisplayCalc.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplayCalc.Text = "";
            lblShowCalc.Text = "";
        }
        #endregion
    }
}
