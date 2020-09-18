namespace BuildRoom.Models {
    public class Adventurer
    {
        public int CharId { get; set; }
        public string CharName { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Mana { get; set; }
        public Room Room { get; set; }

    public int SwordStrike()
    {
        return 10;
    }
    }
}