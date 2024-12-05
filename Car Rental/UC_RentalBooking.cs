using Guna.UI2.WinForms;
using RentalBookingBusinessLayer;
using RentalTransactionBL;
using System;
using System.Drawing;
using System.Windows.Forms;
using VehicleReturnsBusinessLayer;
using VehiclesBusinessLayer;

namespace Car_Rental_Project
{
    public partial class UC_RentalBooking : UserControl
    {
        public bool IsFilterSelected = false;

        public UC_RentalBooking()
        {
            InitializeComponent();

        }

        private void _LoadRentalBookings()
        {
            dgvAllRentalBookings.DataSource = clsRentalBooking.GetAllRentalBooking();
        }
        public void _CenterAlignBookingList()
        {
            foreach (DataGridViewColumn column in dgvAllRentalBookings.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        private void UC_RentalBooking_Load(object sender, EventArgs e)
        {
            _LoadRentalBookings();
            _CenterAlignBookingList();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _LoadRentalBookings();
            _CenterAlignBookingList();
            tbSearchBookInfo.Text = string.Empty;
            cbFilter.SelectedIndex = 0;
            cbSort.SelectedIndex = -1;
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsFilterSelected = true;
            string BookInfo = tbSearchBookInfo.Text.Trim();
            string Filter = cbFilter.SelectedItem.ToString();
            dgvAllRentalBookings.DataSource = clsVehicleBL.GetVehicleByFilter(BookInfo, Filter);
        }

        private void tbSearchBookInfo_TextChanged(object sender, EventArgs e)
        {
            string BookInfo = tbSearchBookInfo.Text.Trim();

            if (!IsFilterSelected || cbFilter.SelectedItem.ToString() == "None")
                dgvAllRentalBookings.DataSource = clsRentalBooking.GetAllRentalBooking();

            else
                dgvAllRentalBookings.DataSource = clsRentalBooking.GetVehcileBookByFilter(BookInfo, cbFilter.SelectedItem.ToString());
        }

        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvAllRentalBookings.DataSource = clsRentalBooking.SortingRentalBooks(cbSort.SelectedItem.ToString().Trim());

            }
            catch (Exception ex)
            {

                _LoadRentalBookings();

            }
        }

        private void _MakeFieldsReadOnly(Form form)
        {


            foreach (Control control in form.Controls)
            {
                if (control is Guna2TextBox)
                {
                    Guna2TextBox textBox = (Guna2TextBox)control;

                    textBox.ReadOnly = true;

                }

                if (control is Guna2ComboBox)
                {
                    control.Enabled = false;
                    control.ForeColor = Color.Black;
                }

                if (control is Guna2Button || control is LinkLabel)
                    control.Hide();

                if (control is Guna2PictureBox)
                    control.Size = new Size(397, 240);


            }



        }
        private void tsmShowVehicleInfo_Click(object sender, EventArgs e)
        {
            frmEditVehicle frm = new frmEditVehicle((int)dgvAllRentalBookings.CurrentRow.Cells[2].Value);
            _MakeFieldsReadOnly(frm);
            frm.ShowDialog();
        }

        private void tmsCustomerInfo_Click(object sender, EventArgs e)
        {
            frmEditCustomer frm = new frmEditCustomer((int)dgvAllRentalBookings.CurrentRow.Cells[1].Value);
            _MakeFieldsReadOnly(frm);
            frm.ShowDialog();
        }

        private bool _IsVehicleReturned(int VehicleID)
        {
          clsRentalBooking rentalBooking = clsRentalBooking.FindByVehicleID(VehicleID);
          clsRentalTransactionBL rentalTransaction =  clsRentalTransactionBL.FindByBookingID(rentalBooking.BookingID);

            if(rentalTransaction.ReturnID == -1)
                return false;

            else
                return true;

        }

        private void returnVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            frmReturnVehicle frm = new frmReturnVehicle((int)dgvAllRentalBookings.CurrentRow.Cells[2].Value);
            frm.ShowDialog();
            
        
        }

        private void cmsRentalBooking_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!_IsVehicleReturned((int)dgvAllRentalBookings.CurrentRow.Cells[2].Value))
            {
                returnVehicleToolStripMenuItem.ForeColor = Color.Black;
                returnVehicleToolStripMenuItem.Enabled = true;

            }


            else
            {
                returnVehicleToolStripMenuItem.Enabled = false;
                returnVehicleToolStripMenuItem.ForeColor = Color.DarkGray;
            }

        }

    }
}
