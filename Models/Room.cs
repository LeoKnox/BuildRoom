using System;
using System.Collections.Generic;

namespace BuildRoom.Models
{
    public class Room
    {
        public int RoomId { get; set; }

        public string RoomName { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }
        public string WallMaterial { get; set; }
        public string FloorMaterial { get; set; }
        public virtual List<Adventurer> Adventurers { get; set; }
    }
}