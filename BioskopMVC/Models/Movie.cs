using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BioskopMVC.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Director { get; set; }

        public DateTime ProjectionTime { get; set; }
    }
}