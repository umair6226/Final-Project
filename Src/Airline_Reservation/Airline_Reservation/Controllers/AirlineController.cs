using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;
using Grpc.Core;
using System.Collections.Generic;
using Bussiness_Logic_Layer;
using Airline_Reservation.Models;
using Microsoft.AspNetCore.Http;

namespace Airline_Reservation.Controllers
{
    public class AirlineController : Controller
    {
        AirlineBL obj = new AirlineBL();
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public int Save(AirlineBL airline)
        {
            if (ModelState.IsValid)
            {
                int result = obj.Save(airline);
                return result;
            }
            else return 0;
        }
        public IActionResult GetData()
        {
            List<AirlineBL> list = obj.GetAllAirlines();
            return PartialView("_AirlinePartial", list);
        }

        public List<AirlineBL> GetSpecific(int ID)
        {
            List<AirlineBL> list = obj.GetById(ID);
            return list;
        }

        [HttpPost]

        public int Delete(int AirlineId)
        {
            obj.Delete(AirlineId);
            return 1;
        }

       
    }
}
