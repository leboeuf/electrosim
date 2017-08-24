using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Electrosim.Models;

namespace Electrosim
{
    class Program
    {
        private static List<IComponent> _components = new List<IComponent>();
        
        static async Task Main(string[] args)
        {
            InitializeComponents();
        }

        private static void InitializeComponents()
        {
            var ground = new Ground();
            var powerSource = new PowerSource
            {
                Voltage = 5
            };

            var resistor = new Resistor
            {
                Resistance = 220
            };

            var led = new LED
            {
                Current = 20,
                Voltage = 2
            };

            var powerToResistorConnection = new Connection(powerSource, resistor);
            resistor.InputConnection = powerToResistorConnection;
            var resistorToLedConnection = new Connection(resistor, led);
            resistor.OutputConnection = resistorToLedConnection;
            led.AnodeConnection = resistorToLedConnection;
            var ledToGroundConnection = new Connection(led, ground);
            led.CathodeConnection = ledToGroundConnection;

            _components.Add(ground);
            _components.Add(powerSource);
            _components.Add(resistor);
            _components.Add(led);
        }
    }
}
