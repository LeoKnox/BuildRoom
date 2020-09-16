using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using BuildRoom.Models;

namespace BuildRoom.Controllers
{
    public class AdventurerController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}