using System;
using System.Data;
using DashboardDataAccessLayer;
namespace DashboardBusinessLayer
{

    public class clsDashboard
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public float TotalTransactionsAmount { get; set; }
        public int ID { get; set; }
        public int TotalRentalBookings { get; set; }


        public clsDashboard()
        {
            this.TotalTransactionsAmount = default;
            this.ID = default;
            this.TotalRentalBookings = default;


            Mode = enMode.AddNew;

        }

        private clsDashboard(float TotalTransactionsAmount , int TotalRentalBookings)
        {
            this.TotalTransactionsAmount = TotalTransactionsAmount;
            this.TotalRentalBookings = TotalRentalBookings;


            Mode = enMode.Update;

        }

        private bool _AddNewDashboard()
        {
            //call DataAccess Layer 

            this.ID = clsDashboardDataAccess.AddNewDashboard(this.TotalTransactionsAmount, this.TotalRentalBookings);

            return (this.ID != -1);

        }

        private bool _UpdateDashboard()
        {
            //call DataAccess Layer 

            return clsDashboardDataAccess.UpdateDashboard(this.TotalTransactionsAmount);

        }

        public static clsDashboard Find(int ID)
        {
            float TotalTransactionsAmount = default;
            int TotalRentalBookings = default;


            if (clsDashboardDataAccess.GetDashboardInfoByID(ID, ref TotalTransactionsAmount, ref TotalRentalBookings))
                return new clsDashboard(TotalTransactionsAmount , TotalRentalBookings);
            else
                return null;

        }

        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDashboard())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateDashboard();

            }




            return false;
        }

        public static DataTable GetAllDashboard() { return clsDashboardDataAccess.GetAllDashboard(); }

        public static bool DeleteDashboard(int ID) { return clsDashboardDataAccess.DeleteDashboard(ID); }

        public static bool isDashboardExist(int ID) { return clsDashboardDataAccess.IsDashboardExist(ID); }

        public static int GetTotalRentalBookings()
        {
            return clsDashboardDataAccess.GetTotalRentalBookings();
        }

        public static double GetTotalTransactionsAmount()
        {
            return clsDashboardDataAccess.GetTotalTransactionsAmount();

        }

        public static void IncreaseTotalRentalBookings()
        {
            clsDashboardDataAccess.IncreaseTotalRentalBookings();
        }

        public static void IncreaseTotalTransactionAmount(float TotalTransactionsAmount)
        {
            clsDashboardDataAccess.IncreaseTotalTransactionAmount(TotalTransactionsAmount);
        }
    }

}