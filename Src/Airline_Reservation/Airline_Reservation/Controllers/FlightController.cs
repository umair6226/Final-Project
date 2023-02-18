using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Bussiness_Logic_Layer;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Airline_Reservation.Controllers
{
    public class FlightController : Controller
    {
        FlightsBL obj = new FlightsBL();
        AirlineBL airlines = new AirlineBL();
        public IActionResult Index()
        {
            ViewBag.ClassID = new SelectList(obj.GetForDropDown(obj), "ClassID", "Class_Type");
            List<FlightsBL> list = obj.GetAllFlights(obj);
            return View(list);
        }
        public IActionResult Create()
        {
            ViewBag.AirlineID = new SelectList(airlines.GetForDropDown(), "AirlineID", "AirlineName");
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
