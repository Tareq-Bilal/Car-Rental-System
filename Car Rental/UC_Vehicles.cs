using System;
using System.Windows.Forms;
using VehiclesBusinessLayer;

namespace Car_Rental_Project
{
    public partial class UC_Vehicles : UserControl
    {

        public bool IsFilterSelected = false;
        public UC_Vehicles()
        {
            InitializeComponent();
        }

        public void _CenterAlignVehiclesList()
        {
            foreach (DataGridViewColumn column in dgvAllVehicles.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        void _LoadVehiclesList()
        {
            dgvAllVehicles.DataSource = clsVehicleBL.GetAllVehicles();

        }

        void _SetHeadersNames()
        {

            dgvAllVehicles.Columns[0].HeaderText = "ID";
            dgvAllVehicles.Columns[1].HeaderText = "Make";
            dgvAllVehicles.Columns[2].HeaderText = "Model";
            dgvAllVehicles.Columns[3].HeaderText = "Year";
            dgvAllVehicles.Columns[4].HeaderText = "Milage";
            dgvAllVehicles.Columns[5].HeaderText = "FuelTypeID";
            dgvAllVehicles.Columns[6].HeaderText = "PlateNum";
            dgvAllVehicles.Columns[7].HeaderText = "Category";
            dgvAllVehicles.Columns[8].HeaderText = "Price/Day";
            dgvAllVehicles.Columns[9].HeaderText = "IsAvailable";

        }
        private void UC_Vehicles_Load(object sender, EventArgs e)
        {
            _LoadVehiclesList();
            _SetHeadersNames();
            _CenterAlignVehiclesList();
        }

        private void tbSearchVehicleInfo_TextChanged(object sender, EventArgs e)
        {
            string VehicleInfo = tbSearchVehicleInfo.Text.Trim();

            if (!IsFilterSelected || cbFilter.SelectedIndex == 0)
                dgvAllVehicles.DataSource = clsVehicleBL.GetVehiclesByInfo(VehicleInfo);

            else
                dgvAllVehicles.DataSource = clsVehicleBL.GetVehicleByFilter(VehicleInfo, cbFilter.SelectedItem.ToString());
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _LoadVehiclesList();
            tbSearchVehicleInfo.Text = string.Empty;
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsFilterSelected = true;
            string VehicleInfo = tbSearchVehicleInfo.Text.Trim();
            string Filter = cbFilter.SelectedItem.ToString();
            dgvAllVehicles.DataSource = clsVehicleBL.GetVehicleByFilter(VehicleInfo, Filter);

        }

        private void btnAddNewVehicle_Click(object sender, EventArgs e)
        {
            frmAddNewVehicle frm = new frmAddNewVehicle();
            frm.ShowDialog();
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            frmEditVehicle frm = new frmEditVehicle((int)dgvAllVehicles.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {

            if ((int)dgvAllVehicles.CurrentRow.Cells[9].Value == 0)
            {
                MessageBox.Show("You Can't Delete Rented / Under maintenance Vehicle !", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            DialogResult result = MessageBox.Show("Are You Sure To Delete Vehcile With ID [" + (int)dgvAllVehicles.CurrentRow.Cells[0].Value + "] ? ", "Deletetion Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (clsVehicleBL.DeleteVehicle((int)dgvAllVehicles.CurrentRow.Cells[0].Value))
                    MessageBox.Show("Vehcile Deleted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                else
                    MessageBox.Show("Vehcile Deleted Failed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }


            _LoadVehiclesList();

        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int VehicleID = (int)dgvAllVehicles.CurrentRow.Cells[0].Value;
            if (clsVehicleBL.Find((int)dgvAllVehicles.CurrentRow.Cells[0].Value).IsAvailableForRent == 1)
            {
                frmBooking frm = new frmBooking(VehicleID);
                frm.ShowDialog();
            }

            else
                MessageBox.Show("Vehcile Is Not Available For Rent !", "Not Available Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
    }
}
