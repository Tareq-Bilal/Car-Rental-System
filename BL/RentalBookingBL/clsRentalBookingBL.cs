using System;
using System.Data;
using RentalBookingDataAccessLayer;
namespace RentalBookingBusinessLayer
{

    public class clsRentalBooking
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int BookingID { get; set; }
        public int CustomerID { get; set; }
        public int VehicleID { get; set; }
        public DateTime RentalStartDate { get; set; }
        public DateTime RentalEndDate { get; set; }
        public string PickupLocation { get; set; }
        public string DropoffLocation { get; set; }
        public int InitialRentalDays { get; set; }
        public decimal RentalPricePerDay { get; set; }
        public decimal OldRentalPricePerDay { get; set; }
        public decimal InitialTotalDueAmount { get; set; }
        public string InitialCheckNotes { get; set; }


        public clsRentalBooking()
        {
            this.BookingID = default;
            this.CustomerID = default;
            this.VehicleID = default;
            this.RentalStartDate = default;
            this.RentalEndDate = default;
            this.PickupLocation = default;
            this.DropoffLocation = default;
            this.InitialRentalDays = default;
            this.RentalPricePerDay = default;
            this.InitialTotalDueAmount = default;
            this.InitialCheckNotes = default;
            this.OldRentalPricePerDay = default;

            Mode = enMode.AddNew;

        }

        private clsRentalBooking(int BookingID, int CustomerID, int VehicleID, DateTime RentalStartDate, DateTime RentalEndDate, string PickupLocation, string DropoffLocation, int InitialRentalDays, decimal RentalPricePerDay, decimal InitialTotalDueAmoun, string InitialCheckNotes)
        {
            this.BookingID = BookingID;
            this.CustomerID = CustomerID;
            this.VehicleID = VehicleID;
            this.RentalStartDate = RentalStartDate;
            this.RentalEndDate = RentalEndDate;
            this.PickupLocation = PickupLocation;
            this.DropoffLocation = DropoffLocation;
            this.InitialRentalDays = InitialRentalDays;
            this.RentalPricePerDay = RentalPricePerDay;
            this.InitialTotalDueAmount = InitialTotalDueAmoun;
            this.InitialCheckNotes = InitialCheckNotes;
            this.OldRentalPricePerDay = RentalPricePerDay;

            Mode = enMode.Update;

        }

        private bool _AddNewRentalBooking()
        {
            //call DataAccess Layer 

            this.BookingID = clsRentalBookingDataAccess.AddNewRentalBooking(this.CustomerID, this.VehicleID, this.RentalStartDate, this.RentalEndDate, this.PickupLocation, this.DropoffLocation, this.InitialRentalDays, this.RentalPricePerDay, this.InitialTotalDueAmount, this.InitialCheckNotes);

            return (this.BookingID != -1);

        }

        private bool _UpdateRentalBooking()
        {
            //call DataAccess Layer 

            return clsRentalBookingDataAccess.UpdateRentalBooking(this.BookingID, this.CustomerID, this.VehicleID, this.RentalStartDate, this.RentalEndDate, this.PickupLocation, this.DropoffLocation, this.InitialRentalDays, this.RentalPricePerDay, this.InitialTotalDueAmount, this.InitialCheckNotes);

        }

        public static clsRentalBooking Find(int BookingID)
        {
            int CustomerID = default;
            int VehicleID = default;
            DateTime RentalStartDate = default;
            DateTime RentalEndDate = default;
            string PickupLocation = default;
            string DropoffLocation = default;
            int InitialRentalDays = default;
            decimal RentalPricePerDay = default;
            decimal InitialTotalDueAmount = default;
            string InitialCheckNotes = default;


            if (clsRentalBookingDataAccess.GetRentalBookingInfoByID(BookingID, ref CustomerID, ref VehicleID, ref RentalStartDate, ref RentalEndDate, ref PickupLocation, ref DropoffLocation, ref InitialRentalDays, ref RentalPricePerDay, ref InitialTotalDueAmount, ref InitialCheckNotes))
                return new clsRentalBooking(BookingID, CustomerID, VehicleID, RentalStartDate, RentalEndDate, PickupLocation, DropoffLocation, InitialRentalDays, RentalPricePerDay, InitialTotalDueAmount, InitialCheckNotes);
            else
                return null;

        }

        public static clsRentalBooking FindByVehicleID(int VehicleID)
        {
            int CustomerID = default;
            int BookingID = default;
            DateTime RentalStartDate = default;
            DateTime RentalEndDate = default;
            string PickupLocation = default;
            string DropoffLocation = default;
            int InitialRentalDays = default;
            decimal RentalPricePerDay = default;
            decimal InitialTotalDueAmount = default;
            string InitialCheckNotes = default;


            if (clsRentalBookingDataAccess.GetRentalBookingInfoByVehicleID(VehicleID, ref CustomerID, ref BookingID, ref RentalStartDate, ref RentalEndDate, ref PickupLocation, ref DropoffLocation, ref InitialRentalDays, ref RentalPricePerDay, ref InitialTotalDueAmount, ref InitialCheckNotes))
                return new clsRentalBooking(BookingID, CustomerID, VehicleID, RentalStartDate, RentalEndDate, PickupLocation, DropoffLocation, InitialRentalDays, RentalPricePerDay, InitialTotalDueAmount, InitialCheckNotes);
            else
                return null;

        }

        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewRentalBooking())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateRentalBooking();

            }




            return false;
        }

        public static DataTable GetAllRentalBooking() { return clsRentalBookingDataAccess.GetAllRentalBooking(); }

        public static bool DeleteRentalBooking(int BookingID) { return clsRentalBookingDataAccess.DeleteRentalBooking(BookingID); }

        public static bool isRentalBookingExist(int BookingID) { return clsRentalBookingDataAccess.IsRentalBookingExist(BookingID); }

        public static DataTable GetVehcileBookByFilter(string BookInfo, string Filter)
        {
            return clsRentalBookingDataAccess.GetVehcileBookByFilter(BookInfo, Filter);
        }

        public static DataTable SortingRentalBooks(string Filter)
        {
            return clsRentalBookingDataAccess.SortingRentalBooks(Filter);
        }

        public static DateTime GetBookingStartDateFromVehicleID(int VehicleID)
        {
            return clsRentalBookingDataAccess.GetBookingStartDateFromVehicleID((int)VehicleID);
        }
        public static DateTime GetBookingEndDateFromVehicleID(int VehicleID)
        {
            return clsRentalBookingDataAccess.GetBookingEndDateFromVehicleID((int)VehicleID);
        }

        public static DateTime GetRentalStartDateFormVehicleID(int VehicleID)
        {
            return clsRentalBookingDataAccess.GetRentalStartDateFormVehicleID((int)VehicleID);
        }

        public static int GetVehicleIDByRentalBookingID(int BookingID)
        {

            return clsRentalBookingDataAccess.GetVehicleIDByRentalBookingID((int)BookingID);
        }
        public static bool IsCustomerHasRentalBooking(int CustomerID)
        {
            return clsRentalBookingDataAccess.IsCustomerHasRentalBooking((int)CustomerID);
        }

        public static int GetNumberOfRentalBookings()
        {
            return clsRentalBookingDataAccess.GetNumberOfRentalBookings();
        }

    }

}