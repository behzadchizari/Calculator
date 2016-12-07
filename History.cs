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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }
        public string HistoryLog { get; set; }
        private void History_Load(object sender, EventArgs e)
        {
            lblHistory.Text = HistoryLog;
        }
    }
}
