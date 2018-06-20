using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {        
        public ActionResult Index()
        {
            string current = calenderItem.GetCurrentYearRecords();
            var dict1x = current.Split(' ');
            string monthss = dict1x[0].ToString();
            int monthnox = DateTime.ParseExact(monthss, "MMMM", CultureInfo.InvariantCulture).Month;
            var model = new usermodel
            {              
                ListItems = calenderItem.Years(),
                ListItems1= calenderItem.GetDates(monthnox),
                SelectedItem = monthnox              
            };
            //ViewData["Records"] = calenderItem.Years();
            //string currentDate = calenderItem.GetCurrentYearRecords();
            return View(model);
        }
     
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
 
        //public ActionResult Index(string[] values)
        //{
        //    string Monthyear = values[0];
        //    string[] dates = Monthyear.Split(' ');
        //    string year = dates[1];
        //    int month = Convert.ToInt16(values[1]);
        //    //ViewData["Date"] = calenderItem.GetDates(month);
        //    var model = new usermodel
        //    {
        //        ListItems1 = calenderItem.GetDates(month)
        //    };
        //    return PartialView("MyPartialView", model);
        //}
    }
}