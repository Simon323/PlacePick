using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlacePick.Site.Models
{
    public class PolylinePoints
    {
        public string latitude { get; set; }
        public string longitude { get; set; }
    }

    public class MarkerPoints
    {
        public int id { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
    }

    public class RouteModel
    {
        public string KML { get; set; }
        public List<MarkerPoints> markerList { get; set; }

        public RouteModel()
        {
            markerList = new List<MarkerPoints>();
        }

    }
}