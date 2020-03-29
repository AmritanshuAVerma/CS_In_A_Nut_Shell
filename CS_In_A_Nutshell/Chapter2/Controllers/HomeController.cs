using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Chapter2.Models;

namespace Chapter2.Controllers
{
    public class HomeController : Controller
    {
      
        public IActionResult Index()
        {

            //Null operators
            string y = null;
            //Checks for null ,if found returns null or gets the Function 
            var NotNull = y?.ToString();

            Car car = new Car();
            Bike bike = new Bike();


            car.CarID = 1;
            car.Name = "Maruti800";
            car.NamePlate = @"2020-2525-3636-8989";
            car.NuumberOfWheles = 4;

            bike.BikeID = 1;
            bike.Name = "Hero";
            bike.NamePlate = @"47H4-256-1145";
            bike.NuumberOfWheles = 2;

            ViewBag.Bike = bike;
            ViewBag.Car = car;

            VehicleCollection vehicleCollection = new VehicleCollection(car);
            
       

            return View(vehicleCollection);
        }






    }

    public class VehicleCollection
    {
        public Vehicle[] VehicleObj = new Vehicle[50];
        public VehicleCollection(Vehicle x)
        {
            VehicleObj[0] = (x);
        }
      
    }

    public class  Vehicle
    {
        public string Name { get; set; }
        public string NamePlate { get; set; }
        public int NuumberOfWheles { get; set; }

        public string returnHonk()
        {
            return " Honk ";
        }

    }

    public class Car : Vehicle
    {
        public int CarID { get; set; }
    }

    public class Bike : Vehicle
    {

        public int BikeID { get; set; }

    }


   
}
