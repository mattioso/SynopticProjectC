using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ApprenticeTips.App.Controllers
{
    public class Internal : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
