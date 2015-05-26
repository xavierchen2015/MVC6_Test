using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MyLibrary
{
    public class TestController : Controller
    { 
        private readonly MyLibrary.IRepService RepService; 
        public TestController(MyLibrary.Class1 myLib, MyLibrary.IRepService repService)
        { 
            this.RepService = repService; 
        }
        // GET: /<controller>/
        ////public IActionResult Index()
        public string Index()
        {
            //return View();
            string first = this.RepService.GetCounter().ToString();
            return "TestController - first:" + first + " second:" + this.RepService.GetCounter().ToString();
        }
    }
}
