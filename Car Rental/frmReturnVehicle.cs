using Guna.UI2.WinForms;
using RentalBookingBusinessLayer;
using RentalTransactionBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleReturnsBusinessLayer;
using VehiclesBusinessLayer;

namespace Car_Rental_Project
{
    public partial class frmReturnVehicle : Form
    {

        int _VehicleID;

        clsVehicleBL _Vehicle = new clsVehicleBL();
        clsVehicleReturn _Return = new clsVehicleReturn();
        clsRentalBooking _Book;
        clsRentalTransactionBL _Transaction;
        public frmReturnVehicle(int VehcileID)
        {
            InitializeComponent();
            _VehicleID = VehcileID;
            _Vehicle = clsVehicleBL.Find(_VehicleID);
            _Book = clsRentalBooking.FindByVehicleID(_Vehicle.VehicleID); // Finding The Booking Record
            _Transaction = clsRentalTransactionBL.FindByBookingID(_Book.BookingID); // Finding The Wanted Transaction
            _SetMinimumReturnDate();
            this.Load += frmReturnVehicle_Load;

        }
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        private void frmReturnVehicle_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 17, 17));

            lblOldMilage.Text = _Vehicle.Mileage.ToString()+" )";

        }

        private void _SetMinimumReturnDate()
        {
            dtpReturnDate.MinDate = clsRentalBooking.GetBookingStartDateFromVehicleID(_VehicleID).AddDays(1);
            dtpReturnDate.Value = clsRentalBooking.GetBookingEndDateFromVehicleID(_VehicleID);

        }

        private bool IsNumeric(string value)
        {
            double result;
            return double.TryParse(value, out result);
        }

        bool _IsMilageValid()
        {
            int NewMilage;
            int OldMilage = _Vehicle.Mileage;
            int.TryParse(tbNewMilage.Text , out NewMilage);

            if (NewMilage < OldMilage)
                return false;

            else
                return true;


        }

        private void tbMilage_Validating(object sender, CancelEventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;

            if (!IsNumeric(textBox.Text))
            {
                e.Cancel = true;
                textBox.Select(0, textBox.Text.Length);
                epNumericValueCheck.SetError(textBox, "Please enter a valid numeric value.");
                MessageBox.Show("Please enter a valid numeric value", "Invalid Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!_IsMilageValid())
            {

                e.Cancel = true;
                textBox.Select(0, textBox.Text.Length);
                epNumericValueCheck.SetError(textBox, "Please enter a valid milage value.");
                MessageBox.Show("This Milage Value Is Less Than The Old Milage (" + _Vehicle.Mileage +") Mile, Please Enter A Currect Milage Value", "Invalid Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void tbMilage_Validated(object sender, EventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;
            epNumericValueCheck.SetError(textBox, "");
        }

        private void tbAdditionalCharges_Validating(object sender, CancelEventArgs e)
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

        private void tbAdditionalCharges_Validated(object sender, EventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;
            epNumericValueCheck.SetError(textBox, "");
        }

        private bool _CheckTextBoxes()
        {

            if(string.IsNullOrWhiteSpace(tbNewMilage.Text) || string.IsNullOrWhiteSpace(tbAdditionalCharges.Text))
            {
              MessageBox.Show("Please Fill All The Fields", "Invalid Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;   
            }

            return true;

        }

        private int _CalculateActualRentalDays()
        {
            DateTime ReturnDate = dtpReturnDate.Value;
            DateTime PickUpDate = clsRentalBooking.GetRentalStartDateFormVehicleID(_Vehicle.VehicleID);

            TimeSpan difference = ReturnDate.Subtract(PickUpDate);

            return (int)difference.TotalDays;
        }

        private int _CalculateConsumedMilage()
        {

            int NewMilage  = 0 , Difference = 0;
            int.TryParse(tbNewMilage.Text, out NewMilage);
            Difference =  NewMilage - _Vehicle.Mileage;
            _Vehicle.Mileage = NewMilage;
            _UpdateVehicleMilage();
            return Difference;

        }
        private int _CalculateAdditionalCharges()
        {

            int AdditionalCharges = 0;
            int.TryParse(tbAdditionalCharges.Text, out AdditionalCharges);

            return AdditionalCharges;

        }

        private void _UpdateVehicleMilage()
        {
            _Vehicle.Mode = clsVehicleBL.enMode.Update;
            _Vehicle.Save();
        }
        private decimal _CalculateActualTotalDueAmount()
        {

            decimal ActualTotalDueAmount = ( _CalculateActualRentalDays() * _Vehicle.RentalPricePerDay) + _CalculateAdditionalCharges();
            return ActualTotalDueAmount;

        }
        void _ReturnProcess()
        {
            _Return.Mode = clsVehicleReturn.enMode.AddNew;
            _Return.ActualReturnDate = dtpReturnDate.Value;
            _Return.ActualRentalDays = _CalculateActualRentalDays();
            _Return.Mileage = _Vehicle.Mileage;
            _Return.ConsumedMilaeage = _CalculateConsumedMilage();
            _Return.FinalCheckNotes = tbFinalCheckNotes.Text.Trim();
            _Return.AdditionalCharges = _CalculateAdditionalCharges();
            _Return.ActualTotalDueAmount = _CalculateActualTotalDueAmount();
        }

        private void _CalculateTheRestFeildsInRentalTransaction()
        {
            _Transaction.mode = clsRentalTransactionBL.enMode.eUpdate;
            _Transaction.TransactionID = _Transaction.TransactionID;
            _Transaction.BookingID = _Book.BookingID;
            _Transaction.ActualTotalDueAmount = _Return.ActualTotalDueAmount;
            _Transaction.TotalRemaining = (_Transaction.PaidInitialTotalDueAmount - _Transaction.ActualTotalDueAmount);
            _Transaction.TotalRefundedAmount = 0;
            _Transaction.PaymentDetails = _Transaction.PaymentDetails;
            _Transaction.PaidInitialTotalDueAmount = _Transaction.PaidInitialTotalDueAmount;
            _Transaction.TransactionDate = _Transaction.TransactionDate;
            _Transaction.UpdatedTransactionDate = DateTime.Today;
            _Transaction.ReturnID = _Return.ReturenID;

        }
        private void _ChangeVehicleAvailabilty()
        {

           // clsVehicleBL _Vehicle = clsVehicleBL.Find(clsRentalBooking.GetVehicleIDByRentalBookingID(_Transaction.BookingID));
            _Vehicle.Mode = clsVehicleBL.enMode.Update;
            _Vehicle.IsAvailableForRent = 1;
            _Vehicle.Save();

        }
        private void btnReturn_Click(object sender, EventArgs e)
        {

            if (_CheckTextBoxes())
            {
                DialogResult = MessageBox.Show("Are You Sure To Retuen Vehicle With ID [" + _Vehicle.VehicleID + "] ?", "Reutrn Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.Yes)
                {
                    _ReturnProcess();
                    if (_Return.Save())
                    {
                        _CalculateTheRestFeildsInRentalTransaction();
                        if (_Transaction.Save())
                        {
                            MessageBox.Show("Vehicle Returned Successfully :)" ,"Return Successfull", MessageBoxButtons.OK , MessageBoxIcon.Information );
                            _ChangeVehicleAvailabilty();
                        }
                    }

                    else
                        MessageBox.Show("Vehicle Return Failed :(", "Return Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }



        }

    }
}
