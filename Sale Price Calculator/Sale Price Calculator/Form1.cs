using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal orignalPrice;
            decimal discountPercentage;
            decimal discountAmount;
            decimal salePrice;

            orignalPrice = decimal.Parse(originalPricePromptTextbox.Text);
            discountPercentage = decimal.Parse(discPercentagePromptTextBox.Text);
            discountPercentage = discountPercentage / 100;
            discountAmount = orignalPrice * discountPercentage;
            salePrice = orignalPrice - discountAmount;
            salePriceLabel.Text = salePrice.ToString("c");
                
           
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
