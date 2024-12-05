using System;
using System.Data;
using System.Data.SqlClient;

namespace DashboardDataAccessLayer
{
    static class clsDataAccessSettings
    {
        public static string ConnectionString = "Server=TAREQ\\DB1;Database=P4 - Car Rental;Integrated Security=true;";
    }

    public static class clsDashboardDataAccess
    {
        public static bool GetDashboardInfoByID(int ID, ref float TotalTransactionsAmount, ref int TotalRentalBookings)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Dashboard WHERE ID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    TotalTransactionsAmount = reader["TotalTransactionsAmount"] != DBNull.Value ? (float)reader["TotalTransactionsAmount"] : TotalTransactionsAmount = default;
                    ID = (int)reader["ID"];
                    TotalRentalBookings = reader["TotalRentalBookings"] != DBNull.Value ? (int)reader["TotalRentalBookings"] : TotalRentalBookings = default;

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
        public static int AddNewDashboard(float TotalTransactionsAmount, int TotalRentalBookings)
        {

            int ID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Dashboard VALUES (@TotalTransactionsAmount, @TotalRentalBookings)
            SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);


            if (string.IsNullOrEmpty(TotalTransactionsAmount.ToString()))
                command.Parameters.AddWithValue("@TotalTransactionsAmount", DBNull.Value);
            else
                command.Parameters.AddWithValue("@TotalTransactionsAmount", TotalTransactionsAmount);
            if (string.IsNullOrEmpty(TotalRentalBookings.ToString()))
                command.Parameters.AddWithValue("@TotalRentalBookings", DBNull.Value);
            else
                command.Parameters.AddWithValue("@TotalRentalBookings", TotalRentalBookings);

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
        public static bool UpdateDashboard(float TotalTransactionsAmount)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"update Dashboard set TotalTransactionsAmount =  TotalTransactionsAmount + @TotalTransactionsAmount";

            SqlCommand command = new SqlCommand(query, connection);


            if (string.IsNullOrEmpty(TotalTransactionsAmount.ToString()))
                command.Parameters.AddWithValue("@TotalTransactionsAmount", DBNull.Value);
            else
                command.Parameters.AddWithValue("@TotalTransactionsAmount", TotalTransactionsAmount);

            try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return (rowsAffected > 0);

        }
        public static bool DeleteDashboard(int ID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "DELETE Dashboard WHERE ID = @ID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }


            return (rowsAffected > 0);

        }

        public static bool IsDashboardExist(int ID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT Found=1 FROM Dashboard WHERE ID= @ID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

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

        public static DataTable GetAllDashboard()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Dashboard";
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

        public static int GetTotalRentalBookings()
        {
            int TotalRentalBookings = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT TotalRentalBookings FROM Dashboard";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                   
                    TotalRentalBookings =  (int)reader["TotalRentalBookings"];

                }
                else
                {
                }

                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return TotalRentalBookings;

        }
        public static double GetTotalTransactionsAmount()
        {
            double TotalTransactionsAmount = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT TotalTransactionsAmount FROM Dashboard";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    TotalTransactionsAmount = (double)reader["TotalTransactionsAmount"];

                }
                else
                {
                }

                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return TotalTransactionsAmount;

        }


        public static void IncreaseTotalRentalBookings()
        {

                int rowsAffected = 0;

                SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

                string query = @"update Dashboard set TotalRentalBookings = TotalRentalBookings + 1";

                SqlCommand command = new SqlCommand(query, connection);


                try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
                catch (Exception ex) { }
                finally { connection.Close(); }


        }

        public static void IncreaseTotalTransactionAmount(float TotalTransactionsAmount)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"update Dashboard set TotalTransactionsAmount =  TotalTransactionsAmount + @TotalTransactionsAmount";

            SqlCommand command = new SqlCommand(query, connection);


            if (string.IsNullOrEmpty(TotalTransactionsAmount.ToString()))
                command.Parameters.AddWithValue("@TotalTransactionsAmount", DBNull.Value);
            else
                command.Parameters.AddWithValue("@TotalTransactionsAmount", TotalTransactionsAmount);

            try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
            catch (Exception ex) { }
            finally { connection.Close(); }

        }


    }

}