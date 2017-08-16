namespace Electrosim.Models
{
    public class Resistor : IComponent
    {
        // The resistance in ohms
        public int Resistance { get; set; }

        public IConnection InputConnection { get; set; }
        public IConnection OutputConnection { get; set; }
    }
}