using Electrosim.Models.Enums;

namespace Electrosim.Models
{
    public class Pin : IComponent
    {
        public IConnection TerminalConnection { get; set; }

        // The logical direction of current flow
        public PinDirection Direction { get; set; }
    }
}