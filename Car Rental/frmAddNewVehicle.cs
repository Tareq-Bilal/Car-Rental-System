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
using VehiclesBusinessLayer;

namespace Car_Rental_Project
{
    public partial class frmAddNewVehicle : Form
    {
        clsVehicleBL Vehicle = new clsVehicleBL();
        private string _CurrentImagePath = "";

        public frmAddNewVehicle()
        {
            InitializeComponent();
        }


        void _LoadCarCategories()
        {
            DataTable Categories = clsVehicleBL.GetVehicleCategories();

            foreach(DataRow row in Categories.Rows)
            {
                cbCategories.Items.Add(row["CategoryName"]);
            }

        }

        void _LoadFuelTypes()
        {
            DataTable Categories = clsVehicleBL.GetFuelTypes();

            foreach (DataRow row in Categories.Rows)
            {
                cbFuelType.Items.Add(row["FuleType"]);
            }

        }
        private void frmAddNewVehicle_Load(object sender, EventArgs e)
        {
            _LoadCarCategories();
            _LoadFuelTypes();
        }

        private bool IsNumeric(string value)
        {
            double result;
            return double.TryParse(value, out result);
        }

        private void guna2TextBox6_Validating(object sender, CancelEventArgs e)
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

        private void guna2TextBox6_Validated(object sender, EventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;
            epNumericValueCheck.SetError(textBox, "");

        }

        private bool _CheckTextBoxes()
        {
            foreach (Control control in Controls)
            {
                if (control is Guna2TextBox textBox)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        MessageBox.Show($"Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox.Focus();
                        return false;
                    }
                }
            }
            return true;
        }

        private bool _CheckComboBoxes()
        {
            foreach (Control control in Controls)
            {
                if (control is Guna2ComboBox comboBox)
                {
                    if (comboBox.SelectedIndex == -1)
                    {
                        MessageBox.Show($"Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        comboBox.Focus();
                        return false;
                    }
                }
            }
            return true;
        }

        private void _ClearTextBoxes()
        {
            foreach (Control control in Controls)
            {
                if (control is Guna2TextBox textBox)
                    textBox.Clear();

            }
        }

        private void _ClearComboBoxes()
        {
            foreach (Control control in Controls)
            {
                if (control is Guna2ComboBox comboBox)
                    comboBox.SelectedIndex = -1;

            }
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            int Year , Milage , RentPrice;

            Vehicle.Mode = clsVehicleBL.enMode.AddNew;
            Vehicle.Make = tbMake.Text.Trim();
            Vehicle.Model = tbModel.Text.Trim();

            if (int.TryParse(tbYear.Text, out Year))
                Vehicle.Year = Year;

            if (int.TryParse(tbMilage.Text, out Milage))
                Vehicle.Mileage = Milage;

            if (int.TryParse(tbRentPrice.Text, out RentPrice))
                Vehicle.RentalPricePerDay = RentPrice;

            Vehicle.PlateNumber = tbPlateNumber.Text.Trim();
            Vehicle.FuelType = clsVehicleBL.GetFuelID(cbFuelType.SelectedItem.ToString());
            Vehicle.CarCategoryID = clsVehicleBL.GetCategoryID(cbCategories.SelectedItem.ToString());

            //if (pbCarImage.ImageLocation != null || pbCarImage.ImageLocation != @"C:\Users\ASUS\Downloads\63e2f428156dab02c45d51b9__.jpg")
                Vehicle.ImagePath = _CurrentImagePath;

            if (cbAvailablity.SelectedIndex == 0)
                Vehicle.IsAvailableForRent =  1;

            else
                Vehicle.IsAvailableForRent = 0;

            if (_CheckTextBoxes() && _CheckComboBoxes())
            {
                if (Vehicle.Save())
                {
                    MessageBox.Show("Vehicle Added Successfully :)", "Vehcile Addition Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblVehicleID.Text = Vehicle.VehicleID.ToString();
                    Vehicle.Mode = clsVehicleBL.enMode.Update;

                }

                else
                    MessageBox.Show("Vehicle Added Failed :(", "Vehcile Addition Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            _ClearTextBoxes();
            _ClearComboBoxes();
        }

        private void llblSetPicture_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                //MessageBox.Show("Selected Image is:" + selectedFilePath);
                _CurrentImagePath = selectedFilePath;
                pbCarImage.Load(selectedFilePath);
                // ...
            }
        }

        private void llblRemovePicture_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbCarImage.ImageLocation = null;

        }

        private void tbPlateNumber_Validating(object sender, CancelEventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;

            if (clsVehicleBL.IsPlateNumberRepeated(tbPlateNumber.Text.Trim() , ""))
            {
                e.Cancel = true;
                textBox.Select(0, textBox.Text.Length);
                epPlateNumberCheck.SetError(textBox, "Plate Number Is Already Exist! , Please Enter Another Plate Number");
                MessageBox.Show("Plate Number Is Already Exist! , Please Enter Another Plate Number", "Exist Plate Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        
        }

        private void tbPlateNumber_Validated(object sender, EventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;
            epPlateNumberCheck.SetError(textBox, "");
        }
    }
}
