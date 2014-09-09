
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using Entities2;


namespace Data1
{
    public class EmployeeDAL
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\BE Project\Final Backup\WindowsFormsApplication10\Data1\Database2.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dread;


        //
        //Adds Employee and returns assigned Employee ID (or Error Message)
        //
        public string addEmployee(Employee e)
        {
            //try
            //{
                e.employee_Id = this.getNext();
                conn.Open();
                cmd = new SqlCommand("Insert into Employee(Employee_ID,Last_Name,First_Name,Birthdate,Hire_Date,Address,City,Region,PostalCode,Country,Mobile_Number,Password,Type) values('" + e.employee_Id + "','" + e.last_Name + "','" + e.first_Name + "','" + e.birthdate + "','" + e.hire_Date + "' ,'" + e.address + "','" + e.city + "','" + e.region + "'," + e.postalCode + ",'" + e.country + "','" + e.mobile_Number + "','" + e.password +"',"+e.type+")", conn);
                int i=cmd.ExecuteNonQuery();
                conn.Close();
                if(i==1)
                    return e.first_Name +" "+e.last_Name+" you have successfully registered yourself & have been assigned ID " + e.employee_Id + ".";
                else
                    return "Some error occured. Sorry for the inconvenience.";
            //}
            //catch (Exception ex)
            //{
            //    conn.Close();
            //    return "Some error occured. Sorry for the inconvenience.";
            //}
        }


        //
        //Updates Employee and returns Success (or Error Message)
        //
        public string updateEmployee(Employee e)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("Update Employee SET Last_Name='" + e.last_Name + "',First_Name='" + e.first_Name + "',Birthdate='" + e.birthdate + "',Hire_Date='" + e.hire_Date + "',Address='" + e.address + "',City='" + e.city + "',Region='" + e.region + "',PostalCode=" + e.postalCode + ",Country='" + e.country + "',Mobile_Number='" + e.mobile_Number + "' Where Employee_ID='" + e.employee_Id + "'", conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if(i==1)
                    return "Employee "+e.employee_Id+" was successfully updated.";
                else
                    return "Some error occured. Sorry for the inconvenience.";
            }
            catch (Exception ex)
            {
                conn.Close();
                return "Some error occured. Sorry for the inconvenience.";
            }
        }


        //
        //Sets new Admins; returns Success (or Error Message)
        //
        public string setAdmin(Employee [] e)
        {
            try
            {
                int j = 0;
                bool indicator = true;
                conn.Open();
                for (int i = 0; i < e.Length; i++)
                {
                    cmd = new SqlCommand("Update Employee SET Type =" + 1 + " Where Employee_ID='" + e[i].employee_Id + "'", conn);
                    j = cmd.ExecuteNonQuery();
                    if (j != 1)
                        indicator = false;
                }
                conn.Close();
                if (indicator)
                    return "Successfully set as admin.";
                else
                    return "Some error occured. Sorry for the inconvenience.";
            }
            catch (Exception ex)
            {
                conn.Close();
                return "Some error occured. Sorry for the inconvenience.";
            }
        }


        //
        //Deletes an Employee with given Employee ID, and returns a success or error message
        //
        public string deleteEmployee(Employee e)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand( "Delete Employee where Employee_ID='"+e.employee_Id+"'", conn);
                int i =cmd.ExecuteNonQuery();
                conn.Close();
                if(i==1)
                    return "Employee " + e.employee_Id + " is successfully deleted";
                else
                    return "Attempt unsuccessful. Sorry for the inconvenience.";
            }
            catch (Exception ex)
            {
                conn.Close();
                return "Attempt unsuccessful. Sorry for the inconvenience.";
            }
        }


        //
        //Returns an array containing all the Employee ID's
        //
        public string[] loadEmployee(int i)
        {
            string[] abc = new string[i];
            cmd = new SqlCommand("select Last_Name, First_Name, Employee_ID from Employee", conn);
            conn.Open();
            dread = cmd.ExecuteReader();
            int j = 0;
            while (dread.Read())
            {
                abc[j] = dread["Employee_ID"].ToString() + " : " + dread["First_Name"].ToString() + " " + dread["Last_Name"].ToString();
                j++;
            }
            dread.Close();
            conn.Close();
            return abc;
        }


        //
        //Returns an Employee array containing all the Employees who do not have admin access in an array
        //
        public Employee[] loadNonAdmins(int i)
        {
            Employee[] abc = new Employee[i];
            cmd = new SqlCommand("select Last_Name, First_Name, Employee_ID from Employee where Type = 2", conn);
            conn.Open();
            dread = cmd.ExecuteReader();
            int j = 0;
            while (dread.Read())
            {
                abc[j] = new Employee();
                abc[j].employee_Id = dread["Employee_ID"].ToString();
                abc[j].first_Name = dread["First_Name"].ToString();
                abc[j].last_Name = dread["Last_Name"].ToString();
                j++;
            }
            dread.Close();
            conn.Close();
            return abc;
        } 


        //
        //Returns number of Employees
        //
        public int getCount()
        {
            cmd = new SqlCommand("select count(Employee_ID) from Employee", conn);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            return count;
        }


        //
        //Returns number of Employees who are not Admins
        //
        public int getNonAdminCount()
        {
            cmd = new SqlCommand("select count(Employee_ID) from Employee where Type = 2", conn);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            return count;
        }
       

        //
        // Gets the next Employee ID
        //
        public string getNext()
        {
            cmd = new SqlCommand("select Max(Employee_ID) from Employee", conn);
            conn.Open();
            string id = (string)cmd.ExecuteScalar();
            int last = Convert.ToInt32(id.Substring(1, 3));
            last = last+1;
            string lastmod;
            if (last >= 0 && last <= 9)
                lastmod = "00" + last;
            else if (last >= 10 && last <= 99)
                lastmod = "0" + last;
            else
                lastmod = last+"";
            string next = id.Substring(0, 1) + lastmod;
            conn.Close();
            return next;        
        }


        //
        //Gets other fields of a Exam given the Exam ID
        //
        public Employee getEmployee(Employee e)
        {
            conn.Open();
            cmd = new SqlCommand("select Last_Name, First_Name, Birthdate, Hire_Date, Address, City, Region, PostalCode, Country, Mobile_Number from Employee where Employee_ID = '"+e.employee_Id+"'", conn);
            dread = cmd.ExecuteReader();
            dread.Read();
            e.last_Name = dread.GetString(0);
            e.first_Name = dread.GetString(1);
            e.birthdate = dread.GetDateTime(2);
            e.hire_Date = dread.GetDateTime(3);
            e.address = dread.GetString(4);
            e.city = dread.GetString(5);
            e.region = dread.GetString(6);
            e.postalCode = dread.GetInt32(7);
            e.country = dread.GetString(8);
            e.mobile_Number = dread.GetString(9);
            dread.Close();
            conn.Close();
            return e;
        }
        

        //
        //Changes password of Employee
        //
        public string changePassword(Employee e, String newp)
        {
            try
            {
                cmd = new SqlCommand("Update Employee SET Password = '" + newp + "' WHERE Employee_ID= '" + e.employee_Id + "'", conn);
                conn.Open();
                int i =cmd.ExecuteNonQuery();
                conn.Close();
                if (i == 1)
                    return "Password Successfully Changed";
                else
                    return "Sorry, Some Problem Occured During The Process. Please Try Later";
            }
            catch (Exception ex)
            {
                conn.Close();
                return "Sorry, Some Problem Occured During The Process. Please Try Later";
            }
        }


        //
        //Gets the password of the Employee
        //
        public string getPassword(Employee e)
        {
            conn.Open();
            cmd = new SqlCommand("select Password from Employee where Employee_ID = '" + e.employee_Id + "'", conn);
            string password = (string)cmd.ExecuteScalar();
            conn.Close();
            return password;
        }


        //
        //Gets the password and type for employee
        //
        public Employee formvalidate(Employee l)
        {
            Employee l1 = new Employee();
            try
            {
                conn.Open();
                cmd = new SqlCommand("Select Password, Type from Employee Where Employee_ID='" + l.employee_Id + "'", conn);
                dread = cmd.ExecuteReader();
                dread.Read();
                l1.employee_Id = l.employee_Id;
                l1.password = (string)dread[0];
                l1.type = (int)dread[1];
                dread.Close();
                conn.Close();
                return l1;
            }
            catch (InvalidOperationException ex)
            {
                l1.employee_Id = "E000";
                conn.Close();
                return l1;
            }
            catch (Exception e)
            {
                l1.employee_Id = "E00";
                conn.Close();
                return l1;
            }
        }
    }
}
