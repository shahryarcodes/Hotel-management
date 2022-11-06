using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace HotelManagement.Models
{
    public class tblPayment
    {
        public int PaymentId { get; set; }

        public int BookingID { get; set; }

        public string PaymentType { get; set; }

        public Int32 Amount { get; set; }

        public string PaymentDetails { get; set; }

        public string PaymemntDate { get; set; }

        public string PaymentStatus { get; set; }

        internal void insert(tblPayment k)
        {

            string query = string.Format("insert into tblPayment values({0},{1},'{2}',{3},'{4}','{5}','{6}')", k.PaymentId, k.BookingID, k.PaymentType, k.Amount, k.PaymentDetails,k.PaymemntDate,k.PaymentStatus);
            SqlCommand cmd = new SqlCommand(query, connection.GetCon());
            cmd.ExecuteNonQuery();

        }
    }
}