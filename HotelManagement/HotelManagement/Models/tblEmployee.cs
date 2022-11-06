using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace HotelManagement.Models
{
    public class tblEmployee
    {
        public int EmployeeID { get; set; }

        public string EmployeeName { get; set; }

        public int LoginID { get; set; }

        public string LoginPassword { get; set; }

        public string EmployeeType { get; set; }

        public string EmployeeStatus { get; set; }

        internal void insert(tblEmployee s)
        {

            string query = string.Format("insert into tblEmployee values({0},'{1}',{2},'{3}','{4}','{5}')", s.EmployeeID, s.EmployeeName, s.LoginID, s.LoginPassword, s.EmployeeType,s.EmployeeStatus);
            SqlCommand cmd = new SqlCommand(query, connection.GetCon());
            cmd.ExecuteNonQuery();

        }
        public void Deleteemp(int Id)
        {
            string query = string.Format("delete from tblEmployee where EmployeeID = {0}", Id);
            SqlCommand cmd = new SqlCommand(query, connection.GetCon());
            cmd.ExecuteNonQuery();
        }
        public List<tblEmployee> Showemp()
        {
            string query = string.Format("select * from tblEmployee");
            SqlCommand cmd = new SqlCommand(query, connection.GetCon());
            SqlDataReader read = cmd.ExecuteReader();
            List<tblEmployee> em = new List<tblEmployee>();
            while (read.Read())
            {
                tblEmployee s = new tblEmployee();
                s.EmployeeID = int.Parse(read[0].ToString());
                s.EmployeeName = read[1].ToString();
                s.LoginID = int.Parse(read[2].ToString());
                s.LoginPassword = read[3].ToString();
                s.EmployeeType = read[4].ToString();
                s.EmployeeStatus = read[5].ToString();
                //e.emp_role = read[5].ToString();
                //e.emp_salary = int.Parse(read[6].ToString());
                em.Add(s);
            }
            read.Close();
            return em;


        }

    }
}