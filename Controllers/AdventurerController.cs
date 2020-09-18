using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using BuildRoom.Models;
using System.Collections.Generic;

namespace BuildRoom.Controllers
{
    public class AdventurerController : Controller
    {
        public ActionResult Index()
        {
            Adventurer NewAdventurer = new Adventurer();
            Monster Mob = new Monster();
            Room MyRoom = new Room();
            MyRoom.RoomName = "Entry";
            Mob.MonsterName = "Steve the Orc";
            NewAdventurer.CharName = "Eveehi";
            NewAdventurer.Attack = 10;
            NewAdventurer.Defense = 11;
            NewAdventurer.Mana = 7;
            MyRoom.Adventurers = new List<Adventurer>();
            MyRoom.Adventurers.Add(NewAdventurer);
            return View(MyRoom);
        }
    }
}