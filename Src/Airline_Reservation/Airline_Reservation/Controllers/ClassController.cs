using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airline_Reservation.Controllers
{
    public class ClassController : Controller
    {
        ClassBL obj = new ClassBL();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public int Save(ClassBL cls)
        {
            if (ModelState.IsValid)
            {
                int result = obj.Save(cls);
                return result;
            }
            else return 0;
        }
        public IActionResult GetData()
        {
            List<ClassBL> list = obj.GetAllClasses();
            return PartialView("_ClassPartial", list);
        }
    }
}
