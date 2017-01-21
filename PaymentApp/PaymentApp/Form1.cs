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
    public partial class Form1 : Form
    {
        private bool isDataSaved = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Form paymentForm = new frmPayment();
            DialogResult selectedButton = paymentForm.ShowDialog();
            if (selectedButton == DialogResult.OK)
            {
                txtPayment.Text = (string)paymentForm.Tag;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboName.Items.Add("Anantha Komanduru");
            cboName.Items.Add("Purushotham Komanduru");
        }

        private void DataChanged(object sender, EventArgs e)
        {
            isDataSaved = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData()) 
            {
                SaveData();
            }
        }
        private void SaveData()
        {
            cboName.SelectedIndex = -1;
            txtPayment.Text = "";
            isDataSaved = true;
            cboName.Focus();
        }
        private bool IsValidData()
        {
            if (cboName.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a customer.", "Entry error");
                cboName.Focus();
                return false;
            }
            return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message;
            if (isDataSaved == false)
            {
                message =
                    "This form contains unsaved data.\n\n" +
                    "Do you want to save it?";

                DialogResult button =
                    MessageBox.Show(message, "Customer",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);
                if (button == DialogResult.Yes)
                {
                    if (IsValidData())
                        this.SaveData();
                    else
                        e.Cancel = true;
                }
                if (button == DialogResult.Cancel)
                {
                    e.Cancel = true;

                }
            }
        }
    }
}
