namespace Electrosim.Models
{
    public class Connection : IConnection
    {
        public IComponent From { get; set; }
        public IComponent To { get; set; }

        public Connection(IComponent from, IComponent to)
        {
            From = from;
            To = to;
        }
    }
}