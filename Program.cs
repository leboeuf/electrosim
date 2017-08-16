using System;
using System.Collections.Generic;
using Electrosim.Models;

namespace Electrosim
{
    class Program
    {
        private static List<IComponent> _components = new List<IComponent>();
        static void Main(string[] args)
        {
            InitializeComponents();
        }

        private static void InitializeComponents()
        {
            var ground = new Ground();
            var powerSource = new PowerSource();
            powerSource.Voltage = 5;

            _components.Add(ground);
            _components.Add(powerSource);
        }
    }
}
