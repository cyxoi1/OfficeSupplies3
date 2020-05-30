using System;
using System.Collections;
using System.Collections.Generic;

namespace OfficeSupplies
{
    public class Employee
    {
       public Employee()
       {
            Count++;
       }
        public static int Count;
        public int EmployeeId { get; set; }
        public  string FirstName { get; set; }
        public string LastName { get; set; }

        private string userName;
        public string UserName
        {
            get { return userName; }
            set
            {
                if (value.Length < 4)
                {
                    throw new Exception("Username must be at least 4 characters long.");
                }
                userName = value; 
            }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set 
            {
                if (value.Length<4)
                {
                    throw new Exception("Password should be at least 6 charcters long");
                }
                password = value;
            }
        }
        public Employee(int employeeID)
        {
            this.EmployeeId = employeeID;
        }
        public bool LogIn(string userName, string password)
        {
            if ( UserName == userName && Password ==password)
            {
                return true;
            }
             return false;
        }
        public bool LogOut()
        {
            return true;
        }

        public virtual string GetFullName()
        {
            return FirstName + " " + LastName;
        }
       // public abstract double GetEarnings();
    }

}