using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcAdd_Click(object sender, EventArgs e)
        {
            lblAnsadd.Text = String.Format("{0}", 1 + 2);
        }

        private void btnCalcSub_Click(object sender, EventArgs e)
        {
            lblAnsSub.Text = String.Format("{0}", 5 - 3);
        }

        private void btnCalcMul_Click(object sender, EventArgs e)
        {
            lblAnsMul.Text = String.Format("{0}", 2 * 3);
        }

        private void btnCalcDiv_Click(object sender, EventArgs e)
        {
            lblAnsDiv.Text = String.Format("{0}", 8 / 2);

        }
    }
}
