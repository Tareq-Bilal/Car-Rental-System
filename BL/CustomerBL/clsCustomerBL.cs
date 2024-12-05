using System;
using System.Data;
using CustomersDataAccessLayer;
namespace CustomersBusinessLayer
{

    public class clsCustomerBL
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string ContactInformation { get; set; }
        public string DriverLicenseNumber { get; set; }

        public string ImagePath { get; set; }
        public clsCustomerBL()
        {
            this.CustomerID = default;
            this.Name = default;
            this.ContactInformation = default;
            this.DriverLicenseNumber = default;


            Mode = enMode.AddNew;

        }

        private clsCustomerBL(int CustomerID, string Name, string ContactInformation, string DriverLicenseNumber ,string ImagePath)
        {
            this.CustomerID = CustomerID;
            this.Name = Name;
            this.ContactInformation = ContactInformation;
            this.DriverLicenseNumber = DriverLicenseNumber;
            this.ImagePath = ImagePath;

          //  Mode = enMode.Update;

        }

        private bool _AddNewCustomer()
        {
            //call DataAccess Layer 

            this.CustomerID = clsCustomerDL.AddNewCustomer(this.Name, this.ContactInformation, this.DriverLicenseNumber , this.ImagePath);

            return (this.CustomerID != -1);

        }

        private bool _UpdateCustomer()
        {
            //call DataAccess Layer 

            return clsCustomerDL.UpdateCustomer(this.CustomerID, this.Name, this.ContactInformation, this.DriverLicenseNumber , this.ImagePath);

        }

        public static clsCustomerBL Find(int CustomerID)
        {
            string Name = default;
            string ContactInformation = default;
            string DriverLicenseNumber = default;
            string ImagePath = default;

            if (clsCustomerDL.GetCustomerInfoByID(CustomerID, ref Name, ref ContactInformation, ref DriverLicenseNumber , ref ImagePath))
                return new clsCustomerBL(CustomerID, Name, ContactInformation, DriverLicenseNumber , ImagePath);
            else
                return null;

        }

        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCustomer())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateCustomer();

            }




            return false;
        }

        public static DataTable GetAllCustomers() { return clsCustomerDL.GetAllCustomers(); }

        public static bool DeleteCustomer(int CustomerID) { return clsCustomerDL.DeleteCustomer(CustomerID); }

        public static bool isCustomerExist(int CustomerID) { return clsCustomerDL.IsCustomerExist(CustomerID); }

        public static DataTable GetCustomerByFilter(string CustomerInfo, string Filter)
        {
            return clsCustomerDL.GetCustomerByFilter(CustomerInfo, Filter);
        }

        public static bool IsDLNRepeated(string DLN, string OriginalDLN)
        {
            return clsCustomerDL.IsDLNRepeated(DLN, OriginalDLN);
        }

        public static int GetNumberOfCustomers()
        {
            return clsCustomerDL.GetNumberOfCustomers();
        }

    }

}