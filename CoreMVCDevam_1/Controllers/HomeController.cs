using Microsoft.AspNetCore.Mvc;

namespace CoreMVCDevam_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CarpimTablosu()
        {
            return View();
        }



        /*
         1x1 = 1
         1x2 = 2
         ..
        .. 
        ..
         1x10 = 10
         --------------------------
        2 x 1 = 2
        2x2 = 4
        ...
        2x10 = 20
        -----------------------------
         
         
         
         
         */
    }
}
