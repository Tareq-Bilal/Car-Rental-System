using Guna.UI2.WinForms;
using Microsoft.SqlServer.Server;
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
using System.Web.Util;
using System.Windows.Forms;
using VehiclesBusinessLayer;

namespace Car_Rental_Project
{
    public partial class UC_RentalTransactions : UserControl
    {
        public bool IsFilterSelected = false;

        public UC_RentalTransactions()
        {
            InitializeComponent();

        }

        private void _LoadRentalTransactions()
        {
            dgvAllRentalTransactions.DataSource = clsRentalTransactionBL.GetAllRows();

        }
        private void _CenterAlignBookingList()
        {
            foreach (DataGridViewColumn column in dgvAllRentalTransactions.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                
            }
        }
        private void UC_RentalTransactions_Load(object sender, EventArgs e)
        {
            _LoadRentalTransactions();
            _CenterAlignBookingList();
        }

        private void dgvAllRentalTransactions_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null || string.IsNullOrWhiteSpace(e.Value.ToString()))
            {
                e.Value = "---";
            }

            int targetColumnIndex = 6;
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                // Check if the current cell is in the target column and a data cell
                if (e.ColumnIndex == targetColumnIndex && e.ColumnIndex < dgvAllRentalTransactions.Columns.Count && e.RowIndex < dgvAllRentalTransactions.Rows.Count)
                {
                    // ... (rest of formatting logic remains the same)
                    // Get the value, check if < 0, set red foreground color if applicable
                    double cellValue;
                    if (double.TryParse(e.Value?.ToString(), out cellValue))
                    {
                        if (cellValue < 0)
                        {
                            // Set the foreground color to red
                            e.CellStyle.ForeColor = Color.Red;
                            e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                        }

                        if (cellValue > 0)
                        {
                            e.CellStyle.ForeColor = Color.Green;
                            e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                        }

                        if(cellValue == 0)
                        {
                            e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);

                        }
                    }
                    else
                    {
                        // Handle non-numeric values (optional)
                        // You can display an error message or set a default color
                    }


                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _LoadRentalTransactions();
            _CenterAlignBookingList();
            tbSearchTransactionInfo.Text = string.Empty;
            cbFilter.SelectedIndex = 0;
            cbSort.SelectedIndex = -1;
        }

        private void tbSearchTransactionInfo_TextChanged(object sender, EventArgs e)
        {
            string TrasnactionInfo = tbSearchTransactionInfo.Text.Trim();

            if (!IsFilterSelected || cbFilter.SelectedItem.ToString() == "None")
                dgvAllRentalTransactions.DataSource = clsRentalTransactionBL.GetAllRows();

            else
                dgvAllRentalTransactions.DataSource = clsRentalTransactionBL.GetRentalTransactionByFilter(TrasnactionInfo, cbFilter.SelectedItem.ToString());


        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsFilterSelected = true;
            string TransactionInfo = tbSearchTransactionInfo.Text.Trim();
            string Filter = cbFilter.SelectedItem.ToString();
            dgvAllRentalTransactions.DataSource = clsRentalTransactionBL.GetRentalTransactionByFilter(TransactionInfo, Filter);
        }

        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvAllRentalTransactions.DataSource = clsRentalTransactionBL.SortingRentalBooks(cbSort.SelectedItem.ToString().Trim());

            }
            catch (Exception ex)
            {

                _LoadRentalTransactions();

            }
        }

        private void tsmPay_Click(object sender, EventArgs e)
        {
            frmPayTransaction frm = new frmPayTransaction((int)dgvAllRentalTransactions.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private bool _IsVehicleReturned(int TransactionID)
        {
            clsRentalTransactionBL Transaction = clsRentalTransactionBL.FindByTransactionID(TransactionID);

            if (Transaction.ReturnID == -1)
                return false;

            return true;

        }

        private void cmsPayTransaction_Opening(object sender, CancelEventArgs e)
        {
            if (!_IsVehicleReturned((int)dgvAllRentalTransactions.CurrentRow.Cells[0].Value))
            {
                cmsPayTransaction.ForeColor = Color.DarkGray;
                cmsPayTransaction.Enabled = false;

            }

            else
            {

                cmsPayTransaction.ForeColor = Color.Black;
                cmsPayTransaction.Enabled = true;
            }

        }
    }
}
