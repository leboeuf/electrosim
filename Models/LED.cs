namespace Electrosim.Models
{
    public class LED : IComponent
    {
        // The forward voltage of this LED
        public decimal Voltage { get; set; }
        // The current drawn by this LED in mA
        public decimal Current { get; set; }

        public IConnection AnodeConnection { get; set; }
        public IConnection CathodeConnection { get; set; }
    }
}