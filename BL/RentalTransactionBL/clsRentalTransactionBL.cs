using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalTransactionDL;

namespace RentalTransactionBL
{
    public class clsRentalTransactionBL
    {
        public enum enMode { eAddNew = 0, eUpdate = 1 }
        public enMode mode = enMode.eAddNew;


        public int TransactionID { get; set; }
        public int BookingID { get; set; }
        public int? ReturnID { get; set; }
        public string PaymentDetails { get; set; }
        public decimal PaidInitialTotalDueAmount { get; set; }
        public decimal? ActualTotalDueAmount { get; set; }
        public decimal? TotalRemaining { get; set; }
        public decimal? TotalRefundedAmount { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime? UpdatedTransactionDate { get; set; }



        public clsRentalTransactionBL()
        {
            TransactionID = -1;
            BookingID = -1;
            ReturnID = -1;
            PaymentDetails = "";
            PaidInitialTotalDueAmount = -1;
            ActualTotalDueAmount = -1;
            TotalRemaining = -1;
            TotalRefundedAmount = -1;
            TransactionDate = DateTime.Now;
            UpdatedTransactionDate = DateTime.Now;

            mode = enMode.eAddNew;
        }

        private clsRentalTransactionBL(int TransactionID, int BookingID, int ReturnID, string PaymentDetails, decimal PaidInitialTotalDueAmount, decimal ActualTotalDueAmount, decimal TotalRemaining, decimal TotalRefundedAmount, DateTime TransactionDate, DateTime UpdatedTransactionDate)
        {

            this.TransactionID = TransactionID;
            this.BookingID = BookingID;
            this.ReturnID = ReturnID;
            this.PaymentDetails = PaymentDetails;
            this.PaidInitialTotalDueAmount = PaidInitialTotalDueAmount;
            this.ActualTotalDueAmount = ActualTotalDueAmount;
            this.TotalRemaining = TotalRemaining;
            this.TotalRefundedAmount = TotalRefundedAmount;
            this.TransactionDate = TransactionDate;
            this.UpdatedTransactionDate = UpdatedTransactionDate;

            mode = enMode.eUpdate;

        }



        bool _AddNewRow()
        {

            this.TransactionID = clsRentalTransactionDL.AddNewRow(this.BookingID, this.ReturnID, this.PaymentDetails, this.PaidInitialTotalDueAmount, this.ActualTotalDueAmount, this.TotalRemaining, this.TotalRefundedAmount, this.TransactionDate, this.UpdatedTransactionDate);

            return this.TransactionID != -1;

        }

        bool _UpdateRow()
        {

            return clsRentalTransactionDL.UpdateRow(this.TransactionID, this.BookingID, this.ReturnID, this.PaymentDetails, this.PaidInitialTotalDueAmount, this.ActualTotalDueAmount, this.TotalRemaining, this.TotalRefundedAmount, this.TransactionDate, this.UpdatedTransactionDate);


        }

        public static clsRentalTransactionBL FindByTransactionID(int TransactionID)
        {

            int BookingID = -1;
            int ReturnID = -1;
            string PaymentDetails = "";
            decimal PaidInitialTotalDueAmount = -1;
            decimal ActualTotalDueAmount = -1;
            decimal TotalRemaining = -1;
            decimal TotalRefundedAmount = -1;
            DateTime TransactionDate = DateTime.Now;
            DateTime UpdatedTransactionDate = DateTime.Now;


            if (clsRentalTransactionDL.GetRowInfoByTransactionID(TransactionID, ref BookingID, ref ReturnID, ref PaymentDetails, ref PaidInitialTotalDueAmount, ref ActualTotalDueAmount, ref TotalRemaining, ref TotalRefundedAmount, ref TransactionDate, ref UpdatedTransactionDate))
            {

                return new clsRentalTransactionBL(TransactionID, BookingID, ReturnID, PaymentDetails, PaidInitialTotalDueAmount, ActualTotalDueAmount, TotalRemaining, TotalRefundedAmount, TransactionDate, UpdatedTransactionDate);
            }
            else
                return null;

        }
        public static clsRentalTransactionBL FindByBookingID(int BookingID)
        {
            int ReturnID = -1;
            int TransactionID = -1;
            string PaymentDetails = "";
            decimal PaidInitialTotalDueAmount = -1;
            decimal ActualTotalDueAmount = -1;
            decimal TotalRemaining = -1;
            decimal TotalRefundedAmount = -1;
            DateTime TransactionDate = DateTime.Now;
            DateTime UpdatedTransactionDate = DateTime.Now;

            if (clsRentalTransactionDL.GetRowInfoByBookingID(BookingID, ref TransactionID, ref ReturnID, ref PaymentDetails, ref PaidInitialTotalDueAmount, ref ActualTotalDueAmount, ref TotalRemaining, ref TotalRefundedAmount, ref TransactionDate, ref UpdatedTransactionDate))
                return new clsRentalTransactionBL(TransactionID, BookingID, ReturnID, PaymentDetails, PaidInitialTotalDueAmount, ActualTotalDueAmount, TotalRemaining, TotalRefundedAmount, TransactionDate, UpdatedTransactionDate);
            else
                return null;


        }





        public static DataTable GetAllRows()
        {
            DataTable DT = clsRentalTransactionDL.GetAllRows();
            return DT;
        }

        public static int GetNumberOfRows()
        {
            return clsRentalTransactionDL.GetNumberOfRows();
        }

        public static bool DeleteRow(int TransactionID)
        {
            return (clsRentalTransactionDL.DeleteRow(TransactionID));
        }

        public static bool DoesRowExist(int TransactionID)
        {
            return (clsRentalTransactionDL.DoesRowExist(TransactionID));
        }

        public bool Save()
        {
            switch (mode)
            {
                case enMode.eAddNew:
                    {
                        if (_AddNewRow())
                        {
                            mode = enMode.eUpdate;
                            return true;
                        }
                        else
                            return false;

                    }
                case enMode.eUpdate:
                            
                    return _UpdateRow();

            }

            return false;
        }


        public static DataTable GetRentalTransactionByFilter(string TransactionInfo, string Filter)
        {
            return clsRentalTransactionDL.GetRentalTransactionByFilter(TransactionInfo, Filter);
        }

        public static DataTable SortingRentalBooks(string Filter)
        {
            return clsRentalTransactionDL.SortingRentalBooks(Filter);
        }

        public static decimal GetTotalTransactionsAmount()
        {
            return clsRentalTransactionDL.GetTotalTransactionsAmount();
        }

    }
}
