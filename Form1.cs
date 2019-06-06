using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackofPaperNapkinMacroeconomics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
       
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double federalfundsrate =0;
            double Inflation = 0;

            Inflation = Double.Parse(InputInflation.Text);
            Inflation = Inflation / 100;

            federalfundsrate = 2.07 + 1.28 * Inflation - 1.95 * 0.04; 
            MessageBox.Show($"Value of Federal funds rate is {federalfundsrate} %");
        }



        private void InputInflation_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
