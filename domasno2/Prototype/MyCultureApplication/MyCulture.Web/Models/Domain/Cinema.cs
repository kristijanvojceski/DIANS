using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCulture.Web.Models.Domain
{
    public class Cinema
    {
        public Guid id { get; set; }

        public string  CinemaName { get; set; }

        public string  CinemaImage { get; set; }

        public string  CinemaDescription { get; set; }

        public int Rating { get; set; }
    }
}
