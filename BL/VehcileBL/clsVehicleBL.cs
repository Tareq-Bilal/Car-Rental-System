using System;
using System.Data;
using VehiclesDataAccessLayer;
using static VehiclesBusinessLayer.clsVehicleBL;

namespace VehiclesBusinessLayer
{

    public class clsVehicleBL
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode;
        public int VehicleID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
        public int FuelType {get; set;}
    public string PlateNumber { get; set; }
    public int CarCategoryID { get; set; }
    public decimal RentalPricePerDay { get; set; }
    public int IsAvailableForRent { get; set; }
    public string ImagePath { get; set; }
    public clsVehicleBL()
    {
        this.VehicleID = default;
        this.Make = default;
        this.Model = default;
        this.Year = default;
        this.Mileage = default;
        this.FuelType = default;
        this.PlateNumber = default;
        this.CarCategoryID = default;
        this.RentalPricePerDay = default;
        this.IsAvailableForRent = default;
        this.ImagePath = default;

        Mode = enMode.AddNew;

    }

    private clsVehicleBL(int VehicleID, string Make, string Model, int Year, int Mileage, int FuelType, string PlateNumber, int CarCategoryID, decimal RentalPricePerDay, int IsAvailableForRent , string imagePath)
    {
        this.VehicleID = VehicleID;
        this.Make = Make;
        this.Model = Model;
        this.Year = Year;
        this.Mileage = Mileage;
        this.FuelType = FuelType;
        this.PlateNumber = PlateNumber;
        this.CarCategoryID = CarCategoryID;
        this.RentalPricePerDay = RentalPricePerDay;
        this.IsAvailableForRent = IsAvailableForRent;
        this.ImagePath= imagePath;

       // Mode = enMode.Update;

    }

    private bool _AddNewVehicle()
    {
        //call DataAccess Layer 

        this.VehicleID = clsVehiclesDataAccess.AddNewVehicle(this.Make, this.Model, this.Year, this.Mileage, this.FuelType, this.PlateNumber, this.CarCategoryID, this.RentalPricePerDay, this.IsAvailableForRent , this.ImagePath);

        return (this.VehicleID != -1);

    }

    private bool _UpdateVehicle()
    {
        //call DataAccess Layer 

        return clsVehiclesDataAccess.UpdateVehicle(this.VehicleID, this.Make, this.Model, this.Year, this.Mileage, this.FuelType, this.PlateNumber, this.CarCategoryID, this.RentalPricePerDay, this.IsAvailableForRent , this.ImagePath);

    }

    public static clsVehicleBL Find(int VehicleID)
    {
        string Make = default;
        string Model = default;
        int Year = default;
        int Mileage = default;
        int FuelType = default;
        string PlateNumber = default;
        int CarCategoryID = default;
        decimal RentalPricePerDay = default;
        int IsAvailableForRent = default;
        string ImagePath = default;

        if (clsVehiclesDataAccess.GetVehicleInfoByID(VehicleID, ref Make, ref Model, ref Year, ref Mileage, ref FuelType, ref PlateNumber, ref CarCategoryID, ref RentalPricePerDay, ref IsAvailableForRent , ref ImagePath))
            return new clsVehicleBL(VehicleID, Make, Model, Year, Mileage, FuelType, PlateNumber, CarCategoryID, RentalPricePerDay, IsAvailableForRent , ImagePath);
        else
            return null;

    }

    public bool Save()
    {


        switch (Mode)
        {
            case enMode.AddNew:
                if (_AddNewVehicle())
                {

                    Mode = enMode.Update;
                    return true;
                }
                else
                {
                    return false;
                }

            case enMode.Update:

                return _UpdateVehicle();

        }


        return false;
    }

    public static DataTable GetAllVehicles() { return clsVehiclesDataAccess.GetAllVehicles(); }

    public static bool DeleteVehicle(int VehicleID) { return clsVehiclesDataAccess.DeleteVehicle(VehicleID); }

    public static bool isVehicleExist(int VehicleID) { return clsVehiclesDataAccess.IsVehicleExist(VehicleID); }


    public static DataTable GetVehiclesByInfo(string VehicleInfo)
        {

            return clsVehiclesDataAccess.GetVehiclesByInfo(VehicleInfo);

        }

        public static DataTable GetVehicleByFilter(string VehicleInfo, string Filter)
        {
            return clsVehiclesDataAccess.GetVehicleByFilter(VehicleInfo, Filter);
        }

        public static DataTable GetVehicleCategories()
        {
            return clsVehiclesDataAccess.GetVehicleCategories();
        }

        public static DataTable GetFuelTypes()
        {
            return clsVehiclesDataAccess.GetFuelTypes();
        }

        public static int GetCategoryID(string CategoryName)
        {
            return clsVehiclesDataAccess.GetCategoryID(CategoryName);
        }

        public static int GetFuelID(string FuelName)
        {
            return clsVehiclesDataAccess.GetFuelID(FuelName);
        }

        public static string GetCategoryName(int CategoryID)
        {
            return clsVehiclesDataAccess.GetCategoryName(CategoryID);
        }

        public static string GetFuelName(int FuelID)
        {
            return clsVehiclesDataAccess.GetFuelName(FuelID);
        }

        public static bool IsPlateNumberRepeated(string PlateNumber , string OriginalPlateNumber)
        {
            return clsVehiclesDataAccess.IsPlateNumberRepeated(PlateNumber , OriginalPlateNumber);
        }

        public static int NumberOfVehicles()
        {
            return clsVehiclesDataAccess.GetNumberOfVehicles();
        }

    }

}