using Microsoft.AspNetCore.Mvc;

namespace MusicShop.Controllers
{
    public class HomeController : Controller
    {
        [ViewData]
        public string CustomProperty { get; set; }

        public ViewResult Index()
        {
            CustomProperty = "Custom value";

            return View();
        }

        public ViewResult AboutUs()
        {
            return View();
        }

        public ViewResult ContactUs()
        {
            return View();
        }
        // 37
    }
}
