using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreMvcDynamicViews.Models;
using AspNetCoreMvcDynamicViews.Views.Shared.Components.DynamicDisplay;

namespace AspNetCoreMvcDynamicViews.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var model = new MyDisplayModel();
            model.DynamicDisplayData = new DynamicDisplayModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(MyDisplayModel myDisplayModel)
        {
            // save data to db...
            return View("Index", myDisplayModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
