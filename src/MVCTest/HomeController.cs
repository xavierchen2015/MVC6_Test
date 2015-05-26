using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCTest
{
    public class HomeController : Controller
    {
        private readonly MyLibrary.Class1 _myLib;
        private readonly MyLibrary.IRepService RepService;
        private readonly MyLibrary.IRepService RepService2;
        public HomeController(MyLibrary.Class1 myLib, MyLibrary.IRepService repService, MyLibrary.IRepService repService2)
        {
            _myLib = myLib;
            this.RepService = repService;
            this.RepService2 = repService2;
        }

        // GET: /<controller>/
        public string Index()
        {
            string first = this.RepService.GetCounter().ToString();
            return "Test ASP.NET 5 - first:" + first +" second:"+ this.RepService2.GetCounter().ToString();
        }
        public string About()
        {
            ////return "This is view for test ASP.NET 5";
            string first = this.RepService.GetCounter().ToString();
            return _myLib.SayHi() + " - first:" + first + " second:" + this.RepService2.GetCounter().ToString();
        }
    }
}
