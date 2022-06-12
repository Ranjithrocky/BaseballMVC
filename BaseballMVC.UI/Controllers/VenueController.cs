using BaseballMVC.DataService;
using BaseballMVC.UI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaseballMVC.UI.Controllers
{
    public class VenueController : Controller
    {
        public VenueRepository venueRepository;
        public VenueController ()
        {
            venueRepository = new VenueRepository ();
        }

        // GET: Venue

        public ActionResult Index()
        {

            return View();
        }
        public ActionResult ViewVenues()
        {
            IEnumerable<Venue> venues = venueRepository.GetVenues();
            return View(venues);
        }

        



    }
}