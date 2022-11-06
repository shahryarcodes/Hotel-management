
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelManagement.Services;
using System.Data.SqlClient;
using HotelManagement.Models;
namespace HotelManagement.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            return View();
        }
        [HttpGet]
        public ActionResult insertRcd()
        {
            return View();
        }
        [HttpPost]

        public ActionResult insertRcd(tblRoom e ,tblBooking b)
        {
            e.insert(e);
            b.insert(b);
            
            return View();
        }
        [HttpGet]
        public ActionResult insertemp()
        {
            return View();
        }
        [HttpPost]

        public ActionResult insertemp(tblEmployee s)
        {
            s.insert(s);
            return View();
        }
        [HttpGet]
        public ActionResult Customer()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Customer(tblCheckIN j)
        {
            j.insert(j);
            return View();
        }
        [HttpGet]
        public ActionResult PayView()
        {
            return View();
        }
        [HttpPost]

        public ActionResult PayView(tblPayment k)
        {
            k.insert(k);
            return View();
        }
        public ActionResult ShowData()
        {
            tblBooking b = new tblBooking();
            //tblRoom e = new tblRoom();
            return View(b.Showdata());
            //return View(e.Showdata());
            //e.Showdata();
            

        }
        public ActionResult Delete(int BookingID)
        {
            tblBooking b = new tblBooking ();
            b.Deletedata(BookingID);
            return RedirectToAction("ShowData");
        }
        public ActionResult ShowEmp()
        {
            tblEmployee s = new tblEmployee();
            
            return View(s.Showemp());
            


        }
        public ActionResult DeleteEmp(int EmployeeID)
        {
            tblEmployee s = new tblEmployee();
            s.Deleteemp(EmployeeID);
            return RedirectToAction("ShowEmp");
        }

        //public ActionResult insertRcd(tblBooking b)
        //{
        //    b.insert(b);
        //    return View();
        //}


    }
}