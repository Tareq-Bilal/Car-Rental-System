using System;
using RentalBookingBusinessLayer;
using RentalTransactionBL;
using VehicleReturnsBusinessLayer;
using VehiclesBusinessLayer;
using CustomersBusinessLayer;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DashboardBusinessLayer;
using LiveCharts.Wpf;
using LiveCharts;
using System.Windows.Forms.DataVisualization.Charting;
using LiveCharts.Defaults;
using System.Data.SQLite;


namespace Car_Rental_Project
{
    public partial class UC_Dashboard : UserControl
    {
        private int rentalBookings = 0;
        private double totalAmount = 0;
        private int numberOfCustomers = 0;
        private Timer timer;

        public UC_Dashboard()
        {
            InitializeComponent();
            InitializeChart();
        }

        private void InitializeChart()
        {
            cartesianChart1.Series = new LiveCharts.SeriesCollection
{
    new LineSeries
    {
        Title = "Total Rental Bookings",
        Values = new ChartValues<ObservablePoint>
        {
            new ObservablePoint(0, 10),  // First Point of First Line
            new ObservablePoint(4, 7),   // 2nd Point
            new ObservablePoint(5, 3),   // ------
            new ObservablePoint(7, 6),
            new ObservablePoint(10, 8)
        },
        PointGeometrySize = 25,
        DataLabels = true,
        LabelPoint = point => $"Total: {point.Y}"
    },
    new LineSeries
    {
        Title = "Number Of Customers",
        Values = new ChartValues<ObservablePoint>
        {
            new ObservablePoint(0, 2),   // First Point of 2nd Line
            new ObservablePoint(2, 5),   // 2nd Point
            new ObservablePoint(3, 6),   // ------
            new ObservablePoint(6, 8),
            new ObservablePoint(10, 5)
        },
        PointGeometrySize = 15,
        DataLabels = true,
        LabelPoint = point => $"Customers: {point.Y}"
    },
    new LineSeries
    {
        Title = "Number Of Rental Bookings",
        Values = new ChartValues<ObservablePoint>
        {
            new ObservablePoint(0, 4),   // First Point of 3rd Line
            new ObservablePoint(5, 5),   // 2nd Point
            new ObservablePoint(7, 7),   // ------
            new ObservablePoint(9, 10),
            new ObservablePoint(10, 9)
        },
        PointGeometrySize = 15,
        DataLabels = true,
        LabelPoint = point => $"Rentals: {point.Y}"
    }
};
        }

        private string _DisplayTotalTransactionsWithFormat(double TotalTransactions)
        {
            string Result = "";
            if(TotalTransactions >= 1000)
                Result = (TotalTransactions / 1000.000).ToString()+" k";
            
            return Result;

        }

        
    void _LoadInfo()
        {
            lblNumberOfVehicles.Text    = clsVehicleBL.NumberOfVehicles().ToString();
            lblNUmberOfCustomers.Text   = clsCustomerBL.GetNumberOfCustomers().ToString();
            lblTotalRentalBookings.Text = clsDashboard.GetTotalRentalBookings().ToString();
            lblTotalTransactions.Text = _DisplayTotalTransactionsWithFormat(clsDashboard.GetTotalTransactionsAmount());
        }
        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            _LoadInfo();



        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _LoadInfo();
        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
