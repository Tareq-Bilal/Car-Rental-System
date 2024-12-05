using CustomersBusinessLayer;
using RentalBookingBusinessLayer;
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
    public partial class UC_Customers : UserControl
    {

        public bool IsFilterSelected = false;


        public UC_Customers()
        {
            InitializeComponent();
        }

        private void _LoadCustomersList()
        {

            dgvAllCustomers.DataSource = clsCustomerBL.GetAllCustomers();

        }
        public void _CenterAlignVehiclesList()
        {
            foreach (DataGridViewColumn column in dgvAllCustomers.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void UC_Customers_Load(object sender, EventArgs e)
        {
            _LoadCustomersList();
            _CenterAlignVehiclesList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _LoadCustomersList();
            _CenterAlignVehiclesList();
            cbFilter.SelectedIndex = 0;
            tbSearchCustomerInfo.Text = string.Empty;
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            frmAddNewCustomer frm = new frmAddNewCustomer();
            frm.ShowDialog();
        }

        private void tbSearchCustomerInfo_TextChanged(object sender, EventArgs e)
        {
            string CustomerInfo = tbSearchCustomerInfo.Text.Trim();

            dgvAllCustomers.DataSource =  clsCustomerBL.GetCustomerByFilter(CustomerInfo, cbFilter.SelectedItem.ToString());
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsFilterSelected = true;
            string VehicleInfo = tbSearchCustomerInfo.Text.Trim();
            string Filter = cbFilter.SelectedItem.ToString();
            dgvAllCustomers.DataSource = clsVehicleBL.GetVehicleByFilter(VehicleInfo, Filter);


        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            if (!clsRentalBooking.IsCustomerHasRentalBooking((int)dgvAllCustomers.CurrentRow.Cells[0].Value))
            {
                DialogResult result = MessageBox.Show("Are You Sure To Delete This Customer ?", "Delete Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    clsCustomerBL.DeleteCustomer((int)dgvAllCustomers.CurrentRow.Cells[0].Value);
                    MessageBox.Show("Customer Deleted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _LoadCustomersList();
                }

            }

            else
            {
                MessageBox.Show("You Can't Delete A Customer Has An Active Rental Booking Operation !!", "Delete Active Customer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {

            frmEditCustomer frm = new frmEditCustomer((int)dgvAllCustomers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

        }
    }
}
