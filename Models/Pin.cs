namespace Electrosim.Models
{
    public class Pin : IComponent
    {
        public IConnection TerminalConnection { get; set; }
    }
}