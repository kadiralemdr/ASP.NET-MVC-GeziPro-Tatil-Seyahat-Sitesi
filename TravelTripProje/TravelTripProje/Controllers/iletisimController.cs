using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;
namespace TravelTripProje.Controllers
{
    public class iletisimController : Controller
    {
        // GET: iletisim
        public ActionResult Index()
        {
            return View();
        }
    }
}