using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehiclesBusinessLayer;

namespace Car_Rental_Project
{
    public partial class frmEditVehicle : Form
    {

        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        bool IsLoaded = false;
        clsVehicleBL Vehicle = new clsVehicleBL();
        private int _VehicleID;
        private string _CurrentImagePath = "";
        private string _CurrentPlateNumber = "";

        public frmEditVehicle(int vehicleID)
        {
            InitializeComponent();
            this.Load += frmEditVehicle_Load; // Attach the Form1_Load event handler to the Load event of the form

            _VehicleID = vehicleID;

            if (_VehicleID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;


        }

        void _LoadVehicleData()
        {

            Vehicle = clsVehicleBL.Find(_VehicleID);

            if (Vehicle != null)
            {
                lblVehicleID.Text = Vehicle.VehicleID.ToString();
                tbMake.Text = Vehicle.Make.ToString();
                tbMilage.Text = Vehicle.Mileage.ToString();
                tbModel.Text = Vehicle.Model.ToString();
                tbYear.Text = Vehicle.Year.ToString();
                tbRentPrice.Text = Vehicle.RentalPricePerDay.ToString();
                tbPlateNumber.Text = Vehicle.PlateNumber;
                _CurrentPlateNumber = Vehicle.PlateNumber;
                _SelectedFuelType(clsVehicleBL.GetFuelName(Vehicle.FuelType));
                _SelectedCategory(clsVehicleBL.GetCategoryName(Vehicle.CarCategoryID));
               
                if(Vehicle.IsAvailableForRent == 1)
                    cbAvailablity.SelectedIndex = 0;

                else
                    cbAvailablity.SelectedIndex = 1;

                try
                {
                    _CurrentImagePath = Vehicle.ImagePath;
                    pbCarImage.Load(_CurrentImagePath);
                }
                catch (Exception ex)
                {
                    Vehicle.ImagePath = @"C:\Users\ASUS\Downloads\63e2f428156dab02c45d51b9__.jpg";
                    _CurrentImagePath = Vehicle.ImagePath;
                    pbCarImage.Load(Vehicle.ImagePath);

                }


            }

            else
            {
                MessageBox.Show("Vehcile Does NOT Exist !!", "Not Found Vehicle Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        void _SelectedFuelType(string FuelType)
        {
            switch (FuelType) {

                case "Gasoline":
                    {
                        cbFuelType.SelectedIndex = 0; break;

                    }
                case "Diesel":
                    {
                        cbFuelType.SelectedIndex = 1; break;
                    }
                case "Electricity":
                    {
                        cbFuelType.SelectedIndex = 2; break;
                    }
                case "Hybrid":
                    {
                        cbFuelType.SelectedIndex = 3; break;
                    }

            }

        }
        void _SelectedCategory(string Category)
        {
                switch (Category)
            {

                case "Sedan":
                    {
                        cbCategories.SelectedIndex = 0; break;

                    }
                case "SUV":
                    {
                        cbCategories.SelectedIndex = 1; break;
                    }
                case "Coupe":
                    {
                        cbCategories.SelectedIndex = 2; break;
                    }
                case "Hatchback":
                    {
                        cbCategories.SelectedIndex = 3; break;
                    }

            }

        }



        void _LoadFuelTypes()
        {
            DataTable FuelTypes = clsVehicleBL.GetFuelTypes();

            foreach (DataRow row in FuelTypes.Rows)
            {
                cbFuelType.Items.Add(row["FuleType"]);
            }

        }
        void _LoadVehicleCategories()
        {
            DataTable Categories = clsVehicleBL.GetVehicleCategories();

            foreach (DataRow row in Categories.Rows)
            {
                cbCategories.Items.Add(row["CategoryName"]);
            }
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        private void frmEditVehicle_Load(object sender, EventArgs e)
        {
            if (!IsLoaded)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 17, 17));

                _LoadFuelTypes();
                _LoadVehicleCategories();
                _LoadVehicleData();
                this.Focus();

                IsLoaded = true;

            }
            

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
           // llblRemovePicture.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure To Save This Data", "Save Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            int VehicleID;
            int.TryParse(lblVehicleID.Text.Trim(), out VehicleID);
            Vehicle.Mode = clsVehicleBL.enMode.Update;
            VehicleID = clsVehicleBL.Find(VehicleID).VehicleID;

            if(result == DialogResult.Yes)
            {
                int Year = 0 , Milage = 0;
                decimal RentalPrice;
                Vehicle.Make = tbMake.Text.Trim();
                Vehicle.Model = tbModel.Text.Trim();
                int.TryParse(tbYear.Text.Trim(), out Year);
                Vehicle.Year =Year;
                int.TryParse(tbMilage.Text.Trim(), out Milage);
                Vehicle.Mileage = Milage;
                decimal.TryParse(tbRentPrice.Text.Trim(), out RentalPrice);
                Vehicle.RentalPricePerDay = RentalPrice;
                Vehicle.PlateNumber = tbPlateNumber.Text.Trim();
                Vehicle.FuelType = clsVehicleBL.GetFuelID(cbFuelType.SelectedItem.ToString());
                Vehicle.CarCategoryID = clsVehicleBL.GetCategoryID(cbCategories.SelectedItem.ToString());
                Vehicle.VehicleID = VehicleID;

                if (cbAvailablity.SelectedIndex == 0)
                    Vehicle.IsAvailableForRent = 1;

                else
                    Vehicle.IsAvailableForRent = 0;

                //if (pbCarImage.ImageLocation != null || pbCarImage.ImageLocation != @"C:\Users\ASUS\Downloads\63e2f428156dab02c45d51b9__.jpg")
                    Vehicle.ImagePath = _CurrentImagePath;

                //else
                //    Vehicle.ImagePath = @"C:\Users\ASUS\Downloads\63e2f428156dab02c45d51b9__.jpg";


                if (Vehicle.Save())
                    MessageBox.Show("Data Saved Successfully :)", "Save Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                else
                    MessageBox.Show("Data Saved Failed :(", "Save Failuer", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void tbPlateNumber_Validating(object sender, CancelEventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;

            if (clsVehicleBL.IsPlateNumberRepeated(tbPlateNumber.Text.Trim() , _CurrentPlateNumber))
            {
                e.Cancel = true;
                textBox.Select(0, textBox.Text.Length);
                epPlateNumberCheck.SetError(textBox, "Plate Number Is Already Exist! , Please Enter Another Plate Number");
                MessageBox.Show("Plate Number Is Already Exist! , Please Enter Another Plate Number", "Exist Plate Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPlateNumber.Text = _CurrentPlateNumber;
            }
        }

        private void tbPlateNumber_Validated(object sender, EventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;
            epPlateNumberCheck.SetError(textBox, "");
        }
        private bool IsNumeric(string value)
        {
            double result;
            return double.TryParse(value, out result);
        }
        private void tbRentPrice_Validating(object sender, CancelEventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;

            if (!IsNumeric(textBox.Text))
            {
                e.Cancel = true;
                textBox.Select(0, textBox.Text.Length);
                epNumericValueCheck.SetError(textBox, "Please enter a valid numeric value.");
                MessageBox.Show("Please enter a valid numeric value !", "Invalid Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbRentPrice_Validated(object sender, EventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;
            epNumericValueCheck.SetError(textBox, "");
        }

        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
