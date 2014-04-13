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

            GenerateCalendar(model);

            return View(model);
        }

        private void GenerateCalendar(CalendarViewModel model)
        {
            var curdate = 1;
            var today = DateTime.Today;
            var daysinmonth = DateTime.DaysInMonth(today.Year, today.Month);
            var monthday1 = (int)(new DateTime(today.Year, today.Month, 1)).DayOfWeek;
            for (var week = 0; curdate <= daysinmonth; week++)
            {
                for (var day = 0; day < 7; day++)
                {
                    if (week == 0 && day < monthday1)
                    {
                        model.DaysInMonth.Add(0);
                    }
                    else if (curdate > daysinmonth)
                    {
                        model.DaysInMonth.Add(0);
                    }
                    else
                    {
                        model.DaysInMonth.Add(curdate);
                        curdate++;
                    }
                }
            }
        }

        public ActionResult Test1()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

    }
}