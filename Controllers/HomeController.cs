using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using tcgy_4_TimeTravelParty.Models;

namespace tcgy_4_TimeTravelParty.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Participant participant)
        {
            var isParticipating = participant.Participation;
            var isCovidShot = participant.CovidShot;

            if (isParticipating && isCovidShot)
                return View("Thanks");
            if (isParticipating && !isCovidShot)
                return View();
            if (!isParticipating)
                return View("Why");
            throw new ArgumentOutOfRangeException(nameof(isParticipating));
        }
    }
}
