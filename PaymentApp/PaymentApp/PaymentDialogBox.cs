using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentApp
{
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            // Change payment app
            InitializeComponent();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            lbCCtype.Items.Add("Visa");
            lbCCtype.Items.Add("MasterCard");
            lbCCtype.Items.Add("American Express");
            lbCCtype.SelectedIndex = 0;

            string[] months = { " Select a month...",
                "January","February", "March", "April",
                "May", "June", "July", "August",
                "September", "October", "November", "December" };
            foreach (string month in months)
                cboMonth.Items.Add(month);
            cboMonth.SelectedIndex = 0;

            int year = DateTime.Today.Year;
            int endYear = year + 8;
            cboYear.Items.Add("Select a year..");
            while (year < endYear)
            {
                cboYear.Items.Add(year);
                year++;
            }
            cboYear.SelectedIndex = 0;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Just a test for Git.
            if (IsValidData())
            {
                this.SaveData();
            }
        }
        private bool IsValidData()
        {
            if (rbCredit.Checked)
            {
                //second commit
                if (lbCCtype.SelectedIndex == -1 )
                {
                    MessageBox.Show("You must select a credit card type.",
                        "Entry error");
                    lbCCtype.Focus();
                    return false;
                }
                if (txtCardNumber.Text == "")
                {
                    MessageBox.Show("You must enter a credit card number.",
                        "Entry error");
                    txtCardNumber.Focus();
                    return false;
                }
                if (cboMonth.SelectedIndex == 0)
                {
                    MessageBox.Show("You must select a month", "Entry error");
                    cboMonth.Focus();
                    return false;
                }
                if (cboYear.SelectedIndex == 0)
                {
                    MessageBox.Show("You must select a year.", "Entry error");
                    cboYear.Focus();
                    return false;
                }
            }
            return true;
        }
        private void SaveData()
        {
            string msg = null;
            if (rbCredit.Checked == true)
            {
                msg += "Charge to credit card." + "\n";
                msg += "\n";
                msg += "Card type: " + lbCCtype.Text + "\n";
                msg += "Card number:" + txtCardNumber.Text + "\n";
                msg += "Expiration date: " + cboMonth.Text + cboYear.Text + "\n";
            }
            else
            {
                msg += "Send bill to customer." + "\n";
                msg += "\n";
            }

            bool isDefaultBilling = cbBillingMethod.Checked;
            msg += "Default billing: " + isDefaultBilling;

            this.Tag = msg;
            this.DialogResult = DialogResult.OK;
        }

        private void cbBillingMethod_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCredit.Checked)
                EnableControls();
            else
                DisableControls();
        }
        private void EnableControls()
        {
            lbCCtype.Enabled = true;
            txtCardNumber.Enabled = true;
            cboMonth.Enabled = true;
            cboYear.Enabled = true;
        }
        private void DisableControls()
        {
            lbCCtype.Enabled = false;
            txtCardNumber.Enabled = false;
            cboMonth.Enabled = false;
            cboYear.Enabled = false;
        }
    }
}
