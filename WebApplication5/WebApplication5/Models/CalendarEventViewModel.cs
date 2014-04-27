using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class CalendarEventViewModel
    {
       
        public DateTime When { get; set; }
        public FilmViewModel Film { get; set; }
        
    }
    public class FilmViewModel 
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string Link { get; set; }
    }
}