using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class CurrentFilmModel
    {
        public CurrentFilmModel(string title)
        {
            Films = new List<FilmViewModel>();
        }

        public CurrentFilmModel()
        {
            // TODO: Complete member initialization
        }
        public string Title { get; set; }

        public List<FilmViewModel> Films { get; set; }
    }
}

