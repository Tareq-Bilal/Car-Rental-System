using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Runtime.Remoting.Lifetime;

namespace VehiclesDataAccessLayer
{
    static class clsDataAccessSettings
    {
        public static string ConnectionString = "Server=TAREQ\\DB1;Database=P4 - Car Rental;Integrated Security=true;";
    }

    public static class clsVehiclesDataAccess
    {
        private static short _AvailablitySelect = 1;

        public static bool GetVehicleInfoByID(int VehicleID, ref string Make, ref string Model, ref int Year, ref int Mileage, ref int FuelType, ref string PlateNumber, ref int CarCategoryID, ref decimal RentalPricePerDay, ref int IsAvailableForRent , ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Vehicles WHERE VehicleID = @VehicleID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@VehicleID", VehicleID);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    VehicleID = (int)reader["VehicleID"];
                    Make = (string)reader["Make"];
                    Model = (string)reader["Model"];
                    Year = (int)reader["Year"];
                    Mileage = (int)reader["Mileage"];
                    FuelType = (int)reader["FuelTypeID"];
                    PlateNumber = (string)reader["PlateNumber"];
                    CarCategoryID = (int)reader["CarCategoryID"];
                    RentalPricePerDay = (decimal)reader["RentalPricePerDay"];
                    IsAvailableForRent = (int)reader["IsAvailableForRent"];
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
        public static int AddNewVehicle(string Make, string Model, int Year, int Mileage, int FuelTypeID, string PlateNumber, int CarCategoryID, decimal RentalPricePerDay, int IsAvailableForRent , string ImagePath)
        {
            int ID = -1 ;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
                  INSERT INTO Vehicles (Make , Model , Year , Mileage , FuelTypeID , PlateNumber , CarCategoryID , RentalPricePerDay , IsAvailableForRent , ImagePath)
                  VALUES (@Make, @Model, @Year, @Mileage, @FuelTypeID, @PlateNumber, @CarCategoryID, @RentalPricePerDay, @IsAvailableForRent , @ImagePath)   
                   SELECT SCOPE_IDENTITY()";   

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@Make", Make);

            command.Parameters.AddWithValue("@Model", Model);

            command.Parameters.AddWithValue("@Year", Year);

            command.Parameters.AddWithValue("@Mileage", Mileage);

            command.Parameters.AddWithValue("@FuelTypeID", FuelTypeID);

            command.Parameters.AddWithValue("@PlateNumber", PlateNumber);

            command.Parameters.AddWithValue("@CarCategoryID", CarCategoryID);

            command.Parameters.AddWithValue("@RentalPricePerDay", RentalPricePerDay);

            command.Parameters.AddWithValue("@IsAvailableForRent", IsAvailableForRent);

            command.Parameters.AddWithValue("@ImagePath", ImagePath);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ID =  insertedID;
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
        public static bool UpdateVehicle(int VehicleID, string Make, string Model, int Year, int Mileage, int FuelTypeID, string PlateNumber, int CarCategoryID, decimal RentalPricePerDay, int IsAvailableForRent , string ImagePath)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Vehicles
	                        SET	Make = @Make,
	                        Model = @Model,
	                        Year = @Year,
	                        Mileage = @Mileage,
	                        FuelTypeID = @FuelTypeID,
	                        PlateNumber = @PlateNumber,
	                        CarCategoryID = @CarCategoryID,
	                        RentalPricePerDay = @RentalPricePerDay,
                            ImagePath = @ImagePath ,
	                        IsAvailableForRent = @IsAvailableForRent	WHERE VehicleID = @VehicleID";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@VehicleID", VehicleID);

            command.Parameters.AddWithValue("@Make", Make);

            command.Parameters.AddWithValue("@Model", Model);

            command.Parameters.AddWithValue("@Year", Year);

            command.Parameters.AddWithValue("@Mileage", Mileage);

            command.Parameters.AddWithValue("@FuelTypeID", FuelTypeID);

            command.Parameters.AddWithValue("@PlateNumber", PlateNumber);

            command.Parameters.AddWithValue("@CarCategoryID", CarCategoryID);

            command.Parameters.AddWithValue("@RentalPricePerDay", RentalPricePerDay);

            command.Parameters.AddWithValue("@IsAvailableForRent", IsAvailableForRent);

            command.Parameters.AddWithValue("@ImagePath", ImagePath);

            try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return (rowsAffected > 0);

        }
        public static bool DeleteVehicle(int VehicleID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "DELETE Vehicles WHERE VehicleID = @VehicleID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@VehicleID", VehicleID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }


            return (rowsAffected > 0);

        }
        public static bool IsVehicleExist(int VehicleID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT Found=1 FROM Vehicles WHERE VehicleID= @VehicleID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@VehicleID", VehicleID);

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
        public static DataTable GetAllVehicles()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Vehicles";
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

        public static DataTable GetVehiclesByInfo(string VehicleInfo)
        {


            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"   SELECT * FROM Vehicles      
                                WHERE Vehicles.Make LIKE @VehicleInfo
                                or Vehicles.Model LIKE @VehicleInfo  
                                or Vehicles.VehicleID LIKE @VehicleInfo
                                or Vehicles.PlateNumber LIKE @VehicleInfo";
            
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@VehicleInfo", "%" + VehicleInfo + "%");

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

        static string GetQueryFromFilter(string VehicleInfo, string Filter)
        {

            string query = "";
            switch (Filter)
            {

                case "Year":
                    {
                        query = @"   SELECT * FROM Vehicles WHERE Vehicles.Year LIKE @VehicleInfo";
                        return query;
                    }

                case "Fuel Type":
                    {
                        query = @"   SELECT * FROM Vehicles WHERE Vehicles.FuelTypeID LIKE @VehicleInfo";
                        return query;
                    }

                case "Category":
                    {
                        query = @"   SELECT * FROM Vehicles WHERE Vehicles.CarCategoryID LIKE @VehicleInfo";
                        return query;
                    }

                case "Milage":
                    {
                        query = @"SELECT * FROM Vehicles WHERE Vehicles.Mileage LIKE @VehicleInfo";
                        return query;
                    }


                case "Availablity":
                    {
                        if(_AvailablitySelect == 1)
                        {
                            query = @"   SELECT * FROM Vehicles WHERE Vehicles.IsAvailableForRent LIKE 1";
                            _AvailablitySelect = 0;
                            return query;
                        }

                        else
                        {
                            query = @"   SELECT * FROM Vehicles WHERE Vehicles.IsAvailableForRent LIKE 0";
                            _AvailablitySelect = 1;
                            return query;
                        }
       

                    }


            }
            return  query;
        }

        public static DataTable GetVehicleByFilter(string VehicleInfo , string Filter)
        {


            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = GetQueryFromFilter(VehicleInfo , Filter);

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@VehicleInfo", "%" + VehicleInfo + "%");

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

        public static DataTable GetVehicleCategories()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM VehicleCategories";
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

        public static DataTable GetFuelTypes()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM FuleTypes";
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

        public static int GetCategoryID(string CategoryName)
        {
            int CategoryID = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = " select CategoryID from VehicleCategories where VehicleCategories.CategoryName = @CategoryName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CategoryName", CategoryName);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    CategoryID = (int)reader["CategoryID"];
                }
                else
                {
                    return -1;
                }

                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return CategoryID;

        }

        public static string GetCategoryName(int CategoryID)
        {
            string CategoryName = "";
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = " select CategoryName from VehicleCategories where CategoryID = @CategoryID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CategoryID", CategoryID);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    CategoryName = (string)reader["CategoryName"];
                }
                else
                {
                    return "---";
                }

                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return CategoryName;

        }

        public static int GetFuelID(string FuelName)
        {
            int FuelID = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = " select ID from FuleTypes where FuleTypes.FuleType = @FuelName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FuelName", FuelName);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    FuelID = (int)reader["ID"];
                }
                else
                {
                    return -1;
                }

                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return FuelID;

        }

        public static string GetFuelName(int FuelID)
        {
            string FuelName = "";
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = " select FuleType from FuleTypes where ID = @FuelID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FuelID", FuelID);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    FuelName = (string)reader["FuleType"];
                }
                else
                {
                    return "---";
                }

                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return FuelName;

        }

        public static bool IsPlateNumberRepeated(string PlateNumber , string OriginalPlateNumber)
        {
            if (PlateNumber == OriginalPlateNumber)
                return false;


            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select Found = 1  from Vehicles where PlateNumber = @PlateNumber";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PlateNumber", PlateNumber);

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

        public static int GetNumberOfVehicles()
        {
            int NumberOfVehicles = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select count (*) NumOfVehicles from Vehicles";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    NumberOfVehicles = (int)reader["NumOfVehicles"];
                }
                else
                {
                    return 0;
                }

                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return NumberOfVehicles;


        }

    }

}