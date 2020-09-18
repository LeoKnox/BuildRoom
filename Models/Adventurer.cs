using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuildRoom.Models {
    public class Adventurer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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