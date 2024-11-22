﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering_2024.DB_connect
{

    public static class SqlQueries
    {

        // Member-related queries
        public const string RegisterMember = "INSERT INTO members ( first_name, last_name, email, phone_no, password, house_no, street, city, state, city_code, country) VALUES (@first_name, @last_name, @Email, @phone_no, @password,  @house_no, @street, @city, @state, @city_code, @country)";
        public const string AuthenticateUser = "SELECT password FROM members WHERE email = @Email";
        public const string INTEREST_query = "INSERT INTO interests (interest_1, interest_2, interest_3, interest_4, interest_5, MemberID) VALUES (@interest_1, @interest_2, @interest_3, @interest_4, @interest_5, @MemberID)";
        public const string TAG_query = "INSERT INTO tags (tag_1, tag_2, tag_3, tag_4, tag_5, tag_6, tag_7, tag_8, tag_9, tag_10, tag_11, tag_12) VALUES (@tag_1, @tag_2, @tag_3, @tag_4, @tag_5, @tag_6, @tag_7, @tag_8, @tag_9, @tag_10, @tag_11, @tag_12)";
        public const string MemInfo_query = "INSERT INTO membership (membership_name) VALUES (@membership_name)";
        public const string Payment_query = "INSERT INTO payments (cardHolder_name, card_no, cvv, house_no, city, state, country, street , citycode, exp_date) VALUES (@cardHolder_name, @card_no, @cvv, @house_no, @city, @state, @country, @street, @citycode, @exp_date )";

        //public const string CheckUserExist = "SELECT 1 FROM Users WHERE Username = @Username OR Email = @Email LIMIT 1";

        // Customer-related queries
        //public const string InsertCustomer = "INSERT INTO Customer (Name, Email, Phone) VALUES (@Name, @Email, @Phone)";
        //public const string GetAllCustomers = "SELECT * FROM Customer";
        //public const string UpdateCustomer = "UPDATE Customer SET Name = @Name, Email = @Email, Phone = @Phone WHERE CustomerID = @CustomerID";
        //public const string DeleteCustomer = "DELETE FROM Customer WHERE CustomerID = @CustomerID";

        // You can add more queries here as needed, following the same format
    }





}