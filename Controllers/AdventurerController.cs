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
            Monster Mob = new Monster();
            Mob.MonsterName = "Steve the Orc";
            NewAdventurer.CharName = "Eveehi";
            return View(NewAdventurer);
        }
    }
}