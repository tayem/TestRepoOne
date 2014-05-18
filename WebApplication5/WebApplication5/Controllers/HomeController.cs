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

            var nextFilm = CurrFilm();
            return View(nextFilm);
        }

        public ActionResult Film()
        {
            ViewBag.Title = "Current Movie";
            var nextFilm = CurrFilm();
            return View(nextFilm);
            
        } 
        private CalendarEventViewModel  CurrFilm(){
            var filmList = GetEventList();
            var date = DateTime.Today;
            var candidates = filmList.Where(x => x.When >= date).OrderBy(x => x.When);
            var nextFilm = candidates.FirstOrDefault();
            return nextFilm;
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

            var model = new CalendarViewModel(DateTime.Today.Month, DateTime.Today.Year);

            GenerateCalendar(model);
            model.Events = GetEventList();
            return View(model);
        }

        private List<CalendarEventViewModel> GetEventList()
        {
            var films = new List<CalendarEventViewModel>();
            films.Add(new CalendarEventViewModel()
            {
                Film = new FilmViewModel
                {
                    Title = "Schindler's List",
                    Link = "http://www.imdb.com/title/tt0108052/",
                    Description = "A very powerful movie with an extremely important message about WWII and the situation in Germany.",
                    Image = "http://www.cinemasterpieces.com/92010/listapr10.jpg",
                },
                When = new DateTime(2014, 04, 28, 12, 0, 0),
            });

            films.Add(new CalendarEventViewModel()
            {
                Film = new FilmViewModel
                {
                    Title = "Schindler's List",
                    Link = "http://www.imdb.com/title/tt0108052/",
                    Description = "A very powerful movie with an extremely important message about WWII and the situation in Germany.",
                    Image = "http://www.cinemasterpieces.com/92010/listapr10.jpg",
                },
                When = new DateTime(2014, 04, 30, 12, 0, 0),
            });

            films.Add(new CalendarEventViewModel()
            {
                Film = new FilmViewModel
                {
                    Title = "Schindler's List",
                    Link = "http://www.imdb.com/title/tt0108052/",
                    Description = "A very powerful movie with an extremely important message about WWII and the situation in Germany.",
                    Image = "http://www.cinemasterpieces.com/92010/listapr10.jpg",
                },
               When = new DateTime(2014, 05, 06, 12, 0, 0),
            });

            films.Add(new CalendarEventViewModel()
            {
                Film = new FilmViewModel
                {
                    Title = "Captain Phillips",
                    Link = "http://www.imdb.com/title/tt1535109/",
                    Description = "An interesting movie about a true story of Somalian Pirates boarding a container ship.",
                    Image = UrlHelper.GenerateContentUrl("~/Content/Movie Posters/cap_phil.jpg", this.HttpContext),
                    Video = "https://www.youtube.com/embed/_3ASoBrFGlc?rel=0&fs=1",
                },
                When = new DateTime(2014, 05, 07, 12, 0, 0),
            });


            films.Add(new CalendarEventViewModel()
            {
                Film = new FilmViewModel
                {
                    Title = "Captain Phillips",
                    Link = "http://www.imdb.com/title/tt1535109/",
                    Description = "An interesting movie about a true story of Somalian Pirates boarding a container ship.",
                    Image = UrlHelper.GenerateContentUrl("~/Content/Movie Posters/cap_phil.jpg", this.HttpContext),
                    Video = "https://www.youtube.com/embed/_3ASoBrFGlc?rel=0&fs=1",
                },
                When = new DateTime(2014, 05, 12, 12, 0, 0),
            });

            films.Add(new CalendarEventViewModel()
            {
                Film = new FilmViewModel
                {
                    Title = "Captain Phillips",
                    Link = "http://www.imdb.com/title/tt1535109/",
                    Description = "An interesting movie about a true story of Somalian Pirates boarding a container ship.",
                    Image = UrlHelper.GenerateContentUrl("~/Content/Movie Posters/cap_phil.jpg", this.HttpContext),
                    Video = "https://www.youtube.com/embed/_3ASoBrFGlc?rel=0&fs=1",
                },
                When = new DateTime(2014, 05, 14, 12, 0, 0),
            });

            films.Add(new CalendarEventViewModel()
            {
                Film = new FilmViewModel
                {
                    Title = "Captain Phillips",
                    Link = "http://www.imdb.com/title/tt1535109/",
                    Description = "An interesting movie about a true story of Somalian Pirates boarding a container ship.",
                    Image = UrlHelper.GenerateContentUrl("~/Content/Movie Posters/cap_phil.jpg", this.HttpContext),
                    Video = "https://www.youtube.com/embed/_3ASoBrFGlc?rel=0&fs=1",
                },
                When = new DateTime(2014, 05, 19, 12, 0, 0),
            });

            films.Add(new CalendarEventViewModel()
            {
                Film = new FilmViewModel
                {
                    Title = "Captain Phillips",
                    Link = "http://www.imdb.com/title/tt1535109/",
                    Description = "An interesting movie about a true story of Somalian Pirates boarding a container ship.",
                    Image = UrlHelper.GenerateContentUrl("~/Content/Movie Posters/cap_phil.jpg", this.HttpContext),
                    Video = "https://www.youtube.com/embed/_3ASoBrFGlc?rel=0&fs=1",
                },
                When = new DateTime(2014, 05, 21, 12, 0, 0),
            });

            return films;
        }
        
        private void GenerateCalendar(CalendarViewModel viewModel)
        {
            var curdate = 1;
            var daysinmonth = DateTime.DaysInMonth(viewModel.Year, viewModel.Month);
            var monthday1 = (int)(new DateTime(viewModel.Year, viewModel.Month, 1)).DayOfWeek;
            for (var week = 0; curdate <= daysinmonth; week++)
            {
                for (var day = 0; day < 7; day++)
                {
                    if (week == 0 && day < monthday1)
                    {
                        viewModel.DaysInMonth.Add(0);
                    }
                    else if (curdate > daysinmonth)
                    {
                        viewModel.DaysInMonth.Add(0);
                    }
                    else
                    {
                        viewModel.DaysInMonth.Add(curdate);
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