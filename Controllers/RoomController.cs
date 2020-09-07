using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace BuildRoom.Controllers
{
    public class RoomController : Controller
    {
        public string Index()
        {
            return "Index Rooms";
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