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

namespace Car_Rental_Project
{
    public partial class UC_VehicleReturns : UserControl
    {
        public UC_VehicleReturns()
        {
            InitializeComponent();
        }

        bool IsFilterSelected = false;

        public void _CenterAlignVehiclesReturnList()
        {
            foreach (DataGridViewColumn column in dgvAllVehiclesReturn.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        void _LoadVehiclesReturns()
        {

           dgvAllVehiclesReturn.DataSource = clsVehicleReturn.GetAllVehicleReturns();

        }

        private void UC_VehicleReturns_Load(object sender, EventArgs e)
        {
            _LoadVehiclesReturns();
            _CenterAlignVehiclesReturnList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _LoadVehiclesReturns();
            _CenterAlignVehiclesReturnList();
            cbFilter.SelectedIndex = 0;
            tbSearchReturnInfo.Text = string.Empty;

        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsFilterSelected = true;
            string ReturnInfo = tbSearchReturnInfo.Text.Trim();
            string Filter = cbFilter.SelectedItem.ToString();
            dgvAllVehiclesReturn.DataSource = clsVehicleReturn.GetVehicleReturnRecordByFilter(ReturnInfo, Filter);

        }

        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvAllVehiclesReturn.DataSource = clsVehicleReturn.SortingVehicleReturns(cbSort.SelectedItem.ToString().Trim());

            }
            catch (Exception ex)
            {

                _LoadVehiclesReturns();

            }


        }

        private void tbSearchReturnInfo_TextChanged(object sender, EventArgs e)
        {
            string ReturnVehicleInfo = tbSearchReturnInfo.Text.Trim();

            if (!IsFilterSelected || cbFilter.SelectedItem.ToString() == "None")
                dgvAllVehiclesReturn.DataSource = clsVehicleReturn.GetAllVehicleReturns();

            else
                dgvAllVehiclesReturn.DataSource = clsVehicleReturn.GetVehicleReturnRecordByFilter(ReturnVehicleInfo, cbFilter.SelectedItem.ToString());
        }
    }
}
