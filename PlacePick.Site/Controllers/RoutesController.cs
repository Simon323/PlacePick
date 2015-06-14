using PlacePick.Model.EntityModel;
using PlacePick.Model.Repository;
using PlacePick.Model.Repository.Interfaces;
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
        IUserRepository userRepository;
        IRouteRepository routeRepository;
        IPointRepository pointRepository;
        public RoutesController()
        {
            userRepository = new UserRepository();
            routeRepository = new RouteRepository();
            pointRepository = new PointRepository();
        }

        // GET: Routes
        public ActionResult RoutesAdd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RoutesAdd(string PolylinePoints, string MarkerPoints, string city, string duration, string name)
        {
            string email = System.Web.HttpContext.Current.User.Identity.Name;
            User user = userRepository.getByASPUserEmail(email);
            
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<PolylinePoints> polylinePoints = serializer.Deserialize<List<PolylinePoints>>(PolylinePoints);
            List<MarkerPoints> markerPoints = serializer.Deserialize<List<MarkerPoints>>(MarkerPoints);

            string guid = KMLProvider.GenerateKML(polylinePoints);
            Route route = new Route
            {
                Name = name,
                Duration = duration,
                City = city,
                CreatorId = user.id,
                KML = guid
            };

            routeRepository.Add(route);

            routeRepository.Save();

            foreach (var marker in markerPoints)
            {
                pointRepository.Add(new Point
                {
                    RouteId = route.id,
                    Longitude = marker.longitude,
                    Latitude = marker.latitude
                });

                pointRepository.Save();
            }

            pointRepository.Save();

            return RedirectToAction("RoutesStepTwo", "Routes", new { id = route.id });
        }

        public ActionResult RoutesStepTwo(int id)
        {
            var route = routeRepository.GetRouteById(id);
            RouteModel routeModel = new RouteModel();

            routeModel.KML = route.KML;

            foreach (var marker in route.Points)
            {
                routeModel.markerList.Add(new MarkerPoints
                {
                    longitude = marker.Longitude,
                    latitude = marker.Latitude,
                    id = marker.id
                });
            }

            return View(routeModel);
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