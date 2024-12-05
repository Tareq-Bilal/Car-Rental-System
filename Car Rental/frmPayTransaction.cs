using DashboardBusinessLayer;
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
    public partial class frmPayTransaction : Form
    {
        int _TransactionID;
        clsRentalTransactionBL _Transaction = new clsRentalTransactionBL();
        decimal? _CurrentTotalRemaining;
        decimal PaymentAmount;

        clsDashboard _Dashboard = clsDashboard.Find(1);

        public frmPayTransaction(int TransactionID)
        {
            InitializeComponent();

            this.Load += frmPayTransaction_Load; // Attach the Form1_Load event handler to the Load event of the form

            _TransactionID = TransactionID;
            _Transaction = clsRentalTransactionBL.FindByTransactionID(TransactionID);
            _CurrentTotalRemaining = _Transaction.TotalRemaining;
            guna2Panel1.Focus();

        }

        private void _LoadTransactionInfo()
        {
            lblTransactionID.Text = _Transaction.TransactionID.ToString();
            lblPaidInitialTotalDueAmount.Text = _Transaction.PaidInitialTotalDueAmount.ToString() + "  $";
            lblActualTotalDueAmount.Text = _Transaction.ActualTotalDueAmount.ToString() + "  $";
            lblTotalRemaining.Text = _Transaction.TotalRemaining.ToString() + "  $";
            lblTotalRefunded.Text = _Transaction.TotalRefundedAmount.ToString() + "  $";


        }
        private void frmPayTransaction_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 17, 17));

            _LoadTransactionInfo();

            if(_Transaction.TotalRemaining == 0)
            {
                tbPamentAmount.Hide();
                guna2HtmlLabel4.Hide();
            }

        }


        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private bool IsNumeric(string value)
        {
            double result;
            return double.TryParse(value, out result);
        }

        private bool _IsVaildPaymentAmount(string sAmount)
        {

            decimal result;
            decimal.TryParse(sAmount, out result);

            if (_Transaction.TotalRemaining < 0 && (result >= _Transaction.TotalRemaining && result <= _Transaction.TotalRemaining * -1) && (result > 0))
            {
                return true;
            }

            else if (_Transaction.TotalRemaining > 0 && (result <= _Transaction.TotalRemaining) && (result > 0))
            {
                return true;
            }

            else
                return false;

        }
        private void tbPamentAmount_Validating(object sender, CancelEventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;

            if (!IsNumeric(textBox.Text))
            {
                e.Cancel = true;
                textBox.Select(0, textBox.Text.Length);
                epNumericValueCheck.SetError(textBox, "Please enter a valid numeric value.");
                MessageBox.Show("Please enter a valid numeric value", "Invalid Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (!_IsVaildPaymentAmount(textBox.Text))
            {
                e.Cancel = true;
                textBox.Select(0, textBox.Text.Length);
                epNumericValueCheck.SetError(textBox, "Please enter a valid Payment value.");
                MessageBox.Show("This Payment Value Is More/Less Than The Remaining Amount (" + _Transaction.TotalRemaining + ") $, Please Enter Currect Payment Amount", "Invalid Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void _ChangeTotalRemaingValue()
        {

            decimal.TryParse(tbPamentAmount.Text, out PaymentAmount);

            if (_Transaction.TotalRemaining < 0)
            {
                _CurrentTotalRemaining = (PaymentAmount + _Transaction.TotalRemaining);
                lblTotalRemaining.Text = _CurrentTotalRemaining.ToString() + "  $";

            }

            else
            {
                _CurrentTotalRemaining = (_Transaction.TotalRemaining - PaymentAmount);
                lblTotalRemaining.Text = _CurrentTotalRemaining.ToString() + "  $";
            }

        }
        private void tbPamentAmount_TextChanged(object sender, EventArgs e)
        {
            _ChangeTotalRemaingValue();

            if (string.IsNullOrEmpty(tbPamentAmount.Text))
                lblTotalRemaining.Text = _CurrentTotalRemaining.ToString() + "  $";

        }

        void _FullPayment()
        {
            try
            {
                _Transaction.TotalRemaining = _CurrentTotalRemaining;
                _Dashboard.Mode = clsDashboard.enMode.Update;
                clsDashboard.IncreaseTotalRentalBookings();
                clsDashboard.IncreaseTotalTransactionAmount((float)_Transaction.ActualTotalDueAmount);
               // _Dashboard.Save();
                _Transaction.Save();
                clsRentalTransactionBL.DeleteRow(_Transaction.TransactionID);
                clsRentalBooking.DeleteRentalBooking(_Transaction.BookingID);
                clsVehicleReturn.DeleteVehicleReturn(_Transaction.ReturnID);

                MessageBox.Show("Payment Done Successfully ✔\n\n" +
                                "Total Remaining : " + _Transaction.TotalRemaining + "\n" +
                                "Payment Date : " + DateTime.Today + "\n\n" +
                                "*Note : Fantastic news! Your payment transaction has been fully paid! We're thrilled to hear that and hope that this gives you peace of mind." , "Transaction Payment Succeeded", MessageBoxButtons.OK , MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

            }

        }


        void _PartialPayment()
        {
            try
            {
                _Transaction.TotalRemaining = _CurrentTotalRemaining;

                if (_Transaction.TotalRemaining > 0)
                    _Transaction.TotalRefundedAmount += PaymentAmount;

                _Transaction.Save();

                MessageBox.Show("Payment Done Successfully ✔\n\n" +
                                "Total Remaining : " + _Transaction.TotalRemaining + "\n" +
                                "Payment Date : " + DateTime.Today + "\n" , "Transaction Payment Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

            }

        }
        void _Pay()
        {

            DialogResult = MessageBox.Show("Are You Sure To Pay This Transaction ?", "Payment Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult == DialogResult.Yes)
            {

                if (_CurrentTotalRemaining == 0)

                {
                    _FullPayment();
                }
                else
                {
                    _PartialPayment();

                }
            }

        }
        private void btnPay_Click(object sender, EventArgs e)
        {

            _Pay();

        }
    }
}
