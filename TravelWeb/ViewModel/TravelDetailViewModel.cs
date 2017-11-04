using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelWeb.Models;

namespace TravelWeb.ViewModel
{
    public class TravelDetailViewModel
    {
        public Attractions Attractions{ get; set; }

        public IEnumerable<AttractionsImg> AttractionsImglist { get; set; }
    }
}