using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using BuildRoom.Models;

namespace BuildRoom.Controllers
{
    public class AdventurerController : Controller
    {
        public ActionResult Index()
        {
            Adventurer NewAdventurer = new Adventurer();
            NewAdventurer.CharName = "Eveehi";
            return View(NewAdventurer);
        }
    }
}