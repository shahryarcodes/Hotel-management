using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace HotelManagement
{
    public class connection
    {
        public static SqlConnection con;

        public static SqlConnection GetCon()
        {
            if (con == null)
            {
                con = new SqlConnection();
                con.ConnectionString = @"Data Source= DESKTOP-QN3SQNF\SQLEXPRESS; initial catalog=Hotel_Management_System; integrated security=true";
                con.Open();
            }
            return con;

        }
    }
}