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
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void Operation(object sender, EventArgs e)
        {
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
        }
    }
}
