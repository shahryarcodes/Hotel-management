using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace HotelManagement.Models
{
    public class tblBooking
    {
      

        public Int32 BookingID { get; set; }

        public Int32 RoomID { get; set; }

        public Int32 CustomerID { get; set; }

        public DateTime BookingDate { get; set; }

        public string BookingStatus { get; set; }

        internal void insert(tblBooking b)
        {

            string query = string.Format("insert into tblBooking values({0},{1},{2},'{3}','{4}')", b.BookingID, b.RoomID, b.CustomerID, b.BookingDate, b.BookingStatus);
            SqlCommand cmd = new SqlCommand(query, connection.GetCon());
            cmd.ExecuteNonQuery();

        }
        public void Deletedata(int Id)
        {
            string query = string.Format("delete from tblBooking where BookingID = {0}", Id);
            SqlCommand cmd = new SqlCommand(query, connection.GetCon());
            cmd.ExecuteNonQuery();
        }
        public List<tblBooking> Showdata()
        {
            string query = string.Format("select * from tblBooking");
            SqlCommand cmd = new SqlCommand(query, connection.GetCon());
            SqlDataReader read = cmd.ExecuteReader();
            List<tblBooking> em = new List<tblBooking>();
            while (read.Read())
            {
                tblBooking b = new tblBooking();
                b.BookingID = int.Parse(read[0].ToString());
                b.RoomID = int.Parse(read[1].ToString());
                b.CustomerID = int.Parse(read[2].ToString());
                b.BookingDate = DateTime.Parse(read[3].ToString());
                b.BookingStatus = read[4].ToString();
                //e.emp_role = read[5].ToString();
                //e.emp_salary = int.Parse(read[6].ToString());
                em.Add(b);
            }
            read.Close();
            return em;


        }
    }
    
}