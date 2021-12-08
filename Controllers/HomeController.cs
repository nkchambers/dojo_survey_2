using Microsoft.AspNetCore.Mvc;

namespace dojo_survey.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index() //View Result = always render on this route
        {
            return View();
        }


        [HttpPost("method")]
        public ViewResult NewNinja(string name, string dojo_location, string favorite_language, string comment)
        {
            ViewBag.NinjaName = name;
            ViewBag.Dojo_Location = dojo_location;
            ViewBag.Favorite_Language = favorite_language;
            ViewBag.Comment = comment;
            
            return View("NewNinja");
        }

        [HttpGet("return_home")]
        public RedirectToActionResult ReturnHome()
        {
            return RedirectToAction("Index");
        }

    }
}