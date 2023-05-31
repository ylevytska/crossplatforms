using lab_2_3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace lab_2_3.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Background = "C:\\Users\\Yuli\\Desktop\\crossplatforms\\lab2_3\\background.jpg";
            return View("MyView");
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            Repository.AddResponse(guestResponse);
            return View("Thanks", guestResponse);
        }

        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }
    }
}