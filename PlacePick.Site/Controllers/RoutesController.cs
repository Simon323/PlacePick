using PlacePick.Site.Models;
using PlacePick.Site.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace PlacePick.Site.Controllers
{
    public class RoutesController : Controller
    {
        // GET: Routes
        public ActionResult RoutesAdd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RoutesAdd(string PolylinePoints, string MarkerPoints)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<PolylinePoints> polylinePoints = serializer.Deserialize<List<PolylinePoints>>(PolylinePoints);
            List<MarkerPoints> markerPoints = serializer.Deserialize<List<MarkerPoints>>(MarkerPoints);

            string guid = KMLProvider.GenerateKML(polylinePoints);
            
            //foreach(var )

            return View();
        }

        public ActionResult RoutesList()
        {
            return View();
        }

        public ActionResult RoutesDetails(int id)
        {
            return View();
        }
    }
}