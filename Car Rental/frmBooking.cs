using CustomersBusinessLayer;
using DashboardBusinessLayer;
using Guna.UI2.WinForms;
using RentalBookingBusinessLayer;
using RentalTransactionBL;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using VehiclesBusinessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Car_Rental_Project
{
    public partial class frmBooking : Form
    {
        int _VehicleID = 0;
        int initialRentalDays = 0;
        float TotalTransactionsAmount = 0;
        clsRentalBooking _Rent = new clsRentalBooking();
        clsRentalTransactionBL Transaction = new clsRentalTransactionBL();
        public frmBooking(int VehicleID)
        {
            InitializeComponent();

            _VehicleID = VehicleID;
            this.Load += frmBooking_Load; // Attach the Form1_Load event handler to the Load event of the form

        }

        clsVehicleBL _Vehicle = new clsVehicleBL();
        private void _SetMinimumDates()
        {

            dtpPickUpDate.MinDate = DateTime.Now;
            dtpDroppOffDate.MinDate = dtpPickUpDate.Value.AddDays(1);
        }

        private void _LoadVehicleData()
        {
            _Vehicle = clsVehicleBL.Find(_VehicleID);

            lblMake.Text = _Vehicle.Make;
            lblVehicleID.Text = _VehicleID.ToString();
            lblModel.Text = _Vehicle.Model;
            lblMilage.Text = _Vehicle.Mileage.ToString();
            lblPlateNumber.Text = _Vehicle.PlateNumber.ToString();
            lblPricePerDay.Text = _Vehicle.RentalPricePerDay.ToString() + '$';

            if (_Vehicle.ImagePath != null)
                pbSelectedCarImage.Load(_Vehicle.ImagePath);

            else
                pbSelectedCarImage.Load(@"C:\Users\ASUS\Downloads\63e2f428156dab02c45d51b9__.jpg");


        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void frmBooking_Load(object sender, EventArgs e)
        {
           // cbDroppOffLocation.DropDownStyle = cbPickUpLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 17, 17));

            _SetMinimumDates();
            _LoadVehicleData();

        }
        private bool IsNumeric(string value)
        {
            double result;
            return double.TryParse(value, out result);
        }

        private void tbCustomerID_Validating(object sender, CancelEventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;
            int CustomerID;
            int.TryParse(textBox.Text, out CustomerID);

            if (!IsNumeric(textBox.Text))
            {
                e.Cancel = true;
                textBox.Select(0, textBox.Text.Length);
                epNumericValueCheck.SetError(textBox, "Please enter a valid numeric value.");
                MessageBox.Show("Please enter a valid numeric value !", "Invalid Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            else if (!clsCustomerBL.isCustomerExist(CustomerID))
            {
                e.Cancel = true;
                textBox.Select(0, textBox.Text.Length);
                epNumericValueCheck.SetError(textBox, "Customer Does Not Exist !");
                MessageBox.Show("Customer Does Not Exist ! , Please Try Again", "Not Exist Customer Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void tbInitailRentalDays_Validated(object sender, EventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;
            epNumericValueCheck.SetError(textBox, "");
        }

        private void tbInitailRentalDays_Validating(object sender, CancelEventArgs e)
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

        private decimal _CalculatInitailTotalDueAmount(int InitialRentDays)
        {
            decimal Total = _Vehicle.RentalPricePerDay * InitialRentDays;
            return Total;

        }

        private void _ChangeVehicleAvailabilty()
        {
            _Vehicle.Mode = clsVehicleBL.enMode.Update;
            _Vehicle.IsAvailableForRent = 0;
            _Vehicle.Save();
        }

        private int _CalculateInitialRentalDays()
        {
            DateTime DroppOffDate = dtpDroppOffDate.Value;
            DateTime PickUpDate = dtpPickUpDate.Value;
            DateTime today = DateTime.Now;

            bool IsToday = PickUpDate.Day == today.Day;

            if (IsToday){

                TimeSpan difference = DroppOffDate.Subtract(PickUpDate);
                return (int)difference.TotalDays + 1 ;
            }

            else
            {
                TimeSpan difference = DroppOffDate.Subtract(PickUpDate);
                return (int)difference.TotalDays;
            }

        }

        private bool _EmptyFieldsValidation()
        {
            if (string.IsNullOrWhiteSpace(tbCustomerID.Text) || cbPickUpLocation.SelectedIndex == -1 || cbDroppOffLocation.SelectedIndex == -1)
                return false;

            return true;
        }

        private void _AddRentalTransaction()
        {

            Transaction.mode = clsRentalTransactionBL.enMode.eAddNew;
            Transaction.BookingID = _Rent.BookingID;
            Transaction.ReturnID = null;
            Transaction.TransactionDate = DateTime.Today;
            Transaction.ActualTotalDueAmount = null;
            Transaction.PaidInitialTotalDueAmount = _Rent.InitialTotalDueAmount;
            Transaction.TotalRemaining = null;
            Transaction.TotalRefundedAmount = null;
            Transaction.UpdatedTransactionDate = null;

        }
        private void btnRent_Click(object sender, EventArgs e)
        {

            if (!_EmptyFieldsValidation())
            {
                MessageBox.Show("Invaild Fields Input ! , Please Fill All The Fields", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _Rent.Mode = clsRentalBooking.enMode.AddNew;

            initialRentalDays = _CalculateInitialRentalDays();
            lblInitialRentDays.Text = initialRentalDays.ToString();

            int CustomerID;
            int.TryParse(tbCustomerID.Text, out CustomerID);
            _Rent.VehicleID = _VehicleID;
            _Rent.RentalPricePerDay = _Vehicle.RentalPricePerDay;
            _Rent.OldRentalPricePerDay = _Vehicle.RentalPricePerDay;
            _Rent.RentalStartDate = dtpPickUpDate.Value;
            _Rent.RentalEndDate = dtpDroppOffDate.Value;
            _Rent.PickupLocation = cbPickUpLocation.SelectedItem.ToString();
            _Rent.DropoffLocation = cbDroppOffLocation.SelectedItem.ToString();
            _Rent.CustomerID = CustomerID;
            _Rent.InitialRentalDays = initialRentalDays;
            _Rent.InitialCheckNotes = tbInitialCheckNotes.Text.Trim();
            _Rent.InitialTotalDueAmount = _CalculatInitailTotalDueAmount(initialRentalDays);

            DialogResult = MessageBox.Show("Are You Sure To Rent This Car ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                if (_Rent.Save())
                {

                    MessageBox.Show("Rental Operation Saved Successfully :) \n" +
                                    "* Booking ID : [" + _Rent.BookingID + "]\n" +
                                    "* Initail Total Due Amount : " + _Rent.InitialTotalDueAmount + "", "Addition Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    _ChangeVehicleAvailabilty();
                    _AddRentalTransaction();


                    if (Transaction.Save())
                        MessageBox.Show("Transaction Operation Saved :)", "Addition Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    else
                        MessageBox.Show("Transaction Operation Saving Failed :(", "Addition Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                else
                {
                    MessageBox.Show("Rental Operation Saving Failed :(", "Addition Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void dtpPickUpDate_ValueChanged(object sender, EventArgs e)
        {
            _SetMinimumDates();
        }

        private void cbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            Transaction.PaymentDetails = cbPaymentMethod.SelectedItem.ToString();
        }

    }
}
