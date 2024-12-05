using CustomersBusinessLayer;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_Project
{
    public partial class frmAddNewCustomer : Form
    {

        private clsCustomerBL _Customer = new clsCustomerBL();
        private string _CurrentImagePath = "";

        public frmAddNewCustomer()
        {
            InitializeComponent();
        }

        private bool IsNumeric(string value)
        {
            double result;
            return double.TryParse(value, out result);
        }

       private void _CheckEmptyFields()
        {

            if (string.IsNullOrWhiteSpace(tbDLN.Text) || string.IsNullOrWhiteSpace(tbName.Text) || string.IsNullOrWhiteSpace(tbPhoneNumber.Text))
                MessageBox.Show("Please Fill All The Feilds !", "Empty Feilds Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure To Add This Customer ?", "Add Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if ( result == DialogResult.Yes)
            {
                _CheckEmptyFields();
                _Customer.Mode = clsCustomerBL.enMode.AddNew;
                _Customer.Name = tbName.Text.Trim();
                _Customer.ContactInformation = tbPhoneNumber.Text.Trim();
                _Customer.DriverLicenseNumber = tbDLN.Text.Trim();
                _Customer.ImagePath = _CurrentImagePath;


                if (_Customer.Save())
                {
                    MessageBox.Show("Customer Added Successfully With Number [" + _Customer.CustomerID + "]", "Addition Succeeded Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblCustomerID.Text = _Customer.CustomerID.ToString();
                    _Customer.Mode = clsCustomerBL.enMode.Update;
                }

                else
                    MessageBox.Show("Customer Added Failed !", "Addition Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            tbDLN.Text = tbName.Text = tbPhoneNumber.Text = "";
        }

        private void llblRemovePicture_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbCustomer.ImageLocation = null;
        }

        private void llblSetPicture_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                _CurrentImagePath = selectedFilePath;
                pbCustomer.Load(selectedFilePath);
            }
        }

        private void tbPhoneNumber_Validating_1(object sender, CancelEventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;

            if (!IsNumeric(textBox.Text))
            {
                e.Cancel = true;
                textBox.Select(0, textBox.Text.Length);
                epNumericValueCheck.SetError(textBox, "Please enter a valid numeric value.");
                MessageBox.Show("Please enter a valid numeric value", "Invalid Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbPhoneNumber_Validated_1(object sender, EventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;
            epNumericValueCheck.SetError(textBox, "");
        }

        private void tbDLN_Validating(object sender, CancelEventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;

            if (clsCustomerBL.IsDLNRepeated(textBox.Text , ""))
            {
                e.Cancel = true;
                textBox.Select(0, textBox.Text.Length);
                epDLNCheck.SetError(textBox, "This Driver License Number Is Already Exist ! , Please Enter Onther One");
                MessageBox.Show("This Driver License Number Is Already Exist ! , Please Enter Onther One", "DLN Repeated Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbDLN_Validated(object sender, EventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;
            epDLNCheck.SetError(textBox, "");
        }
    }
}
