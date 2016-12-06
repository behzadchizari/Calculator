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
        public Form1()
        {
            InitializeComponent();
        }

        private void Operation(object sender, EventArgs e)
        {
        }

        private void Number(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Symetry(object sender, EventArgs e)
        {
            var sym = (Convert.ToDouble(txtResult.Text) * (-1));
            txtResult.Text = sym.ToString();
        }

        private void Clear(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;
        }
    }
}
