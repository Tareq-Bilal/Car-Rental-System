using System;
using System.Windows.Forms;


namespace Car_Rental_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load; // Attach the Form1_Load event handler to the Load event of the form
        }
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 9, 9));
            uC_Dashboard1.BringToFront();
            Home.SetShadowForm(this);

        }

        private void btnDashboard_CheckedChanged(object sender, EventArgs e)
        {
            if (btnDashboard.Checked) uC_Dashboard1.BringToFront();

        }

        private void btnVehicles_CheckedChanged(object sender, EventArgs e)
        {
            if (btnVehicles.Checked) uC_Vehicles1.BringToFront();

        }

        private void btnCustomers_CheckedChanged(object sender, EventArgs e)
        {
            if (btnCustomers.Checked) uC_Customers1.BringToFront();

        }

        private void btnRentalBooking_CheckedChanged(object sender, EventArgs e)
        {
            if (btnRentalBooking.Checked) uC_RentalBooking1.BringToFront();

        }

        private void btnRentalTransaction_CheckedChanged(object sender, EventArgs e)
        {
            if (btnRentalTransaction.Checked) uC_RentalTransactions1.BringToFront();

        }

        private void btnVehicleReturns_CheckedChanged(object sender, EventArgs e)
        {
            if (btnVehicleReturns.Checked) uC_VehicleReturns1.BringToFront();

        }

        private void uC_VehicleReturns1_Load(object sender, EventArgs e)
        {

        }

        private void btnRentalBooking_Click(object sender, EventArgs e)
        {

        }
    }
}
