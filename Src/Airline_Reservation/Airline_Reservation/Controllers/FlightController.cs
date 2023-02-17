using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Bussiness_Logic_Layer;
using System.Threading.Tasks;

namespace Airline_Reservation.Controllers
{
    public class FlightController : Controller
    {
        FlightsBL obj = new FlightsBL();
        public IActionResult Index()
        {
            List<FlightsBL> list = obj.GetAllFlights(obj);
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
        public int Save(FlightsBL flight)
        {
            if (ModelState.IsValid)
            {
                int result = obj.Save(flight);
                return result;
            }
            else
            {
                return 0;
            }
        }

        [HttpPost]
        public int Delete(int FlightNo)
        {
            obj.Delete(FlightNo);
            return 1;
        }

        public  IActionResult Edit(int ID)
        {
            FlightsBL data = obj.GetSpecific(ID);
            return View("Create", data);
        }
    }
}
