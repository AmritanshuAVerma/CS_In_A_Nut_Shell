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

            return View();
        }






    }
}
