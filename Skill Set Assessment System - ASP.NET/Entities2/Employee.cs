using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities2
{
    public class Employee
    {
        private String Employee_ID, Last_Name, First_Name, Title_Of_Courtesy, Address, City, Region, Country,Password;
        private int PostalCode,Type;
        private String Mobile_Number;
        private DateTime Hire_Date, Birthdate;

        public string employee_Id
        {
            get
            {
                return Employee_ID;
            }
            set
            {
                Employee_ID = value;
            }
        }
        public string last_Name
        {
            get
            {
                return Last_Name;
            }
            set
            {
                Last_Name = value;
            }
        }
        public string first_Name
        {
            get
            {
                return First_Name;
            }
            set
            {
                First_Name = value;
            }
        }
        public string title_Of_Courtesy
        {
            get
            {
                return Title_Of_Courtesy;
            }
            set
            {
                Title_Of_Courtesy = value;
            }
        }
        public DateTime birthdate
        {
            get
            {
                return Birthdate;
            }
            set
            {
                Birthdate = value;
            }
        }
        public DateTime hire_Date
        {
            get
            {
                return Hire_Date;
            }
            set
            {
                Hire_Date = value;
            }
        }
        public string address
        {
            get
            {
                return Address;
            }
            set
            {
                Address = value;
            }
        }
        public string city
        {
            get
            {
                return City;
            }
            set
            {
                City = value;
            }
        }
        public string region
        {
            get
            {
                return Region;
            }
            set
            {
                Region = value;
            }
        }
        public int postalCode
        {
            get
            {
                return PostalCode;
            }
            set
            {
                PostalCode = value;
            }
        }
        public string country
        {
            get
            {
                return Country;
            }
            set
            {
                Country = value;
            }
        }
        public string mobile_Number
        {
            get
            {
                return Mobile_Number;
            }
            set
            {
                Mobile_Number = value;
            }
        }

        public string password
        {
            get
            {
                return Password;
            }
            set
            {
                Password = value;
            }
        }
        public int type
        {
            get
            {
                return Type;
            }
            set
            {
                Type = value;
            }
        }
    }
}
