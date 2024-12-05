using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalTransactionDL
{
    public class clsRentalTransactionDL
    {
        public static string connectionString = "Server=TAREQ\\DB1;Database=P4 - Car Rental;Integrated Security=true;";

        public static bool GetRowInfoByTransactionID(int TransactionID, ref int BookingID, ref int ReturnID, ref string PaymentDetails, ref decimal PaidInitialTotalDueAmount, ref decimal ActualTotalDueAmount, ref decimal TotalRemaining, ref decimal TotalRefundedAmount, ref DateTime TransactionDate, ref DateTime UpdatedTransactionDate)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(connectionString);

            string Query = "SELECT * FROM RentalTransaction WHERE TransactionID = @TransactionID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@TransactionID", TransactionID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    BookingID = (int)Reader["BookingID"];

                    if (Reader["ReturnID"] != DBNull.Value)
                    {
                        ReturnID = (int)Reader["ReturnID"];
                    }


                    PaymentDetails = (string)Reader["PaymentDetails"];
                    PaidInitialTotalDueAmount = (decimal)Reader["PaidInitialTotalDueAmount"];

                    if (Reader["ActualTotalDueAmount"] != DBNull.Value)
                    {
                        ActualTotalDueAmount = (decimal)Reader["ActualTotalDueAmount"];
                    }

                    if (Reader["TotalRemaining"] != DBNull.Value)
                    {
                        TotalRemaining = (decimal)Reader["TotalRemaining"];
                    }

                    if (Reader["TotalRefundedAmount"] != DBNull.Value)
                    {
                        TotalRefundedAmount = (decimal)Reader["TotalRefundedAmount"];
                    }
                    TransactionDate = (DateTime)Reader["TransactionDate"];
                    UpdatedTransactionDate = (DateTime)Reader["UpdatedTransactionDate"];


                }

                Reader.Close();

            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return IsFound;


        }

        public static bool GetRowInfoByBookingID(int BookingID, ref int TransactionID, ref int ReturnID, ref string PaymentDetails, ref decimal PaidInitialTotalDueAmount, ref decimal ActualTotalDueAmount, ref decimal TotalRemaining, ref decimal TotalRefundedAmount, ref DateTime TransactionDate, ref DateTime UpdatedTransactionDate)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(connectionString);

            string Query = "SELECT * FROM RentalTransaction WHERE BookingID = @BookingID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@BookingID", BookingID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    BookingID = (int)Reader["BookingID"];
                    TransactionID = (int)Reader["TransactionID"];
                    if (Reader["ReturnID"] != DBNull.Value)
                    {
                        ReturnID = (int)Reader["ReturnID"];
                    }


                    PaymentDetails = (string)Reader["PaymentDetails"];
                    PaidInitialTotalDueAmount = (decimal)Reader["PaidInitialTotalDueAmount"];

                    if (Reader["ActualTotalDueAmount"] != DBNull.Value)
                    {
                        ActualTotalDueAmount = (decimal)Reader["ActualTotalDueAmount"];
                    }

                    if (Reader["TotalRemaining"] != DBNull.Value)
                    {
                        TotalRemaining = (decimal)Reader["TotalRemaining"];
                    }

                    if (Reader["TotalRefundedAmount"] != DBNull.Value)
                    {
                        TotalRefundedAmount = (decimal)Reader["TotalRefundedAmount"];
                    }
                    TransactionDate = (DateTime)Reader["TransactionDate"];
                    UpdatedTransactionDate = (DateTime)Reader["UpdatedTransactionDate"];


                }

                Reader.Close();

            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return IsFound;


        }


        public static int AddNewRow(int BookingID, int? ReturnID, string PaymentDetails, decimal PaidInitialTotalDueAmount, decimal? ActualTotalDueAmount, decimal? TotalRemaining, decimal? TotalRefundedAmount, DateTime TransactionDate, DateTime? UpdatedTransactionDate)
        {

            int TransactionID = -1;

            SqlConnection connection = new SqlConnection(connectionString);

            string Query = @"INSERT INTO RentalTransaction 
                               (BookingID, ReturnID, PaymentDetails, PaidInitialTotalDueAmount, ActualTotalDueAmount, TotalRemaining, TotalRefundedAmount, TransactionDate, UpdatedTransactionDate)     
                             VALUES
                               (@BookingID, @ReturnID, @PaymentDetails, @PaidInitialTotalDueAmount, @ActualTotalDueAmount, @TotalRemaining, @TotalRefundedAmount, @TransactionDate, @UpdatedTransactionDate)
                              SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@BookingID", BookingID);

            if (ReturnID != null && ReturnID.ToString() != string.Empty)
                Command.Parameters.AddWithValue("@ReturnID", ReturnID);
            else
                Command.Parameters.AddWithValue("@ReturnID", DBNull.Value);
            Command.Parameters.AddWithValue("@PaymentDetails", PaymentDetails);
            Command.Parameters.AddWithValue("@PaidInitialTotalDueAmount", PaidInitialTotalDueAmount);

            if (ActualTotalDueAmount != null && ActualTotalDueAmount.ToString() != string.Empty)
                Command.Parameters.AddWithValue("@ActualTotalDueAmount", ActualTotalDueAmount);
            else
                Command.Parameters.AddWithValue("@ActualTotalDueAmount", DBNull.Value);

            if (TotalRemaining != null && TotalRemaining.ToString() != string.Empty)
                Command.Parameters.AddWithValue("@TotalRemaining", TotalRemaining);
            else
                Command.Parameters.AddWithValue("@TotalRemaining", DBNull.Value);

            if (TotalRefundedAmount != null && TotalRefundedAmount.ToString() != string.Empty)
                Command.Parameters.AddWithValue("@TotalRefundedAmount", TotalRefundedAmount);
            else
                Command.Parameters.AddWithValue("@TotalRefundedAmount", DBNull.Value);
            Command.Parameters.AddWithValue("@TransactionDate", TransactionDate);

            if (UpdatedTransactionDate != null && UpdatedTransactionDate.ToString() != string.Empty)
                Command.Parameters.AddWithValue("@UpdatedTransactionDate", UpdatedTransactionDate);

            else
                Command.Parameters.AddWithValue("@UpdatedTransactionDate", DBNull.Value);



            try
            {
                connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    TransactionID = InsertedID;
                }

            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }


            return TransactionID;

        }
        public static bool UpdateRow(int TransactionID, int BookingID, int? ReturnID, string PaymentDetails, decimal PaidInitialTotalDueAmount, decimal? ActualTotalDueAmount, decimal? TotalRemaining, decimal? TotalRefundedAmount, DateTime TransactionDate, DateTime? UpdatedTransactionDate)
        {

            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(connectionString);

            string Query = $@"UPDATE RentalTransaction SET 
		                      BookingID = @BookingID,
		                      ReturnID = @ReturnID,
		                      PaymentDetails = @PaymentDetails,
		                      PaidInitialTotalDueAmount = @PaidInitialTotalDueAmount,
		                      ActualTotalDueAmount = @ActualTotalDueAmount,
		                      TotalRemaining = @TotalRemaining,
		                      TotalRefundedAmount = @TotalRefundedAmount,
		                      TransactionDate = @TransactionDate,
		                      UpdatedTransactionDate = @UpdatedTransactionDate
		                       WHERE TransactionID = @TransactionID";


            SqlCommand Command = new SqlCommand(Query, connection);


            Command.Parameters.AddWithValue("@TransactionID", TransactionID);
            Command.Parameters.AddWithValue("@BookingID", BookingID);

            if (ReturnID != null && ReturnID.ToString() != string.Empty)
                Command.Parameters.AddWithValue("@ReturnID", ReturnID);
            else
                Command.Parameters.AddWithValue("@ReturnID", DBNull.Value);
            Command.Parameters.AddWithValue("@PaymentDetails", PaymentDetails);
            Command.Parameters.AddWithValue("@PaidInitialTotalDueAmount", PaidInitialTotalDueAmount);

            if (ActualTotalDueAmount != null && ActualTotalDueAmount.ToString() != string.Empty)
                Command.Parameters.AddWithValue("@ActualTotalDueAmount", ActualTotalDueAmount);
            else
                Command.Parameters.AddWithValue("@ActualTotalDueAmount", DBNull.Value);

            if (TotalRemaining != null && TotalRemaining.ToString() != string.Empty)
                Command.Parameters.AddWithValue("@TotalRemaining", TotalRemaining);
            else
                Command.Parameters.AddWithValue("@TotalRemaining", DBNull.Value);

            if (TotalRefundedAmount != null && TotalRefundedAmount.ToString() != string.Empty)
                Command.Parameters.AddWithValue("@TotalRefundedAmount", TotalRefundedAmount);
            else
                Command.Parameters.AddWithValue("@TotalRefundedAmount", DBNull.Value);
            Command.Parameters.AddWithValue("@TransactionDate", TransactionDate);
            Command.Parameters.AddWithValue("@UpdatedTransactionDate", UpdatedTransactionDate);


            try
            {
                connection.Open();
                RowsAffected = Command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (RowsAffected > 0);

        }

        public static DataTable GetAllRows()
        {

            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(connectionString);

            string Query = @"SELECT * FROM RentalTransaction";

            SqlCommand Command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                while (Reader.HasRows)
                {
                    DT.Load(Reader);
                }

                Reader.Close();


            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return DT;

        }

        public static int GetNumberOfRows()
        {
            int NumberOfRows = -1;

            SqlConnection connection = new SqlConnection(connectionString);

            string Query = "SELECT Count(*) FROM RentalTransaction WHERE TransactionID is not null";

            SqlCommand Command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int AcualNum))
                {
                    NumberOfRows = AcualNum;
                }


            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return NumberOfRows;
        }
        public static bool DeleteRow(int TransactionID)
        {

            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(connectionString);

            string Query = "DELETE RentalTransaction WHERE TransactionID = @TransactionID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@TransactionID", TransactionID);


            try
            {
                connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return (RowsAffected > 0);

        }

        public static bool DoesRowExist(int TransactionID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = "SELECT Found=1 FROM RentalTransaction WHERE TransactionID = @TransactionID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@TransactionID", TransactionID);


            try
            {
                connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null)
                {
                    IsFound = true;
                }

            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        static string GetQueryFromFilter(string TransactionInfo, string Filter)
        {
            /*
               None
               Transaction ID
               Book ID
               Return ID
               Paid Initial
             
             */
            string query = "";
            switch (Filter)
            {

                case "None":
                    {
                        query = @"   SELECT * FROM RentalTransaction";
                        return query;
                    }

                case "Book ID":
                    {
                        query = @"   SELECT * FROM RentalTransaction WHERE RentalTransaction.BookingID LIKE @TransactionInfo";
                        return query;
                    }

                case "Transaction ID":
                    {
                        query = @"   SELECT * FROM RentalTransaction WHERE RentalTransaction.TransactionID LIKE @TransactionInfo";
                        return query;
                    }

                case "Return ID":
                    {
                        query = @"SELECT * FROM RentalTransaction WHERE RentalTransaction.ReturnID LIKE @TransactionInfo";
                        return query;
                    }

                case "Paid Initial":
                    {
                        query = @"SELECT * FROM RentalTransaction WHERE RentalTransaction.PaidInitialTotalDueAmount LIKE @TransactionInfo";
                        return query;
                    }

            }
            return query;
        }

        static string GetQueryForSrotingFilter(string Filter)
        {

            string query = "";
            switch (Filter)
            {

                case "Newest":
                    {
                        query = @"   SELECT * FROM RentalTransaction  order by TransactionDate desc";
                        return query;
                    }

                case "Oldest":
                    {
                        query = @"   SELECT * FROM RentalTransaction  order by TransactionDate asc";
                        return query;
                    }

                case "Highest Actual Total Due Amount":
                    {
                        query = @"   SELECT * FROM RentalTransaction  order by ActualTotalDueAmount desc";
                        return query;
                    }

                case "Lowest Actual Total Due Amount":
                    {
                        query = @"   SELECT * FROM RentalTransaction  order by ActualTotalDueAmount asc";
                        return query;
                    }

                case "Highest Total Remaining":
                    {
                        query = @"  SELECT * FROM RentalTransaction  order by TotalRemaining desc";
                        return query;
                    }

                case "Lowest Total Remaining":
                    {
                        query = @"  SELECT * FROM RentalTransaction  order by TotalRemaining asc";
                        return query;
                    }

            }
            return query;
        }

        public static DataTable GetRentalTransactionByFilter(string TransactionInfo, string Filter)
        {


            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(connectionString);

            string query = GetQueryFromFilter(TransactionInfo, Filter);

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TransactionInfo", "%" + TransactionInfo + "%");

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) dt.Load(reader);
                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }


            return dt;
        }

        public static DataTable SortingRentalBooks(string Filter)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(connectionString);

            string query = GetQueryForSrotingFilter(Filter);

            SqlCommand command = new SqlCommand(query, connection);
            //command.Parameters.AddWithValue("@TransactionInfo", "%" + TransactionInfo + "%");

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) dt.Load(reader);
                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }


            return dt;

        }

        public static decimal GetTotalTransactionsAmount()
        {
            decimal TotalTransactionsAmount = 0;
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select SUM (RentalTransaction.ActualTotalDueAmount) TotalTransactionsAmount from RentalTransaction";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    TotalTransactionsAmount = (int)reader["TotalTransactionsAmount"];
                }
                else
                {
                    return 0;
                }

                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return TotalTransactionsAmount;


        }

    }
}
