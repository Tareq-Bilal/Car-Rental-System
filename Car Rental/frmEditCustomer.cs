using CustomersBusinessLayer;
using Guna.UI2.WinForms;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Car_Rental_Project
{
    public partial class frmEditCustomer : Form
    {
        private int _CustomerID = 0;
        private string _CurrentImagePath = "";
        private string _CurrentDLN = "";
        clsCustomerBL _Customer = new clsCustomerBL();

        public frmEditCustomer(int CustomerID)
        {
            InitializeComponent();

            _CustomerID = CustomerID;
            this.Load += frmEditCustomer_Load; // Attach the Form1_Load event handler to the Load event of the form

        }

        private void _LoadCustomerData()
        {

            _Customer = clsCustomerBL.Find(_CustomerID);
            if (_Customer == null)
            {
                MessageBox.Show("Customer Does Not Exist!!", "Not Found Customer Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblCustomerID.Text = _Customer.CustomerID.ToString();
            tbName.Text = _Customer.Name;
            tbPhoneNumber.Text = _Customer.ContactInformation;
            tbDLN.Text = _Customer.DriverLicenseNumber.ToString();
            _CurrentDLN = _Customer.DriverLicenseNumber.ToString();

            try
            {
                _CurrentImagePath = _Customer.ImagePath;
                pbCustomer.Load(_CurrentImagePath);
            }
            catch (Exception ex)
            {
                _Customer.ImagePath = @"C:\Users\ASUS\Downloads\Unkown.jpg";
                pbCustomer.Load(_Customer.ImagePath);

            }

            //pbCustomer.Load(_CurrentImagePath);
        }
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        private void frmEditCustomer_Load(object sender, EventArgs e)
        {
            _LoadCustomerData();

            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 17, 17));

        }

        private void tbPhoneNumber_Validating(object sender, CancelEventArgs e)
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

        private void tbPhoneNumber_Validated(object sender, EventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;
            epNumericValueCheck.SetError(textBox, "");
        }

        private bool IsNumeric(string value)
        {
            double result;
            return double.TryParse(value, out result);
        }

        private bool _IsThereEmptyFields()
        {

            if (string.IsNullOrWhiteSpace(tbDLN.Text) || string.IsNullOrWhiteSpace(tbName.Text) || string.IsNullOrWhiteSpace(tbPhoneNumber.Text))
            {
                MessageBox.Show("Please Fill All The Feilds !", "Empty Feilds Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private void tbDLN_Validating(object sender, CancelEventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;

            if (clsCustomerBL.IsDLNRepeated(textBox.Text, _CurrentDLN))
            {
                e.Cancel = true;
                textBox.Select(0, textBox.Text.Length);
                epDLNCheck.SetError(textBox, "This Driver License Number Is Already Exist ! , Please Enter Onther One");
                MessageBox.Show("This Driver License Number Is Already Exist ! , Please Enter Onther One", "DLN Repeated Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tbDLN.Text = _CurrentDLN;
        }

        private void tbDLN_Validated(object sender, EventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;
            epDLNCheck.SetError(textBox, "");
        }

        private void llblSetPicture_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void llblRemovePicture_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbCustomer.ImageLocation = null;
            _CurrentImagePath = string.Empty;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure To Save This Data", "Save Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //int ID;
            // int.TryParse(lblCustomerID.Text.Trim(), out VehicleID);
            _Customer.Mode = clsCustomerBL.enMode.Update;
            _CustomerID = clsCustomerBL.Find(_CustomerID).CustomerID;

            if (result == DialogResult.Yes && !_IsThereEmptyFields())
            {
                _Customer.Name = tbName.Text.Trim();
                _Customer.ContactInformation = tbPhoneNumber.Text.Trim();
                _Customer.DriverLicenseNumber = tbDLN.Text.Trim();
                _Customer.ImagePath = _CurrentImagePath;
            }

            if (_Customer.Save())
                MessageBox.Show("Data Saved Successfully :)", "Save Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
                MessageBox.Show("Data Saved Failed :(", "Save Failuer", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
