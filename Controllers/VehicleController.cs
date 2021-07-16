using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCForm.Controllers
{
    public class VehicleController : Controller
    {
        public IActionResult AddVehicle()
        {
            return View();
        }
    }
}
