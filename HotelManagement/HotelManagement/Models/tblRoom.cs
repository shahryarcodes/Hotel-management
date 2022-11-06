using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace HotelManagement.Models
{
    public class tblRoom
    {
        public Int32 RoomID { get; set; }

        public Int32 RoomTypeID { get; set; }

        public string RoomNumber { get; set; }

        public string RoomDiscription { get; set; }

       
        public string RoomStatus { get; set; }

        public Int32 Room_Cost { get; set; }



        public void insert(tblRoom e)
        {

            string query = string.Format("insert into tblRoom values({0},{1},'{2}','{3}','{4}',{5})", e.RoomID,e.RoomTypeID, e.RoomNumber, e.RoomDiscription, e.RoomStatus,e.Room_Cost);
            SqlCommand cmd = new SqlCommand(query, connection.GetCon());
            cmd.ExecuteNonQuery();

        }

        //public List<tblRoom> Showdata()
        //{
        //    string query = string.Format("select * from tblRoom");
        //    SqlCommand cmd = new SqlCommand(query, connection.GetCon());
        //    SqlDataReader read = cmd.ExecuteReader();
        //    List<tblRoom> em = new List<tblRoom>();
        //    while (read.Read())
        //    {
        //        tblRoom e = new tblRoom();
        //        e.RoomID = int.Parse(read[0].ToString());
        //        e.RoomTypeID = int.Parse(read[1].ToString());
        //        e.RoomNumber = read[2].ToString();
        //        e.RoomDiscription = read[3].ToString();
        //        e.RoomStatus = read[4].ToString();
        //        //e.Room_Cost = Convert.ToInt32(read[5].ToString());
        //        //e.emp_role = read[5].ToString();
        //        //e.emp_salary = int.Parse(read[6].ToString());
        //        em.Add(e);
        //    }
        //    read.Close();
        //    return em;


        //}

    }
}