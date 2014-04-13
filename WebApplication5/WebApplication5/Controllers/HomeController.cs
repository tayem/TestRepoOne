using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;


namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "Current Movie";
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult WebForm1()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }



        public ActionResult Calendar()
        {
            ViewBag.Title = "Calendar";
            var model = new CalendarViewModel(DateTime.Today.Month);
            model.Events.Add(new CalendarEventViewModel() { Title = "The Killing Fields", When = new DateTime(2014, 3, 24) });
            model.Events.Add(new CalendarEventViewModel() { Title = "The Killing Fields", When = new DateTime(2014, 3, 26) });
            var x = 1;


            var t = (new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)).DayOfWeek;
            for (int i = 1; i <= 30; i++)
            {
                var day = (new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)).DayOfWeek;

            }
            return View(model);
        }


        public ActionResult Test1()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

    }
}