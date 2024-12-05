using System;
using System.Data;
using System.Data.SqlClient;

namespace VehicleReturnsDataAccessLayer
{
    static class clsDataAccessSettings
    {
        public static string ConnectionString = "Server=TAREQ\\DB1;Database=P4 - Car Rental;Integrated Security=true;";
    }

    public static class clsVehicleReturnsDataAccess
    {
        public static bool GetVehicleReturnInfoByID(int ReturenID, ref DateTime ActualReturnDate, ref int ActualRentalDays, ref int Mileage, ref int ConsumedMilaeage, ref string FinalCheckNotes, ref int AdditionalCharges, ref int ActualTotalDueAmount)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM VehicleReturns WHERE ReturenID = @ReturenID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ReturenID", ReturenID);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    ReturenID = (int)reader["ReturenID"];
                    ActualReturnDate = (DateTime)reader["ActualReturnDate"];
                    ActualRentalDays = (int)reader["ActualRentalDays"];
                    Mileage = (int)reader["Mileage"];
                    ConsumedMilaeage = (int)reader["ConsumedMilaeage"];
                    FinalCheckNotes = (string)reader["FinalCheckNotes"];
                    AdditionalCharges = (int)reader["AdditionalCharges"];
                    ActualTotalDueAmount = (int)reader["ActualTotalDueAmount"];

                }
                else
                {
                    isFound = false;
                }

                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return isFound;

        }
        public static int AddNewVehicleReturn(DateTime ActualReturnDate, int ActualRentalDays, int Mileage, int ConsumedMilaeage, string FinalCheckNotes, int AdditionalCharges, decimal ActualTotalDueAmount)
        {

            int ID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO VehicleReturns VALUES (@ActualReturnDate, @ActualRentalDays, @Mileage, @ConsumedMilaeage, @FinalCheckNotes, @AdditionalCharges, @ActualTotalDueAmount)
                            SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@ActualReturnDate", ActualReturnDate);

            command.Parameters.AddWithValue("@ActualRentalDays", ActualRentalDays);

            command.Parameters.AddWithValue("@Mileage", Mileage);

            command.Parameters.AddWithValue("@ConsumedMilaeage", ConsumedMilaeage);

            command.Parameters.AddWithValue("@FinalCheckNotes", FinalCheckNotes);

            command.Parameters.AddWithValue("@AdditionalCharges", AdditionalCharges);

            command.Parameters.AddWithValue("@ActualTotalDueAmount", ActualTotalDueAmount);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine(Error:  + ex.Message);

            }

            finally
            {
                connection.Close();
            }


            return ID;

        }
        public static bool UpdateVehicleReturn(int ReturenID, DateTime ActualReturnDate, int ActualRentalDays, int Mileage, int ConsumedMilaeage, string FinalCheckNotes, int AdditionalCharges, decimal ActualTotalDueAmount)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE VehicleReturns
	                        SET	ActualReturnDate = @ActualReturnDate,
	                        ActualRentalDays = @ActualRentalDays,
	                        Mileage = @Mileage,
	                        ConsumedMilaeage = @ConsumedMilaeage,
	                        FinalCheckNotes = @FinalCheckNotes,
	                        AdditionalCharges = @AdditionalCharges,
	                        ActualTotalDueAmount = @ActualTotalDueAmount	WHERE ReturenID = @ReturenID";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@ReturenID", ReturenID);

            command.Parameters.AddWithValue("@ActualReturnDate", ActualReturnDate);

            command.Parameters.AddWithValue("@ActualRentalDays", ActualRentalDays);

            command.Parameters.AddWithValue("@Mileage", Mileage);

            command.Parameters.AddWithValue("@ConsumedMilaeage", ConsumedMilaeage);

            command.Parameters.AddWithValue("@FinalCheckNotes", FinalCheckNotes);

            command.Parameters.AddWithValue("@AdditionalCharges", AdditionalCharges);

            command.Parameters.AddWithValue("@ActualTotalDueAmount", ActualTotalDueAmount);


            try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return (rowsAffected > 0);

        }
        public static bool DeleteVehicleReturn(int? ReturenID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "DELETE VehicleReturns WHERE ReturenID = @ReturenID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ReturenID", ReturenID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }


            return (rowsAffected > 0);

        }

        public static bool IsVehicleReturnExist(int ReturenID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT Found=1 FROM VehicleReturns WHERE ReturenID= @ReturenID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ReturenID", ReturenID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                isFound = reader.HasRows;
                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }


            return isFound;

        }

        public static DataTable GetAllVehicleReturns()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM VehicleReturns";
            SqlCommand command = new SqlCommand(query, connection);

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
        static string GetQueryFromFilter(string TransactionInfo, string Filter)
        {

            string query = "";
            switch (Filter)
            {

                case "None":
                    {
                        query = @"   SELECT * FROM VehicleReturns";
                        return query;
                    }

                case "Returen ID":
                    {
                        query = @"   SELECT * from VehicleReturns WHERE VehicleReturns.ReturenID LIKE @TransactionInfo";
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
                        query = @"    SELECT * FROM VehicleReturns order by VehicleReturns.ActualReturnDate desc";
                        return query;
                    }

                case "Oldest":
                    {
                        query = @"    SELECT * FROM VehicleReturns order by VehicleReturns.ActualReturnDate asc";
                        return query;
                    }

                case "Highest Consumed Milaeage":
                    {
                        query = @"   SELECT * FROM VehicleReturns  order by VehicleReturns.ConsumedMileage desc";
                        return query;
                    }

                case "Lowest Consumed Milaeage":
                    {
                        query = @"   SELECT * FROM VehicleReturns  order by VehicleReturns.ConsumedMileage asc";
                        return query;
                    }

                case "Highest Additional Charges":
                    {
                        query = @"  SELECT * FROM VehicleReturns  order by VehicleReturns.AdditionalCharges desc";
                        return query;
                    }

                case "Lowest Additional Charges":
                    {
                        query = @"  SELECT * FROM VehicleReturns  order by VehicleReturns.AdditionalCharges asc";
                        return query;
                    }


                case "Highest Actual Total Due Amount":
                    {
                        query = @"  SELECT * FROM VehicleReturns  order by VehicleReturns.ActualTotalDueAmount desc";
                        return query;
                    }

                case "Lowest Actual Total Due Amount":
                    {
                        query = @"  SELECT * FROM VehicleReturns  order by VehicleReturns.ActualTotalDueAmount asc";
                        return query;
                    }


            }
            return query;
        }

        public static DataTable GetVehicleReturnRecordByFilter(string TransactionInfo, string Filter)
        {


            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

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

        public static DataTable SortingVehicleReturns(string Filter)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

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

    }

}