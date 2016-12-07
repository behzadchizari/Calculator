using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        #region  ****properties****
        bool dottIsUsed = false;
        Calc calc = new Calc();
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void Operation(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                if (calc.First == null && calc.Second == null)
                {
                    if (txtResult.Text != string.Empty)
                    {
                        calc.First = Convert.ToDouble(txtResult.Text);
                        calc.Operation = btn.Text;
                        lblResult.Text = calc.First.ToString() + " " + calc.Operation;
                        txtResult.Text = string.Empty;

                    }
                }
                if (calc.First != null && calc.Second == null)
                {
                    if (txtResult.Text != string.Empty)
                    {
                        calc.Second = Convert.ToDouble(txtResult.Text);
                        if (btn.Text == "=")
                        {
                            calc.Operate();
                            lblResult.Text = calc.First.ToString() + " " + calc.Operation + " " + calc.Second.ToString();
                            txtResult.Text = calc.Result.ToString();
                            calc.First = calc.Result;
                            calc.Second = null;
                        }
                        else
                        {
                            if (calc.Result!= null)
                            {
                                lblResult.Text = calc.Result.ToString();
                            }
                            calc.Operate();
                            calc.Operation = btn.Text;
                            lblResult.Text = calc.Result.ToString() + " " + calc.Operation ;
                            txtResult.Text = string.Empty;
                            calc.First = calc.Result;
                            calc.Second = null;









                            //calc.First = calc.Result;
                            //calc.Second = null;
                            //calc.Operation = btn.Text;
                            //lblResult.Text += " " + calc.First;
                            //txtResult.Text = string.Empty;
                        }
                    }
                }
            }


















        }
        private void Number(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                if (txtResult.Text == string.Empty || string.IsNullOrWhiteSpace(txtResult.Text))
                {
                    if (btn.Text == "/")
                    {
                        txtResult.Text = "0";
                    }
                }

                if (dottIsUsed == false)
                {
                    if (btn.Text == "/")
                        dottIsUsed = true;
                    txtResult.Text += btn.Text;
                }
                else
                    if (btn.Text != "/")
                    txtResult.Text += btn.Text;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Symetry(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResult.Text))
            {
                var sym = (Convert.ToDouble(txtResult.Text) * (-1));
                txtResult.Text = sym.ToString();
            }

        }
        private void Clear(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;
            dottIsUsed = false;
            calc = new Calc();
            lblResult.Text = string.Empty;
        }
        private void Back(object sender, EventArgs e)
        {
            var lastChar = txtResult.Text.Substring(txtResult.Text.Length - 1, 1);
            if (txtResult.Text != string.Empty)
            {
                if (lastChar == "/")
                    dottIsUsed = false;
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;
        }
    }
}
