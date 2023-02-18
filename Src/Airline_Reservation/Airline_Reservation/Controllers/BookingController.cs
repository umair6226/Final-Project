using Bussiness_Logic_Layer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airline_Reservation.Controllers
{
    public class BookingController : Controller
    {
        FlightsBL obj = new FlightsBL();
        public IActionResult Index(int? ID=null)
        {

            List<FlightsBL> list = obj.GetAllFlights(obj,ID);
            return View(list);
        }
        public IActionResult GetData(int ID)
        {
            List<FlightsBL> list = obj.GetAllFlights(obj,ID);
            return PartialView("_BookingPartial", list);
        }
    }
}
