using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCForm.Controllers
{
    public class VehicleController : Controller
    {
        [HttpGet] // When user navigates to URL
        public IActionResult AddVehicle()
        {
            return View();
        }

        [HttpPost] // Call this add method after user potsts form data
        public IActionResult AddVehicle(IFormCollection form)
        {
            // Add validation
            Vehicle v = new Vehicle();
            v.Model = form["model"];
            v.Make = form["make"];
            v.Year = Convert.ToDateTime(form["year"]);
            v.Price = Convert.ToDouble(form["price"]);
            v.FuelType = form["fuel-type"];
            v.BodyType = form["body-type"];
            v.GasMileage = Convert.ToDouble(form["gas-mileage"]);

            // Add v to the Database

            ViewData["Added"] = v.Make + " " + v.Model + " has been successfuly added!";

            return View();
        }

        public IActionResult AddWithBinding()
        {
            return View();
        }
    }
}
