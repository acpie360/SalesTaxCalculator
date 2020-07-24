using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesTaxCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSales_Enter(object sender, EventArgs e)
        {
            txtSales.SelectAll();
        }

        private void txtTaxRate_Enter(object sender, EventArgs e)
        {
            txtTaxRate.SelectAll();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSales.Text = "";
            txtTaxRate.Text = "";
            txtSaleTax.Text = "";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double salesAmount = Convert.ToDouble(txtSales.Text);
            double taxRate = Convert.ToDouble(txtTaxRate.Text) / 100;

            double taxAmount = salesAmount * taxRate;
            string strTaxAmount = Convert.ToString(String.Format("{0:C}", taxAmount));

            txtSaleTax.Text = strTaxAmount;
        }
    }
}
