using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace HotelManagement.Models
{
    public class tblCheckIN
    {
        public int CustomerID { get; set; }

        public string Customer_Name { get; set; }

        public string C_Address { get; set; }

        public string Contact_No { get; set; }

        public string Country { get; set; }

        internal void insert(tblCheckIN j)
        {

            string query = string.Format("insert into tblCheckIN values({0},'{1}','{2}','{3}','{4}')", j.CustomerID, j.Customer_Name, j.C_Address, j.Contact_No, j.Country);
            SqlCommand cmd = new SqlCommand(query, connection.GetCon());
            cmd.ExecuteNonQuery();

        }
        //public void Deleteemp(int Id)
        //{
        //    string query = string.Format("delete from tblCheckIN where EmployeeID = {0}", Id);
        //    SqlCommand cmd = new SqlCommand(query, connection.GetCon());
        //    cmd.ExecuteNonQuery();
        //}
        //public List<tblCheckIN> Showemp()
        //{
        //    string query = string.Format("select * from tblCheckIN");
        //    SqlCommand cmd = new SqlCommand(query, connection.GetCon());
        //    SqlDataReader read = cmd.ExecuteReader();
        //    List<tblCheckIN> em = new List<tblEmployee>();
        //    while (read.Read())
        //    {
        //        tblEmployee s = new tblEmployee();
        //        s.EmployeeID = int.Parse(read[0].ToString());
        //        s.EmployeeName = read[1].ToString();
        //        s.LoginID = int.Parse(read[2].ToString());
        //        s.LoginPassword = read[3].ToString();
        //        s.EmployeeType = read[4].ToString();
        //        s.EmployeeStatus = read[5].ToString();
        //        //e.emp_role = read[5].ToString();
        //        //e.emp_salary = int.Parse(read[6].ToString());
        //        em.Add(s);
        //    }
        //    read.Close();
        //    return em;


        //}



    }
}