using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birthdate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showDateButton_Click(object sender, EventArgs e)
        {
            string output;

            output = dayofWeekTextBox.Text + ", " +
                monthTextBox.Text + " " +
                dayofMonthTextBox.Text + ", " +
                yeartextbox.Text;

            dateoutputlabel.Text = output;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            dayofWeekTextBox.Text = " ";
                monthTextBox.Text = " ";
                dayofMonthTextBox.Text = " ";
                yeartextbox.Text = " ";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
