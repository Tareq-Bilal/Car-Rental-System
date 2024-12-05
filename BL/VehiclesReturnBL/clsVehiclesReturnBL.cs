using System;
using System.Data;
using VehicleReturnsDataAccessLayer;
namespace VehicleReturnsBusinessLayer
{

    public class clsVehicleReturn
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int ReturenID { get; set; }
        public DateTime ActualReturnDate { get; set; }
        public int ActualRentalDays { get; set; }
        public int Mileage { get; set; }
        public int ConsumedMilaeage { get; set; }
        public string FinalCheckNotes { get; set; }
        public int AdditionalCharges { get; set; }
        public decimal ActualTotalDueAmount { get; set; }


        public clsVehicleReturn()
        {
            this.ReturenID = default;
            this.ActualReturnDate = default;
            this.ActualRentalDays = default;
            this.Mileage = default;
            this.ConsumedMilaeage = default;
            this.FinalCheckNotes = default;
            this.AdditionalCharges = default;
            this.ActualTotalDueAmount = default;


            Mode = enMode.AddNew;

        }

        private clsVehicleReturn(int ReturenID, DateTime ActualReturnDate, int ActualRentalDays, int Mileage, int ConsumedMilaeage, string FinalCheckNotes, int AdditionalCharges, decimal ActualTotalDueAmount)
        {
            this.ReturenID = ReturenID;
            this.ActualReturnDate = ActualReturnDate;
            this.ActualRentalDays = ActualRentalDays;
            this.Mileage = Mileage;
            this.ConsumedMilaeage = ConsumedMilaeage;
            this.FinalCheckNotes = FinalCheckNotes;
            this.AdditionalCharges = AdditionalCharges;
            this.ActualTotalDueAmount = ActualTotalDueAmount;


            Mode = enMode.Update;

        }

        private bool _AddNewVehicleReturn()
        {
            //call DataAccess Layer 

            this.ReturenID = clsVehicleReturnsDataAccess.AddNewVehicleReturn(this.ActualReturnDate, this.ActualRentalDays, this.Mileage, this.ConsumedMilaeage, this.FinalCheckNotes, this.AdditionalCharges, this.ActualTotalDueAmount);

            return (this.ReturenID != -1);

        }

        private bool _UpdateVehicleReturn()
        {
            //call DataAccess Layer 

            return clsVehicleReturnsDataAccess.UpdateVehicleReturn(this.ReturenID, this.ActualReturnDate, this.ActualRentalDays, this.Mileage, this.ConsumedMilaeage, this.FinalCheckNotes, this.AdditionalCharges, this.ActualTotalDueAmount);

        }

        public static clsVehicleReturn Find(int ReturenID)
        {
            DateTime ActualReturnDate = default;
            int ActualRentalDays = default;
            int Mileage = default;
            int ConsumedMilaeage = default;
            string FinalCheckNotes = default;
            int AdditionalCharges = default;
            int ActualTotalDueAmount = default;


            if (clsVehicleReturnsDataAccess.GetVehicleReturnInfoByID(ReturenID, ref ActualReturnDate, ref ActualRentalDays, ref Mileage, ref ConsumedMilaeage, ref FinalCheckNotes, ref AdditionalCharges, ref ActualTotalDueAmount))
                return new clsVehicleReturn(ReturenID, ActualReturnDate, ActualRentalDays, Mileage, ConsumedMilaeage, FinalCheckNotes, AdditionalCharges, ActualTotalDueAmount);
            else
                return null;

        }

        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewVehicleReturn())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateVehicleReturn();

            }




            return false;
        }

        public static DataTable GetAllVehicleReturns() { return clsVehicleReturnsDataAccess.GetAllVehicleReturns(); }

        public static bool DeleteVehicleReturn(int? ReturenID) { return clsVehicleReturnsDataAccess.DeleteVehicleReturn(ReturenID); }

        public static bool isVehicleReturnExist(int ReturenID) { return clsVehicleReturnsDataAccess.IsVehicleReturnExist(ReturenID); }

        public static DataTable GetVehicleReturnRecordByFilter(string TransactionInfo, string Filter)
        {
            return clsVehicleReturnsDataAccess.GetVehicleReturnRecordByFilter(TransactionInfo, Filter);
        }

        public static DataTable SortingVehicleReturns(string Filter)
        {
            return clsVehicleReturnsDataAccess.SortingVehicleReturns(Filter);
        }



    }

}