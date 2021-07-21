using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc2_MtheusPereira.Models;

namespace mvc2_MtheusPereira.Controllers
{
    public class MusicoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}