using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class CalendarEventViewModel
    {
        public string Title { get; set; }
        public DateTime When { get; set; }
        public string Link { get; set; }
        public string Image { get; set; }
    }
}