using System;
using System.Data;
using System.Data.SqlClient;

namespace RentalBookingDataAccessLayer
{
    static class clsDataAccessSettings
    {
        public static string ConnectionString = "Server=TAREQ\\DB1;Database=P4 - Car Rental;Integrated Security=true;";
    }

    public static class clsRentalBookingDataAccess
    {
        public static bool GetRentalBookingInfoByID(int BookingID, ref int CustomerID, ref int VehicleID, ref DateTime RentalStartDate, ref DateTime RentalEndDate, ref string PickupLocation, ref string DropoffLocation, ref int InitialRentalDays, ref decimal RentalPricePerDay, ref decimal InitialTotalDueAmount, ref string InitialCheckNotes)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM RentalBooking WHERE BookingID = @BookingID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookingID", BookingID);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    BookingID = (int)reader["BookingID"];
                    CustomerID = (int)reader["CustomerID"];
                    VehicleID = (int)reader["VehicleID"];
                    RentalStartDate = (DateTime)reader["RentalStartDate"];
                    RentalEndDate = (DateTime)reader["RentalEndDate"];
                    PickupLocation = (string)reader["PickupLocation"];
                    DropoffLocation = (string)reader["DropoffLocation"];
                    InitialRentalDays = (int)reader["InitialRentalDays"];
                    RentalPricePerDay = (decimal)reader["RentalPricePerDay"];
                    InitialTotalDueAmount = (decimal)reader["InitialTotalDueAmount"];
                    InitialCheckNotes = reader["InitialCheckNotes"] != DBNull.Value ? (string)reader["InitialCheckNotes"] : InitialCheckNotes = default;

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

        public static bool IsCustomerHasRentalBooking(int CustomerID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT Found=1 FROM RentalBooking WHERE CustomerID = @CustomerID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CustomerID", CustomerID);

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
        public static bool GetRentalBookingInfoByVehicleID(int VehicleID, ref int CustomerID, ref int BookingID, ref DateTime RentalStartDate, ref DateTime RentalEndDate, ref string PickupLocation, ref string DropoffLocation, ref int InitialRentalDays, ref decimal RentalPricePerDay, ref decimal InitialTotalDueAmount, ref string InitialCheckNotes)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM RentalBooking WHERE VehicleID = @VehicleID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@VehicleID", VehicleID);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    BookingID = (int)reader["BookingID"];
                    CustomerID = (int)reader["CustomerID"];
                    VehicleID = (int)reader["VehicleID"];
                    RentalStartDate = (DateTime)reader["RentalStartDate"];
                    RentalEndDate = (DateTime)reader["RentalEndDate"];
                    PickupLocation = (string)reader["PickupLocation"];
                    DropoffLocation = (string)reader["DropoffLocation"];
                    InitialRentalDays = (int)reader["InitialRentalDays"];
                    RentalPricePerDay = (decimal)reader["RentalPricePerDay"];
                    InitialTotalDueAmount = (decimal)reader["InitialTotalDueAmount"];
                    InitialCheckNotes = reader["InitialCheckNotes"] != DBNull.Value ? (string)reader["InitialCheckNotes"] : InitialCheckNotes = default;

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

        public static int AddNewRentalBooking(int CustomerID, int VehicleID, DateTime RentalStartDate, DateTime RentalEndDate, string PickupLocation, string DropoffLocation, int InitialRentalDays, decimal RentalPricePerDay, decimal InitialTotalDueAmount, string InitialCheckNotes)
        {

            int ID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO RentalBooking VALUES (@CustomerID, @VehicleID, @RentalStartDate, @RentalEndDate, @PickupLocation, @DropoffLocation, @InitialRentalDays, @RentalPricePerDay, @InitialTotalDueAmount, @InitialCheckNotes)
        SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@CustomerID", CustomerID);

            command.Parameters.AddWithValue("@VehicleID", VehicleID);

            command.Parameters.AddWithValue("@RentalStartDate", RentalStartDate);

            command.Parameters.AddWithValue("@RentalEndDate", RentalEndDate);

            command.Parameters.AddWithValue("@PickupLocation", PickupLocation);

            command.Parameters.AddWithValue("@DropoffLocation", DropoffLocation);

            command.Parameters.AddWithValue("@InitialRentalDays", InitialRentalDays);

            command.Parameters.AddWithValue("@RentalPricePerDay", RentalPricePerDay);

            command.Parameters.AddWithValue("@InitialTotalDueAmount", InitialTotalDueAmount);

            if (string.IsNullOrEmpty(InitialCheckNotes))
                command.Parameters.AddWithValue("@InitialCheckNotes", DBNull.Value);
            else
                command.Parameters.AddWithValue("@InitialCheckNotes", InitialCheckNotes);

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
        public static bool UpdateRentalBooking(int BookingID, int CustomerID, int VehicleID, DateTime RentalStartDate, DateTime RentalEndDate, string PickupLocation, string DropoffLocation, int InitialRentalDays, decimal RentalPricePerDay, decimal InitialTotalDueAmount, string InitialCheckNotes)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE RentalBooking
	                        SET	CustomerID = @CustomerID,
	                        VehicleID = @VehicleID,
	                        RentalStartDate = @RentalStartDate,
	                        RentalEndDate = @RentalEndDate,
	                        PickupLocation = @PickupLocation,
	                        DropoffLocation = @DropoffLocation,
	                        InitialRentalDays = @InitialRentalDays,
	                        RentalPricePerDay = @RentalPricePerDay,
	                        InitialTotalDueAmount = @InitialTotalDueAmount,
	                        InitialCheckNotes = @InitialCheckNotes	WHERE BookingID = @BookingID";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@BookingID", BookingID);

            command.Parameters.AddWithValue("@CustomerID", CustomerID);

            command.Parameters.AddWithValue("@VehicleID", VehicleID);

            command.Parameters.AddWithValue("@RentalStartDate", RentalStartDate);

            command.Parameters.AddWithValue("@RentalEndDate", RentalEndDate);

            command.Parameters.AddWithValue("@PickupLocation", PickupLocation);

            command.Parameters.AddWithValue("@DropoffLocation", DropoffLocation);

            command.Parameters.AddWithValue("@InitialRentalDays", InitialRentalDays);

            command.Parameters.AddWithValue("@RentalPricePerDay", RentalPricePerDay);

            command.Parameters.AddWithValue("@InitialTotalDueAmount", InitialTotalDueAmount);

            if (string.IsNullOrEmpty(InitialCheckNotes))
                command.Parameters.AddWithValue("@InitialCheckNotes", DBNull.Value);
            else
                command.Parameters.AddWithValue("@InitialCheckNotes", InitialCheckNotes);

            try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return (rowsAffected > 0);

        }
        public static bool DeleteRentalBooking(int BookingID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "DELETE RentalBooking WHERE BookingID = @BookingID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BookingID", BookingID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }


            return (rowsAffected > 0);

        }

        public static bool IsRentalBookingExist(int BookingID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT Found=1 FROM RentalBooking WHERE BookingID= @BookingID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BookingID", BookingID);

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

        public static DataTable GetAllRentalBooking()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM RentalBooking";
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
        static string GetQueryFromFilter(string BookInfo, string Filter)
        {
            /*
             None
             Book ID
             Vehicle ID
             Customer ID
             Pickup Location
             Dropoff Location
             
             */
            string query = "";
            switch (Filter)
            {

                case "None":
                    {
                        query = @"   SELECT * FROM RentalBooking";
                        return query;
                    }

                case "Book ID":
                    {
                        query = @"   SELECT * FROM RentalBooking WHERE RentalBooking.BookingID LIKE @BookInfo";
                        return query;
                    }

                case "Vehicle ID":
                    {
                        query = @"   SELECT * FROM RentalBooking WHERE RentalBooking.VehicleID LIKE @BookInfo";
                        return query;
                    }

                case "Customer ID":
                    {
                        query = @"SELECT * FROM RentalBooking WHERE RentalBooking.CustomerID LIKE @BookInfo";
                        return query;
                    }

                case "Pickup Location":
                    {
                        query = @"SELECT * FROM RentalBooking WHERE RentalBooking.PickupLocation LIKE @BookInfo";
                        return query;
                    }

                case "Dropoff Location":
                    {
                        query = @"SELECT * FROM RentalBooking WHERE RentalBooking.DropoffLocation LIKE @BookInfo";
                        return query;
                    }

            }
            return query;
        }

        static string GetQueryForSrotingFilter(string Filter)
        {
            /*
             Newest
             Oldest
             Longest Rent Period
             Shortest Rent Period
             Highest Rent Price/Day
             Lowest Rent Price/Day
             
             */
            string query = "";
            switch (Filter)
            {

                case "Newest":
                    {
                        query = @"   SELECT * FROM RentalBooking  order by RentalBooking.RentalEndDate desc";
                        return query;
                    }

                case "Oldest":
                    {
                        query = @"   SELECT * FROM RentalBooking  order by RentalBooking.RentalEndDate asc";
                        return query;
                    }

                case "Longest Rent Period":
                    {
                        query = @"   SELECT * FROM RentalBooking order by RentalBooking.InitialRentalDays desc";
                        return query;
                    }

                case "Shortest Rent Period":
                    {
                        query = @"  SELECT * FROM RentalBooking order by RentalBooking.InitialRentalDays asc";
                        return query;
                    }

                case "Highest Rent Price/Day":
                    {
                        query = @"  SELECT * FROM RentalBooking order by RentalPricePerDay desc";
                        return query;
                    }

                case "Lowest Rent Price/Day":
                    {
                        query = @"  SELECT * FROM RentalBooking order by RentalPricePerDay asc";
                        return query;
                    }

            }
            return query;
        }

        public static DataTable GetVehcileBookByFilter(string BookInfo, string Filter)
        {


            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = GetQueryFromFilter(BookInfo, Filter);

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookInfo", "%" + BookInfo + "%");

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
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = GetQueryForSrotingFilter(Filter);

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


        public static DateTime GetBookingStartDateFromVehicleID(int VehicleID)
        {

            DateTime BookingStartDate = DateTime.Today;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select RentalStartDate from RentalBooking where VehicleID = @VehicleID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@VehicleID", VehicleID);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    BookingStartDate = (DateTime)reader["RentalStartDate"];
                }

                reader.Close();

            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return BookingStartDate;

        }

        public static DateTime GetBookingEndDateFromVehicleID(int VehicleID)
        {

            DateTime BookingEndDate = DateTime.Today;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select RentalEndDate from RentalBooking where VehicleID = @VehicleID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@VehicleID", VehicleID);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    BookingEndDate = (DateTime)reader["RentalEndDate"];
                }

                reader.Close();

            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return BookingEndDate;

        }
            
        public static DateTime GetRentalStartDateFormVehicleID(int VehicleID)
        {

            DateTime PickUpDate = DateTime.Today;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select RentalStartDate from RentalBooking where VehicleID = @VehicleID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@VehicleID", VehicleID);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    PickUpDate = (DateTime)reader["RentalStartDate"];
                }

                reader.Close();

            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return PickUpDate;

        }

        public static int GetVehicleIDByRentalBookingID(int BookingID)
        {
            int VehicleID = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select VehicleID from RentalBooking where BookingID = @BookingID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookingID", BookingID);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    VehicleID = (int)reader["VehicleID"];
                }

                reader.Close();

            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return VehicleID;
        }

        public static int GetNumberOfRentalBookings()
        {
            int NumberOfBookings = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select count (*) NumOfBookings from RentalBooking";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    NumberOfBookings = (int)reader["NumOfBookings"];
                }
                else
                {
                    return 0;
                }

                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return NumberOfBookings;


        }

    }
}