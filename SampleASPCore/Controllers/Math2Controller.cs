using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SampleASPCore.Controllers
{
    public class Math2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}