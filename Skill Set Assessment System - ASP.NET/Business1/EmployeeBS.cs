using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities2;
using Data1;

namespace Business1
{
    public class EmployeeBS
    {
        EmployeeDAL em = new EmployeeDAL();


        //
        //Validates fields before adding Employee
        //
        public string addEmployee(Employee e,string confirmPassword)
        {   
            string feedback="";
            bool feed = false;
            int i = 0;

            if (e.last_Name.Length == 0)
            {
                feedback += (++i)+". Last Name  ";
                feed = true;
            }
            if (e.first_Name.Length == 0)
            {
                feedback += (++i)+". First Name  ";
                feed = true;
            }
            if ((DateTime.Today.Year - e.birthdate.Year) < 18)
            {
                feedback += (++i)+". Birth Date ";
                feed = true;
            }
            if (e.address.Length == 0)
            {
                feedback += (++i) + ". Address ";
                feed = true;
            }
            if (e.city.Length == 0)
            {
                feedback += (++i) + ". City ";
                feed = true;
            }
            if (e.region.Length==0)
            {
                feedback += (++i) + ". State ";
                feed = true;
            }
            if ((e.postalCode.ToString().Length==0 ) ||  e.postalCode.ToString().Length != 6 )
            {
                feedback += (++i) + ". Postal Code ";
                feed = true;
            }
            if (e.country.Length == 0)
            {
                feedback += (++i) + ". Country ";
                feed = true;
            }
            if (e.mobile_Number.Length != 10)
            {
                feedback += (++i) + ". Mobile Number  ";
                feed = true;
            }
            if ((!(e.password.Equals(confirmPassword))) ||e.password.Length==0)
            {
                feedback += (++i) + ". Password & Confirm Password ";
                feed = true;
            }
            if (feed)
            {
                //Not valid: Returns erroneous fields
                return ("Please enter valid entries for: " + feedback);
            }
            else
            {
                //Valid: Adds Employee and returns assigned Employee ID or Error Message
                string eid = em.addEmployee(e);
                return eid;
            }
        }


        //
        //Validates fields before updating Employee
        //
        public string updateEmployee(Employee e)
        {
            string feedback = "";
            bool feed = false;
            int i = 0;

            if (e.last_Name.Length == 0)
            {
                feedback += (++i) + ". Last Name  ";
                feed = true;
            }
            if (e.first_Name.Length == 0)
            {
                feedback += (++i) + ". First Name  ";
                feed = true;
            }
            if ((DateTime.Today.Year - e.birthdate.Year) < 18)
            {
                feedback += (++i) + ". Birth Date ";
                feed = true;
            }
            if (e.address.Length == 0)
            {
                feedback += (++i) + ". Address ";
                feed = true;
            }
            if (e.city.Length == 0)
            {
                feedback += (++i) + ". City ";
                feed = true;
            }
            if (e.region.Length == 0)
            {
                feedback += (++i) + ". Region ";
                feed = true;
            }
            if ((e.postalCode.ToString().Length == 0) || e.postalCode.ToString().Length != 6)
            {
                feedback += (++i) + ". Postal Code ";
                feed = true;
            }
            if (e.country.Length == 0)
            {
                feedback += (++i) + ". country ";
                feed = true;
            }
            if (e.mobile_Number.Length != 10)
            {
                feedback += (++i) + ". Mobile Number  ";
                feed = true;
            }
            if (feed)
            {
                //Not valid: Returns erroneous fields
                return ("Please enter valid entries for: " + feedback);
            }
            else
            {
                //Valid: Updates Employee and returns Success or Error Message
                string eid = em.updateEmployee(e);
                return eid;
            }
        }


        //
        //DAL call to set new Admins
        //
        public string setAdmin(Employee [] e)
        {
            string feedback = em.setAdmin(e);
            return feedback;
        }


        //
        //DAL call to get the Next Employee ID
        //
        public string getNext()
        {
            string next = em.getNext();
            return next;
        }


        //
        //DAL call to get all the Employee ID's in an array
        //
        public string[] loadEmployee(int i)
        {
            string[] abc = new string[i];
            abc = em.loadEmployee(i);
            return abc;
        }


        //
        //DAL call to get all the Employees who do not have admin access in an array
        //
        public Employee[] loadNonAdmins(int i)
        {
            Employee[] abc = new Employee[i];
            abc = em.loadNonAdmins(i);
            return abc;
        }


        //
        //DAL call to get the number of Employee
        //
        public int getCount()
        {
            int i = em.getCount();
            return i;
        }


        //
        //DAL call to get the number of Employee (Non-admins)
        //
        public int getNonAdminCount()
        {
            int i = em.getNonAdminCount();
            return i;
        }


        //
        //DAl call to delete an Employee with the given Employee ID
        //
        public string deleteEmployee(Employee e)
        {
            string abc = em.deleteEmployee(e);
            return abc;
        }


        //
        //DAL call to get other fields of a Exam given the Employee ID
        //        
        public Employee getEmployee(Employee et)
        {
            et = em.getEmployee(et);
            return et;
        }

        
        //
        //Validates current password, verifies new password and updates it
        //
        public string validatePassword(String oldpassword, String newpassword, String verifypassword, Employee e)
        {
            String old = em.getPassword(e);
            if (old != oldpassword)
            {
                return "Please enter the correct current password.";
            }
            else if (newpassword != verifypassword)
            {
                return "New Password does not match Verify Password.";
            }
            else
            {
                string feed = em.changePassword(e, newpassword);
                return feed;
            }
        }


        //
        //Validates login details
        //
        public string validateLogin(Employee l)
        {
            Employee l1 = em.formvalidate(l);
            if (l1.employee_Id == "E00")
                return "Some error occured.Sorry for the inconveneince.";
            if (l1.employee_Id == "E000")
                return "Wrong Employee ID.";
            if(l1.password != l.password)
                return "Wrong Password";
            if (l1.type != 1)
            {
                if (l.type != l1.type)
                {
                    return "Wrong entry. Are you a admin?";
                }
                else
                    return "true";
            }
            else
                return "true";
        }

        /*
        public bool validatedeleteEmployee(int index)
        {
            if (index == -1)
            {
                return false;
            }
            else
                return true;
        }*/
    }
}
