using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelWeb.Models;

namespace TravelWeb.ViewModel
{
    public class TravelViewModel
    {
        public IEnumerable<Attractions> Attractionslist { get; set; }

        public IEnumerable<AttractionsImg> AttractionsImglist { get; set; }
    }
}