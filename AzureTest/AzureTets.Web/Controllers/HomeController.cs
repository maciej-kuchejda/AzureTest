using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AzureTets.Web.Controllers
{
    [Route("")]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        // GET: /home/
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
