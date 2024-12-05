using System;
using System.Data;
using System.Data.SqlClient;

namespace CustomersDataAccessLayer
{

    public static class clsCustomerDL
    {
       public static string ConnectionString = "Server=TAREQ\\DB1;Database=P4 - Car Rental;Integrated Security=true;";
       // public static string ConnectionString = "Data Source=|DataDirectory|\\P4 - Car Rental.db;";
        public static bool GetCustomerInfoByID(int CustomerID, ref string Name, ref string ContactInformation, ref string DriverLicenseNumber , ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ConnectionString);
            string query = "SELECT * FROM Customer WHERE CustomerID = @CustomerID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CustomerID", CustomerID);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                
                if (reader.Read())
                {
                    isFound = true;

                    CustomerID = (int)reader["CustomerID"];
                    Name = (string)reader["Name"];
                    ContactInformation = (string)reader["ContactInformation"];
                    DriverLicenseNumber = (string)reader["DriverLicenseNumber"];
                    ImagePath = (string)reader["ImagePath"];

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
        public static int AddNewCustomer(string Name, string ContactInformation, string DriverLicenseNumber , string ImagePath)
        {

            int ID = -1;

            SqlConnection connection = new SqlConnection(ConnectionString);

            string query = @"INSERT INTO Customer VALUES (@Name, @ContactInformation, @DriverLicenseNumber, @ImagePath)
        SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@Name", Name);

            command.Parameters.AddWithValue("@ContactInformation", ContactInformation);

            command.Parameters.AddWithValue("@DriverLicenseNumber", DriverLicenseNumber);

            command.Parameters.AddWithValue("@ImagePath", ImagePath);


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
        public static bool UpdateCustomer(int CustomerID, string Name, string ContactInformation, string DriverLicenseNumber , string ImagePath)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(ConnectionString);

            string query = @"UPDATE Customer
	                        SET	Name = @Name,
	                        ContactInformation = @ContactInformation,
	                        DriverLicenseNumber = @DriverLicenseNumber,
                            ImagePath = @ImagePath WHERE CustomerID = @CustomerID";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@CustomerID", CustomerID);

            command.Parameters.AddWithValue("@Name", Name);

            command.Parameters.AddWithValue("@ContactInformation", ContactInformation);

            command.Parameters.AddWithValue("@DriverLicenseNumber", DriverLicenseNumber);

            command.Parameters.AddWithValue("@ImagePath", ImagePath);


            try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return (rowsAffected > 0);

        }
        public static bool DeleteCustomer(int CustomerID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(ConnectionString);
            string query = "DELETE Customer WHERE CustomerID = @CustomerID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CustomerID", CustomerID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }


            return (rowsAffected > 0);

        }

        public static bool IsCustomerExist(int CustomerID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(ConnectionString);
            string query = "SELECT Found=1 FROM Customer WHERE CustomerID= @CustomerID";
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

        public static DataTable GetAllCustomers()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ConnectionString);
            string query = "SELECT * FROM Customer";
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

        static string GetQueryFromFilter(string CustomerInfo, string Filter)
        {

            string query = "";
            switch (Filter)
            {

                case "None":
                    {
                        query = @"   SELECT * FROM Customer";
                        return query;
                    }

                case "ID":
                    {
                        query = @"   SELECT * FROM Customer WHERE CustomerID LIKE @CustomerInfo";
                        return query;
                    }

                case "Name":
                    {
                        query = @"   SELECT * FROM Customer WHERE Customer.Name LIKE @CustomerInfo";
                        return query;
                    
                    }

                case "Phone Number":
                    {
                        query = @"SELECT * FROM Customer WHERE Customer.ContactInformation LIKE @CustomerInfo";
                        return query;
                    }


                case "Driver License Number":
                    {
                        query = @"SELECT * FROM Customer WHERE Customer.DriverLicenseNumber LIKE @CustomerInfo";
                        return query;

                    }


            }
            return query;
        }

        public static DataTable GetCustomerByFilter(string CustomerInfo, string Filter)
        {


            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ConnectionString);

            string query = GetQueryFromFilter(CustomerInfo, Filter);

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CustomerInfo", "%" + CustomerInfo + "%");

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

        public static bool IsDLNRepeated(string DLN, string OriginalDLN)
        {
            if (DLN == OriginalDLN)
                return false;


            bool isFound = false;
            SqlConnection connection = new SqlConnection(ConnectionString);
            string query = "select found = 1 from Customer where DriverLicenseNumber = @DLN";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DLN", DLN);

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

        public static int GetNumberOfCustomers()
        {
            int NumberOfCustomers = 0;
            SqlConnection connection = new SqlConnection(ConnectionString);
            string query = "select count (*) NumOfCustomers from Customer";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    NumberOfCustomers = (int)reader["NumOfCustomers"];
                }
                else
                {
                    return 0;
                }

                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return NumberOfCustomers;


        }


    }

}