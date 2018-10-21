using System;
using Microsoft.AspNetCore.Mvc;
using PartyRSVP.Models;

namespace PartyRSVP.Controllers {
    public class HomeController : Controller {
        public ViewResult Index() {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse) {
            // Todo: Store guest response, covered in later lessons
            return View("Thanks", guestResponse);
        }

        public IActionResult Rsvp()
        {
            return View();
        }

    }
}
