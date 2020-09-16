using System;

namespace BuildRoom.Models
{
    public class Room {
        public string RoomName {get; set; }
        public int Width { get; set; }
        public int Length { get; set; }
        public string WallMaterial { get; set; }
        public string FloorMaterial { get; set; }
    }
}