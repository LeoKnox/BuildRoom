using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using BuildRoom.Models;

namespace BuildRoom.Controllers
{
    public class RoomController : Controller
    {
        public ActionResult Index()
        {
            var NewRoom = new Room();
            NewRoom.RoomName = "Entry";
            return View(NewRoom);
        }
        public string CreateRoom()
        {
            return "Create room here";
        }
        public string SingleRoom(string name, int width = 5)
        {
            return HtmlEncoder.Default.Encode($"Room Name: {name} - Width: {width}");
        }
    }
}