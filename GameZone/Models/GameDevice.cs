namespace GameZone.Models
{
    public class GameDevice
    {
        public int  GamesId { get; set; }
        public Games Games { get; set; } = default!;

        public int DevicesId { get; set; }
        public Devices Devices { get; set; } = default!;
    }
}
