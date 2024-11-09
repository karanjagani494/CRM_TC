using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering_2024
{
  
        public static class SqlQueries
        {
            // User-related queries
            public const string RegisterUser = "INSERT INTO user (Email, password, firstName, lastName, phoneNumber, houseNumber, city, state, country, street, cityCode) VALUES (@Email, @password, @firstName, @lastName, @phoneNumber, @houseNumber, @city, @state, @country, @street, @cityCode)";
            //public const string AuthenticateUser = "SELECT Password FROM Users WHERE Username = @Username";
            //public const string CheckUserExist = "SELECT 1 FROM Users WHERE Username = @Username OR Email = @Email LIMIT 1";

        // Customer-related queries
            //public const string InsertCustomer = "INSERT INTO Customer (Name, Email, Phone) VALUES (@Name, @Email, @Phone)";
            //public const string GetAllCustomers = "SELECT * FROM Customer";
            //public const string UpdateCustomer = "UPDATE Customer SET Name = @Name, Email = @Email, Phone = @Phone WHERE CustomerID = @CustomerID";
            //public const string DeleteCustomer = "DELETE FROM Customer WHERE CustomerID = @CustomerID";

            // You can add more queries here as needed, following the same format
        }
    

}
